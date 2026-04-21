#pragma warning disable 0618
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MvCamCtrl.NET;
using System.Runtime.InteropServices;


namespace DeviceSource {
    using ImageCallBack = MyCamera.cbOutputdelegate;
    using ExceptionCallBack = MyCamera.cbExceptiondelegate;
    using System.Net;

    public class CameraOperator {
        public const int CO_FAIL = -1;
        public const int CO_OK = 0;
        public MyCamera m_pCSI;
        
        public CameraOperator() {
            m_pCSI = new MyCamera();
        }

        /****************************************************************************
         * @fn           EnumDevices
         * @brief        枚举可连接设备
         * @param        nLayerType       IN         传输层协议：1-GigE; 4-USB;可叠加
         * @param        stDeviceList     OUT        设备列表
         * @return       成功：0；错误：错误码
         ****************************************************************************/
        public static int EnumDevices(uint nLayerType, ref MyCamera.MV_CC_DEVICE_INFO_LIST stDeviceList) {
            return MyCamera.MV_CC_EnumDevices_NET(nLayerType, ref stDeviceList);
        }


        /****************************************************************************
         * @fn           Open
         * @brief        连接设备
         * @param        stDeviceInfo       IN       设备信息结构体
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int Open(ref MyCamera.MV_CC_DEVICE_INFO stDeviceInfo) {
            if (null == m_pCSI) {
                m_pCSI = new MyCamera();
                if (null == m_pCSI) {
                    return CO_FAIL;
                }
            }

            int nRet;
            nRet = m_pCSI.MV_CC_CreateDeviceWithoutLog_NET(ref stDeviceInfo);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }

            nRet = m_pCSI.MV_CC_OpenDevice_NET();
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           Close
         * @brief        关闭设备
         * @param        none
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int Close() {
            int nRet;

            nRet = m_pCSI.MV_CC_CloseDevice_NET();
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }

            nRet = m_pCSI.MV_CC_DestroyDevice_NET();
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           StartGrabbing
         * @brief        开始采集
         * @param        none
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int StartGrabbing() {
            int nRet;
            //开始采集
            nRet = m_pCSI.MV_CC_StartGrabbing_NET();
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }



        /****************************************************************************
         * @fn           StopGrabbing
         * @brief        停止采集
         * @param        none
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int StopGrabbing() {
            int nRet;
            nRet = m_pCSI.MV_CC_StopGrabbing_NET();
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           RegisterImageCallBack
         * @brief        注册取流回调函数
         * @param        CallBackFunc          IN        回调函数
         * @param        pUser                 IN        用户参数
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int RegisterImageCallBack(ImageCallBack CallBackFunc, IntPtr pUser) {
            int nRet;
            nRet = m_pCSI.MV_CC_RegisterImageCallBack_NET(CallBackFunc, pUser);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           RegisterExceptionCallBack
         * @brief        注册异常回调函数
         * @param        CallBackFunc          IN        回调函数
         * @param        pUser                 IN        用户参数
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int RegisterExceptionCallBack(ExceptionCallBack CallBackFunc, IntPtr pUser) {
            int nRet;
            nRet = m_pCSI.MV_CC_RegisterExceptionCallBack_NET(CallBackFunc, pUser);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           GetOneFrame
         * @brief        获取一帧图像数据
         * @param        pData                 IN-OUT            数据数组指针
         * @param        pnDataLen             IN                数据大小
         * @param        nDataSize             IN                数组缓存大小
         * @param        pFrameInfo            OUT               数据信息
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int GetOneFrame(IntPtr pData, ref UInt32 pnDataLen, UInt32 nDataSize, ref MyCamera.MV_FRAME_OUT_INFO pFrameInfo) {
            pnDataLen = 0;
            int nRet = m_pCSI.MV_CC_GetOneFrame_NET(pData, nDataSize, ref pFrameInfo);
            pnDataLen = pFrameInfo.nFrameLen;
            if (MyCamera.MV_OK != nRet) {
                return nRet;
            }

            return nRet;
        }

        public int GetOneFrameTimeout(IntPtr pData, ref UInt32 pnDataLen, UInt32 nDataSize, ref MyCamera.MV_FRAME_OUT_INFO_EX pFrameInfo, Int32 nMsec) {
            pnDataLen = 0;
            int nRet = m_pCSI.MV_CC_GetOneFrameTimeout_NET(pData, nDataSize, ref pFrameInfo, nMsec);
            pnDataLen = pFrameInfo.nFrameLen;
            if (MyCamera.MV_OK != nRet) {
                return nRet;
            }

            return nRet;
        }


        /****************************************************************************
         * @fn           Display
         * @brief        显示图像
         * @param        hWnd                  IN        窗口句柄
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int Display(IntPtr hWnd) {
            int nRet;
            nRet = m_pCSI.MV_CC_Display_NET(hWnd);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           GetIntValue
         * @brief        获取Int型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        pnValue               OUT       返回值
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int GetIntValue(string strKey, ref UInt32 pnValue) {

            MyCamera.MVCC_INTVALUE stParam = new MyCamera.MVCC_INTVALUE();
            int nRet = m_pCSI.MV_CC_GetIntValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }

            pnValue = stParam.nCurValue;

            return CO_OK;
        }


        /****************************************************************************
         * @fn           SetIntValue
         * @brief        设置Int型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        nValue                IN        设置参数值，具体取值范围参考HikCameraNode.xls文档
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int SetIntValue(string strKey, UInt32 nValue) {

            int nRet = m_pCSI.MV_CC_SetIntValue_NET(strKey, nValue);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }



        /****************************************************************************
         * @fn           GetFloatValue
         * @brief        获取Float型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        pValue                OUT       返回值
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int GetFloatValue(string strKey, ref float pfValue) {
            MyCamera.MVCC_FLOATVALUE stParam = new MyCamera.MVCC_FLOATVALUE();
            int nRet = m_pCSI.MV_CC_GetFloatValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }

            pfValue = stParam.fCurValue;

            return CO_OK;
        }


        /****************************************************************************
         * @fn           SetFloatValue
         * @brief        设置Float型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        fValue                IN        设置参数值，具体取值范围参考HikCameraNode.xls文档
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int SetFloatValue(string strKey, float fValue) {
            int nRet = m_pCSI.MV_CC_SetFloatValue_NET(strKey, fValue);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           GetEnumValue
         * @brief        获取Enum型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        pnValue               OUT       返回值
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int GetEnumValue(string strKey, ref UInt32 pnValue) {
            MyCamera.MVCC_ENUMVALUE stParam = new MyCamera.MVCC_ENUMVALUE();
            int nRet = m_pCSI.MV_CC_GetEnumValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }

            pnValue = stParam.nCurValue;

            return CO_OK;
        }



        /****************************************************************************
         * @fn           SetEnumValue
         * @brief        设置Float型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        nValue                IN        设置参数值，具体取值范围参考HikCameraNode.xls文档
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int SetEnumValue(string strKey, UInt32 nValue) {
            int nRet = m_pCSI.MV_CC_SetEnumValue_NET(strKey, nValue);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }



        /****************************************************************************
         * @fn           GetBoolValue
         * @brief        获取Bool型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        pbValue               OUT       返回值
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int GetBoolValue(string strKey, ref bool pbValue) {
            int nRet = m_pCSI.MV_CC_GetBoolValue_NET(strKey, ref pbValue);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }

            return CO_OK;
        }

        /****************************************************************************
        * @fn           SetHeartBeatValue（心跳帧）
        * @brief        设置uint型参数值    
        * @param        nValue                IN        设置参数值，超时时间参数
        * @return       成功：0；错误：-1
        ****************************************************************************/
        public int SetHeartBeatValue(uint nValue=500)
        {
            int nRet = m_pCSI.MV_CC_SetHeartBeatTimeout_NET(nValue);
            if (MyCamera.MV_OK != nRet)
            {
                return CO_FAIL;
            }
            return CO_OK;
        }

        /****************************************************************************
         * @fn           SetBoolValue
         * @brief        设置Bool型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        bValue                IN        设置参数值，具体取值范围参考HikCameraNode.xls文档
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int SetBoolValue(string strKey, bool bValue) {
            int nRet = m_pCSI.MV_CC_SetBoolValue_NET(strKey, bValue);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           GetStringValue
         * @brief        获取String型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        strValue              OUT       返回值
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int GetStringValue(string strKey, ref string strValue) {
            MyCamera.MVCC_STRINGVALUE stParam = new MyCamera.MVCC_STRINGVALUE();
            int nRet = m_pCSI.MV_CC_GetStringValue_NET(strKey, ref stParam);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }

            strValue = stParam.chCurValue;

            return CO_OK;
        }


        /****************************************************************************
         * @fn           SetStringValue
         * @brief        设置String型参数值
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @param        strValue              IN        设置参数值，具体取值范围参考HikCameraNode.xls文档
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int SetStringValue(string strKey, string strValue) {
            int nRet = m_pCSI.MV_CC_SetStringValue_NET(strKey, strValue);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           CommandExecute
         * @brief        Command命令
         * @param        strKey                IN        参数键值，具体键值名称参考HikCameraNode.xls文档
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int CommandExecute(string strKey) {
            int nRet = m_pCSI.MV_CC_SetCommandValue_NET(strKey);
            if (MyCamera.MV_OK != nRet) {
                return CO_FAIL;
            }
            return CO_OK;
        }


        /****************************************************************************
         * @fn           SaveImage
         * @brief        保存图片
         * @param        pSaveParam            IN        保存图片配置参数结构体
         * @return       成功：0；错误：-1
         ****************************************************************************/
        public int SaveImage(ref MyCamera.MV_SAVE_IMAGE_PARAM_EX pSaveParam) {
            int nRet;
            nRet = m_pCSI.MV_CC_SaveImageEx_NET(ref pSaveParam);
            return nRet;
        }


        //By fra.
        public static MyCamera.MV_CC_DEVICE_INFO_LIST m_pDeviceList = new MyCamera.MV_CC_DEVICE_INFO_LIST();
        public static List<MyCamera.MV_GIGE_DEVICE_INFO> m_pGigeInfoList = new List<MyCamera.MV_GIGE_DEVICE_INFO>();
        public static List<string> EnumerateDevices() {

            int nRet;
            /*创建设备列表*/
            System.GC.Collect();
            List<string> deviceList = new List<string>();
            m_pGigeInfoList.Clear();
            nRet = CameraOperator.EnumDevices(MyCamera.MV_GIGE_DEVICE, ref m_pDeviceList);
            if (0 == nRet) {

                //在窗体列表中显示设备名
                for (int i = 0; i < m_pDeviceList.nDeviceNum; i++) {
                    MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[i], typeof(MyCamera.MV_CC_DEVICE_INFO));

                    IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
                    MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));
                    if (gigeInfo.chUserDefinedName != "") {
                        deviceList.Add(gigeInfo.chUserDefinedName);
                    }
                    else {
                        deviceList.Add(gigeInfo.chManufacturerName + " " + gigeInfo.chModelName + " (" + gigeInfo.chSerialNumber + ")");
                    }
                    m_pGigeInfoList.Add(gigeInfo);
                }
            }

            return deviceList;
        }
        public static void GigeCameraNetInfo(int id, out string ipAddress, out string subnetMask, out string defaultGateway) {

            ipAddress = "";
            subnetMask = "";
            defaultGateway = "";

            if (m_pDeviceList.nDeviceNum == 0) {
                return;
            }
            MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[id], typeof(MyCamera.MV_CC_DEVICE_INFO));
            IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
            MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));

            UInt32 nNetIp1 = (gigeInfo.nNetExport & 0xFF000000) >> 24;
            UInt32 nNetIp2 = (gigeInfo.nNetExport & 0x00FF0000) >> 16;
            UInt32 nNetIp3 = (gigeInfo.nNetExport & 0x0000FF00) >> 8;
            UInt32 nNetIp4 = (gigeInfo.nNetExport & 0x000000FF);

            // 显示IP
            UInt32 nIp1 = (gigeInfo.nCurrentIp & 0xFF000000) >> 24;
            UInt32 nIp2 = (gigeInfo.nCurrentIp & 0x00FF0000) >> 16;
            UInt32 nIp3 = (gigeInfo.nCurrentIp & 0x0000FF00) >> 8;
            UInt32 nIp4 = (gigeInfo.nCurrentIp & 0x000000FF);

            ipAddress = nIp1.ToString() + "." + nIp2.ToString() + "." + nIp3.ToString() + "." + nIp4.ToString();

            // 显示掩码
            nIp1 = (gigeInfo.nCurrentSubNetMask & 0xFF000000) >> 24;
            nIp2 = (gigeInfo.nCurrentSubNetMask & 0x00FF0000) >> 16;
            nIp3 = (gigeInfo.nCurrentSubNetMask & 0x0000FF00) >> 8;
            nIp4 = (gigeInfo.nCurrentSubNetMask & 0x000000FF);

            subnetMask = nIp1.ToString() + "." + nIp2.ToString() + "." + nIp3.ToString() + "." + nIp4.ToString();

            // 显示网关
            nIp1 = (gigeInfo.nDefultGateWay & 0xFF000000) >> 24;
            nIp2 = (gigeInfo.nDefultGateWay & 0x00FF0000) >> 16;
            nIp3 = (gigeInfo.nDefultGateWay & 0x0000FF00) >> 8;
            nIp4 = (gigeInfo.nDefultGateWay & 0x000000FF);

            defaultGateway = nIp1.ToString() + "." + nIp2.ToString() + "." + nIp3.ToString() + "." + nIp4.ToString();
        }
        public static bool GigeForceIP(int id, string ipAddress, string subnetMask, string defaultGateway) {
            if (m_pDeviceList.nDeviceNum == 0) {
                return false;
            }
            MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[id], typeof(MyCamera.MV_CC_DEVICE_INFO));
            IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
            MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));

            // IP转换
            IPAddress clsIpAddr;
            if (false == IPAddress.TryParse(ipAddress, out clsIpAddr)) {
                return false;
            }
            long nIp = IPAddress.NetworkToHostOrder(clsIpAddr.Address);

            // 掩码转换
            IPAddress clsSubMask;
            if (false == IPAddress.TryParse(subnetMask, out clsSubMask)) {
                return false;
            }
            long nSubMask = IPAddress.NetworkToHostOrder(clsSubMask.Address);

            // 网关转换
            IPAddress clsDefaultWay;
            if (false == IPAddress.TryParse(defaultGateway, out clsDefaultWay)) {
                return false;
            }
            long nDefaultWay = IPAddress.NetworkToHostOrder(clsDefaultWay.Address);

            MyCamera cam = new MyCamera();
            if (0 != cam.MV_CC_CreateDeviceWithoutLog_NET(ref device)) {
                return false;
            }

            int nRet = cam.MV_GIGE_ForceIpEx_NET((UInt32)(nIp >> 32), (UInt32)(nSubMask >> 32), (UInt32)(nDefaultWay >> 32));
            cam.MV_CC_DestroyDevice_NET();
            if (CameraOperator.CO_OK != nRet) {
                return false;
            }

            return true;
        }

        public static CameraOperator GetDeviceByIndex(int id) {
            if (m_pDeviceList.nDeviceNum == 0) {
                return null;
            }
            MyCamera.MV_CC_DEVICE_INFO device = (MyCamera.MV_CC_DEVICE_INFO)Marshal.PtrToStructure(m_pDeviceList.pDeviceInfo[id], typeof(MyCamera.MV_CC_DEVICE_INFO));
            IntPtr buffer = Marshal.UnsafeAddrOfPinnedArrayElement(device.SpecialInfo.stGigEInfo, 0);
            MyCamera.MV_GIGE_DEVICE_INFO gigeInfo = (MyCamera.MV_GIGE_DEVICE_INFO)Marshal.PtrToStructure(buffer, typeof(MyCamera.MV_GIGE_DEVICE_INFO));

            CameraOperator cam = new CameraOperator();
            if (0 == cam.Open(ref device))
                return cam;
            return null;
        }

    }
}
