using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ConnectDB
    {
        private string str_connect = "datasource=localhost;port=3306;username=root;password=;database=db_quanlykaraoke;";
        
        public MySqlConnection ConnecttoDB()
        {
            MySqlConnection conn = new MySqlConnection(this.str_connect);
            return conn;
        }
    }
}
