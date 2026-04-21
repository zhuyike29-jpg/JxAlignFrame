using log4net.Repository.Hierarchy;
using MvCamCtrl.NET;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static MvCamCtrl.NET.MyCamera;

namespace JxAlignVision {

    /// <summary> 相机模块 </summary>
    public class BaseHikCamera {
        private MyCamera _camera = null;
        private int _nRet;
        public RotateFlipType _rotateFlipType;

        public BaseHikCamera(RotateFlipType type) {
            //初始化相机
            _camera= new MyCamera();
            _rotateFlipType = type;
            //设定回调
            _imageCallback = new MyCamera.cbOutputdelegate(imageCallbackFun);
            _exceptionCallBack = new MyCamera.cbExceptiondelegate(exceptionCallBackFun);
        }

        MyCamera.cbOutputdelegate _imageCallback;
        MyCamera.cbExceptiondelegate _exceptionCallBack;
        MyCamera.MV_CC_DEVICE_INFO_LIST m_pDeviceList;

        #region Params

        /// <summary> 相机曝光 </summary>
        public double CamExposureTime {
            get { MVCC_FLOATVALUE fVal = new MVCC_FLOATVALUE(); _camera.MV_CC_GetFloatValue_NET("ExposureTime", ref fVal); return fVal.fCurValue;}
            set { _camera.MV_CC_SetFloatValue_NET("ExposureTime", Convert.ToSingle(value));}
        }

        /// <summary> 相机增益 </summary>
        public double CamGain {
            get { MVCC_FLOATVALUE fVal = new MVCC_FLOATVALUE(); _camera.MV_CC_GetFloatValue_NET("Gain", ref fVal); return fVal.fCurValue; }
            set { _camera.MV_CC_SetFloatValue_NET("Gain", Convert.ToSingle(value)); }
        }

        /// <summary> 相机Gamma </summary>
        public double CamGamma {
            get { MVCC_FLOATVALUE fVal = new MVCC_FLOATVALUE(); _camera.MV_CC_GetFloatValue_NET("Gamma", ref fVal); return fVal.fCurValue; }
            set { _camera.MV_CC_SetFloatValue_NET("Gamma", Convert.ToSingle(value)); }
        }

        /// <summary> 保存用户设置 </summary>
        public void UserSetSave() {
            //m_camera.CommandExecute("UserSetSave");
            _camera.MV_CC_SetCommandValue_NET("UserSetSave");
        }

        #endregion

        #region Field



        /// <summary> 相机名称 </summary>
        public string Name;

        /// <summary> 相机型号 </summary>
        public string Model;

        /// <summary> 相机SN号 </summary>
        public string Sn;

        /// <summary> 帧数 </summary>
        public int Frame = 0;

        /// <summary> 帧率 </summary>
        public double Fps = 0;
        Stopwatch _fps_watch = new Stopwatch();

        /// <summary> 图像宽度 </summary>
        public int ImageWidth = 0;

        /// <summary> 图像高度 </summary>
        public int ImageHeight = 0;

        /// <summary> 触发模式，1：连续（软触发），2：软触发，3：硬件触发 </summary>
        int TriMode = 1;

        #endregion

        #region Event

        /// <summary> 相机打开事件 </summary>
        public event Action OnCameraOpen;

        /// <summary> 相机关闭事件 </summary>
        public event Action OnCameraClose;

        /// <summary> 相机掉线事件 </summary>
        public event Action OnCameraLose;

        /// <summary> 相机取图事件 </summary>
        public event Action<Cognex.VisionPro.CogImage8Grey> OnNewImage;

        #endregion

        #region Method

        /// <summary>
        /// 枚举相机
        /// </summary>
        private List<string> DeviceListAcq()
        {

            List<string> deviceList = new List<string>();
            m_pDeviceList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
            // ch:创建设备列表 || en: Create device list
            System.GC.Collect();

            _nRet = MyCamera.MV_CC_EnumDevices_NET(MyCamera.MV_GIGE_DEVICE | MyCamera.MV_USB_DEVICE | MyCamera.MV_GENTL_GIGE_DEVICE
                | MyCamera.MV_GENTL_CAMERALINK_DEVICE | MyCamera.MV_GENTL_CXP_DEVICE | MyCamera.MV_GENTL_XOF_DEVICE, ref m_pDeviceList, null, MyCamera.MV_SORT_METHOD.SortMethod_SerialNumber);
            if (MyCamera.MV_OK != _nRet)
            {
                throw new Exception("Enum devices failed!");
            }

            // ch:在窗体列表中显示设备名 || Display the device'name on window's list
            for (int i = 0; i < m_pDeviceList.nDeviceNum; i++)
            {
                MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));
                deviceList.Add(getCameraInfo(device).Name);
            }
            return deviceList;
        }

        public class CameraInfo
        {
            public string Name;
            public string Model;
            public string Sn;
        }


        private CameraInfo getCameraInfo(MyCamera.MV_CC_DEVICE_INFO device) {
            CameraInfo  cameraInfo = new CameraInfo();
            if (device.nTLayerType == MyCamera.MV_GIGE_DEVICE || device.nTLayerType == MyCamera.MV_GENTL_GIGE_DEVICE)
            {
                IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
                MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));
                if (gigeInfo.chUserDefinedName != "")
                {
                    cameraInfo.Name = gigeInfo.chUserDefinedName;
                    cameraInfo.Model = gigeInfo.chModelName;
                    cameraInfo.Sn = gigeInfo.chSerialNumber;
                }
                else
                {
                    cameraInfo.Name = gigeInfo.chManufacturerName;
                    cameraInfo.Model = gigeInfo.chModelName;
                    cameraInfo.Sn = gigeInfo.chSerialNumber;
                }
            }
            else if (device.nTLayerType == MyCamera.MV_USB_DEVICE)
            {
                IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stUsb3VInfo, 0);
                MyCamera.MV_USB3_DEVICE_INFO usbInfo = (MyCamera.MV_USB3_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_USB3_DEVICE_INFO));
                if (usbInfo.chUserDefinedName != "")
                {
                    cameraInfo.Name = usbInfo.chUserDefinedName;
                    cameraInfo.Model = usbInfo.chModelName;
                    cameraInfo.Sn = usbInfo.chSerialNumber;
                }
                else
                {
                    cameraInfo.Name = usbInfo.chManufacturerName;
                    cameraInfo.Model = usbInfo.chModelName;
                    cameraInfo.Sn = usbInfo.chSerialNumber;
                }
            }
            else if (device.nTLayerType == MyCamera.MV_GENTL_CAMERALINK_DEVICE)
            {
                IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stCMLInfo, 0);
                MyCamera.MV_CML_DEVICE_INFO CMLInfo = (MyCamera.MV_CML_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_CML_DEVICE_INFO));
                if (CMLInfo.chUserDefinedName != "")
                {
                    cameraInfo.Name = CMLInfo.chUserDefinedName;
                    cameraInfo.Model = CMLInfo.chModelName;
                    cameraInfo.Sn = CMLInfo.chSerialNumber;
                }
                else
                {
                    cameraInfo.Name = CMLInfo.chVendorName;
                    cameraInfo.Model = CMLInfo.chModelName;
                    cameraInfo.Sn = CMLInfo.chSerialNumber;
                }
            }
            else if (device.nTLayerType == MyCamera.MV_GENTL_CXP_DEVICE)
            {
                IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stCXPInfo, 0);
                MyCamera.MV_CXP_DEVICE_INFO CXPInfo = (MyCamera.MV_CXP_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_CXP_DEVICE_INFO));
                if (CXPInfo.chUserDefinedName != "")
                {
                    cameraInfo.Name = CXPInfo.chUserDefinedName;
                    cameraInfo.Model = CXPInfo.chModelName;
                    cameraInfo.Sn = CXPInfo.chSerialNumber;
                }
                else
                {
                    cameraInfo.Name = CXPInfo.chVendorName;
                    cameraInfo.Model = CXPInfo.chModelName;
                    cameraInfo.Sn = CXPInfo.chSerialNumber;
                }
            }
            else if (device.nTLayerType == MyCamera.MV_GENTL_XOF_DEVICE)
            {
                IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stXoFInfo, 0);
                MyCamera.MV_XOF_DEVICE_INFO XoFInfo = (MyCamera.MV_XOF_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_XOF_DEVICE_INFO));
                if (XoFInfo.chUserDefinedName != "")
                {
                    cameraInfo.Name = XoFInfo.chUserDefinedName;
                    cameraInfo.Model = XoFInfo.chModelName;
                    cameraInfo.Sn = XoFInfo.chSerialNumber;
                }
                else
                {
                    cameraInfo.Name = XoFInfo.chVendorName;
                    cameraInfo.Model = XoFInfo.chModelName;
                    cameraInfo.Sn = XoFInfo.chSerialNumber;
                }
            }

            return cameraInfo;
        }



        private string GetErrorMsg(int errorCode)
        {
            // 1. 先将十进制错误码转换为十六进制字符串（便于对照SDK文档）
            string hexCode = $"0x{errorCode:X8}"; // 格式化为8位十六进制（补零）

            // 2. 同时匹配十进制和十六进制错误码（覆盖常见场景）
            switch (errorCode)
            {
                // 基础错误码（十进制）
                case -1: return $"十进制：{errorCode}（{hexCode}）→ MV_E_FAIL：通用失败";
                case -2: return $"十进制：{errorCode}（{hexCode}）→ MV_E_INVALID_HANDLE：无效句柄";
                case -3: return $"十进制：{errorCode}（{hexCode}）→ MV_E_NOT_SUPPORT：不支持的操作";
                case -4: return $"十进制：{errorCode}（{hexCode}）→ MV_E_PARAMETER：参数错误";
                case -5: return $"十进制：{errorCode}（{hexCode}）→ MV_E_RESOURCE：资源不足";
                case -6: return $"十进制：{errorCode}（{hexCode}）→ MV_E_TIMEOUT：超时";
                case -7: return $"十进制：{errorCode}（{hexCode}）→ MV_E_NO_DEVICE：无设备";
                case -8: return $"十进制：{errorCode}（{hexCode}）→ MV_E_NOT_FOUND：未找到";
                case -9: return $"十进制：{errorCode}（{hexCode}）→ MV_E_UNKNOWN：未知错误";

                // 补充你遇到的权限拒绝错误（十六进制0x80000203，对应十进制-2147483133）
                case -2147483133: return $"十进制：{errorCode}（{hexCode}）→ MV_E_ACCESS_DENIED：设备访问权限拒绝（被占用/权限不足）";

                // 其他常见十六进制错误码（补充）
                case -2147483134: return $"十进制：{errorCode}（{hexCode}）→ MV_E_DEVICE_OPENED：设备已被打开";
                case -2147483132: return $"十进制：{errorCode}（{hexCode}）→ MV_E_DEVICE_CLOSED：设备已被关闭";
                case -2147483131: return $"十进制：{errorCode}（{hexCode}）→ MV_E_BUFFER_TOO_SMALL：缓存区过小";

                // 默认情况：显示十进制+十六进制，提示参考文档
                default: return $"未知错误码 → 十进制：{errorCode}，十六进制：{hexCode}（参考海康SDK文档/MvErrorDefine.h）";
            }
        }
        // <summary> 打开相机（默认连续模式） </summary>
        public void Open(string name)
        {

            //关闭现有
            if (IsOpen())
                Close();


            //查找相机
            int findId = -1;
            var camList = DeviceListAcq();
            for (int i = 0; i < camList.Count; i++)
            {
                if (name == camList[i])
                {
                    findId = i;
                    break;
                }
            }

            //未找到
            if (findId < 0)
            {
                throw new Exception(string.Format("Camera [{0}] lose.", name));
            }



            //获取选择的设备信息
            MyCamera.MV_CC_DEVICE_INFO device =
                (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[findId],
                                                              typeof(MyCamera.MV_CC_DEVICE_INFO));
            _camera = new MyCamera();
            int nRet = 0;

            _camera = new MyCamera();
            nRet = _camera.MV_CC_CreateDevice_NET(ref device);

            if (MyCamera.MV_OK != nRet)
            {

                return;
            }


            // ch:打开设备 | en:Open device
            nRet = _camera.MV_CC_OpenDevice_NET();
            if (MyCamera.MV_OK != nRet)
            {
               // MessageBox.Show("Open Device Fail");
                UIMessageBox.ShowError($"打开设备失败！错误码：{nRet}\n{GetErrorMsg(nRet)}");

                // 创建设备成功后，打开失败需要销毁设备句柄
                _camera.MV_CC_DestroyDevice_NET();
                return;
            }

            _camera.MV_CC_SetHeartBeatTimeout_NET(1000);//设置心跳帧（异常断电时，可连接相机）
            //设置采集连续模式
            _camera.MV_CC_SetEnumValue_NET("AcquisitionMode", 2);// 工作在连续模式
            _camera.MV_CC_SetEnumValue_NET("TriggerMode", 0);    // 连续模式

            //注册回调函数
            _camera.MV_CC_RegisterImageCallBack_NET(_imageCallback, IntPtr.Zero);
            _camera.MV_CC_RegisterExceptionCallBack_NET(_exceptionCallBack, IntPtr.Zero);

            //开始取图
            if (0 != _camera.MV_CC_StartGrabbing_NET())
            {
                throw new Exception(string.Format("Camera [{0}] start grabbing failure.", name));
            }

            //
            var cameraInfo = getCameraInfo(device);
            Name = cameraInfo.Name;
            Sn = cameraInfo.Sn;
            Model = cameraInfo.Model;

            Frame = 0;
            Fps = 0;
            _fps_watch.Start();
            _isLose = false;
            _isOpen = true;
        }


        /// <summary>设置触发模式（1：连续（软触发），2：软触发，3：硬件触发）</summary>
        public void SetTriggerMode(int isAuto)
        {
            if (isAuto == 1 || isAuto == 2 || isAuto == 3)
            {
                TriMode = isAuto;

                if (TriMode == 1)
                {
                    _camera.MV_CC_SetEnumValue_NET("AcquisitionMode", 2);// 
                    _camera.MV_CC_SetEnumValue_NET("TriggerMode", 0);    // 连续模式(软触发)
                }
                else if (TriMode == 2)
                {
                    _camera.MV_CC_SetEnumValue_NET("AcquisitionMode", 2);// 
                    _camera.MV_CC_SetEnumValue_NET("TriggerMode", 1);    // 设置采集模式：触发模式
                    _camera.MV_CC_SetEnumValue_NET("TriggerSource", 7);  //设置软触发模式：软触发
                }
                else if (TriMode == 3)
                {
                    _camera.MV_CC_SetEnumValue_NET("AcquisitionMode", 2);// 
                    _camera.MV_CC_SetEnumValue_NET("TriggerMode", 1);    // 设置采集模式：触发模式
                    _camera.MV_CC_SetEnumValue_NET("TriggerSource", 0);  //设置软触发模式：硬件触发
                }
            }
        }
        Cognex.VisionPro.CogImage8Grey i1 = null;
        Cognex.VisionPro.CogImage8Grey i2 = null;
        void imageCallbackFun(IntPtr srcData, ref MyCamera.MV_FRAME_OUT_INFO pFrameInfo, IntPtr pUser)
        {

            //
            int w = pFrameInfo.nWidth;
            int h = pFrameInfo.nHeight;
            ImageWidth = w;
            ImageHeight = h;

            //
            try
            {

                //
                Frame++;
                _fps_watch.Stop();
                double time = _fps_watch.ElapsedMilliseconds;
                Fps = (time != 0 ? 1000 / time : 0);
                _fps_watch.Restart();

                //
                {
                    if (i1 == null)
                    {
                        i1 = new Cognex.VisionPro.CogImage8Grey(w, h);
                    }
                    var dstData = i1.Get8GreyPixelMemory(Cognex.VisionPro.CogImageDataModeConstants.Write, 0, 0, w, h);
                    for (int y = 0; y < h; y++)
                    {
                        CopyMemory(dstData.Scan0 + y * dstData.Stride, srcData + y * w, w);
                    }
                    Bitmap bimg = i1.ToBitmap();
                    bimg.RotateFlip(_rotateFlipType);
                    _cog_image = new Cognex.VisionPro.CogImage8Grey(bimg);
                    bimg.Dispose();

                }

                if (_waitNewImage)
                {
                    if (i2 == null)
                    {
                        i2 = new Cognex.VisionPro.CogImage8Grey(w, h);
                    }
                    var dstData = i2.Get8GreyPixelMemory(Cognex.VisionPro.CogImageDataModeConstants.Write, 0, 0, w, h);
                    for (int y = 0; y < h; y++)
                    {
                        CopyMemory(dstData.Scan0 + y * dstData.Stride, srcData + y * w, w);
                    }
                    Bitmap bimg = i2.ToBitmap();
                    bimg.RotateFlip(_rotateFlipType);
                    _cog_image_new = new Cognex.VisionPro.CogImage8Grey(bimg);
                    bimg.Dispose();
                    _waitNewImage = false;
                }

                OnNewImage?.Invoke(_cog_image);
            }
            catch
            {

            }

        }
        Cognex.VisionPro.CogImage8Grey _cog_image;
        Cognex.VisionPro.CogImage8Grey _cog_image_new;
        volatile bool _waitNewImage = false;

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern void CopyMemory(IntPtr dst, IntPtr src, int count);

        void exceptionCallBackFun(uint nMsgType, IntPtr pUser) {
            try {
                _isLose = true;
                _camera.MV_CC_CloseDevice_NET();
                OnCameraLose?.Invoke();
            }
            catch {

            }
        }

        void M_camera_ConnectionLost(object sender, EventArgs e) {
            try {
                _isLose = true;             
                _camera.MV_CC_CloseDevice_NET();
                OnCameraLose?.Invoke();
            }
            catch {

            }
        }
        void M_camera_CameraClosed(object sender, EventArgs e) {
            try {
                OnCameraClose?.Invoke();
            }
            catch {

            }
        }
        void M_camera_CameraOpened(object sender, EventArgs e) {
            try {
                OnCameraOpen?.Invoke();
            }
            catch {

            }
        }

        public Cognex.VisionPro.CogImage8Grey GetNewImage(double timeout = 10) {
            _waitNewImage = true;
            var time0 = System.DateTime.Now;
            while (true) {

                //休眠
                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(10);

                //有图像
                if (!_waitNewImage)
                    break;

                //超时
                var time1 = System.DateTime.Now;
                if ((time1 - time0).TotalSeconds > timeout)
                    break;
            }

            if (!_waitNewImage) {
                return _cog_image_new;
            }

            return null;
        }

        /// <summary> 关闭相机 </summary>
        public void Close() {

            if (IsOpen()) {

                try {
                    try{
                        _camera.MV_CC_StopGrabbing_NET();
                        _camera.MV_CC_CloseDevice_NET();
                      //  m_camera.MV_CC_DestroyDevice_NET();
                    }
                    catch { }
                    //
                    Name = "";
                    Sn = "";
                    Frame = 0;
                    Fps = 0;

                    _isOpen = false;
                }
                catch { }
            }
        }

        /// <summary> 相机是否打开 </summary>
        public bool IsOpen() {
            return _isOpen&&!_isLose;
        }

        /// <summary> 相机是否掉线 </summary>
        public bool IsLose() {
            return _isLose;
        }
        bool _isLose = false;
        bool _isOpen = false;

        /// <summary> 软触发获取图片 </summary>
        public Cognex.VisionPro.CogImage8Grey GetNewImage_SoftTrigger(double timeout = 10)
        {
            if (TriMode != 2) {
                return null;
            }
            _waitNewImage = true;
            if (MyCamera.MV_OK == _camera.MV_CC_SetCommandValue_NET("TriggerSoftware"))
            {
                var time0 = System.DateTime.Now;
                while (true)
                {

                    //休眠
                    System.Windows.Forms.Application.DoEvents();
                    System.Threading.Thread.Sleep(10);

                    //有图像
                    if (!_waitNewImage)
                        break;

                    //超时
                    var time1 = System.DateTime.Now;
                    if ((time1 - time0).TotalSeconds > timeout)
                        break;
                }

                if (!_waitNewImage)
                {
                    return _cog_image_new;
                }
            }
           

            return null;
        }

        #endregion

    }
}

