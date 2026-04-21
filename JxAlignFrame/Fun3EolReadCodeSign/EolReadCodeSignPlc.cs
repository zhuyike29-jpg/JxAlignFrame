using Alignlib;
using System;
using System.Threading;
using static JxAlignVision.Static;

namespace JxAlignVision
{
    /// <summary>
    /// 当前特定项目的业务逻辑类 (换个项目就重新写一个或继承修改)
    /// </summary>
    public class EolReadCodeSignPlc
    {
        // 核心：持有一个底层的 PLC 驱动
        private readonly IPLC _plc;

        // 通过构造函数注入底层的通讯实例
        public EolReadCodeSignPlc(IPLC plc)
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

        //EOL读码信号
        public short EolPlcProductCodeTrigger
        {
            get { return _plc.ReadInt16(Config.App.EolPlcProductCodeTrigger).Content; }
            set { _plc.Write(Config.App.EolPlcProductCodeTrigger, value); }
        }
        /// EOL读码结果（1=OK，2=NG）</summary>
        public short EolPlcProductCodeResult
        {
            get { return _plc.ReadInt16(Config.App.EolPlcProductCodeResult).Content; }
            set { _plc.Write(Config.App.EolPlcProductCodeResult, value); }
        }
        //EOL码写入
        public string EolPlcProductCode
        {
            set { _plc.Write(Config.App.EolPlcProductCodeAds, value); }
        }

        //EOL 点亮触发
        public short EolPlcProductSignTrigger
        {
            get { return _plc.ReadInt16(Config.App.EolPlcProductSignTrigger).Content; }
            set { _plc.Write(Config.App.EolPlcProductSignTrigger, value); }
        }

        //EOL 点亮结果
        public short EolPlcProductSignResult
        {
            get { return _plc.ReadInt16(Config.App.EolPlcProductSignResult).Content; }
            set { _plc.Write(Config.App.EolPlcProductSignResult, value); }
        }

        #endregion


    }
}