using ActUtlType64Lib;
using HslCommunication; // 继续复用 Hsl 的 OperateResult 结构以保持兼容
using System;
using System.Collections.Concurrent;
using System.Text;

namespace JxAlignVision
{
    /// <summary>
    /// 基于三菱官方 MX Component 的底层 PLC 驱动实现
    /// </summary>
    public class PlcMx : IPLC
    {
        /// <summary> PLC会话类，用于同一个逻辑站号的连接复用 </summary>
        private class PlcSession
        {
            // 若为64位程序，请将 ActUtlType 改为 ActUtlType64
            public ActUtlType64 Client { get; set; }

            /// <summary> 读写同步锁，确保多线程并发时不串报文 </summary>
            public object SyncLock { get; set; } = new object();

            /// <summary> 引用计数，支持多个实例共享连接 </summary>
            public int RefCount { get; set; } = 0;
            public bool IsOpen { get; set; } = false;
        }

        // 静态连接池，以 "站号" 为 Key 管理多实例
        private static readonly ConcurrentDictionary<int, PlcSession> _sessionPool = new ConcurrentDictionary<int, PlcSession>();
        private readonly PlcSession _session;

        #region 初始化与连接

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="stationNumber">MX Component 通信设置向导中配置的逻辑站号</param>
        public PlcMx(int stationNumber)
        {
            // 从连接池获取现有的共享Session；如果是新站号，则创建新的Session
            _session = _sessionPool.GetOrAdd(stationNumber, k =>
            {
                // 若为64位程序，请改为: var act = new ActUtlType64();
                var act = new ActUtlType64();
                act.ActLogicalStationNumber = stationNumber;
                return new PlcSession { Client = act };
            });
        }

        /// <summary> 连接 </summary>
        public void Open()
        {
            lock (_session.SyncLock)
            {
                _session.RefCount++;
                if (_session.IsOpen) return;

                int result = _session.Client.Open();
                _session.IsOpen = (result == 0); // MX中，返回0表示成功，非0为错误码

                if (!_session.IsOpen)
                {
                    _session.RefCount--;
                    throw new Exception($"Connect PLC Error. MX Error Code: 0x{result:X8}");
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
                // 只有当所有复用该站号的实例都调用了Close，才真正断开物理连接
                if (_session.RefCount <= 0)
                {
                    _session.Client.Close();
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

        #region 基础读写安全封装 (已包含 32位原生读写优化)

        // ==================== 16位 (Short) 读写 ====================

        public OperateResult<short> ReadInt16(string address)
        {
            lock (_session.SyncLock)
            {
                int ret = _session.Client.GetDevice2(address, out short value);
                if (ret == 0) return OperateResult.CreateSuccessResult(value);
                return new OperateResult<short>($"ReadInt16 Error: 0x{ret:X8}");
            }
        }

        public OperateResult Write(string address, short value)
        {
            lock (_session.SyncLock)
            {
                int ret = _session.Client.SetDevice2(address, value);
                if (ret == 0) return OperateResult.CreateSuccessResult();
                return new OperateResult($"WriteInt16 Error: 0x{ret:X8}");
            }
        }

        // ==================== 32位 (Int) 读写 ====================

        public OperateResult<int> ReadInt32(string address)
        {
            lock (_session.SyncLock)
            {
                // 优化：直接使用 GetDevice (无后缀2) 原生支持 32 位读取
                int ret = _session.Client.GetDevice(address, out int value);
                if (ret == 0) return OperateResult.CreateSuccessResult(value);
                return new OperateResult<int>($"ReadInt32 Error: 0x{ret:X8}");
            }
        }

        public OperateResult<int[]> ReadInt32(string address, ushort length)
        {
            lock (_session.SyncLock)
            {
                int[] buffer = new int[length];
                // 优化：直接使用 ReadDeviceBlock 传入 int 数组
                int ret = _session.Client.ReadDeviceBlock(address, length, out buffer[0]);

                if (ret == 0) return OperateResult.CreateSuccessResult(buffer);
                return new OperateResult<int[]>($"ReadInt32Array Error: 0x{ret:X8}");
            }
        }

        public OperateResult Write(string address, int value)
        {
            lock (_session.SyncLock)
            {
                // 优化：直接使用 SetDevice 原生支持 32 位写入
                int ret = _session.Client.SetDevice(address, value);
                if (ret == 0) return OperateResult.CreateSuccessResult();
                return new OperateResult($"WriteInt32 Error: 0x{ret:X8}");
            }
        }

        public OperateResult Write(string address, int[] values)
        {
            lock (_session.SyncLock)
            {
                // 优化：直接使用 WriteDeviceBlock 传入 int 数组
                int ret = _session.Client.WriteDeviceBlock(address, values.Length, ref values[0]);
                if (ret == 0) return OperateResult.CreateSuccessResult();
                return new OperateResult($"WriteInt32Array Error: 0x{ret:X8}");
            }
        }

        // ==================== 布尔 (Bool) 读写 ====================

        public OperateResult<bool> ReadBool(string address)
        {
            lock (_session.SyncLock)
            {
                int ret = _session.Client.GetDevice2(address, out short value);
                if (ret == 0) return OperateResult.CreateSuccessResult(value == 1);
                return new OperateResult<bool>($"ReadBool Error: 0x{ret:X8}");
            }
        }

        public OperateResult Write(string address, bool value)
        {
            lock (_session.SyncLock)
            {
                int ret = _session.Client.SetDevice2(address, (short)(value ? 1 : 0));
                if (ret == 0) return OperateResult.CreateSuccessResult();
                return new OperateResult($"WriteBool Error: 0x{ret:X8}");
            }
        }

        public OperateResult<string> ReadString(string address, ushort length)
        {
            lock (_session.SyncLock)
            {
                // length 代表要读取的“字(Word/寄存器)”的数量
                // 1 个字 = 2 个字节 = 2 个 ASCII 字符
                short[] buffer = new short[length];
                int ret = _session.Client.ReadDeviceBlock2(address, length, out buffer[0]);

                if (ret == 0)
                {
                    // 将 short 数组转换为 byte 数组进行 ASCII 解码
                    byte[] bytes = new byte[length * 2];
                    for (int i = 0; i < length; i++)
                    {
                        bytes[i * 2] = (byte)(buffer[i] & 0xFF);         // 低字节
                        bytes[i * 2 + 1] = (byte)((buffer[i] >> 8) & 0xFF); // 高字节
                    }

                    // 使用 ASCII 编码将其转换为字符串，并去掉可能包含的 '\0' 结束符
                    string resultStr = Encoding.ASCII.GetString(bytes).TrimEnd('\0');
                    return OperateResult.CreateSuccessResult(resultStr);
                }

                return new OperateResult<string>($"ReadString Error: 0x{ret:X8}");
            }
        }

        public OperateResult Write(string address, string value)
        {
            lock (_session.SyncLock)
            {
                if (string.IsNullOrEmpty(value)) return OperateResult.CreateSuccessResult();

                // 1. 将字符串转换为 ASCII 字节数组
                byte[] strBytes = Encoding.ASCII.GetBytes(value);

                // 2. 计算需要写入多少个“字(Word)”
                // 如果字节数是奇数，需要补 1 个 \0 凑成偶数
                int wordCount = (strBytes.Length + 1) / 2;
                short[] buffer = new short[wordCount];

                // 3. 将字节数组打包成 short 数组 (低字节在前，高字节在后)
                for (int i = 0; i < strBytes.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        // 偶数索引，放入低字节
                        buffer[i / 2] = (short)(strBytes[i]);
                    }
                    else
                    {
                        // 奇数索引，放入高字节，与已有的低字节合并
                        buffer[i / 2] |= (short)(strBytes[i] << 8);
                    }
                }

                // 4. 调用 MX Component 写入
                int ret = _session.Client.WriteDeviceBlock2(address, wordCount, ref buffer[0]);
                if (ret == 0) return OperateResult.CreateSuccessResult();

                return new OperateResult($"WriteString Error: 0x{ret:X8}");
            }
        }

        #endregion
    }
}