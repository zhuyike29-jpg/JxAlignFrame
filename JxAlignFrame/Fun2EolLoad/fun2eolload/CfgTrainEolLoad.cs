using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;

namespace JxAlignVision
{
    public class CfgTrainEolLoad : ModConfig
    {
        //1.产品位置P1,机械手位置R1
        //Tool1=R1.CalcTool(P1)
        public double modTool1X = 0;
        public double modTool1Y = 0;
        public double modTool1R = 0;

        //治具位置P2,机械手放料位R2
        //Tool2=R2.ToolUsed(Tool1).CalcTool(P2)
        public double modTool2X = 0;
        public double modTool2Y = 0;
        public double modTool2R = 0;

        //补偿值
        public double modTargetHX = 0;
        public double modTargetHY = 0;
        public double modTargetHR = 0;

    }
}
