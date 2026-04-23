using Cognex.VisionPro;
using System;
using Alignlib;
using System.Collections.Generic;

namespace JxAlignVision
{
    public class MyVision : Base.BaseCognexVision
    {

        //==处理============================================
        /// <summary> 获取当前视觉点(标定用) </summary>
        public ECoord GetCalibCurrVisionPt(CogImage8Grey img)
        {

            //视觉处理
            this.Tool.Outputs["Count"].Value = 0;
            this.Tool.Inputs["ImageIn"].Value = img;
            this.Tool.Run();

            //运行状态检测
            if (this.Tool.RunStatus.Result != Cognex.VisionPro.CogToolResultConstants.Accept)
            {
                throw new Exception("run vision failure: " + this.Tool.RunStatus.Message);
            }

            //输出检查
            int count = (int)this.Tool.Outputs["Count"].Value;
            if (count == 0)
                throw new Exception("can't find location.");

            //输出
            double x = (double)this.Tool.Outputs["X"].Value;
            double y = (double)this.Tool.Outputs["Y"].Value;
            double r = (double)this.Tool.Outputs["R"].Value * 180 / Math.PI;
            return new ECoord(x, y, r);
        }

        /// 判断产品是否点亮，有一个区域的平均灰阶大于 minGray 判定为点亮
        public bool GetProdSign(CogImage8Grey img,int minGray,int regionCnt) 
        {
            //初始化输出以及图片传入
            this.Tool.Outputs["Count"].Value = 0;
            this.Tool.Inputs["ImageIn"].Value = img;

            for (int i = 0; i < regionCnt; i++) 
            {
                this.Tool.Outputs[$"Region{i+1}"].Value = 0;
            }

            this.Tool.Run();

            //运行状态检测
            if (this.Tool.RunStatus.Result != Cognex.VisionPro.CogToolResultConstants.Accept)
            {
                throw new Exception("run vision failure: " + this.Tool.RunStatus.Message);
            }

            //输出检查
            int count = (int)this.Tool.Outputs["Count"].Value;
            if (count == 0)
            {
                throw new Exception("can't find location.");
            }

            //检查区域是否点亮
            bool isSign = false;
            for (int i = 0; i < regionCnt; i++) 
            {
                var gray = (double)Tool.Outputs[$"Region{i + 1}"].Value;
                if(gray>=minGray) { isSign = true; break; }
            }

            return isSign;
        }

        /// <summary> 获取读码结果</summary>
        public string GetProdCode(CogImage8Grey img)
        {
            //视觉处理
            this.Tool.Outputs["Count"].Value = 0;
            this.Tool.Outputs["Code"].Value = "";
            this.Tool.Inputs["ImageIn"].Value = img;
            this.Tool.Run();

            //运行状态检测
            if (this.Tool.RunStatus.Result != Cognex.VisionPro.CogToolResultConstants.Accept)
            {
                throw new Exception("run vision failure: " + this.Tool.RunStatus.Message);
            }

            //输出检查
            int count = (int)this.Tool.Outputs["Count"].Value;
            if (count == 0)
            {
                throw new Exception("can't find location.");
            }

            //输出
            return (string)this.Tool.Outputs["Code"].Value;
            
        }

        /// <summary> 获取对位视觉点 </summary>
        public ECoord GetAlignPos(CogImage8Grey img)
        {

            //视觉处理
            this.Tool.Outputs["Count"].Value = 0;
            this.Tool.Inputs["ImageIn"].Value = img;
            this.Tool.Run();

            //运行状态检测
            if (this.Tool.RunStatus.Result != Cognex.VisionPro.CogToolResultConstants.Accept)
            {
                throw new Exception("run vision failure: " + this.Tool.RunStatus.Message);
            }

            //输出检查
            int count = (int)this.Tool.Outputs["Count"].Value;
            if (count == 0)
            {
                throw new Exception("can't find location.");
            }

            //输出
            double x = (double)this.Tool.Outputs["X"].Value;
            double y = (double)this.Tool.Outputs["Y"].Value;
            double r = (double)this.Tool.Outputs["R"].Value * 180 / Math.PI;
            return new ECoord(x, y, r);
        }
        //==结果显示============================================

        /// <summary> 图像结果 </summary>
        public ICogRecord GetRecord()
        {
            var reg = Tool.CreateLastRunRecord();
            return reg.SubRecords[reg.SubRecords.Count-1];
        }
    }
}
