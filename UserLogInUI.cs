using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace VideoOCRDemo
{
    public partial class UserLogInUI : Form
    {
        private string userName;
        
        public UserLogInUI()
        {
            InitializeComponent();
            GetUserName();
        }
        public void ClearData()
        {
            userNameTextBox.Clear();
            passwordTtextBox.Clear();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
                this.AcceptButton = logInButton;
                string uName = string.Concat(userNameTextBox.Text);
                userName = uName.ToUpper();
                string password = passwordTtextBox.Text;

                if (userName != "" && password != "")
                {
                    try
                    {
                        if (UserExist(userName, password))
                        {
                             DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            ClearData();
                            MessageBox.Show(@"Please enter valid username & password", "ERROR", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(@"Please enter UserName or Password", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
        }
           

        public string GetUserName()
        {
            return userName;
        }

        private bool UserExist(string uName, string password)
        {
            string[] lineOfContents = File.ReadAllLines(@"D:\abcdefxyz\fdnhjdnhjkbudsgr\sht9e5uycbxnvbjfn\jgiotrjihokj\..9d5abgcdefxhyz");
            return lineOfContents.Select(line => line.Split(',')).Any(tokens => uName == tokens[0].ToString() && password == tokens[1].ToString());
        }

        //private void passwordTtextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        logInButton.PerformClick();

        //    }
        //}
        //private void userNameTtextBox_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        logInButton.PerformClick();

        //    }
        //}

        
        

      
    }
}
