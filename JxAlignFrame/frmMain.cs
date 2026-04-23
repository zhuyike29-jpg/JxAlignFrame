using Alignlib;
using Base;
using log4net.Repository.Hierarchy;
using Modules;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static JxAlignVision.Static;


namespace JxAlignVision
{
    public partial class frmMain : UIForm
    {
        int userId = 0;
        bool isRunning = false;
        bool isWpcPlcOpen = false;
        bool isEolLoadPlcOpen = false;
        bool isEolCsPlcOpen = false;

        bool isWpcCam1Open = false;
        bool isWpcCam2Open = false;
        bool isEolProdCamOpen = false;
        bool isEolJigCamOpen = false;
        bool isEolJigCodeSignOpen = false;

        public frmMain()
        {
            InitializeComponent();
        }        

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                //显示程序名称
                this.Text = Config.App.SysName;

                //主界面版本号
                lb_vision.Text = Utils.UtilGetBuildTag.Get(this);
                //显示当前配方名称
                lb_recipe.Text = Config.App.Recipe;

                //绑定相机实时画面 * 多个相机做多次绑定
                Device.WpcCam1.OnNewImage += WpcCam1OnNewImage;
                if (Config.App.IsAutoStart)
                {
                    Status.isRunning = true;
                }

                //开启处理线程 多个流程开多个

                //1WPC 相机1 点亮+读码判断
                ModLogger.RecordThread(() => 
                {
                    Wpc1ThreadRun(); 
                });
                //2WPC 相机2 点亮+读码判断
                ModLogger.RecordThread(() =>
                {
                    Wpc2ThreadRun();
                });
                //3.EOL拍产品
                ModLogger.RecordThread(() =>
                {
                    EolProdThreadRun();
                });
                //4.EOL拍治具
                ModLogger.RecordThread(() =>
                {
                    EolJigThreadRun();
                });
                //5.EOL联合计算
                ModLogger.RecordThread(() =>
                {
                    EolCalcThreadRun();
                });
                //6.EOL 点亮+读码
                ModLogger.RecordThread(() => {
                    EolCodeSignThreadRun();
                });
                

                //开启心跳线程
                if (Config.App.IsActivataHeartbeatThread) 
                { 
                    ModLogger.RecordThread(() => { threadHeartdog(); }); 
                }
                
                //各状态初始化
                userId = Status.LoginUserId - 1;
                isRunning = !Status.isRunning;
                isWpcPlcOpen = !Device.WpcReadCodeSignPlc.IsOpen();
                isEolLoadPlcOpen = !Device.EolLoadPlc.IsOpen();
                isEolCsPlcOpen = !Device.EolReadCodeSignPlc.IsOpen();

                isWpcCam1Open = !Device.WpcCam1.IsOpen();
                isWpcCam2Open = !Device.WpcCam2.IsOpen();
                isEolJigCamOpen = !Device.EolJigCam.IsOpen();
                isEolProdCamOpen= !Device.EolProdCam.IsOpen();
                isEolJigCodeSignOpen=!Device.EolCsCam.IsOpen();
            });
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            ModLogger.Record(() => {
                if (Status.isRunning)
                {
                    UIMessageBox.ShowError("运行中, 请停止运行！");
                    e.Cancel = true;
                    return;
                }
                if (!UIMessageBox.ShowAsk("您确定要退出系统吗 ?"))
                {
                    e.Cancel = true;
                    return;
                }

                Device.WpcCam1.OnNewImage -= WpcCam1OnNewImage;

                //断开硬件&保存系统参数
                Static.UnInit();
            });
        }

        private void WpcCam1OnNewImage( Cognex.VisionPro.CogImage8Grey obj)
        {
            if (ckbAutoGrabbing.Checked)
            {
                ucDisWpc1.ShowRealTimeImg(obj);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ModLogger.Record(() => {
                //定时删除过期日志
                ModLogger.CheckExceed(Config.App.LogFolder, Config.App.LogExceeDays);

                //权限用户
                if (userId != Status.LoginUserId)
                {
                    userId = Status.LoginUserId;
                    StripMenu_Login.Text = userId > 0 ? "登出" : "登入";
                    StripMenu_Recipe.Visible = userId >= 1 && !Status.isRunning;
                    StripMenu_Dubug.Visible = userId >= 2 && !Status.isRunning;
                    StripMenu_Param.Visible = userId >= 3 && !Status.isRunning;
                }

                //设备连接状态 -- PLC
                if (isWpcPlcOpen != Device.WpcReadCodeSignPlc.IsOpen())
                {
                    isWpcPlcOpen = Device.WpcReadCodeSignPlc.IsOpen();
                    tsslblWpcPlc.ForeColor = isWpcPlcOpen ? Color.Green : Color.Red;
                }

                if (isEolLoadPlcOpen != Device.EolLoadPlc.IsOpen())
                {
                    isEolLoadPlcOpen = Device.EolLoadPlc.IsOpen();
                    tsslblEolLoadPlc.ForeColor = isEolLoadPlcOpen ? Color.Green : Color.Red;
                }

                if (isEolCsPlcOpen != Device.EolReadCodeSignPlc.IsOpen()) 
                {
                    isEolCsPlcOpen = Device.EolReadCodeSignPlc.IsOpen();
                    tsslblEolPlc.ForeColor = isEolCsPlcOpen ? Color.Green : Color.Red;
                }

                //设备连接状态 -- 相机
                if (isWpcCam1Open != Device.WpcCam1.IsOpen())
                {
                    isWpcCam1Open = Device.WpcCam1.IsOpen();
                    tsslblWpcCam1.ForeColor = isWpcCam1Open ? Color.Green : Color.Red;
                }

                if (isWpcCam2Open != Device.WpcCam2.IsOpen())
                {
                    isWpcCam2Open = Device.WpcCam2.IsOpen();
                    tsslblWpcCam2.ForeColor = isWpcCam2Open ? Color.Green : Color.Red;
                }
                
                if (isEolProdCamOpen != Device.EolProdCam.IsOpen())
                {
                    isEolProdCamOpen = Device.EolProdCam.IsOpen();
                    tsslblEolProdCam.ForeColor = isEolProdCamOpen ? Color.Green : Color.Red;
                }

                if (isEolJigCamOpen != Device.EolJigCam.IsOpen()) 
                { 
                    isEolJigCamOpen = Device.EolJigCam.IsOpen();
                    tsslblEolJigCam.ForeColor = isEolJigCamOpen ? Color.Green : Color.Red;
                }

                if(isEolJigCodeSignOpen != Device.EolCsCam.IsOpen())
                {
                    isEolJigCodeSignOpen = Device.EolCsCam.IsOpen();
                    tsslblEolCsCam.ForeColor = isEolJigCodeSignOpen ? Color.Green : Color.Red;
                }

                //程序运行状态
                if (isRunning != Status.isRunning)
                {
                    isRunning = Status.isRunning;
                    lb_IsRunning.ForeColor = isRunning ? Color.Green : Color.Red;
                    lb_IsRunning.Text = isRunning ? "运行中" : "已停止";
                    btnStart.Enabled = !isRunning;
                    btnStop.Enabled = isRunning;
                    ckbAutoGrabbing.Enabled = !isRunning;
                    
                    StripMenu_Recipe.Visible = Status.LoginUserId >= 1 && !isRunning;
                    StripMenu_Dubug.Visible = Status.LoginUserId >= 2 && !isRunning;
                    StripMenu_Param.Visible = Status.LoginUserId >= 3 && !isRunning;
                }

                GC.Collect();
            });
        }


        //====[执行线程]=======================================================
        ECoord lastEolProdTool = null;
        ECoord lastJigPos = null;

        void Wpc1ThreadRun()
        {
            while (true)
            {
                Thread.Sleep(15);
                if (!Status.isRunning) continue;

                //检查设备连接状态
                if (!Device.WpcReadCodeSignPlc.IsOpen())
                {
                    UpdateProcess("WPC Plc未连接", false);
                    Status.isRunning = false;
                    continue;
                }

                if (!Device.WpcCam1.IsOpen())
                {
                    UpdateProcess("WPC相机1连接失败", false);
                    Status.isRunning = false;
                    continue;
                }

                if (Device.WpcReadCodeSignPlc.WpcPlcProductCodeTrigger1 == 1)
                {
                    UpdateProcess("收到WPC 1 读码信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.WpcCam1.GetNewImage());
                        ucDisWpc1.ShowImg(Img);
                        var code = Recipe.VisWpcCam1Code.GetProdCode(Img);
                        UpdateProcess($"WPC1解码：{code}");
                        //识别失败
                        if (string.IsNullOrEmpty(code))
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductCodeResult1 = 2;
                            SaveNgImage(Img, "WPC1读码");
                        }
                        else
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductCodeResult1 = 1;
                            Device.WpcReadCodeSignPlc.WpcWriteProductCode1 = code;
                            SaveOkImage(Img, code, "WPC1读码");
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"WPC1读码失败，{ex.Message}", false);
                        Device.WpcReadCodeSignPlc.WpcPlcProductCodeResult1 = 2;
                        SaveNgImage(Img, "WPC1读码");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.WpcReadCodeSignPlc.WpcPlcProductCodeTrigger1 = 0;
                    }
                }

                if (Device.WpcReadCodeSignPlc.WpcPlcProductSignTrigger1 == 1)
                {
                    UpdateProcess("收到WPC 1 点亮信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.WpcCam1.GetNewImage());
                        ucDisWpc1.ShowImg(Img);
                        var isSign = Recipe.VisWpcCam1Sign.GetProdSign(Img, Recipe.TrainWpcSignReadCode1.minGray, Recipe.TrainWpcSignReadCode1.regionCnt);
                        UpdateProcess($"WPC1产品点亮状态：{isSign}");
                        //识别失败
                        if (isSign)
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductSignResult1 = 1;
                            SaveOkImage(Img, "WPC1点亮");
                        }
                        else
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductSignResult1 = 2;
                            SaveNgImage(Img, "WPC1点亮");
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"判断产品点亮失败，{ex.Message}", false);
                        Device.WpcReadCodeSignPlc.WpcPlcProductSignResult1 = 2;
                        SaveNgImage(Img, "WPC1点亮");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.WpcReadCodeSignPlc.WpcPlcProductSignTrigger1 = 0;
                    }
                }
            }
        }
        void Wpc2ThreadRun()
        {
            while (true)
            {
                Thread.Sleep(15);
                if (!Status.isRunning) continue;

                //检查设备连接状态
                if (!Device.WpcReadCodeSignPlc.IsOpen())
                {
                    UpdateProcess("WPC Plc未连接", false);
                    Status.isRunning = false;
                    continue;
                }

                if (!Device.WpcCam2.IsOpen())
                {
                    UpdateProcess("WPC 2 相机连接失败", false);
                    Status.isRunning = false;
                    continue;
                }

                if (Device.WpcReadCodeSignPlc.WpcPlcProductCodeTrigger2 == 1)
                {
                    UpdateProcess("收到WPC 2 读码信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.WpcCam2.GetNewImage());
                        ucDisWpc2.ShowImg(Img);
                        var code = Recipe.VisWpcCam2Code.GetProdCode(Img);
                        UpdateProcess($"WPC2读码：{code}");
                        //识别失败
                        if (string.IsNullOrEmpty(code))
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductCodeResult2 = 2;
                            SaveNgImage(Img, "WPC2读码");
                        }
                        else
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductCodeResult2 = 1;
                            Device.WpcReadCodeSignPlc.WpcWriteProductCode2 = code;
                            SaveOkImage(Img, code, "WPC2读码");
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"读码失败，{ex.Message}", false);
                        Device.WpcReadCodeSignPlc.WpcPlcProductCodeResult2 = 2;
                        SaveNgImage(Img, "WPC2读码");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.WpcReadCodeSignPlc.WpcPlcProductCodeTrigger1 = 0;
                    }
                }

                if (Device.WpcReadCodeSignPlc.WpcPlcProductSignTrigger2 == 1)
                {
                    UpdateProcess("收到WPC 2 点亮信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.WpcCam2.GetNewImage());
                        ucDisWpc2.ShowImg(Img);
                        var isSign = Recipe.VisWpcCam2Sign.GetProdSign(Img, Recipe.TrainWpcSignReadCode2.minGray, Recipe.TrainWpcSignReadCode2.regionCnt);
                        UpdateProcess($"WPC2产品点亮状态：{isSign}");
                        //识别失败
                        if (isSign)
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductSignResult2 = 1;
                            SaveOkImage(Img, "WPC2点亮");
                        }
                        else
                        {
                            Device.WpcReadCodeSignPlc.WpcPlcProductSignResult2 = 2;
                            SaveNgImage(Img, "WPC2点亮");
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"判断产品点亮失败，{ex.Message}", false);
                        Device.WpcReadCodeSignPlc.WpcPlcProductSignResult2 = 2;
                        SaveNgImage(Img, "WPC2点亮");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.WpcReadCodeSignPlc.WpcPlcProductSignTrigger2 = 0;
                    }
                }
            }
        }
        void EolProdThreadRun()
        {
            while (true)
            {
                Thread.Sleep(15);
                if (!Status.isRunning) continue;

                //检查设备连接状态
                if (!Device.EolLoadPlc.IsOpen())
                {
                    UpdateProcess("EOL Plc未连接", false);
                    Status.isRunning = false;
                    continue;
                }

                if (!Device.EolProdCam.IsOpen())
                {
                    UpdateProcess("EOL产品相机连接失败", false);
                    Status.isRunning = false;
                    continue;
                }

                if (Device.EolLoadPlc.EolProdAlignTrigger == 1)
                {
                    UpdateProcess("收到EOL产品信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        var currRobpt = Device.EolLoadPlc.GetPlcCurPosCoord;
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.EolProdCam.GetNewImage());
                        ucDisEolProd.ShowImg(Img);
                        var imgpt = Recipe.VisEolProd.GetAlignPos(Img);
                        ucDisEolProd.ShowRecord(Recipe.VisEolProd.GetRecord());
                        var img2Robpt = Config.EolProdCalib.MatCamera.TransformCoord(imgpt);
                        lastEolProdTool = currRobpt.CalcTool(img2Robpt);
                        SaveOkImage(Img, "EOL产品");
                        UpdateProcess($"EOL产品拍照完成,Tool ={lastEolProdTool.ToString()}");
                        Device.EolLoadPlc.EolProdAlignResult = 1;
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"EOL产品拍照失败，{ex.Message}", false);
                        Device.EolLoadPlc.EolProdAlignResult = 2;
                        SaveNgImage(Img, "EOL产品");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.EolLoadPlc.EolProdAlignTrigger = 0;
                    }
                }
            }
        }
        void EolJigThreadRun()
        {
            while (true)
            {
                Thread.Sleep(15);
                if (!Status.isRunning) continue;

                //检查设备连接状态
                if (!Device.EolLoadPlc.IsOpen())
                {
                    UpdateProcess("Eol Plc未连接", false);
                    Status.isRunning = false;
                    continue;
                }

                if (!Device.EolJigCam.IsOpen())
                {
                    UpdateProcess("EOL治具相机连接失败", false);
                    Status.isRunning = false;
                    continue;
                }

                if (Device.EolLoadPlc.EolJigAlignTrigger == 1)
                {
                    UpdateProcess("收到EOL产品信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.EolJigCam.GetNewImage());
                        ucDisEolJig.ShowImg(Img);
                        var imgpt = Recipe.VisEolJig.GetAlignPos(Img);
                        ucDisEolJig.ShowRecord(Recipe.VisEolJig.GetRecord());
                        var img2Robpt = Config.EolJigCalib.MatCamera.TransformCoord(imgpt);
                        lastJigPos = img2Robpt;

                        SaveOkImage(Img, "EOL治具");
                        UpdateProcess($"EOL治具拍照完成,坐标：{lastJigPos.ToString()}");
                        Device.EolLoadPlc.EolJigAlignResult = 1;

                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"EOL治具拍照失败，{ex.Message}", false);
                        Device.EolLoadPlc.EolJigAlignResult = 2;
                        SaveNgImage(Img, "EOL治具");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.EolLoadPlc.EolJigAlignTrigger = 0;
                    }
                }
            }
        }
        void EolCalcThreadRun()
        {
            while (true)
            {
                Thread.Sleep(15);
                if (!Status.isRunning) continue;

                //检查设备连接状态
                if (!Device.EolLoadPlc.IsOpen())
                {
                    UpdateProcess("Eol Plc未连接", false);
                    Status.isRunning = false;
                    continue;
                }

                if (Device.EolLoadPlc.EolCalcAlignTrigger == 1)
                {
                    UpdateProcess("收到EOL偏移计算信号！");
                    try
                    {
                        if (lastEolProdTool == null) throw new Exception("EOL产品坐标为空");
                        if (lastJigPos == null) throw new Exception("EOL治具坐标为空");

                        var tool2 = new ECoord(Recipe.TrainEolLoad.modTool2X, Recipe.TrainEolLoad.modTool2Y, Recipe.TrainEolLoad.modTool2R);
                        var TargetHX = new ECoord(Recipe.TrainEolLoad.modTargetHX, Recipe.TrainEolLoad.modTargetHY, Recipe.TrainEolLoad.modTargetHR);
                        var tar = (lastJigPos+ TargetHX).ToolUndo(tool2).ToolUndo(lastEolProdTool);
                        var baseTar = Device.EolLoadPlc.GetEolBaseTarPosCoord;

                        var offset = tar - baseTar;
                        UpdateProcess($"EOL 偏移计算完成：目标坐标：{tar.ToString()}\r\n 示教放置位：{baseTar.ToString()}\r\n 补偿值：{offset.ToString()}");
                        Device.EolLoadPlc.EolProductAlignPos=offset;
                        Thread.Sleep(50);
                        Device.EolLoadPlc.EolCalcAlignResult = 1;
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"EOL偏移计算失败，{ex.Message}", false);
                        Device.EolLoadPlc.EolCalcAlignResult = 2;
                    }
                    finally
                    {
                        lastEolProdTool=null;
                        lastJigPos=null;
                        //还原触发信号
                        Device.EolLoadPlc.EolCalcAlignTrigger = 0;
                    }
                }
            }
        }

        void EolCodeSignThreadRun()
        {
            while (true)
            {
                Thread.Sleep(15);
                if (!Status.isRunning) continue;

                //检查设备连接状态
                if (!Device.EolReadCodeSignPlc.IsOpen())
                {
                    UpdateProcess("EOL Plc未连接", false);
                    Status.isRunning = false;
                    continue;
                }

                if (!Device.EolCsCam.IsOpen())
                {
                    UpdateProcess("相机连接失败", false);
                    Status.isRunning = false;
                    continue;
                }

                if (Device.EolReadCodeSignPlc.EolPlcProductCodeTrigger == 1)
                {
                    UpdateProcess("收到EOL 读码信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.EolCsCam.GetNewImage());
                        ucDisEolCs.ShowImg(Img);
                        var code = Recipe.VisEolCode.GetProdCode(Img);
                        UpdateProcess($"EOL码：{code}");
                        //识别失败
                        if (string.IsNullOrEmpty(code))
                        {
                            Device.EolReadCodeSignPlc.EolPlcProductCodeResult = 2;
                            SaveNgImage(Img, "EOL解码");
                        }
                        else
                        {
                            Device.EolReadCodeSignPlc.EolPlcProductCodeResult = 1;
                            Device.EolReadCodeSignPlc.EolPlcProductCode = code;
                            SaveOkImage(Img, code, "EOL解码");
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"EOL读码失败，{ex.Message}", false);
                        Device.EolReadCodeSignPlc.EolPlcProductCodeResult = 2;
                        SaveNgImage(Img, "EOL读码");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.EolReadCodeSignPlc.EolPlcProductCodeTrigger = 0;
                    }
                }

                if (Device.EolReadCodeSignPlc.EolPlcProductSignTrigger == 1)
                {
                    UpdateProcess("收到EOL点亮信号！");
                    Cognex.VisionPro.CogImage8Grey Img = null;
                    try
                    {
                        Img = new Cognex.VisionPro.CogImage8Grey(Device.EolCsCam.GetNewImage());
                        ucDisEolCs.ShowImg(Img);
                        var isSign = Recipe.VisEolSign.GetProdSign(Img, Recipe.TrainEolSignReadCode.minGray, Recipe.TrainEolSignReadCode.regionCnt);
                        UpdateProcess($"EOL产品点亮状态：{isSign}");
                        //识别失败
                        if (isSign)
                        {
                            Device.EolReadCodeSignPlc.EolPlcProductCodeResult = 1;
                            SaveOkImage(Img, "EOL点亮");
                        }
                        else
                        {
                            Device.EolReadCodeSignPlc.EolPlcProductCodeResult = 2;
                            SaveNgImage(Img, "EOL点亮");
                        }
                    }
                    catch (Exception ex)
                    {
                        UpdateProcess($"判断EOL产品点亮失败，{ex.Message}", false);
                        Device.WpcReadCodeSignPlc.WpcPlcProductSignResult1 = 2;
                        SaveNgImage(Img, "EOL点亮");
                    }
                    finally
                    {
                        //还原触发信号
                        Device.EolReadCodeSignPlc.EolPlcProductSignTrigger = 0;
                    }
                }
            }
        }

        void threadHeartdog()
        {
            while (true)
            {
                Thread.Sleep(1000);
                if (Status.isRunning) 
                {
                    Task t1 = new Task(() => {
                        Device.WpcReadCodeSignPlc.HeartDog = 1;
                        Thread.Sleep(1000);
                        Device.WpcReadCodeSignPlc.HeartDog = 0;
                    });

                    Task t2 = new Task(() => {
                        Device.EolLoadPlc.HeartDog = 1;
                        Thread.Sleep(1000);
                        Device.EolLoadPlc.HeartDog = 0;
                    });

                    Task t3 = new Task(() => {
                        Device.EolReadCodeSignPlc.HeartDog = 1;
                        Thread.Sleep(1000);
                        Device.EolReadCodeSignPlc.HeartDog = 0;
                    });

                    t1.Start();
                    t2.Start();
                    t3.Start();

                    Task.WaitAll(t1,t2,t3);

                }
            }
        }

        #region 界面按钮

        private void StripMenu_Login_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("权限管理", () =>{
                if(Status.LoginUserId > 0)
                {
                    Status.LoginUserId = 0;
                }
                else
                {
                    using (ModUserLogin frm = new ModUserLogin())
                    {
                        frm.Check += (int userId, string password) => {
                            string[] pwds = { Config.App.OPN_Password, Config.App.ENG_Password, Config.App.ADMIN_Password };
                            return pwds[userId] == password;
                        };
                        frm.AfterLogin += (int userId) => {
                            Status.LoginUserId = userId + 1;
                        };
                        frm.StartPosition = FormStartPosition.CenterParent;
                        frm.ShowDialog();
                    }
                }
                string user = "null";
                switch (Status.LoginUserId)
                {
                    case 0:
                        user = "null";
                        break;
                    case 1:
                        user = "操作员";
                        break;
                    case 2:
                        user = "工程师";
                        break;
                    case 3:
                        user = "管理员";
                        break;
                }
                Status_User.Text = user;
            });
        }

        private void StripMenu_Recipe_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("配方管理", () => {
                using (ModRecipeForm frm = new ModRecipeForm(Config.App.Recipe))
                {
                    frm.ChangeRecipe += (string _recipe) => {
                        Config.App.Recipe = _recipe;
                        Config.App.Save();
                        Recipe.Init();
                        lb_recipe.Text = _recipe;
                    };
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            });
        }

        private void StripMenu_Debug_Device_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("设备点检", () => {
                using(frmDevice frm = new frmDevice())
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            });
        }

        private void StripMenu_Param_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("系统参数", () => {
                Config.App.Edit();
            });
        }

        private void tsmiWpcCam1_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("WPC 相机1配方", () =>
            {
                using (frmWpcDebug frm = new frmWpcDebug(Recipe.VisWpcCam1Code, Recipe.VisWpcCam1Sign, Recipe.TrainWpcSignReadCode1,Device.WpcCam1))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            });
        }

        private void tsmiWpcCam2_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("WPC 相机2配方", () =>
            {
                using (frmWpcDebug frm = new frmWpcDebug(Recipe.VisWpcCam2Code, Recipe.VisWpcCam2Sign, Recipe.TrainWpcSignReadCode2, Device.WpcCam2))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            });
        }

        private void eOL上料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("EOL上料模板调试", () => {
                using (frmEolDebug frm = new frmEolDebug())
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            });
        }

        private void eOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmEolCSDebug frm = new frmEolCSDebug(Recipe.VisEolCode, Recipe.VisEolSign, Recipe.TrainEolSignReadCode, Device.EolCsCam))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
        }

        private void eOL产品位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("EOL产品标定", () => {
                if (!Device.EolLoadPlc.IsOpen())
                {
                    MessageBox.Show("请连接EOL PLC！");
                    return;
                }
                if (!Device.EolProdCam.IsOpen())
                {
                    MessageBox.Show("请连接EOL 产品相机！");
                    return;
                }
                using (frmEolCalib frm = new frmEolCalib(Device.EolProdCam, Config.VisionEolProdCalib, Config.EolProdCalib, Config.App.EolPordCam))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            });
        }

        private void eOL治具位标定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("EOL治具标定", () => {
                if (!Device.EolLoadPlc.IsOpen())
                {
                    MessageBox.Show("请连接EOL PLC！");
                    return;
                }
                if (!Device.EolProdCam.IsOpen())
                {
                    MessageBox.Show("请连接EOL治具相机！");
                    return;
                }
                using (frmEolCalib frm = new frmEolCalib(Device.EolJigCam, Config.VisionEolJigCalib, Config.EolJigCalib, Config.App.EolJigCam))
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog();
                }
            });
        }

        #endregion

        //====[内部函数变量]=======================================================
        void SaveOkImage(Cognex.VisionPro.CogImage8Grey img, string id,string type)
        {
            if (Config.App.LogSaveOkImageAllow)
            {
                var bmp = Base.BaseCognexVision.GetBitmapFromCogGray8Image(img);
                ModLogger.save_image_thread(bmp, $"{Config.App.LogSaveOkImageFolder}/{type}", Config.App.LogSaveOkImageLimitOnDay, Config.App.ImgExceeDays,id);
            }
        }

        void SaveOkImage(Cognex.VisionPro.CogImage8Grey img, string type)
        {
            if (Config.App.LogSaveOkImageAllow)
            {
                var bmp = Base.BaseCognexVision.GetBitmapFromCogGray8Image(img);
                ModLogger.save_image_thread(bmp, $"{Config.App.LogSaveOkImageFolder}/{type}",Config.App.LogSaveOkImageLimitOnDay,Config.App.ImgExceeDays);
            }
        }
        void SaveNgImage(Cognex.VisionPro.CogImage8Grey img, string type)
        {
            if (Config.App.LogSaveNgImageAllow)
            {
                var bmp = Base.BaseCognexVision.GetBitmapFromCogGray8Image(img);
                ModLogger.save_image_thread(bmp, $"{Config.App.LogSaveNgImageFolder}/{type}", Config.App.LogSaveNgImageLimitOnDay, Config.App.ImgExceeDays);
            }
        }
        ///更新界面交互
        void UpdateProcess(string text, bool isOk=true)
        {
            ModLogger.LogCommumication.Info(text);
            ModLogger.FillRichTextBox(rtxtLog, text, isOk);
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("启动", () => {
                Status.isRunning = true;
            });
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            ModLogger.Operate("停止", () => {
                Status.isRunning = false;
            });
        }


    }
}
