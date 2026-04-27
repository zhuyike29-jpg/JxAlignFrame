using Base;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Modules;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JxAlignVision
{
    class Static
    {

        public static void Init()
        {
            ModLogger.Init();
            ModLogger.Record(() => {
                //检查
                using (var frmCheck = new ModStartCheckForm())
                {
                    
                    //显示加载界面
                    frmCheck.Show();

                    frmCheck.AddText("检测是否重复开启程序", () => {
                        string config_path = "Config";
                        if (!Directory.Exists(config_path))
                            Directory.CreateDirectory(config_path);
                        Config.App.Init(config_path + "/cfg_app.xml");
                        Utils.UtilAppControl.AppMultiCheck(Config.App.SysName);
                    });

                    frmCheck.AddText("加载系统文件", () => 
                    {
                        string config_path = "Config";
                        if (!Directory.Exists(config_path))  Directory.CreateDirectory(config_path);

                        Config.EolProdCalib.Init(config_path + "/EolProdCalib.xml");
                        Config.VisionEolProdCalib.LoadAs(config_path + "/VisionEolProdCalib.vpp");

                        Config.EolJigCalib.Init(config_path + "/EolJigCalib.xml");
                        Config.VisionEolJigCalib.LoadAs(config_path + "/VisionEolJigCalib.vpp");
                    });


                    frmCheck.AddText("加载Plc", () => {
                        //传入心跳点位和触发点位 
                        //WPC PLC
                        List<string> lstHeartBeatWpc = new List<string>() { Config.App.WpcPlcHeartDog };
                        List<string> lstTriggersWpc = new List<string>() { Config.App.WpcPlcProdCodeTrigger1, Config.App.WpcPlcProdCodeTrigger2,Config.App.WpcPlcProdSignTrigger1,Config.App.WpcPlcProdSignTrigger2};
                        Device.WpcReadCodeSignPlc = new WpcReadCodeSignPlc(PlcFactory.CreatePlc(Config.App.WpcPlcType, Config.App.WpcPlcIp, Config.App.WpcPlcPort, Config.App.WpcMxStation, lstHeartBeatWpc, lstTriggersWpc, ModLogger.LogCommumication));
                        //EOL PLC
                        List<string> lstHeartBeatEol = new List<string>() { Config.App.EolPlcHeartDog };
                        List<string> lstTriggersEol = new List<string>() { Config.App.EolJigAlignTrigger, Config.App.EolProdAlignTrigger, Config.App.EolCalcAlignTrigger};
                        Device.EolLoadPlc = new EolLoadPlc(PlcFactory.CreatePlc(Config.App.EolPlcType, Config.App.EolPlcIp, Config.App.EolPlcPort, Config.App.EolMxStation, lstHeartBeatEol, lstTriggersEol, ModLogger.LogCommumication));
                        //EOL 读码&点亮PLC
                        List<string> lstHeartBeatEolCs = new List<string>() { Config.App.EolCsPlcHeartDog };
                        List<string> lstTriggersEolCs = new List<string>() { Config.App.EolPlcProductSignTrigger, Config.App.EolPlcProductCodeTrigger };
                        Device.EolReadCodeSignPlc = new EolReadCodeSignPlc(PlcFactory.CreatePlc(Config.App.EolCsPlcType, Config.App.EolCsPlcIp, Config.App.EolCsPort, Config.App.EolCsMxStation, lstHeartBeatEolCs, lstTriggersEolCs, ModLogger.LogCommumication));

                        if (Config.App.IsAutoConnectDevice)
                        {
                            try
                            { 
                                Device.WpcReadCodeSignPlc.Open();
                            }
                            catch(Exception ex) 
                            {
                                UIMessageBox.ShowError($"PLC{Config.App.WpcPlcIp}:{Config.App.WpcMxStation}连接失败，{ex.Message}");
                            }

                            try
                            {
                                Device.EolLoadPlc.Open();
                            }
                            catch (Exception ex)
                            {
                                UIMessageBox.ShowError($"PLC{Config.App.EolPlcIp}:{Config.App.EolMxStation}连接失败，{ex.Message}");
                            }
                        }
                    });

                    frmCheck.AddText("加载相机", () => {
                        Device.WpcCam1 = new BaseHikCamera(Config.App.WpcSysImgRotateFilp1);
                        Device.WpcCam2 = new BaseHikCamera(Config.App.WpcSysImgRotateFilp2);
                        Device.EolProdCam = new BaseHikCamera(Config.App.EolProdSysImgRotateFilp);
                        Device.EolJigCam = new BaseHikCamera(Config.App.EolJigSysImgRotateFilp);
                        Device.EolCsCam = new BaseHikCamera(Config.App.EolCodeSignSysImgRotateFilp);
                        if (Config.App.IsAutoConnectDevice)
                        {
                            try 
                            {
                                Device.WpcCam1.Open(Config.App.WpcCam1);
                            }
                            catch (Exception ex)
                            {
                                UIMessageBox.ShowError($"相机{Config.App.WpcCam1}连接失败，{ex.Message}");
                            }

                            try
                            {
                                Device.WpcCam2.Open(Config.App.WpcCam2);
                            }
                            catch (Exception ex)
                            {
                                UIMessageBox.ShowError($"相机{Config.App.WpcCam2}连接失败，{ex.Message}");
                            }

                            try
                            {
                                Device.EolProdCam.Open(Config.App.EolPordCam);
                            }
                            catch (Exception ex)
                            {
                                UIMessageBox.ShowError($"相机{Config.App.EolPordCam}连接失败，{ex.Message}");
                            }

                            try
                            {
                                Device.EolProdCam.Open(Config.App.EolPordCam);
                            }
                            catch (Exception ex)
                            {
                                UIMessageBox.ShowError($"相机{Config.App.EolPordCam}连接失败，{ex.Message}");
                            }

                            try
                            {
                                Device.EolCsCam.Open(Config.App.EolCodeSignCam);
                            }
                            catch (Exception ex)
                            {
                                UIMessageBox.ShowError($"相机{Config.App.EolCodeSignCam}连接失败，{ex.Message}");
                            }


                        }
                    });
                    frmCheck.AddText("加载配方", () => {
                        try
                        {
                            Recipe.Init();
                        }
                        catch (Exception ex) {
                            UIMessageBox.ShowError($"配方初始化失败，{ex.Message}");
                        }
                        
                    });
                }
            });
        }

        public static void UnInit()
        {
            Device.WpcReadCodeSignPlc?.Close();
            Device.EolLoadPlc?.Close();
            Device.WpcCam1?.Close();
            Device.WpcCam2?.Close();
            Device.EolProdCam?.Close();
            Device.EolJigCam?.Close();
            Device.EolCsCam?.Close();
            Config.App.Save();
        }

        /// <summary> 设备 </summary>
        public static class Device
        {
            //几个单元维护几个PLC 端口不够用的话端口号维护成一样
            public static WpcReadCodeSignPlc WpcReadCodeSignPlc;
            public static EolLoadPlc EolLoadPlc;
            public static EolReadCodeSignPlc EolReadCodeSignPlc;
            //几个相机定义几个
            public static BaseHikCamera WpcCam1;
            public static BaseHikCamera WpcCam2;
            public static BaseHikCamera EolProdCam;
            public static BaseHikCamera EolJigCam;
            public static BaseHikCamera EolCsCam;
        }

        /// <summary> 系统文件 </summary>
        public static class Config
        {
            public static CfgApp App = new CfgApp();
            //几个相机定义几个标定文件

            //EOL 上料产品标定
            public static CfgEolCCDCalib EolProdCalib = new CfgEolCCDCalib();
            public static MyVision VisionEolProdCalib = new MyVision();
            //Eol 上料治具标定
            public static CfgEolCCDCalib EolJigCalib = new CfgEolCCDCalib();
            public static MyVision VisionEolJigCalib = new MyVision();


        }

        /// <summary> 配方文件 </summary>
        public static class Recipe
        {
            //多个单元 .xml | vpp 文件名 要切开
            public static CfgWpcTrainSignReadCode TrainWpcSignReadCode1 = new CfgWpcTrainSignReadCode();
            public static CfgWpcTrainSignReadCode TrainWpcSignReadCode2 = new CfgWpcTrainSignReadCode();
            public static CfgTrainEolLoad TrainEolLoad = new CfgTrainEolLoad();
            public static CfgEolTrainSignReadCode TrainEolSignReadCode = new CfgEolTrainSignReadCode();

            public static MyVision VisWpcCam1Code = new MyVision();
            public static MyVision VisWpcCam1Sign = new MyVision();
            public static MyVision VisWpcCam2Code = new MyVision();
            public static MyVision VisWpcCam2Sign = new MyVision();
            public static MyVision VisEolProd = new MyVision();
            public static MyVision VisEolJig = new MyVision();
            public static MyVision VisEolCode = new MyVision();
            public static MyVision VisEolSign = new MyVision();

            public static void Init()
            {
                string recipe_path = "Recipe/" + Config.App.Recipe;
                if (!Directory.Exists(recipe_path))  Directory.CreateDirectory(recipe_path);

                //WPC 点亮&读码
                TrainWpcSignReadCode1.Init(recipe_path + "/TrainWpcSignReadCode1.xml");
                TrainWpcSignReadCode2.Init(recipe_path + "/TrainWpcSignReadCode2.xml");
                //EOL 上料
                TrainEolLoad.Init(recipe_path+ "/TrainEolLoad.xml");
                //EOL 点亮&读码
                TrainEolSignReadCode.Init(recipe_path + "/TrainEolSignReadCode.xml");
                //WPC 点亮&读码
                VisWpcCam1Code.LoadAs(recipe_path + "/VisWpcCam1Code.vpp");
                VisWpcCam1Sign.LoadAs(recipe_path + "/VisWpcCam1Sign.vpp");
                VisWpcCam2Code.LoadAs(recipe_path + "/VisWpcCam2Code.vpp");
                VisWpcCam2Sign.LoadAs(recipe_path + "/VisWpcCam2Sign.vpp");
                //EOL 上料
                VisEolProd.LoadAs(recipe_path + "/VisEolProd.vpp");
                VisEolJig.LoadAs(recipe_path + "/VisEolJig.vpp");
                //EOL 点亮&读码
                VisEolCode.LoadAs(recipe_path + "/VisEolCode.vpp");
                VisEolSign.LoadAs(recipe_path + "/VisEolSign.vpp");
            }
        }

        /// <summary> 运行状态 </summary>
        public static class Status
        {
            public static int LoginUserId = 0;
            public static bool isRunning;
        }


        /// <summary>
        /// 最简单的用法：在指定位置画红框
        /// </summary>
        /// <param name="display">VisionPro显示控件</param>
        /// <param name="x">左上角X坐标</param>
        /// <param name="y">左上角Y坐标</param>
        /// <param name="width">宽度</param>
        /// <param name="height">高度</param>
        public static void DrawBox(CogDisplay display, CogColorConstants color, double x, double y, double width, double height)
        {
            CogRectangle rect = new CogRectangle
            {
                X = x,
                Y = y,
                Width = width,
                Height = height,
                Color = color,//CogColorConstants.Red,
                //DragLineWidthInScreenPixels = 4,
                LineWidthInScreenPixels = 3,
                SelectedSpaceName = "#"  // 使用图像坐标系
            };
            display.StaticGraphics.Add(rect, "");
            display.Invalidate();
        }

        /// <summary>
        /// 清除所有绘制的图形
        /// </summary>
        public static void Clear(CogDisplay display)
        {
            display.StaticGraphics.Clear();
            display.Invalidate();
        }
    }

}
