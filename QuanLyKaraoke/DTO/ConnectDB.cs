
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ConnectDB
    {
        private string str_connect = "Data Source=localhost:1521/orcl;User Id=karamanagerdb;Password=pts;";
        public OracleConnection ConnecttoDB()
        {
            OracleConnection conn = new OracleConnection(this.str_connect);
            return conn;
        }
    }
}
