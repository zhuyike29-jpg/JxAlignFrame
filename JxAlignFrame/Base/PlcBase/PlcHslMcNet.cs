using Alignlib;
using HslCommunication;
using HslCommunication.Profinet.Melsec;
using System;
using System.Collections.Concurrent;
using System.Threading;

namespace JxAlignVision
{
    public class PlcHslMcNet:IPLC
    {
        /// <summary> PLC会话类，用于同一个IP和端口的连接复用 </summary>
        private class PlcSession
        {
            public MelsecMcNet Client { get; set; }
            /// <summary> 读写同步锁，确保多线程并发时不串报文 </summary>
            public object SyncLock { get; set; } = new object();
            /// <summary> 引用计数，支持多个MyPLC实例共享连接 </summary>
            public int RefCount { get; set; } = 0;
            public bool IsOpen { get; set; } = false;
        }

        // 静态连接池，以 "IP:Port" 为 Key 管理多实例
        private static readonly ConcurrentDictionary<string, PlcSession> _sessionPool = new ConcurrentDictionary<string, PlcSession>();
        private readonly PlcSession _session;

        #region HIDE (初始化与连接)

        public PlcHslMcNet(string ip, int port)
        {
            string key = $"{ip}:{port}";
            // 如果使用相同的IP和端口，获取现有的共享Session；如果是新端口，则创建新的Session
            _session = _sessionPool.GetOrAdd(key, k => new PlcSession
            {
                Client = new MelsecMcNet(ip, port)
            });
        }

        //====[CONNECT]==================
        /// <summary> 连接 </summary>
        public void Open()
        {
            lock (_session.SyncLock)
            {
                _session.RefCount++;
                if (_session.IsOpen) return; // 已经被其他同端口实例打开，直接复用

                var result = _session.Client.ConnectServer();
                _session.IsOpen = result.IsSuccess;
                if (!_session.IsOpen)
                {
                    _session.RefCount--;
                    throw new Exception("Connect PLC Error: " + result.Message);
                }
            }
        }

        /// <summary> 断开 </summary>
        public void Close()
        {
            lock (_session.SyncLock)
            {
                if (!_session.IsOpen) return;

                _session.RefCount--;
                // 只有当所有复用该端口的实例都调用了Close，才真正断开物理连接
                if (_session.RefCount <= 0)
                {
                    _session.Client.ConnectClose();
                    _session.IsOpen = false;
                    _session.RefCount = 0;
                }
            }
        }

        /// <summary> 是否已连接 </summary>
        public bool IsOpen()
        {
            lock (_session.SyncLock)
            {
                return _session.IsOpen;
            }
        }

        #endregion

        #region 基础读写安全封装 只在IO瞬间加锁，不阻塞外部高频调用

        public OperateResult<short> ReadInt16(string address) { lock (_session.SyncLock) return _session.Client.ReadInt16(address); }
        public OperateResult Write(string address, short value) { lock (_session.SyncLock) return _session.Client.Write(address, value); }
        public OperateResult<int> ReadInt32(string address) { lock (_session.SyncLock) return _session.Client.ReadInt32(address); }
        public OperateResult<int[]> ReadInt32(string address, ushort length) { lock (_session.SyncLock) return _session.Client.ReadInt32(address, length); }
        public OperateResult Write(string address, int value) { lock (_session.SyncLock) return _session.Client.Write(address, value); }
        public OperateResult Write(string address, int[] values) { lock (_session.SyncLock) return _session.Client.Write(address, values); }
        public OperateResult<bool> ReadBool(string address) { lock (_session.SyncLock) return _session.Client.ReadBool(address); }
        public OperateResult Write(string address, bool value) { lock (_session.SyncLock) return _session.Client.Write(address, value); }
        public OperateResult<string> ReadString(string address, ushort length){lock (_session.SyncLock){ return _session.Client.ReadString(address, length);}}
        public OperateResult Write(string address, string value){lock (_session.SyncLock){return _session.Client.Write(address, value); } }

        #endregion


    }
}