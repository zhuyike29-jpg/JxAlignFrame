using HslCommunication; // 如果你不用Hsl的OperateResult，可以用自定义返回值
using System;

namespace JxAlignVision
{
    /// <summary>
    /// 纯粹的 PLC 驱动接口 (所有项目通用，永远不需要改)
    /// </summary>
    public interface IPLC
    {
        // 1. 基础连接
        void Open();
        void Close();
        bool IsOpen();

        // 2. 通用读写能力 (剥离了具体业务，只对地址操作)
        OperateResult<short> ReadInt16(string address);
        OperateResult Write(string address, short value);

        OperateResult<int> ReadInt32(string address);
        OperateResult<int[]> ReadInt32(string address, ushort length);
        OperateResult Write(string address, int value);
        OperateResult Write(string address, int[] values);

        OperateResult<bool> ReadBool(string address);
        OperateResult Write(string address, bool value);

        OperateResult<string> ReadString(string address, ushort length);
        OperateResult Write(string address, string value);

    }
}