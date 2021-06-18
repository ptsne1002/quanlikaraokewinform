using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DBContext
    {
        private ConnectDB Connect = new ConnectDB();

        // Process Account into DB
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
        public Account GetAccountByIdEmp(int id)
        {
            Account Temp = new Account();

            MySqlConnection conn = Connect.ConnecttoDB();
            string query = String.Format("select * from account where employeeid='{0}';", id);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Temp.UserName = rd.GetString(0);
                        Temp.Password = rd.GetString(1);
                        Temp.EmployeeId = rd.GetInt32(2);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }

            return Temp;
        }

        public string ChangePwd(Account temp)
        {
            string rs = "Fail";
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = String.Format("update account set password='{0}' where username = '{1}' and employeeid = '{2}';", temp.Password,temp.UserName,temp.EmployeeId);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Password Was Change";
                    
                }
                else
                {
                    rs = "Sorry!! Password Can't Change";
                }
                
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        // Process Employee into DB
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

        public List<Employee> GetAllEmp()
        {
            List<Employee> temp = new List<Employee>();
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = "select * from employee where role='Nhân Viên'";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Employee t = new Employee();
                        t.EmployeeId = rd.GetInt32(0);
                        t.EmployeeName = rd.GetString(1);
                        t.Phone = rd.GetString(2);
                        t.Address = rd.GetString(3);
                        t.Role = rd.GetString(4);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }

        // Process Room into DB
        public List<Room> GetAllRoom()
        {
            List<Room> temp = new List<Room>();
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = "select * from room";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                
                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Room t = new Room();
                        t.RoomId = rd.GetInt32(0);
                        t.RoomName = rd.GetString(1);
                        t.Title = rd.GetString(2);
                        t.PricePerHours = rd.GetInt32(3);
                        temp.Add(t);
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
