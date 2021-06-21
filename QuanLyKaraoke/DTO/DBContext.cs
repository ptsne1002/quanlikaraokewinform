using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DTO
{
    public class DBContext
    {
        private ConnectDB Connect = new ConnectDB();

        // Process Account with DB
        public int CheckAccount(Account n)
        {
            int employeeid = -1;
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select employeeid from account where username = '" + n.UserName + "' and password = '" + n.Password + "'";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
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
            catch (Exception e)
            {

            }
            return employeeid;
        }
        public Account GetAccountByIdEmp(int id)
        {
            Account Temp = new Account();

            OracleConnection conn = Connect.ConnecttoDB();
            string query = String.Format("select * from account where employeeid='{0}'", id);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
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
            OracleConnection conn = Connect.ConnecttoDB();
            conn.Open();
            OracleTransaction transaction;
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            string query = String.Format("update account set password='{0}' where username = '{1}' and employeeid = '{2}'", temp.Password, temp.UserName, temp.EmployeeId);
            OracleCommand cmd = conn.CreateCommand();
            cmd.Transaction = transaction;
            OracleDataReader rd;
            try
            {
                cmd.CommandText = query;
                //conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    
                    rs = "Successful! Password Was Change";
                    transaction.Commit();
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

        // Process Employee with DB
        public Employee GetEmployee(int id)
        {
            Employee temp = new Employee();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from employee where employeeid = '" + id + "' ";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
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
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from employee order by employeeid ASC";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
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
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from employee where role = 'Staff' order by employeeid ASC";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
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
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into employee(employeename, phone, address, role, salary, birthday, gender) values ('{0}','{1}','{2}','{3}',{4},to_date('{5}','dd-mm-yyyy'),'{6}')",
                                          emp.EmployeeName, emp.Phone, emp.Address, emp.Role, emp.Salary, emp.BirthDay, emp.Gender);
            OracleCommand cmd = new OracleCommand(query, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
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
            OracleConnection conn = Connect.ConnecttoDB();
            conn.Open();
            OracleTransaction transaction;
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            string query = string.Format("UPDATE employee SET employeename = '{0}', phone = '{1}', address = '{2}', role = '{3}', salary = '{4}', birthday = to_date('{5}','dd/mm/yyyy'), gender = '{6}'   WHERE employeeid = {7}",
                                          emp.EmployeeName, emp.Phone, emp.Address, emp.Role, emp.Salary, emp.BirthDay, emp.Gender, emp.EmployeeId);
            OracleCommand cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                    transaction.Commit();
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
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("DELETE FROM employee WHERE employeeid = {0}", id);
            OracleCommand cmd = new OracleCommand(query, conn);
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

        // Process Room with DB

        public List<Room> GetAllRoom()
        {
            List<Room> temp = new List<Room>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from room order by roomid ASC";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
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
                        t.Type = rd.GetString(2);
                        t.PricePerHours = rd.GetInt32(3);
                        t.Status = rd.GetString(4);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }

        public string InsertRoom(Room r)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into room(roomname, type) values ('{0}','{1}')",
                                          r.RoomName, r.Type);
            OracleCommand cmd = new OracleCommand(query, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                }
                else
                {
                    rs = "Sorry! Can't Add New Room";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public string EdiRoom(Room r)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            conn.Open();
            OracleTransaction transaction;
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            string query = string.Format("UPDATE room SET roomname = '{0}', type = '{1}' WHERE roomid = {2}",
                                          r.RoomName, r.Type, r.RoomId);
            OracleCommand cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                    transaction.Commit();
                }
                else
                {
                    rs = "Sorry! Can't Edit Room";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public string DeleteRoom(int id)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("DELETE FROM room WHERE roomid = {0}", id);
            OracleCommand cmd = new OracleCommand(query, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                }
                else
                {
                    rs = "Sorry! Can't Delete Room";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        // Process Customer with DB

        public List<Customer> GetAllCustomer()
        {
            List<Customer> temp = new List<Customer>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from customer order by customerid ASC";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Customer t = new Customer();
                        t.CustomerId = rd.GetInt32(0);
                        t.CustomerName = rd.GetString(1);
                        t.Phone = rd.GetString(2);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }

        public string InsertCus(Customer cus)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into customer(name, phone) values ('{0}','{1}')",
                                          cus.CustomerName, cus.Phone);
            OracleCommand cmd = new OracleCommand(query, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                }
                else
                {
                    rs = "Sorry! Can't Add New Customer";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public string EditCus(Customer cus)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            conn.Open();
            OracleTransaction transaction;
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            string query = string.Format("UPDATE customer SET name = '{0}', phone = '{1}' WHERE customerid = {2}",
                                          cus.CustomerName, cus.Phone, cus.CustomerId);
            OracleCommand cmd = conn.CreateCommand();
            cmd.Transaction = transaction;

            try
            {
                cmd.CommandText = query;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                    transaction.Commit();
                }
                else
                {
                    rs = "Sorry! Can't Edit Customer";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public string DeleteCus(int id)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("DELETE FROM customer WHERE customerid = {0}", id);
            OracleCommand cmd = new OracleCommand(query, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Successful";
                }
                else
                {
                    rs = "Sorry! Can't Delete Customer";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }
    }


}