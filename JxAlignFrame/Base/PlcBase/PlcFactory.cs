using System;

namespace JxAlignVision
{
    /// <summary>
    /// 支持的底层通讯库类型枚举
    /// </summary>
    public enum PlcDriverType
    {
        Hsl,
        MxComponent
    }

    public static class PlcFactory
    {
        /// <summary>
        /// 根据配置创建 PLC 实例
        /// </summary>
        /// <param name="driverType">通讯驱动类型</param>
        /// <param name="ip">IP地址 (Hsl专用)</param>
        /// <param name="port">端口 (Hsl专用)</param>
        /// <param name="mxStation">逻辑站号 (MX专用)</param>
        /// <returns>实现 IMyPLC 的具体对象</returns>
        public static IPLC CreatePlc(PlcDriverType driverType, string ip = "192.168.1.10", int port = 6000, int mxStation = 1)
        {
            switch (driverType)
            {
                case PlcDriverType.Hsl:
                    return new PlcHslMcNet(ip, port);

                case PlcDriverType.MxComponent:
                    return new PlcMx(mxStation);

                default:
                    throw new ArgumentException("不支持的 PLC 通讯驱动类型");
            }
        }
    }
}