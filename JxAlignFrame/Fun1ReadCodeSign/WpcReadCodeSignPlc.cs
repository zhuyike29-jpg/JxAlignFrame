using Alignlib;
using System;
using System.Threading;
using static JxAlignVision.Static;

namespace JxAlignVision
{
    /// <summary>
    /// 当前特定项目的业务逻辑类 (换个项目就重新写一个或继承修改)
    /// </summary>
    public class WpcReadCodeSignPlc
    {
        // 核心：持有一个底层的 PLC 驱动
        private readonly IPLC _plc;

        // 通过构造函数注入底层的通讯实例
        public WpcReadCodeSignPlc(IPLC plc)
        {
            _plc = plc ?? throw new ArgumentNullException(nameof(plc));
        }

        public void Open()
        {
            _plc.Open();
        }

        public void Close()
        {
            _plc.Close();
        }

        public bool IsOpen()
        {
            return _plc.IsOpen();
        }

        #region ================= 心跳业务 =================

        public short HeartDog
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcHeartDog).Content; }
            set { _plc.Write(Config.App.WpcPlcHeartDog, value); }
        }

        #endregion

        #region ================= 读码和判断点亮(本项目专属) =================

        //工位1读码信号
        public short WpcPlcProductCodeTrigger1
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdCodeTrigger1).Content; }
            set { _plc.Write(Config.App.WpcPlcProdCodeTrigger1, value); }
        }
        /// 工位1 读码结果（1=OK，2=NG）</summary>
        public short WpcPlcProductCodeResult1
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdCodeResult1).Content; }
            set { _plc.Write(Config.App.WpcPlcProdCodeResult1, value); }
        }
        //工位1 码写入
        public string WpcWriteProductCode1
        {
            set { _plc.Write(Config.App.WpcPlcProdCodeAds1, value); }
        }
        //工位2读码信号
        public short WpcPlcProductCodeTrigger2
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdCodeTrigger2).Content; }
            set { _plc.Write(Config.App.WpcPlcProdCodeTrigger2, value); }
        }
        /// 工位2 读码结果（1=OK，2=NG）</summary>
        public short WpcPlcProductCodeResult2
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdCodeResult2).Content; }
            set { _plc.Write(Config.App.WpcPlcProdCodeResult2, value); }
        }
        //工位2 码写入
        public string WpcWriteProductCode2
        {
            set { _plc.Write(Config.App.WpcPlcProdCodeAds2, value); }
        }

        //工位1 点亮触发
        public short WpcPlcProductSignTrigger1
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdSignTrigger1).Content; }
            set { _plc.Write(Config.App.WpcPlcProdSignTrigger1, value); }
        }

        //工位1 点亮结果
        public short WpcPlcProductSignResult1
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdSignResult1).Content; }
            set { _plc.Write(Config.App.WpcPlcProdSignResult1, value); }
        }

        //工位2 点亮触发
        public short WpcPlcProductSignTrigger2
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdSignTrigger2).Content; }
            set { _plc.Write(Config.App.WpcPlcProdSignTrigger1, value); }
        }

        //工位2 点亮结果
        public short WpcPlcProductSignResult2
        {
            get { return _plc.ReadInt16(Config.App.WpcPlcProdSignResult2).Content; }
            set { _plc.Write(Config.App.WpcPlcProdSignResult2, value); }
        }

        #endregion

     
    }
}