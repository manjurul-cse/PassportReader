////////////////////////////////////////////////////////////////////////////////
// Module       : ViewModel
//
// Description  : Partial class for defining the videoOCR DLL function signatures
//                and data.
//				  
//
// Version      : 1.0
//
////////////////////////////////////////////////////////////////////////////////
//
// Revision History 
//
// Version    Date      Author      Description
//
//   1.0    19/07/12    G Coutts     Created.
//
////////////////////////////////////////////////////////////////////////////////
using System;
using System.Runtime.InteropServices;

namespace VideoOCRDemo
{
    public partial class ViewModel
    {


        // Location of the DLL required
        const String DLL_LOCATION = "videoocr.dll";

        // structure required for MRZ data
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DLL_MRZDATA
        {
            [MarshalAs(UnmanagedType.BStr)]
            public String RawMRZ;
            [MarshalAs(UnmanagedType.BStr)]
            public String DocumentNumber;
            [MarshalAs(UnmanagedType.BStr)]
            public String DOB;
            [MarshalAs(UnmanagedType.BStr)]
            public String Expiry;
            [MarshalAs(UnmanagedType.BStr)]
            public String Issuer;
            [MarshalAs(UnmanagedType.BStr)]
            public String Nationality;
            [MarshalAs(UnmanagedType.BStr)]
            public String LastNames;
            [MarshalAs(UnmanagedType.BStr)]
            public String FirstNames;
            [MarshalAs(UnmanagedType.BStr)]
            public String Type;
            [MarshalAs(UnmanagedType.BStr)]
            public String Discretionary1;
            [MarshalAs(UnmanagedType.BStr)]
            public String Discretionary2;
            [MarshalAs(UnmanagedType.BStr)]
            public String Gender; // added 130810

        }

        // structure required for scanner status updates
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct DLL_STATUS
        {
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean CameraPresent;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean PassportPresent;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean RFIDPresent;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean Active;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean Busy;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean MRZDecoded;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean RFIDDecoded;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean UVEnabled;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean RFIDEnabled;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean ColourEnabled;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean AutoStopEnabled;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean InfraredEnabled;
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean BadDecode; // added 110810
            [MarshalAs(UnmanagedType.Bool)]
            public Boolean DocumentPresent; // added 110810

            [MarshalAs(UnmanagedType.Bool)]
            public Boolean crstatus; // -----
        }

        // DLL function signatures 
        [DllImport(DLL_LOCATION)]
        private static extern Boolean voInitialiseReader(Boolean InfraRed, Boolean Colour, Boolean UV, Boolean RFID, Boolean AutoStop);
        [DllImport(DLL_LOCATION)]
        private static extern Boolean voStartRead();
        [DllImport(DLL_LOCATION)]
        private static extern Boolean voStopRead();
        [DllImport(DLL_LOCATION)]
        private static extern Boolean voQueryReaderState(ref DLL_STATUS Status);
        [DllImport(DLL_LOCATION)]
        private static extern Boolean voRegisterMrzCallback(MRZDelegate Callback, [MarshalAs(UnmanagedType.U4)] ref UInt32 Parameter);
        [DllImport(DLL_LOCATION)]
        private static extern Boolean voRegisterImageCallback(ImageDelegate Callback, ref UInt32 Parameter);

        [DllImport(DLL_LOCATION)]
        private static extern Boolean voTerminate();
        [DllImport(DLL_LOCATION)]
        private static extern Boolean voGetImage(int ImageType, Boolean FullSize);

        [DllImport(DLL_LOCATION)]  //--------------
        private static extern Boolean voEnableCropAndRotate(Boolean crstate);

        [DllImport(DLL_LOCATION)]  //--------------
        private static extern Boolean voSetSounder(Boolean on);

        
        //        [DllImport(DLL_LOCATION)]  //--------------
//        private static extern Boolean voRegisterImageFormats(int imageFormats); 



    }
}
