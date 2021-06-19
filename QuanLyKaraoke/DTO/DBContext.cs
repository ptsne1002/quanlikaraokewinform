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
                    rs = "Successful! Password Was Change";
                    
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
                        temp.Salary = rd.GetInt32(5);
                        temp.BirthDay = DateTime.Parse(rd.GetString(6)).ToShortDateString();
                        temp.Gender = rd.GetString(7);
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
            string query = "select * from employee";
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
                        t.Salary = rd.GetInt32(5);
                        t.BirthDay = DateTime.Parse(rd.GetString(6)).ToShortDateString();
                        t.Gender = rd.GetString(7);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }

        public List<Employee> GetAllEmpServe()
        {
            List<Employee> temp = new List<Employee>();
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = "select * from employee where role = 'Staff'";
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
                        t.Salary = rd.GetInt32(5);
                        t.BirthDay = (rd.GetString(6));
                        t.Gender = rd.GetString(7);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }

        public string InsertEmp(Employee emp)
        {
            string rs = "";
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into employee(employeename, phone, address, role, salary, dayofbirth, gender) values('{0}','{1}','{2}','{3}',{4},'{5}','{6}');",
                                          emp.EmployeeName, emp.Phone, emp.Address, emp.Role, emp.Salary, emp.BirthDay, emp.Gender);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                }
                else
                {
                    rs = "Sorry! Can't Add New Employee";
                }    
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }
        public string EditEmp(Employee emp)
        {
            string rs = "";
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = string.Format("UPDATE employee SET employeename = '{0}', phone = '{1}', address = '{2}', role = '{3}', salary = '{4}', dayofbirth = '{5}', gender = '{6}'   WHERE employeeid = {7};",
                                          emp.EmployeeName, emp.Phone, emp.Address, emp.Role, emp.Salary, emp.BirthDay, emp.Gender, emp.EmployeeId);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                if(cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                }
                else
                {
                    rs = "Sorry! Can't Edit Employee";
                }    
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public string DeleteEmp(int id)
        {
            string rs = "";
            MySqlConnection conn = Connect.ConnecttoDB();
            string query = string.Format("DELETE FROM employee WHERE employeeid = {0}",id);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                }
                else
                {
                    rs = "Sorry! Can't Delete Employee";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
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
