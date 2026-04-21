using Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Alignlib;

namespace JxAlignVision
{
    public class CfgEolCCDCalib : ModConfig
    {

        [XmlIgnore]
        /// <summary> 相机矩阵 </summary>
        public EMatrix MatCamera
        {
            get { return new EMatrix(M1, M2, M3, M4, M5, M6); }
            set
            {
                M1 = value.M11;
                M2 = value.M12;
                M3 = value.M21;
                M4 = value.M22;
                M5 = value.Dx;
                M6 = value.Dy;
            }
        }

        [XmlIgnore]
        public ECoord MatTool
        {
            get { return new ECoord(T1, T2, T3); }
            set
            {
                T1 = value.X;
                T2 = value.Y;
                T3 = value.R;
            }
        }

        public double M1 = 1;
        public double M2 = 0;
        public double M3 = 0;
        public double M4 = 1;
        public double M5 = 0;
        public double M6 = 0;

        public double T1 = 0;
        public double T2 = 0;
        public double T3 = 0;

    }
}
