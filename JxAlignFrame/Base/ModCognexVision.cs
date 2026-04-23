using Cognex.VisionPro;
using Cognex.VisionPro.Display;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base {

    /// <summary> Cognex视觉模块 </summary>
    public class BaseCognexVision {

        public BaseCognexVision() {

        }

        /// <summary> 视觉工具 </summary>
        public CogToolBlock Tool;

        /// <summary> 修改 </summary>
        public void Edit()
        {
            if (_frmEdit == null)
            {
                _frmEdit = new Form() { StartPosition = FormStartPosition.CenterScreen, Width = 1100, Height = 550, Text = "VppEdit" };
                _frmEdit.Controls.Add(new CogToolBlockEditV2() { Dock = DockStyle.Fill });
                _frmEdit.FormClosing += (o1, e1) =>
                {
                    e1.Cancel = true;
                    if (_frmEdit.Visible)
                    {
                        var dr = MessageBox.Show("Do you want to save the Vpp?\n\nYes=Save, No=NoSave, Cancale=Don't exit.", "SaveVpp", MessageBoxButtons.YesNoCancel);
                        if (dr != DialogResult.Cancel)
                        {
                            _frmEdit.Hide();
                            if (dr == DialogResult.Yes)
                            {
                                this.Save();
                               
                            }
                            this.Load();
                        }
                    }
                };
            }
            else
            {
                _frmEdit.Visible = true;
            }

            //重新关联控件
            _frmEdit.Hide();
                ((CogToolBlockEditV2)_frmEdit.Controls[0]).Subject = null;
                ((CogToolBlockEditV2)_frmEdit.Controls[0]).Subject = Tool;
                _frmEdit.Text = string.Format("VppEdit: [{0}]", _filename);

                //
                _frmEdit.ShowDialog();

        }

        /// <summary> 保存 </summary>
        public void Save() {
            SaveAs(_filename);
        }

        /// <summary> 加载 </summary>
        public void Load() {
            LoadAs(_filename);
        }

        /// <summary> 另存文件 </summary>
        public void SaveAs(string filename) {
            Type type = typeof(System.Runtime.Serialization.Formatters.Binary.BinaryFormatter);
            CogSerializer.SaveObjectToFile(Tool, filename, type, CogSerializationOptionsConstants.Minimum);
            _filename = filename;
        }

        /// <summary> 从文件加载 </summary>
        public void LoadAs(string filename) {
            try {
                if (!System.IO.File.Exists(filename)) {
                    throw new Exception($"Vpp file not found.[{filename}]");
                }
                Tool = (CogToolBlock)CogSerializer.LoadObjectFromFile(filename);
                
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
                Tool = new CogToolBlock();
                throw new Exception(ex.Message);
            }
            _filename = filename;
            Tool.Run();//不查错
        }

        /// <summary> 断开所有相机连接 </summary>
        public static void DisconnectAllGrabbers() {
            CogFrameGrabbers grabbers = new CogFrameGrabbers();
            for (int i = 0; i < grabbers.Count; i++)
                grabbers[i].Disconnect(false);
        }

        //--内部变量----------------------------------
        string _filename = "";
        Form _frmEdit = null;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern void CopyMemory(IntPtr dst, IntPtr src, int count);

        /// <summary> 保存到8位灰度图像 </summary>
        public static Bitmap GetBitmapFromCogGray8Image(CogImage8Grey cog) {
            if (cog == null)
                return null;
            return new CogImage8Grey(cog).ToBitmap();
            //int w = cog.Width;
            //int h = cog.Height;

            //var cogdata = cog.Get8GreyPixelMemory(CogImageDataModeConstants.Read, 0, 0, w, h);
            //Bitmap bmp = new Bitmap(w, h, PixelFormat.Format8bppIndexed);
            //var pp = bmp.Palette;
            //for (int i = 0; i < 256; i++)
            //    pp.Entries[i] = Color.FromArgb(i, i, i);
            //bmp.Palette = pp;

            //BitmapData bmpdata = bmp.LockBits(new Rectangle(0, 0, w, h), ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);
            //if (cogdata.Stride == bmpdata.Stride)
            //{
            //    CopyMemory(bmpdata.Scan0, cogdata.Scan0, cogdata.Stride * h);
            //}
            //else
            //{
            //    for (int y = 0; y < h; y++)
            //    {
            //        CopyMemory(bmpdata.Scan0 + y * bmpdata.Stride, cogdata.Scan0 + y * cogdata.Stride, w);
            //    }
            //}
            //bmp.UnlockBits(bmpdata);
            //return bmp;          
        }
    }
}
