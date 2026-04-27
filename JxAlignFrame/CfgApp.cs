using Alignlib;
using Modules;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Xml.Serialization;

namespace JxAlignVision
{
    public class CfgApp :ModConfig
    {
        [Browsable(false)]
        [Category("A-系统"), DisplayName("[A01]操作员密码"), Description("")]
        public string OPN_Password { get; set; } = "123";

        [Browsable(false)]
        [Category("A-系统"), DisplayName("[A01]工程师密码"), Description("")]
        public string ENG_Password { get; set; } = "666";

        [Browsable(false)]
        [Category("A-系统"), DisplayName("[A01]管理员密码"), Description("")]
        public string ADMIN_Password { get; set; } = "888";

        [XmlIgnore]
        [Category("A-系统"), DisplayName("[A01]修改密码"), Description("修改权限密码")]
        public EAction Sys_ChangePassword
        {
            get { return EAction.Action; }
            set
            {
                switch (value)
                {
                    case EAction.Worker:
                        ModChangePWDForm.VerifyAndChangePWD(OPN_Password,
                        newpwd => OPN_Password = newpwd, "操作员");
                        break;
                    case EAction.Engineer:
                        ModChangePWDForm.VerifyAndChangePWD(ENG_Password,
                        newpwd => ENG_Password = newpwd, "工程师");
                        break;
                    case EAction.Administrator:
                        ModChangePWDForm.VerifyAndChangePWD(ADMIN_Password,
                        newpwd => ADMIN_Password = newpwd, "管理员");
                        break;
                }
            }
        }
        /// <summary> 工具执行动作状态 </summary>
        public enum EAction
        {
            /// <summary> 待命状态 </summary>
            Action,
            /// <summary> 厂线人员 </summary>
            Worker,
            /// <summary> 工程人员 </summary>
            Engineer,
            /// <summary> 管理人员 </summary>
            Administrator,
        }

        [Category("A-系统"), DisplayName("[A02]日志存储路径"), Description("")]
        public string LogFolder { get; set; } = "/Log";

        [Category("A-系统"), DisplayName("[A03]日志过期天数"), Description("超过这个时间的日志会被删除")]
        public int LogExceeDays { get; set; } = 30;

        [Category("A-系统"), DisplayName("[A04]程序开启自动运行"), Description("")]
        public bool IsAutoStart { get; set; } = false;

        [Category("A-系统"), DisplayName("[A05]程序开启自动连接设备"), Description("")]
        public bool IsAutoConnectDevice { get; set; } = false;

        [Category("A-系统"), DisplayName("[A06]程序启用心跳线程"), Description("该项更改需重启软件")]
        public bool IsActivataHeartbeatThread { get; set; } = false;

        [Category("A-系统"), DisplayName("[A07]程序是否存储OK图片 "), Description("")]
        public bool LogSaveOkImageAllow { get; set; } = true;

        [Category("A-系统"), DisplayName("[A08]程序是否存储NG图片 "), Description("")]
        public bool LogSaveNgImageAllow { get; set; } = true;

        [Category("A-系统"), DisplayName("[A09]程序存储OK图片路径 "), Description("")]
        public string LogSaveOkImageFolder { get; set; } = "/Image/Ok/";
        [Category("A-系统"), DisplayName("[A10]程序存储NG图片路径 "), Description("")]
        public string LogSaveNgImageFolder { get; set; } = "/Image/Ng/";
        [Category("A-系统"), DisplayName("[A11]程序每天存储OK图片数量"), Description("")]
        public int LogSaveOkImageLimitOnDay { get; set; } = 30;
        [Category("A-系统"), DisplayName("[A12]程序每天存储NG图片数量 "), Description("")]
        public int LogSaveNgImageLimitOnDay { get; set; } = 30;
		[Category("A-系统"), DisplayName("[A13]图片保存天数"), Description("超过这个时间的图片会被删除")]
		public int ImgExceeDays { get; set; } = 15;
        [Category("A-系统"), DisplayName("[A15]程序集名称（左上角） "), Description("该项更改需重启软件")]
        public string SysName { get; set; } = "BMW 13.4 WPC & EOL视觉程序";

        [Category("B1-WPC设备"), DisplayName("[BWPC01]WPC相机1"), Description("")]
        public string WpcCam1 { get; set; } = "1";
        [Category("B1-WPC设备"), DisplayName("[BWPC02]WPC相机1图像旋转"), Description("")]
        public RotateFlipType WpcSysImgRotateFilp1 { get; set; } = RotateFlipType.RotateNoneFlipNone;
        [Category("B1-WPC设备"), DisplayName("[BWPC03]WPC相机2"), Description("")]
        public string WpcCam2 { get; set; } = "2";
        [Category("B1-WPC设备"), DisplayName("[BWPC04]WPC相机2图像旋转"), Description("")]
        public RotateFlipType WpcSysImgRotateFilp2 { get; set; } = RotateFlipType.RotateNoneFlipNone;
        [Category("B1-WPC设备"), DisplayName("[BWPC05]WPC PLC通讯类型"), Description("")]
        public PlcDriverType WpcPlcType { get; set; } = PlcDriverType.Hsl;
        [Category("B1-WPC设备"), DisplayName("[BWPC06]WPC PLCIP地址"), Description("")]
        public string WpcPlcIp { get; set; } = "192.168.0.10";
        [Category("B1-WPC设备"), DisplayName("[BWPC07]WPC PLC端口号"), Description("")]
        public int WpcPlcPort { get; set; } = 5000;
        [Category("B1-WPC设备"), DisplayName("[BWPC08]WPC PLC站点号"), Description("")]
        public int WpcMxStation { get; set; } = 1;
        [Category("B1-WPC设备"), DisplayName("[BWPC09]心跳点位"), Description("")]
        public string WpcPlcHeartDog { get; set; } = "D9600";

        [Category("B2-EOL设备"), DisplayName("[BEOL01]EOL产品相机"), Description("")]
        public string EolPordCam { get; set; } = "1";
        [Category("B2-EOL设备"), DisplayName("[BEOL02]EOL产品相机图像旋转"), Description("")]
        public RotateFlipType EolProdSysImgRotateFilp { get; set; } = RotateFlipType.RotateNoneFlipNone;
        [Category("B2-EOL设备"), DisplayName("[BEOL03]EOL治具相机"), Description("")]
        public string EolJigCam { get; set; } = "1";
        [Category("B2-EOL设备"), DisplayName("[BEOL04]EOL治具相机图像旋转"), Description("")]
        public RotateFlipType EolJigSysImgRotateFilp { get; set; } = RotateFlipType.RotateNoneFlipNone;
        [Category("B2-EOL设备"), DisplayName("[BEOL05]EOL PLC通讯类型"), Description("")]
        public PlcDriverType EolPlcType { get; set; } = PlcDriverType.Hsl;
        [Category("B2-EOL设备"), DisplayName("[BEOL06]EOL PLCIP地址"), Description("")]
        public string EolPlcIp { get; set; } = "192.168.0.10";
        [Category("B2-EOL设备"), DisplayName("[BEOL07]EOL PLC端口号"), Description("")]
        public int EolPlcPort { get; set; } = 5000;
        [Category("B2-EOL设备"), DisplayName("[BEOL08]EOL PLC站点号"), Description("")]
        public int EolMxStation { get; set; } = 1;
        [Category("B2-EOL设备"), DisplayName("[BEOL09]心跳点位"), Description("")]
        public string EolPlcHeartDog { get; set; } = "D9600";


        [Category("B3-EOLCS设备"), DisplayName("[BEOLCS01]EOL读码&点亮相机"), Description("")]
        public string EolCodeSignCam { get; set; } = "1";
        [Category("B3-EOLCS设备"), DisplayName("[BEOLCS02]EOL读码&点亮相机图像旋转"), Description("")]
        public RotateFlipType EolCodeSignSysImgRotateFilp { get; set; } = RotateFlipType.RotateNoneFlipNone;
        [Category("B3-EOLCS设备"), DisplayName("[BEOLCS03]WPC PLC通讯类型"), Description("")]
        public PlcDriverType EolCsPlcType { get; set; } = PlcDriverType.Hsl;
        [Category("B3-EOLCS设备"), DisplayName("[BEOLCS04]WPC PLCIP地址"), Description("")]
        public string EolCsPlcIp { get; set; } = "192.168.0.10";
        [Category("B3-EOLCS设备"), DisplayName("[BEOLCS05]WPC PLC端口号"), Description("")]
        public int EolCsPort { get; set; } = 5000;
        [Category("B3-EOLCS设备"), DisplayName("[BEOLCS06]WPC PLC站点号"), Description("")]
        public int EolCsMxStation { get; set; } = 1;
        [Category("B3-EOLCS设备"), DisplayName("[BEOLCS07]心跳点位"), Description("")]
        public string EolCsPlcHeartDog { get; set; } = "D9600";


        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC01]点亮触发1"), Description("")]
        public string WpcPlcProdSignTrigger1 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC02]点亮结果1"), Description("")]
        public string WpcPlcProdSignResult1 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC03]读码触发1"), Description("")]
        public string WpcPlcProdCodeTrigger1 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC04]读码结果1"), Description("")]
        public string WpcPlcProdCodeResult1 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC05]读码写入地址1"), Description("")]
        public string WpcPlcProdCodeAds1 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC06]点亮触发2"), Description("")]
        public string WpcPlcProdSignTrigger2 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC07]点亮结果2"), Description("")]
        public string WpcPlcProdSignResult2 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC08]读码触发1"), Description("")]
        public string WpcPlcProdCodeTrigger2 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC09]读码结果2"), Description("")]
        public string WpcPlcProdCodeResult2 { get; set; } = "D9000";
        [Category("C1-WPC Plc点位设置"), DisplayName("[CWPC10]读码写入地址2"), Description("")]
        public string WpcPlcProdCodeAds2 { get; set; } = "D9000";

        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL01]产品对位信号"), Description("")]
        public string EolProdAlignTrigger { get; set; } = "D9000";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL02]产品对位结果"), Description("")]
        public string EolProdAlignResult { get; set; } = "D9001";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL03]治具对位信号"), Description("")]
        public string EolJigAlignTrigger { get; set; } = "D9000";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL04]治具对位结果"), Description("")]
        public string EolJigAlignResult { get; set; } = "D9001";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL05]联合计算信号"), Description("")]
        public string EolCalcAlignTrigger { get; set; } = "D9000";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL06]联合计算结果"), Description("")]
        public string EolCalcAlignResult { get; set; } = "D9001";


        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL07]产品对位结果offset-X"), Description("")]
        public string EolAlignPosX { get; set; } = "D9010";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL08]产品对位结果offset-Y"), Description("")]
        public string EolAlignPosY { get; set; } = "D9014";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL09]产品对位结果offset-R"), Description("")]
        public string EolAlignPosR { get; set; } = "D9012";

        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL10]机器人放置基准X值"), Description("")]
        public string EolTarBaseX { get; set; } = "D9500";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL11]机器人放置基准Y值"), Description("")]
        public string EolTarBaseY { get; set; } = "D9504";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL12]机器人放置基准R值"), Description("")]
        public string EolTarBaseR { get; set; } = "D9502";

        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL13]机器人当前X值"), Description("")]
        public string EolRobotCurX { get; set; } = "D9500";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL14]机器人当前Y值"), Description("")]
        public string EolRobotCurY { get; set; } = "D9504";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL15]机器人当前R值"), Description("")]
        public string EolRobotCurR { get; set; } = "D9502";

        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL16]机器人移动X值"), Description("")]
        public string EolRobotMoveX { get; set; } = "D9506";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL17]机器人移动Y值"), Description("")]
        public string EolRobotMoveY { get; set; } = "D9510";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL18]机器人移动R值"), Description("")]
        public string EolRobotMoveR { get; set; } = "D9508";
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL19]机器人移动标志位"), Description("")]
        public string EolRobotMoveFlag { get; set; } = "D9512";

        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL20]PLC补偿轴X读写取反"), Description("标定前修改，标定后不可随意修改")]
        public bool EolXNegation { get; set; } = false;
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL21]PLC补偿轴Y读写取反"), Description("标定前修改，标定后不可随意修改")]
        public bool EolYNegation { get; set; } = false;
        [Category("C2-EOL Plc点位设置"), DisplayName("[CEOL22]PLC补偿轴R读写取反"), Description("标定前修改，标定后不可随意修改")]
        public bool EolRNegation { get; set; } = false;

        [Category("C3-EOL CS Plc点位设置"), DisplayName("[CEOLCS01]点亮触发"), Description("")]
        public string EolPlcProductSignTrigger { get; set; } = "D9000";
        [Category("C3-EOL CS Plc点位设置"), DisplayName("[CEOLCS02]点亮结果"), Description("")]
        public string EolPlcProductSignResult { get; set; } = "D9000";
        [Category("C3-EOL CS Plc点位设置"), DisplayName("[CEOLCS03]读码触发"), Description("")]
        public string EolPlcProductCodeTrigger { get; set; } = "D9000";
        [Category("C3-EOL CS Plc点位设置"), DisplayName("[CEOLCS04]读码结果"), Description("")]
        public string EolPlcProductCodeResult { get; set; } = "D9000";
        [Category("C3-EOL CS Plc点位设置"), DisplayName("[CEOLCS05]读码写入地址"), Description("")]
        public string EolPlcProductCodeAds { get; set; } = "D9000";

        //不显示
        public string Recipe = "Test";
    }
}
