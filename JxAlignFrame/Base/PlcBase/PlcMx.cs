using ActUtlType64Lib;
using HslCommunication;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using log4net;

namespace JxAlignVision
{
    /// <summary>
    /// 基于三菱官方 MX Component 的底层 PLC 驱动实现
    /// </summary>
    public class PlcMx : IPLC
    {
        private class PlcSession
        {
            public ActUtlType64 Client { get; set; }
            public object SyncLock { get; set; } = new object();
            public int RefCount { get; set; } = 0;
            public bool IsOpen { get; set; } = false;
        }

        private static readonly ConcurrentDictionary<int, PlcSession> _sessionPool = new ConcurrentDictionary<int, PlcSession>();
        private readonly PlcSession _session;

        #region [新增] 外部注入的拦截器与日志委托

        private HashSet<string> _heartbeatAddresses = new HashSet<string>();
        private HashSet<string> _triggerAddresses = new HashSet<string>();

        // 外部传入的日志记录方法
        private ILog _log;

        /// <summary>
        /// 配置日志拦截器与外部日志委托
        /// </summary>
        /// <param name="heartbeats">需要屏蔽的心跳地址集合(不记日志)</param>
        /// <param name="triggers">需要过滤的触发地址集合(值不为1时不记日志)</param>
        /// <param name="logInfo">外部的 ILog 接口实例 (如 Static.LogComm)</param>
        public void SetLogInterceptor(List<string> heartbeats, List<string> triggers, ILog logInfo)
        {
            if (heartbeats != null) _heartbeatAddresses = new HashSet<string>(heartbeats);
            if (triggers != null) _triggerAddresses = new HashSet<string>(triggers);

            _log = logInfo;
        }

        #endregion

        #region 初始化与连接

        public PlcMx(int stationNumber)
        {
            _session = _sessionPool.GetOrAdd(stationNumber, k =>
            {
                var act = new ActUtlType64();
                act.ActLogicalStationNumber = stationNumber;
                return new PlcSession { Client = act };
            });
        }

        public void Open()
        {
            lock (_session.SyncLock)
            {
                _session.RefCount++;
                if (_session.IsOpen) return;

                int result = _session.Client.Open();
                _session.IsOpen = (result == 0);

                if (!_session.IsOpen)
                {
                    _session.RefCount--;
                    throw new Exception($"Connect PLC Error. MX Error Code: 0x{result:X8}");
                }
            }
        }

        public void Close()
        {
            lock (_session.SyncLock)
            {
                if (!_session.IsOpen) return;

                _session.RefCount--;
                if (_session.RefCount <= 0)
                {
                    _session.Client.Close();
                    _session.IsOpen = false;
                    _session.RefCount = 0;
                }
            }
        }

        public bool IsOpen()
        {
            lock (_session.SyncLock) return _session.IsOpen;
        }

        #endregion

        #region 基础读写安全封装 + 切面日志拦截

        // ==================== 16位 (Short) 读写 ====================

        public OperateResult<short> ReadInt16(string address)
        {
            int ret;
            short value;
            lock (_session.SyncLock) { ret = _session.Client.GetDevice2(address, out value); }

            OperateResult<short> res = (ret == 0) ? OperateResult.CreateSuccessResult(value) : new OperateResult<short>($"ReadInt16 Error: 0x{ret:X8}");

            if (_heartbeatAddresses.Contains(address)) return res;
            if (_triggerAddresses.Contains(address) && res.IsSuccess && res.Content != 1) return res;

            if (res.IsSuccess) _log?.Info($"[MX PLC读取] 地址:{address}, 值:{res.Content}");
            else _log?.Error($"[MX PLC读取异常] 地址:{address}, 错误:{res.Message}");

            return res;
        }

        public OperateResult Write(string address, short value)
        {
            int ret;
            lock (_session.SyncLock) { ret = _session.Client.SetDevice2(address, value); }

            OperateResult res = (ret == 0) ? OperateResult.CreateSuccessResult() : new OperateResult($"WriteInt16 Error: 0x{ret:X8}");

            if (_heartbeatAddresses.Contains(address)) return res;

            if (res.IsSuccess) _log?.Info($"[MX PLC写入] 地址:{address}, 值:{value} 成功");
            else _log?.Error($"[MX PLC写入异常] 地址:{address}, 值:{value}, 错误:{res.Message}");

            return res;
        }

        // ==================== 32位 (Int) 读写 ====================

        public OperateResult<int> ReadInt32(string address)
        {
            int ret, value;
            lock (_session.SyncLock) { ret = _session.Client.GetDevice(address, out value); }

            OperateResult<int> res = (ret == 0) ? OperateResult.CreateSuccessResult(value) : new OperateResult<int>($"ReadInt32 Error: 0x{ret:X8}");

            if (res.IsSuccess) _log?.Info($"[MX PLC读取] 地址:{address}, 值:{res.Content}");
            else _log?.Error($"[MX PLC读取异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult<int[]> ReadInt32(string address, ushort length)
        {
            int ret;
            int[] buffer = new int[length];
            lock (_session.SyncLock) { ret = _session.Client.ReadDeviceBlock(address, length, out buffer[0]); }

            OperateResult<int[]> res = (ret == 0) ? OperateResult.CreateSuccessResult(buffer) : new OperateResult<int[]>($"ReadInt32Array Error: 0x{ret:X8}");

            if (res.IsSuccess) _log?.Info($"[MX PLC读取数组] 地址:{address}, 长度:{length} 成功");
            else _log?.Error($"[MX PLC读取数组异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult Write(string address, int value)
        {
            int ret;
            lock (_session.SyncLock) { ret = _session.Client.SetDevice(address, value); }

            OperateResult res = (ret == 0) ? OperateResult.CreateSuccessResult() : new OperateResult($"WriteInt32 Error: 0x{ret:X8}");

            if (res.IsSuccess) _log?.Info($"[MX PLC写入] 地址:{address}, 值:{value} 成功");
            else _log?.Error($"[MX PLC写入异常] 地址:{address}, 值:{value}, 错误:{res.Message}");
            return res;
        }

        public OperateResult Write(string address, int[] values)
        {
            int ret;
            lock (_session.SyncLock) { ret = _session.Client.WriteDeviceBlock(address, values.Length, ref values[0]); }

            OperateResult res = (ret == 0) ? OperateResult.CreateSuccessResult() : new OperateResult($"WriteInt32Array Error: 0x{ret:X8}");

            if (res.IsSuccess) _log?.Info($"[MX PLC写入数组] 地址:{address}, 长度:{values?.Length} 成功");
            else _log?.Error($"[MX PLC写入数组异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        // ==================== 布尔 (Bool) 与 字符串 读写 ====================

        public OperateResult<bool> ReadBool(string address)
        {
            int ret; short value;
            lock (_session.SyncLock) { ret = _session.Client.GetDevice2(address, out value); }

            OperateResult<bool> res = (ret == 0) ? OperateResult.CreateSuccessResult(value == 1) : new OperateResult<bool>($"ReadBool Error: 0x{ret:X8}");

            if (res.IsSuccess) _log?.Info($"[MX PLC读取Bool] 地址:{address}, 值:{res.Content}");
            else _log?.Error($"[MX PLC读取Bool异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult Write(string address, bool value)
        {
            int ret;
            lock (_session.SyncLock) { ret = _session.Client.SetDevice2(address, (short)(value ? 1 : 0)); }

            OperateResult res = (ret == 0) ? OperateResult.CreateSuccessResult() : new OperateResult($"WriteBool Error: 0x{ret:X8}");

            if (res.IsSuccess) _log?.Info($"[MX PLC写入Bool] 地址:{address}, 值:{value} 成功");
            else _log?.Error($"[MX PLC写入Bool异常] 地址:{address}, 值:{value}, 错误:{res.Message}");
            return res;
        }

        public OperateResult<string> ReadString(string address, ushort length)
        {
            int ret;
            short[] buffer = new short[length];
            lock (_session.SyncLock) { ret = _session.Client.ReadDeviceBlock2(address, length, out buffer[0]); }

            if (ret == 0)
            {
                byte[] bytes = new byte[length * 2];
                for (int i = 0; i < length; i++)
                {
                    bytes[i * 2] = (byte)(buffer[i] & 0xFF);
                    bytes[i * 2 + 1] = (byte)((buffer[i] >> 8) & 0xFF);
                }
                string resultStr = Encoding.ASCII.GetString(bytes).TrimEnd('\0');
                _log?.Info($"[MX PLC读取String] 地址:{address}, 值:{resultStr}");
                return OperateResult.CreateSuccessResult(resultStr);
            }

            _log?.Error($"[MX PLC读取String异常] 地址:{address}, 错误:0x{ret:X8}");
            return new OperateResult<string>($"ReadString Error: 0x{ret:X8}");
        }

        public OperateResult Write(string address, string value)
        {
            if (string.IsNullOrEmpty(value)) return OperateResult.CreateSuccessResult();

            byte[] strBytes = Encoding.ASCII.GetBytes(value);
            int wordCount = (strBytes.Length + 1) / 2;
            short[] buffer = new short[wordCount];

            for (int i = 0; i < strBytes.Length; i++)
            {
                if (i % 2 == 0) buffer[i / 2] = (short)(strBytes[i]);
                else buffer[i / 2] |= (short)(strBytes[i] << 8);
            }

            int ret;
            lock (_session.SyncLock) { ret = _session.Client.WriteDeviceBlock2(address, wordCount, ref buffer[0]); }

            OperateResult res = (ret == 0) ? OperateResult.CreateSuccessResult() : new OperateResult($"WriteString Error: 0x{ret:X8}");

            if (res.IsSuccess) _log?.Info($"[MX PLC写入String] 地址:{address}, 值:{value} 成功");
            else _log?.Error($"[MX PLC写入String异常] 地址:{address}, 值:{value}, 错误:{res.Message}");
            return res;
        }

        #endregion
    }
}