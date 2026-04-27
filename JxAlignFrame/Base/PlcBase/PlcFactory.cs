using System;
using System.Collections.Generic;
using log4net;

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
        /// 根据配置创建并初始化 PLC 实例 (包含日志拦截器)
        /// </summary>
        /// <param name="driverType">通讯驱动类型</param>
        /// <param name="ip">IP地址 (Hsl专用)</param>
        /// <param name="port">端口 (Hsl专用)</param>
        /// <param name="mxStation">逻辑站号 (MX专用)</param>
        /// <param name="heartbeats">需要过滤的心跳地址集合 (可选)</param>
        /// <param name="triggers">需要过滤的触发地址集合 (可选)</param>
        /// <param name="logInstance">外部日志记录器实例 (可选)</param>
        /// <returns>实现 IPLC 的具体对象</returns>
        public static IPLC CreatePlc(
            PlcDriverType driverType,
            string ip = "192.168.1.10",
            int port = 6000,
            int mxStation = 1,
            // [新增] 日志拦截所需的参数，设为可选参数以兼容老代码
            List<string> heartbeats = null,
            List<string> triggers = null,
            ILog logInstance = null)
        {
            IPLC plc = null;

            switch (driverType)
            {
                case PlcDriverType.Hsl:
                    plc = new PlcHslMcNet(ip, port);
                    // 在工厂内部进行类型转换并注入日志拦截器
                    if (logInstance != null)
                    {
                        ((PlcHslMcNet)plc).SetLogInterceptor(heartbeats, triggers, logInstance);
                    }
                    break;

                case PlcDriverType.MxComponent:
                    plc = new PlcMx(mxStation);
                    if (logInstance != null)
                    {
                        ((PlcMx)plc).SetLogInterceptor(heartbeats, triggers, logInstance);
                    }
                    break;

                default:
                    throw new ArgumentException("不支持的 PLC 通讯驱动类型");
            }

            return plc;
        }
    }
}