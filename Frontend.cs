////////////////////////////////////////////////////////////////////////////////
// Module       : Frontend
//
// Description  : Partial class for display data and status from the scanner
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

//using System;
//using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using VideoOCRDemo.BLL;

namespace VideoOCRDemo
{

    public partial class Frontend : Form
    {
        CheckPassport checkPassport=new CheckPassport();
        //------
        const String DLL_LOCATION = "videoocr.dll";

        [DllImport(DLL_LOCATION)]  //--------------
        private static extern Boolean voEnableCropAndRotate(Boolean crstate);

        public static int pn=1;
        List<District> allDistricts; 
        //private string userName;
        private MySqlConnection mySqlConnection;
        private MySqlCommand command;

        ViewModel videoOCR ;
        private string username = "";
        private int counter;
        private byte[] imageData1;
        private byte[] imageData2;
        private byte[] imageData3;
        private byte[] imageData4;
        private byte[] imageData5;
        private byte[] imageData6;
        private byte[] imageData7;

        public Frontend()
        {
            InitializeComponent();
            counter = 0;
            videoOCR = new ViewModel(this);
            videoOCR.initialiseReader();
            allDistricts=new List<District>();
            GetAllDistrict();
            districtComboBox.DisplayMember = "District_Name";
            districtComboBox.SelectedIndex = 0;
            districtComboBox.MouseWheel += (cmbNetworkComputers_MouseWheel);
            timer1.Enabled = true;
            timer2=new Timer();

            //SetDefault(saveButton);
            //timer2.Interval = 2*1000;
            
            timer2.Tick+=new EventHandler(timer2_Tick);
        }

        void cmbNetworkComputers_MouseWheel(object sender, MouseEventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }


        private void SetDefault(Button myDefaultBtn)
        {
            this.AcceptButton = myDefaultBtn;
        }
        DBGateway gateway=new DBGateway();
        public Frontend(string name):this()
        {
            username = name;
            userLabel.
            Text ="USER NAME : "+  username;
        }
        private void GetAllDistrict()
        {
            string[] lineOfContents = File.ReadAllLines(@"C:\PassportReaderV3.1\District.csv");
           
            lineOfContents = lineOfContents.Where(w => w != lineOfContents[0]).ToArray();
            foreach (var line in lineOfContents)
            {
                District aDistrict=new District();
                string[] tokens = line.Split(',');
                aDistrict.District_ID = Convert.ToInt32(tokens[2]);
                aDistrict.District_Code = tokens[0].ToString();
                aDistrict.District_Name = tokens[1].ToString();
                districtComboBox.Items.Add(aDistrict);
            }
        }

      private void Enable_Click(object sender, EventArgs e)
        {
            videoOCR.startReader();
          
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            // Read the status from scanner
            Boolean status = videoOCR.getScannerStatus();

            // Display status  if valid
            if (status == true)
            {
                changeStatusColour(videoOCR.busy, BusyLabel) ;
                changeStatusColour(videoOCR.documentPresent, DPlabel) ;
                changeStatusColour(videoOCR.passportPresent, PPlabel) ;
                changeStatusColour(videoOCR.MRZDecoded, MRZlabel);
                changeStatusColour(videoOCR.RFIDPresent, RFIDPlabel);
                changeStatusColour(videoOCR.RFIDecoded, RFIDDlabel);
                
            }
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            pn = 2;
            if (counter==0)
            {
                counter++;
                videoOCR.getColourImage();
                timer2.Interval = 4*1000;
                //System.Threading.Thread.Sleep(4000);
                //System.Threading.Tasks.d
            }else if (counter==1)
            {
                counter++;
               // System.Threading.Thread.Sleep(4000);
                videoOCR.getIRImage();
                timer2.Interval =  500;
            }else if (counter==2)
            {
                counter++;
                videoOCR.getUVImage();
                timer2.Interval = 1;
                counter = 0;
                timer2.Enabled = false;
            }
            //else
            //{
            //    counter = 0;
            //    timer2.Enabled = false;
            //    try
            //    {
            //        List<string> seperateAllData = GetDataFromCSV();
            //        string gender = seperateAllData[4];
            //        if (!Regex.IsMatch(seperateAllData[3], @"^[A-Z]*$"))
            //        {
            //            MessageBox.Show("Error occurred in Country Code.", "ERROR", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }
            //        else if (!checkPassport.CheckGender(gender))
            //        {
            //            MessageBox.Show("Error occurred in Gender.", "ERROR", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }
            //        else if (!Regex.IsMatch(seperateAllData[5], @"^[0-9]*$"))
            //        {
            //            MessageBox.Show("Error occurred in Birthday.", "ERROR", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }
            //        else if (!Regex.IsMatch(seperateAllData[6], @"^[0-9]*$"))
            //        {
            //            MessageBox.Show("Error occurred in Expiry date.", "ERROR", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }
            //        else if (!Regex.IsMatch(seperateAllData[7], @"^[A-Z]*$"))
            //        {
            //            MessageBox.Show("Error occurred in Nationality.", "ERROR", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }
            //        else if (!Regex.IsMatch(seperateAllData[8], @"^[A-Z]*$"))
            //        {
            //            MessageBox.Show("Error occurred in Passport type.", "ERROR", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
            //        }
            //        else if (!Regex.IsMatch(seperateAllData[9], @"^[0-9]*$"))
            //        {
            //            MessageBox.Show("Error occurred in Personal No.", "ERROR", MessageBoxButtons.OK,
            //                MessageBoxIcon.Error);
                        
            //        }
                    
            //    }
            //    catch (Exception exception)
            //    {
            //        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }


        private void GetImageData()
        {
            try
            {
                if (checkPassport.CheckFileSize())
                {

                    imageData1 = GetImageByteData(@"C:\PassportReaderV3.1\Storage\1.jpg");
                    imageData2 = GetImageByteData(@"C:\PassportReaderV3.1\Storage\2.jpg");
                    imageData3 = GetImageByteData(@"C:\PassportReaderV3.1\Storage\3.jpg");
                    imageData4 = GetImageByteData(@"C:\PassportReaderV3.1\Storage\4.jpg");
                    imageData5 = GetImageByteData(@"C:\PassportReaderV3.1\Storage\5.jpg");
                    imageData6 = GetImageByteData(@"C:\PassportReaderV3.1\Storage\6.jpg");
                    imageData7 = GetImageByteData(@"C:\PassportReaderV3.1\Storage\7.jpg");
                }
                else
                {
                    MessageBox.Show("Problem to save Image.\nPlease try again...........");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                List<string> seperateAllData = GetDataFromCSV();
                if (DistrictLabel.Text == string.Empty)
                {
                    MessageBox.Show(@"Please Select District on District Combobox.", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dialogResult =
                        MessageBox.Show("You selected District is " + DistrictLabel.Text + "\r\nWant to Save all data",
                            "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        
                        if (checkPassport.CheckPassportNo(seperateAllData[0]))
                        {
                            label10.ForeColor = System.Drawing.Color.Red;

                            label10.Text = "Duplicate Passport.Try this next day.....";
                            saveButton.Visible = false;
                        }
                        else
                        {
                            GetImageData();
                            if (InsertData(seperateAllData))
                            {
                                label10.Text = "Successfully submit data";
                                DeleteData();
                            }
                            else
                            {
                                MessageBox.Show(@"Error on save data into Database", "ERROR", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                            
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Restart_Click(object sender, EventArgs e)
        {
            videoOCR.initialiseReader();
            pn = 1;
            pictureBoxColour.Image = null;
            pictureBoxGrey.Image = null;
            pictureBoxUV.Image = null;
            districtComboBox.SelectedIndex = 0;
            textBoxMRZ.Text = string.Empty;
            passportNoTextBox.Text = string.Empty;
            passportNoTextBox.BackColor = Color.White;
            firstNameTextBox.Text = string.Empty;
            firstNameTextBox.BackColor = Color.White;
            lastNameTextBox.Text = string.Empty;
            lastNameTextBox.BackColor = Color.White;
            timer2.Enabled = false;
            DistrictLabel.Text = string.Empty;
            label10.Text = string.Empty;
           // saveButton.Visible=true;
            DeleteData();
            
        }

        private void DeleteData()
        {
            System.IO.DirectoryInfo directory = new System.IO.DirectoryInfo(@"C:\PassportReaderV3.1\Storage\");
            foreach (FileInfo file in directory.GetFiles())
            {
                file.Delete();
            }
        }

       
        private void changeStatusColour(Boolean status, Label currentLabel)
        {
            if (status == true)
            {
                currentLabel.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                currentLabel.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void RFIDPlabel_Click(object sender, EventArgs e)
        {

        }

        private void ColourSnapshot(object sender, EventArgs e)
        {        
            pn = 2;
            videoOCR.getColourImage();
        }

        private void UVSnapshot(object sender, EventArgs e)
        {
            pn = 2;
            videoOCR.getUVImage();
        }
        
        private void IRSnapshot(object sender, EventArgs e)
        {
            pn = 2;
            videoOCR.getIRImage();
        }

        private void districtComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            try
            {
                District selectDistrictCombo = (District)districtComboBox.SelectedItem;

                //if (selectDistrictCombo.District_ID != 0)
                //{
                //    DistrictLabel.Text = selectDistrictCombo.District_Name;
                //    DistrictLabel.ForeColor = Color.Red;

                //}
                District selectDistrict = (District)districtComboBox.SelectedItem;
                String dstLoc = System.Environment.CurrentDirectory + @"\";
                String folder = @"Storage\";

                if (selectDistrict.District_ID != 0)
                {
                    DistrictLabel.Text = selectDistrictCombo.District_Name;
                    DistrictLabel.ForeColor = Color.Red;
                    System.IO.File.WriteAllText(@"C:\PassportReaderV3.1\Storage\Data1.csv", selectDistrict.District_ID + "," + selectDistrict.District_Code + "," + selectDistrict.District_Name + "," + username + "\r\n");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





            //try
            //{
            //    District selectDistrictCombo = (District)districtComboBox.SelectedItem;

            //    if (selectDistrictCombo.District_ID != 0)
            //    {
            //        DistrictLabel.Text = selectDistrictCombo.District_Name;
            //        DistrictLabel.ForeColor = Color.Red;
            //    }
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }


        private void nextPageButton_Click(object sender, EventArgs e)
        {
            try
            {
                timer2.Enabled = true;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void logOutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       

        private bool InsertData(List<string> seperateAllData)
        {
           mySqlConnection = gateway.SqlConnectionObj;
            command = gateway.SqlCommandObj;
            mySqlConnection.Open();
            command.Connection = mySqlConnection;
            MySqlTransaction mySqlTx = mySqlConnection.BeginTransaction();
            gateway.SqlCommandObj.Transaction = mySqlTx;
            try
            {
                //GetStampImage();
                
                //int id;
                string date = DateTime.Now.ToString("yyyyMMdd");
                
                string query =
                    string.Format(
                        "Insert into pass_img values('','{0}','{1}','{2}',@IMAGE1, @IMAGE2, @IMAGE3, @IMAGE4,@IMAGE5, @IMAGE6,'','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}',@IMAGE7,'')",
                        seperateAllData[0], date, seperateAllData[1], seperateAllData[2], seperateAllData[3], seperateAllData[4],
                        seperateAllData[5], seperateAllData[6], seperateAllData[7], seperateAllData[8],
                        seperateAllData[10]);

                command.CommandText = query;
                command.Parameters.Add(new MySqlParameter("@IMAGE1", imageData1));
                command.Parameters.Add(new MySqlParameter("@IMAGE2", imageData4));
                command.Parameters.Add(new MySqlParameter("@IMAGE3", imageData2));
                command.Parameters.Add(new MySqlParameter("@IMAGE4", imageData5));
                command.Parameters.Add(new MySqlParameter("@IMAGE5", imageData3));
                command.Parameters.Add(new MySqlParameter("@IMAGE6", imageData6));
                command.Parameters.Add(new MySqlParameter("@IMAGE7", imageData7));
                command.ExecuteNonQuery();
                command.Parameters.Clear();

                string query1 = string.Format("insert into scan_user values('','{0}','{1}','{2}')", seperateAllData[0],
                    seperateAllData[11], date);
                command.CommandText = query1;
                command.ExecuteNonQuery();
                mySqlTx.Commit();
                return true;
            }
            catch (Exception exception)
            {
                mySqlTx.Rollback();
                throw new Exception(exception.Message);
            }
            finally
            {
                if (mySqlConnection!=null&&mySqlConnection.State==ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        private byte[] GetImageByteData(string path)
        {
            byte[] imageData = null;
            try
            {
                FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                BinaryReader reader = new BinaryReader(stream);
                imageData = reader.ReadBytes((int)stream.Length);
                stream.Dispose();
                return imageData;
            }
            catch (Exception exception)
            {
                throw  new Exception(exception.Message);
            }
        }

        private List<string> GetDataFromCSV()
        {
            List<string> lines = null;
            string selectDistrict = "";
            try
            {
                District selectDistrictCombo = (District)districtComboBox.SelectedItem;
                selectDistrict = selectDistrictCombo.District_Name;
                lines = File.ReadAllLines(@"C:\PassportReaderV3.1\Storage\Data.csv").ToList();
                lines[0] += "," + selectDistrict + "," + username;
                return lines[0].Split(',').ToList();
            }
            
            catch (Exception exception)
            {
                
                throw new Exception(exception.Message);
            }
            //return lines; 
        } 
    }

}
