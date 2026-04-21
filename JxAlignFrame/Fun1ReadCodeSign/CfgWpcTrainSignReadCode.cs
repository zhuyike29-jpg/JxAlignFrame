using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules;

namespace JxAlignVision
{
    public class CfgWpcTrainSignReadCode : ModConfig
    {
        //产品点亮最低灰阶
        public int minGray = 200;
        //点亮判断区域数量
        public int regionCnt=2;
    }
}
