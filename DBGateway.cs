using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace VideoOCRDemo
{
    class DBGateway
    {
        private MySqlConnection connectionObj;
        private MySqlCommand commandObj;
        

        public DBGateway()
        {
            
            connectionObj = new MySqlConnection(ConfigurationManager.ConnectionStrings["TMLMRP1"].ConnectionString);
            
            
            commandObj = new MySqlCommand();
        }

        public MySqlConnection SqlConnectionObj
        {
            get { return connectionObj; }
        }
        public MySqlCommand SqlCommandObj
        {
            get
            {
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }
    }
}

