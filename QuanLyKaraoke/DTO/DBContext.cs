using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DBContext
    {
        private ConnectDB Connect = new ConnectDB();

        public int CheckAccount(Account n)
        {
            int employeeid = -1;
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = "select employeeid from account where username = '"+n.UserName+"' and password = '"+n.Password+"'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        employeeid = rd.GetInt32(0);
                    }
                else
                    employeeid = -1;

                conn.Close();
            }
            catch(Exception e)
            {
                 
            }
            return employeeid;
        }
        
        public Employee GetEmployee(int id)
        {
            Employee temp = new Employee();
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = "select * from employee where employeeid = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        temp.EmployeeId = rd.GetInt32(0);
                        temp.EmployeeName = rd.GetString(1);
                        temp.Phone = rd.GetString(2);
                        temp.Address = rd.GetString(3);
                        temp.Role = rd.GetString(4);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }
    }
}
