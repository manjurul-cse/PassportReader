////////////////////////////////////////////////////////////////////////////////
// Module       : ViewModel
//
// Description  : Partial class for interfacing to the videoOCR DLL
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
using System.Drawing ;
using System.Drawing.Drawing2D;
using System.Net;
using System.Runtime.InteropServices;
using System.IO;
using System.Text.RegularExpressions;

namespace VideoOCRDemo
{
    public partial class ViewModel
    {
        // Delegate definitions
        private delegate void updatePictureBox(Bitmap bitmap, int imageType);
        private delegate void MRZDelegate(ref UInt32 Parameter, ref DLL_MRZDATA Data);
        private delegate void ImageDelegate(ref UInt32 Parameter, int ImageType, IntPtr hBitmap);
        private delegate void BadDecodeDelegate(ref UInt32 Parameter, [MarshalAs(UnmanagedType.BStr)] String BadMRZ, UInt32 hBitmap);
        private delegate void updateMrzTextBox(string text);
        private delegate void updatetextBox1(String text);
        private delegate void UpdatePassportNoTextBox(string text);

        private delegate  void UpdateFirstNameTextBox(string text);
        private delegate void UpdateLastNameTextBox(string text);

        private delegate void DistrictComboBox(string text);



        private DLL_STATUS Status;
        private Frontend frontend;
        private MRZDelegate md;
        private ImageDelegate id;
        private string dstLoc = @"C:\PassportReaderV3.1\";

        public String sdocumentno, sfname, slname, snationality, sgender, sDOB, sexpiry, sissueer, stype, nationalIDNo,firstName,lastName,newPassportNo;
        public int state = 1;

        ////////////////////////////////////////////////////////////////////////
        // Function name   : ViewModel
        // Description     : Constructor
        //                 : 
        // Return type     : 
        // Argument        : Frontend - Form Class
        ////////////////////////////////////////////////////////////////////////
        public ViewModel( Frontend fe)
        {

            // Get Form class as we need to update when data arrives
            frontend = fe ;

            // create the delegates for the callback functions
             md = new MRZDelegate(MRZCallback);
             id = new ImageDelegate(ImageCallback);

             Status = new DLL_STATUS();
        }


        ////////////////////////////////////////////////////////////////////////
        // Function name   : initialiseReader
        // Description     : Intialise scanner for reading. 
        //					
        //                 : 
        // Return type     : void 
        // Argument        : 
        //////////////////////////////////////////////////////////////////////// 
        public void initialiseReader()
        {
            // Start up the reader
            // Set up capture of all illumination types and RFID
            Boolean Temp = voInitialiseReader(true, true, true, true, false);

            voEnableCropAndRotate(false);  //--------------
            voSetSounder(false);  //---------------

            UInt32 Val = 0;

            // register image and MRZ callback functions
            voRegisterMrzCallback(md, ref Val);
            voRegisterImageCallback(id, ref Val);
      
        }

        ////////////////////////////////////////////////////////////////////////
        // Function name   : reInitialiseReader
        // Description     : Re - intialise scanner for reading. 
        //					
        //                 : 
        // Return type     : void 
        // Argument        : 
        //////////////////////////////////////////////////////////////////////// 
        public void reInitialiseReader()
        {
            // Terminates all the process threads and goes into an ide state
            voTerminate();

            // Set up capture of all illumination types and RFID
            voInitialiseReader(true, true, true, true, false);  // false prev

            voEnableCropAndRotate(false);  ///--------------
            voSetSounder(false);  //---------------

            UInt32 Val = 0;

            // register image and MRZ callback functions
            voRegisterMrzCallback(md, ref Val);
            voRegisterImageCallback(id, ref Val);
        }

        ////////////////////////////////////////////////////////////////////////
        // Function name   : startReader
        // Description     : enables scanner for reading. 
        //					
        //                 : 
        // Return type     : void 
        // Argument        : 
        //////////////////////////////////////////////////////////////////////// 
        public void startReader()
        {
            // Start the capture system of the scanner
//            Boolean crstat = voEnableCropAndRotate(Boolean crstatus);
            Boolean status = voStartRead();
        }

        ////////////////////////////////////////////////////////////////////////
        // Function name   : getIRImage
        // Description     : Grabs a IR image.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : 
        //////////////////////////////////////////////////////////////////////// 
        public void getIRImage()
        {
            // Takes a colour image of whats on scanner plate
            voGetImage(0, true);
        }

        ////////////////////////////////////////////////////////////////////////
        // Function name   : getColourImage
        // Description     : Grabs a colour image.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : 
        //////////////////////////////////////////////////////////////////////// 
        public void getColourImage()
        {
            // Takes a colour image of whats on scanner plate
            voGetImage(1, true); //true
            //System.IO.File.Copy("d:/OCR640. SDKandGuides/Images/Colour  .bmp", "d:/b/Colour  .bmp");
        }

        ////////////////////////////////////////////////////////////////////////
        // Function name   : getUVImage
        // Description     : Grabs a UV image.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : 
        //////////////////////////////////////////////////////////////////////// 
        public void getUVImage()
        {
            // Takes a colour image of whats on scanner plate
            voGetImage(2, true);
        }
        ////////////////////////////////////////////////////////////////////////
        // Function name   : getScannerStatus
        // Description     : Gets status of the scanner.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : 
        //////////////////////////////////////////////////////////////////////// 
        public Boolean getScannerStatus()
        {
            // Get current status of the system
            Boolean returnValue = voQueryReaderState(ref Status) ;
            return (returnValue) ;
        }


        ////////////////////////////////////////////////////////////////////////
        // Function name   : updateTextBox
        // Description     : Ths functions is run in the same thread as the UI.
        //                   Allows us to update the Text box from the callback function.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : string         - the MRZ from the scanner 
        //////////////////////////////////////////////////////////////////////// 
        private void updateTextBox(string text)
        {
            frontend.textBoxMRZ.Text = text;
        }

        private void updateTextBoxPassportNo(string text)
        {
            frontend.passportNoTextBox.Text = text;
        }
        private void updateTextBoxFirstName(string text)
        {
            frontend.firstNameTextBox.Text = text;
        }
        private void updateTextBoxLastName(string text)
        {
            frontend.lastNameTextBox.Text = text;
        }

        ////////////////////////////////////////////////////////////////////////
        // Function name   : updatePicture
        // Description     : Ths functions is run in the same thread as the UI.
        //                   Allows us to update the image box from the callback function.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : Bitmap         - bitmap from the scanner
        //                 : int            - illumination type of image 
        //////////////////////////////////////////////////////////////////////// 
        private void updatePicture(Bitmap bitmap, int imageType)
        {
            switch (imageType)
            {
                case 0:

                    frontend.pictureBoxGrey.Image = bitmap;
                    break;

                case 1:

                    frontend.pictureBoxColour.Image = bitmap;
                    break;

                case 2:

                    frontend.pictureBoxUV.Image = bitmap;
                    break;

                case 3:
                    frontend.pictureBoxRFID.Image = bitmap;
                    break;
            }
        }


//////////////////////////////////////////////////////////////////////////////////
//
//                  Define callback functions
//                    
//////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////
        // Function name   : MRZCallback
        // Description     : This functions is registered as a callback. It is run by the
        //                   videoOCR dll when MRZ data is available.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : ref UInt32     - paramter registered by user.
        //                 : DLL_MRZDATA    - MRZ data from the DLL
        //////////////////////////////////////////////////////////////////////// 
        private void MRZCallback(ref UInt32 Parameter, ref DLL_MRZDATA Data)
        {
            // Make sure the text box update is running in the same thread as the form ;
           frontend.textBoxMRZ.Invoke(new updateMrzTextBox(updateTextBox), Data.RawMRZ);
           // sdocumentno = "A11111111";
            sdocumentno = Data.DocumentNumber.Trim();
            sfname = Data.FirstNames.Trim();         
            slname = Data.LastNames.Trim();          
            snationality = Data.Nationality.Trim();  
            sgender = Data.Gender.Trim();            
            sDOB = Data.DOB.Trim();                  
            sexpiry = Data.Expiry.Trim();            
            sissueer = Data.Issuer.Trim();           
            stype = Data.Type.Trim();
            nationalIDNo = Data.Discretionary1.Trim();
            if (Data.RawMRZ!=string.Empty)
            {
                frontend.passportNoTextBox.Invoke(new UpdatePassportNoTextBox(updateTextBoxPassportNo), Data.DocumentNumber);
                frontend.firstNameTextBox.Invoke(new UpdateFirstNameTextBox(updateTextBoxFirstName), Data.FirstNames);
                frontend.lastNameTextBox.Invoke(new UpdateLastNameTextBox(updateTextBoxLastName), Data.LastNames);
                

                string fullname = sfname + slname;
                if (Regex.IsMatch(fullname, @"^[a-xA-Z ]*$"))
                {
                    firstName = sfname;
                    lastName = slname;

                }
                else
                {
                    frontend.firstNameTextBox.BackColor = Color.Red;
                    frontend.lastNameTextBox.BackColor = Color.Red;
                    firstName = string.Empty;
                    lastName = string.Empty;

                }
                if (sdocumentno!=string.Empty)
                {
                    string ppSubFirst = sdocumentno.Substring(0, 2);
                    string ppSubLast = sdocumentno.Substring(2, (sdocumentno.Length - 2));
                    if (Regex.IsMatch(ppSubFirst, @"^[A-Z]*$") && Regex.IsMatch(ppSubLast, @"^[0-9]*$"))
                    {
                        newPassportNo = sdocumentno;
                        string folder = @"Storage\";
                //            Directory.CreateDirectory(dstLoc + folder);
                System.IO.File.WriteAllText(dstLoc + folder + @"Data.csv", newPassportNo + "," + firstName + "," + lastName + "," + snationality + "," + sgender + "," + sDOB + "," + sexpiry + "," + sissueer + "," + stype + "," + nationalIDNo + "\r\n");

                    }
                    else
                    {
                        frontend.passportNoTextBox.BackColor = Color.Red;
                        newPassportNo = string.Empty;
                    }
                }
                

                
            }
                
            }
            
//            frontend.textBox1.Invoke(new updatetextBox1(updateTextBox), Data.DocumentNumber);
        
        ////////////////////////////////////////////////////////////////////////
        // Function name   : 

        // Description     : Ths functions is registered as a callback. It is run by the
        //                   videoOCR dll when image data is available.
        //					
        //                 : 
        // Return type     : void 
        // Argument        : ref UInt32     - paramter registered by user.
        //                 : int            - illumination type of image data.
        //                 : IntPtr         - Handle to image data.
        //////////////////////////////////////////////////////////////////////// 
        private void ImageCallback(ref UInt32 Parameter, int ImageType, IntPtr Handle)
        {
            Bitmap bitmap;
            //String dstLoc = System.Environment.CurrentDirectory+@"\";

            // depending on the image type - store and display the new image
   //         while (state < 3)
   //         {
                switch (ImageType)
                {
                        
                    case 0:
                        bitmap = System.Drawing.Image.FromHbitmap(Handle);
                        Bitmap bitmap2 = (Bitmap)System.Drawing.Image.FromHbitmap(Handle).Clone();

                        frontend.pictureBoxGrey.Invoke(new updatePictureBox(updatePicture), new Object[] { bitmap, ImageType });
                        bitmap2 = (Bitmap)System.Drawing.Image.FromHbitmap(Handle).Clone();
                       // bitmap2 = ReSizeImage(bitmap2, 600, 480);
                        String folder = @"Storage\";
                        if (Frontend.pn == 1)
                        {
                            bitmap2.Save(dstLoc + folder + @"2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                            
                        }
                        else
                        {
                            //bitmap2.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            bitmap2.Save(dstLoc + folder + @"5.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        break;

                    case 1:
                        bitmap = (Bitmap)System.Drawing.Image.FromHbitmap(Handle).Clone();
                        frontend.pictureBoxColour.Invoke(new updatePictureBox(updatePicture), new Object[] { bitmap, ImageType });
                        bitmap2 = (Bitmap)System.Drawing.Image.FromHbitmap(Handle).Clone();
                        //bitmap2 = ReSizeImage(bitmap2, 600, 480);
                        folder = @"Storage\";
                        if (Frontend.pn == 1)
                        {
                            bitmap2.Save(dstLoc + folder + @"1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                            //GetStampImage();

                        }
                        else
                        {
                           // bitmap2.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            bitmap2.Save(dstLoc + folder + @"4.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }

                        break;

                    case 2:
                        bitmap = System.Drawing.Image.FromHbitmap(Handle);
                        frontend.pictureBoxUV.Invoke(new updatePictureBox(updatePicture), new Object[] { bitmap, ImageType });
                        bitmap2 = (Bitmap)System.Drawing.Image.FromHbitmap(Handle).Clone();
                        //bitmap2 = ReSizeImage(bitmap2, 600, 480);
                        folder = @"Storage\";
                        if (Frontend.pn == 1)
                        {
                            bitmap2.Save(dstLoc + folder + @"3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        else
                        {
                            //bitmap2.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            bitmap2.Save(dstLoc + folder + @"6.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                        }
                        break;

                    case 3:
                        bitmap = System.Drawing.Image.FromHbitmap(Handle);
                        frontend.pictureBoxRFID.Invoke(new updatePictureBox(updatePicture), new Object[] { bitmap, ImageType });
      //                  state = 2;

                        break;
                }
     //       }
        }

        private void GetStampImage()
        {
            Image img = new Bitmap(@"C:\PassportReaderV3.1\Storage\1.jpg");
            Image image = cropImage(img, new Rectangle(15, 65, 170, 210));
            Image brightImage = AdjustBrightness(image, 80);
            Image contrastImage = ContrastImage(brightImage, 20);
            
            contrastImage.Save(@"C:\PassportReaderV3.1\Storage\7.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            img.Dispose();
        }

        private Image cropImage(Image img, Rectangle rectangle)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(rectangle, bmpImage.PixelFormat);
            img.Dispose();
            return (Image)(bmpCrop);
        }

        private Image ContrastImage(Image brightImage, double contrast)
        {

            Bitmap temp = (Bitmap)brightImage;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (contrast < -100) contrast = -100;
            if (contrast > 100) contrast = 100;
            contrast = (100.0 + contrast) / 100.0;
            contrast *= contrast;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    double pR = c.R / 255.0;
                    pR -= 0.5;
                    pR *= contrast;
                    pR += 0.5;
                    pR *= 255;
                    if (pR < 0) pR = 0;
                    if (pR > 255) pR = 255;

                    double pG = c.G / 255.0;
                    pG -= 0.5;
                    pG *= contrast;
                    pG += 0.5;
                    pG *= 255;
                    if (pG < 0) pG = 0;
                    if (pG > 255) pG = 255;

                    double pB = c.B / 255.0;
                    pB -= 0.5;
                    pB *= contrast;
                    pB += 0.5;
                    pB *= 255;
                    if (pB < 0) pB = 0;
                    if (pB > 255) pB = 255;

                    bmap.SetPixel(i, j,
        Color.FromArgb((byte)pR, (byte)pG, (byte)pB));
                }
            }
            brightImage.Dispose();
            return (Bitmap)bmap.Clone();
        }

        private Image AdjustBrightness(Image image1, int brightness)
        {

            Bitmap temp = (Bitmap)image1;
            Bitmap bmap = (Bitmap)temp.Clone();
            if (brightness < -255) brightness = -255;
            if (brightness > 255) brightness = 255;
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    int cR = c.R + brightness;
                    int cG = c.G + brightness;
                    int cB = c.B + brightness;

                    if (cR < 0) cR = 1;
                    if (cR > 255) cR = 255;

                    if (cG < 0) cG = 1;
                    if (cG > 255) cG = 255;

                    if (cB < 0) cB = 1;
                    if (cB > 255) cB = 255;

                    bmap.SetPixel(i, j,
        Color.FromArgb((byte)cR, (byte)cG, (byte)cB));
                }
            }
            image1.Dispose();
            return (Bitmap)bmap.Clone();
        }

        private Bitmap ReSizeImage(Bitmap contrastImage, int newWidth, int newHeight)
        {
            if (newWidth != 0 && newHeight != 0)
            {
                

                   Bitmap b = new Bitmap(newWidth, newHeight);
                   Graphics g = Graphics.FromImage((Image)b);
                   g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                   g.DrawImage(contrastImage, 0, 0, newWidth, newHeight);
                   g.Dispose();
                   contrastImage.Dispose();

                   return (Bitmap)b;
                }
            else
            {
                return contrastImage;
            }

        }

//////////////////////////////////////////////////////////////////////////////////
//
//                  Define Class Getters and Setters
//                    
//////////////////////////////////////////////////////////////////////////////////
        public Boolean RFIDPresent      { get { return (Status.RFIDPresent); } }
        public Boolean RFIDecoded       { get { return (Status.RFIDDecoded); } }
        public Boolean busy             { get { return (Status.Busy); } }
        public Boolean passportPresent  { get { return (Status.PassportPresent); } }
        public Boolean documentPresent  { get { return (Status.DocumentPresent); } }

        public Boolean MRZDecoded
        {
            get { return (Status.MRZDecoded); }
            
        }
    }

}
