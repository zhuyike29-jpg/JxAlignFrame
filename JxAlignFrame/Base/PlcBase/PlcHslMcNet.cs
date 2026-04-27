using Alignlib;
using HslCommunication;
using HslCommunication.Profinet.Melsec;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using log4net;

namespace JxAlignVision
{
    public class PlcHslMcNet : IPLC
    {
        private class PlcSession
        {
            public MelsecMcNet Client { get; set; }
            public object SyncLock { get; set; } = new object();
            public int RefCount { get; set; } = 0;
            public bool IsOpen { get; set; } = false;
        }

        private static readonly ConcurrentDictionary<string, PlcSession> _sessionPool = new ConcurrentDictionary<string, PlcSession>();
        private readonly PlcSession _session;

        #region [新增] 外部注入的拦截器与日志委托

        private HashSet<string> _heartbeatAddresses = new HashSet<string>();
        private HashSet<string> _triggerAddresses = new HashSet<string>();

        // 外部传入的日志记录方法
        private ILog  _log;

        /// <summary>
        /// 配置日志拦截器与外部日志委托
        /// </summary>
        /// <param name="heartbeats">需要屏蔽的心跳地址集合(不记日志)</param>
        /// <param name="triggers">需要过滤的触发地址集合(值不为1时不记日志)</param>
        /// <param name="logInfo">外部的 Info 级别日志方法 (如 Static.LogComm.Info)</param>
        /// <param name="logError">外部的 Error 级别日志方法 (如 Static.LogComm.Error)</param>
        public void SetLogInterceptor(List<string> heartbeats, List<string> triggers, ILog logInfo)
        {
            if (heartbeats != null) _heartbeatAddresses = new HashSet<string>(heartbeats);
            if (triggers != null) _triggerAddresses = new HashSet<string>(triggers);

            _log = logInfo;
        }

        #endregion

        #region HIDE (初始化与连接)

        public PlcHslMcNet(string ip, int port)
        {
            string key = $"{ip}:{port}";
            _session = _sessionPool.GetOrAdd(key, k => new PlcSession
            {
                Client = new MelsecMcNet(ip, port)
            });
        }

        public void Open()
        {
            lock (_session.SyncLock)
            {
                _session.RefCount++;
                if (_session.IsOpen) return;

                var result = _session.Client.ConnectServer();
                _session.IsOpen = result.IsSuccess;
                if (!_session.IsOpen)
                {
                    _session.RefCount--;
                    throw new Exception("Connect PLC Error: " + result.Message);
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
                    _session.Client.ConnectClose();
                    _session.IsOpen = false;
                    _session.RefCount = 0;
                }
            }
        }

        public bool IsOpen()
        {
            lock (_session.SyncLock)
            {
                return _session.IsOpen;
            }
        }

        #endregion

        #region 基础读写安全封装 + 切面日志拦截

        public OperateResult<short> ReadInt16(string address)
        {
            OperateResult<short> res;
            lock (_session.SyncLock) { res = _session.Client.ReadInt16(address); }

            if (_heartbeatAddresses.Contains(address)) return res;
            if (_triggerAddresses.Contains(address) && res.IsSuccess && res.Content != 1) return res;

            // 使用外部注入的委托记录日志 (使用 ?. 确保安全调用)
            if (res.IsSuccess)
                _log?.Info($"[Hsl PLC读取] 地址:{address}, 值:{res.Content}");
            else
                _log?.Error($"[Hsl PLC读取异常] 地址:{address}, 错误:{res.Message}");

            return res;
        }

        public OperateResult Write(string address, short value)
        {
            OperateResult res;
            lock (_session.SyncLock) { res = _session.Client.Write(address, value); }

            if (_heartbeatAddresses.Contains(address)) return res;

            if (res.IsSuccess)
                _log?.Info($"[Hsl PLC写入] 地址:{address}, 值:{value} 成功");
            else
                _log?.Error($"[Hsl PLC写入异常] 地址:{address}, 值:{value}, 错误:{res.Message}");

            return res;
        }

        public OperateResult<int> ReadInt32(string address)
        {
            OperateResult<int> res;
            lock (_session.SyncLock) { res = _session.Client.ReadInt32(address); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC读取] 地址:{address}, 值:{res.Content}");
            else _log?.Error($"[Hsl PLC读取异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult<int[]> ReadInt32(string address, ushort length)
        {
            OperateResult<int[]> res;
            lock (_session.SyncLock) { res = _session.Client.ReadInt32(address, length); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC读取数组] 地址:{address}, 长度:{length} 成功");
            else _log?.Error($"[Hsl PLC读取数组异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult Write(string address, int value)
        {
            OperateResult res;
            lock (_session.SyncLock) { res = _session.Client.Write(address, value); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC写入] 地址:{address}, 值:{value} 成功");
            else _log?.Error($"[Hsl PLC写入异常] 地址:{address}, 值:{value}, 错误:{res.Message}");
            return res;
        }

        public OperateResult Write(string address, int[] values)
        {
            OperateResult res;
            lock (_session.SyncLock) { res = _session.Client.Write(address, values); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC写入数组] 地址:{address}, 长度:{values?.Length} 成功");
            else _log?.Error($"[Hsl PLC写入数组异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult<bool> ReadBool(string address)
        {
            OperateResult<bool> res;
            lock (_session.SyncLock) { res = _session.Client.ReadBool(address); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC读取Bool] 地址:{address}, 值:{res.Content}");
            else _log?.Error($"[Hsl PLC读取Bool异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult Write(string address, bool value)
        {
            OperateResult res;
            lock (_session.SyncLock) { res = _session.Client.Write(address, value); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC写入Bool] 地址:{address}, 值:{value} 成功");
            else _log?.Error($"[Hsl PLC写入Bool异常] 地址:{address}, 值:{value}, 错误:{res.Message}");
            return res;
        }

        public OperateResult<string> ReadString(string address, ushort length)
        {
            OperateResult<string> res;
            lock (_session.SyncLock) { res = _session.Client.ReadString(address, length); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC读取String] 地址:{address}, 值:{res.Content}");
            else _log?.Error($"[Hsl PLC读取String异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        public OperateResult Write(string address, string value)
        {
            OperateResult res;
            lock (_session.SyncLock) { res = _session.Client.Write(address, value); }
            if (res.IsSuccess) _log?.Info($"[Hsl PLC写入String] 地址:{address}, 值:{value} 成功");
            else _log?.Error($"[Hsl PLC写入String异常] 地址:{address}, 错误:{res.Message}");
            return res;
        }

        #endregion
    }
}