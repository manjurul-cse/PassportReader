using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace VideoOCRDemo.BLL
{
    class CheckPassport
    {
        DBGateway gateway=new DBGateway();
        MySqlConnection mySqlConnection;
        MySqlCommand command;
        public bool CheckGender(string gender)
        {
            try
            {
                if (gender == "M")
                {
                    return true;
                }
                else if (gender == "F")
                {
                    return true;
                }
                else if (gender == "X")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {

                throw new Exception("Problem occurs to read gender.\n Please try again.........", exception);
            }
        }

        public bool CheckPassportNo(string passportNo)
        {
             
            try
            {
                string date = DateTime.Now.ToString("yyyyMMdd");

                mySqlConnection = gateway.SqlConnectionObj;
                command = gateway.SqlCommandObj;


                string query = string.Format("Select * from pass_img where Pass_No='{0}' and date='{1}'",
                    passportNo, date);

                mySqlConnection.Open();
                command.CommandText = query;
                MySqlDataReader reader = command.ExecuteReader();
                if (reader != null)
                {
                    return reader.HasRows;
                }
                return false;
            }
            catch (Exception exception)
            {
                throw new Exception("Passport No couldn't loaded from your system", exception);
            }
            finally
            {
                if (mySqlConnection != null && mySqlConnection.State == ConnectionState.Open)
                {
                    mySqlConnection.Close();
                }
            }
        }

        public bool CheckFileSize()
        {
            try
            {
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(@"C:\PassportReaderV3.1\Storage");
                int count = dir.GetFiles().Length;
                if (count == 8)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception exception)
            {
                
                throw new Exception(exception.Message);
            }
        }
    }
}
