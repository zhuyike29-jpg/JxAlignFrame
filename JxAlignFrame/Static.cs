using Base;
using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Modules;
using Sunny.UI;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
                        List<string> lstHeartBeatWpc, lstTriggersWpc;
                        AutoExtractAddresses(Config.App,  out lstHeartBeatWpc, out lstTriggersWpc, "CWPC", "BWPC");
                        Device.WpcReadCodeSignPlc = new WpcReadCodeSignPlc(PlcFactory.CreatePlc(Config.App.WpcPlcType, Config.App.WpcPlcIp, Config.App.WpcPlcPort, Config.App.WpcMxStation, lstHeartBeatWpc, lstTriggersWpc, ModLogger.LogCommumication));
                        //EOL PLC
                        List<string> lstHeartBeatEol, lstTriggersEol;
                        AutoExtractAddresses(Config.App, out lstHeartBeatEol, out lstTriggersEol, "CEOL","BEOL");
                        Device.EolLoadPlc = new EolLoadPlc(PlcFactory.CreatePlc(Config.App.EolPlcType, Config.App.EolPlcIp, Config.App.EolPlcPort, Config.App.EolMxStation, lstHeartBeatEol, lstTriggersEol, ModLogger.LogCommumication));
                        //EOL 读码&点亮PLC
                        List<string> lstHeartBeatEolCs, lstTriggersEolCs;
                        AutoExtractAddresses(Config.App,  out lstHeartBeatEolCs, out lstTriggersEolCs, "CEOLCS", "BEOLCS");
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

                            try
                            {
                                Device.EolReadCodeSignPlc.Open();
                            }
                            catch (Exception ex)
                            {
                                UIMessageBox.ShowError($"PLC{Config.App.EolCsPlcIp}:{Config.App.EolCsMxStation}连接失败，{ex.Message}");
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

        // 正则表达式：兼容英文 '[' 和中文 '【'，精确提取中括号内的纯字母组合
        private static readonly Regex PrefixRegex = new Regex(@"^[\[【]([A-Za-z]+)", RegexOptions.Compiled);

        /// <summary>
        /// 自动提取指定前缀的 PLC 地址 (支持传入多个完整前缀，精确匹配)
        /// </summary>
        /// <param name="configObj">配置对象，如 Config.App</param>
        /// <param name="heartbeats">传出的心跳地址列表</param>
        /// <param name="triggers">传出的触发地址列表</param>
        /// <param name="targetModules">需要匹配的一个或多个完整字母前缀 (例如 "BWPC", "CWPC")</param>
        public static void AutoExtractAddresses(object configObj, out List<string> heartbeats, out List<string> triggers, params string[] targetModules)
        {
            // 【关键修复】带有 out 的参数必须在方法最开头分配内存，否则传出会为空！
            heartbeats = new List<string>();
            triggers = new List<string>();

            // 如果没有传入配置对象，或者没有传入需要寻找的前缀，直接返回
            if (configObj == null || targetModules == null || targetModules.Length == 0) return;

            PropertyInfo[] properties = configObj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);

            foreach (var prop in properties)
            {
                if (prop.PropertyType == typeof(string))
                {
                    // 获取 DisplayName 特性
                    var attributes = prop.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                    if (attributes.Length > 0)
                    {
                        var displayAttr = attributes[0] as DisplayNameAttribute;
                        string displayName = displayAttr.DisplayName;

                        // 正则匹配：例如从 "[BWPC09]心跳点位" 中抓取出 "BWPC"
                        Match match = PrefixRegex.Match(displayName);
                        if (match.Success)
                        {
                            string currentModule = match.Groups[1].Value;

                            // 【核心判断】: 精确判断提取出的前缀，是否存在于我们传入的字符串数组中 (忽略大小写)
                            // 坚决不偷懒，只有严格等于数组里的某个元素才放行！
                            if (targetModules.Contains(currentModule, StringComparer.OrdinalIgnoreCase))
                            {
                                string addressValue = prop.GetValue(configObj) as string;
                                if (string.IsNullOrWhiteSpace(addressValue)) continue;

                                // 功能分类归属
                                if (displayName.Contains("心跳"))
                                {
                                    heartbeats.Add(addressValue);
                                }
                                else if (displayName.Contains("触发") || displayName.Contains("请求"))
                                {
                                    triggers.Add(addressValue);
                                }
                            }
                        }
                    }
                }
            }
        }

    }

}
