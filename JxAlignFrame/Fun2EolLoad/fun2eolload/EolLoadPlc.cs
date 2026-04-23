using Alignlib;
using System;
using System.Threading;
using static JxAlignVision.Static;

namespace JxAlignVision
{
    /// <summary>
    /// 当前特定项目的业务逻辑类 (换个项目就重新写一个或继承修改)
    /// </summary>
    public class EolLoadPlc
    {
        // 核心：持有一个底层的 PLC 驱动
        private readonly IPLC _plc;

        // 通过构造函数注入底层的通讯实例
        public EolLoadPlc(IPLC plc)
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
            get { return _plc.ReadInt16(Config.App.EolPlcHeartDog).Content; }
            set { _plc.Write(Config.App.WpcPlcHeartDog, value); }
        }

        #endregion

        #region ================= Eol上料(本项目专属) =================
        /// <summary>产品对位触发（1=触发拍照，0=发送结果完成）</summary>
        public short EolProdAlignTrigger
        {
            get { return _plc.ReadInt16(Config.App.EolProdAlignTrigger).Content; }
            set { _plc.Write(Config.App.EolProdAlignTrigger, value); }
        }
        /// <summary>治具对位触发（1=触发拍照，0=发送结果完成）</summary>
        public short EolJigAlignTrigger
        {
            get { return _plc.ReadInt16(Config.App.EolJigAlignTrigger).Content; }
            set { _plc.Write(Config.App.EolJigAlignTrigger, value); }
        }
        /// <summary>计算触发（1=触发计算，0=发送结果完成）</summary>
        public short EolCalcAlignTrigger
        {
            get { return _plc.ReadInt16(Config.App.EolCalcAlignTrigger).Content; }
            set { _plc.Write(Config.App.EolCalcAlignTrigger, value); }
        }

        /// <summary>治具对位结果（1=OK，2=NG）</summary>
        public short EolJigAlignResult
        {
            get { return _plc.ReadInt16(Config.App.EolJigAlignResult).Content; }
            set { _plc.Write(Config.App.EolJigAlignResult, value); }
        }

        /// <summary>产品对位结果（1=OK，2=NG）</summary>
        public short EolProdAlignResult
        {
            get { return _plc.ReadInt16(Config.App.EolProdAlignResult).Content; }
            set { _plc.Write(Config.App.EolProdAlignResult, value); }
        }

        /// <summary>联合计算结果（1=OK，2=NG）</summary>
        public short EolCalcAlignResult
        {
            get { return _plc.ReadInt16(Config.App.EolCalcAlignResult).Content; }
            set { _plc.Write(Config.App.EolCalcAlignResult, value); }
        }

        /// <summary>产品对位结果坐标</summary>
        public ECoord EolProductAlignPos
        {
            set
            {
                WriteEolProductAlignPos(value.X, value.Y, value.R);
            }
        }

        /// <summary> 写入产品对位结果XYR </summary>
        public void WriteEolProductAlignPos(double x, double y, double r)
        {
            double wx = x;
            double wy = y;
            double wr = r;
            if (Config.App.EolXNegation) wx = -x;
            if (Config.App.EolYNegation) wy = -y;
            if (Config.App.EolRNegation) wr = -r;

            int[] data = new int[] { (Int32)(wx * 1000), (Int32)(wy * 1000), (Int32)(wr * 1000) };
            _plc.Write(Config.App.EolAlignPosX, data);
        }
        /// <summary> 获取当前位置 </summary>
        public void GetPlcCurPos(out double x, out double y, out double r)
        {
            int[] data = _plc.ReadInt32(Config.App.EolRobotCurX, 3).Content;
            x = data[0] / 1000.0;
            y = data[1] / 1000.0;
            r = data[2] / 1000.0;

            if (Config.App.EolXNegation) x = -x;
            if (Config.App.EolYNegation) y = -y;
            if (Config.App.EolRNegation) r = -r;
        }

        public ECoord GetPlcCurPosCoord
        {
            get
            {
                double x, y, r;
                GetPlcCurPos(out x, out y, out r);
                return new ECoord(x, y, r);
            }
        }
        /// <summary> 获取当前机械臂及相机轴位置 </summary>
        public void GetCurPos(out double x, out double y, out double r)
        {
            int[] data = _plc.ReadInt32(Config.App.EolRobotCurX, 5).Content;
            x = data[0] / 1000.0;
            y = data[1] / 1000.0;
            r = data[2] / 1000.0;

            if (Config.App.EolXNegation) x = -x;
            if (Config.App.EolYNegation) y = -y;
            if (Config.App.EolRNegation) r = -r;
        }

        public ECoord GetEolBaseTarPosCoord
        {
            get
            {
                double x, y, r;
                GetEolBaseTarPos(out x, out y, out r);
                return new ECoord(x, y, r);
            }
        }

        /// <summary> 获取当前机械臂及相机轴位置 </summary>
        public void GetEolBaseTarPos(out double x, out double y, out double r)
        {
            int[] data = _plc.ReadInt32(Config.App.EolRobotCurX, 3).Content;
            x = data[0] / 1000.0;
            y = data[1] / 1000.0;
            r = data[2] / 1000.0;

            if (Config.App.EolXNegation) x = -x;
            if (Config.App.EolYNegation) y = -y;
            if (Config.App.EolRNegation) r = -r;
        }

        public void ResetCalib()
        {
            _plc.Write(Config.App.EolRobotMoveFlag, 0);
        }



        /// <summary> 移动目标位置 </summary>
        public void MovePlcPos(double x, double y, double r, bool waitStop = false)
        {
            WriteMovePlcPos(x, y, r);

            _plc.Write(Config.App.EolRobotMoveFlag, (Int16)1);
            if (waitStop)
            {
                _WaitMoveStop(() => _plc.ReadInt16(Config.App.EolRobotMoveFlag).Content);
            }
        }

        public ECoord MovePlcPosCoord
        {
            set
            {
                MovePlcPos(value.X, value.Y, value.R, true);
            }
        }

        public void WriteMovePlcPos(double x, double y, double r)
        {
            double wx = x;
            double wy = y;
            double wr = r;
            if (Config.App.EolXNegation) wx = -x;
            if (Config.App.EolYNegation) wy = -y;
            if (Config.App.EolRNegation) wr = -r;

            _plc.Write(Config.App.EolRobotMoveX, (Int32)(wx * 1000));
            _plc.Write(Config.App.EolRobotMoveY, (Int32)(wy * 1000));
            _plc.Write(Config.App.EolRobotMoveR, (Int32)(wr * 1000));
        }

        /// <summary> 等待移动到位 </summary>
        void _WaitMoveStop(Func<int> func, int timeout = 30)
        {
            var time0 = System.DateTime.Now;
            while (true)
            {

                //休眠
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);

                //读标志位
                if (func() != 1)
                    break;

                //超时
                var time1 = System.DateTime.Now;
                if ((time1 - time0).TotalSeconds > timeout)
                    break;
            }

            if (func() != 0)
            {
                throw new Exception($"错误:{func()}");
            }
        }

        #endregion


    }
}