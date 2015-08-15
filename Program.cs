using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoOCRDemo
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           UserLogInUI logInUi=new UserLogInUI();
            
            DialogResult r = logInUi.ShowDialog();
            if (r==DialogResult.OK)
            {
                
                Application.Run(new Frontend(logInUi.GetUserName()));
            }
            else
            {
                Application.Exit();
            }

            
        }
    }
}
