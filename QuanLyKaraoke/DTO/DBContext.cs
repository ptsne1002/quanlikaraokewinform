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

        public List<Room> GetRoomIsUsing()
        {
            List<Room> temp = new List<Room>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from room where status = 'Busy' order by roomid ASC";
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

        public Customer GetCusByPhone(string phone)
        {
            Customer rs = new Customer();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("select * FROM customer WHERE phone = {0}", phone);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();
                if(rd.HasRows)
                {
                    while(rd.Read())
                    {
                        rs.CustomerId = rd.GetInt32(0);
                        rs.CustomerName = rd.GetString(1);
                        rs.Phone = rd.GetString(2);
                    }
                }
                
            }
            catch (Exception e)
            {
                
            }
            return rs;
        }


        // Process Booking with DB

        public string InsertBooking(Booking b)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into booking(roomid, empid, customerid, timecreated) values ({0}, {1}, {2}, '{3}')",
                                          b.Room.RoomId, b.Emp.EmployeeId, b.Cus.CustomerId, b.TimeStart);
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
                    rs = "Sorry! Can't Add New Booking";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public List<Booking> GetBookingUsing()
        {
            List<Booking> temp = new List<Booking>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from booking b, room r, employee e, customer c where b.roomid = r.roomid and b.empid = e.employeeid and b.customerid = c.customerid and b.status = 'Using' order by bookingid ASC";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Booking t = new Booking();
                        t.BookingId = rd.GetInt32(0);
                        t.Room.RoomId = rd.GetInt32(1);
                        t.Emp.EmployeeId = rd.GetInt32(2);
                        t.Cus.CustomerId = rd.GetInt32(3);
                        t.Status = rd.GetString(5);
                        t.TimeStart = rd.GetString(4);
                        t.Room.RoomName = rd.GetString(7);
                        t.Room.Type = rd.GetString(8);
                        t.Room.PricePerHours = rd.GetInt32(9);
                        t.Room.Status = rd.GetString(10);
                        t.Emp.EmployeeName = rd.GetString(12);
                        t.Emp.Phone = rd.GetString(13);
                        t.Emp.Address = rd.GetString(14);
                        t.Emp.Role = rd.GetString(15);
                        t.Emp.Salary = rd.GetInt32(16);
                        t.Emp.BirthDay = rd.GetString(17);
                        t.Emp.Gender = rd.GetString(18);
                        t.Cus.CustomerName = rd.GetString(20);
                        t.Cus.Phone = rd.GetString(21);

                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }

        // Process Service with DB

        public List<Service> GetALLService()
        {
            List<Service> temp = new List<Service>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = "select * from service order by serviceid ASC";
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Service t = new Service();
                        t.ServiceID = rd.GetInt32(0);
                        t.ServiceName = rd.GetString(1);
                        t.Price = rd.GetInt32(2);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }


        public string InsertService(Service s)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into service(servicename, price) values ('{0}','{1}')",
                                          s.ServiceName, s.Price);
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
                    rs = "Sorry! Can't Add New Service";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public string EditService(Service s)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            conn.Open();
            OracleTransaction transaction;
            transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
            string query = string.Format("UPDATE service SET servicename = '{0}', price = '{1}' WHERE serviceid = {2}",
                                          s.ServiceName, s.Price, s.ServiceID);
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
                    rs = "Sorry! Can't Edit Service";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public string DeleteService(int id)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("DELETE FROM service WHERE serviceid = {0}", id);
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
                    rs = "Sorry! Can't Delete Service";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }


        // Process Serivce with DB

        public string InsertOrderService(OrderService s)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into orderservice(bookingid, serviceid, amount, timecreated) values ({0},{1},{2},'{3}')",
                                          s.BookingId, s.ServiceId, s.Amount,DateTime.Now.ToString("HH:mm dd/MM/yyyy"));
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
                    rs = "Sorry! Can't Add New OrderService";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public List<OrderService> GetOSByBookingID(int id)
        {
            List<OrderService> temp = new List<OrderService>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("select * from orderservice o, service s where o.serviceid = s.serviceid and o.bookingid = {0}", id);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        OrderService t = new OrderService();
                        t.BookingId = rd.GetInt32(0);
                        t.ServiceId = rd.GetInt32(1);
                        t.Amount = rd.GetInt32(2);
                        t.Total = rd.GetInt32(3);
                        t.TimeCreated = rd.GetString(4);
                        t.NameService = rd.GetString(6);
                        t.UnitPrice = rd.GetInt32(7);

                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }


        //Process Invoice with DB
        public string InsertInvoice(Invoice ins)
        {
            string rs = "";
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("insert into invoice(bookingid, timeend, totalprice, createdby) values ({0},'{1}',{2},{3})",
                                          ins.Booking.BookingId,DateTime.Now.ToString("HH:mm dd/MM/yyyy"), ins.TotalPrice, ins.CreatedBy);
            OracleCommand cmd = new OracleCommand(query, conn);
            try
            {
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    rs = "Create Invoice Successful";
                }
                else
                {
                    rs = "Sorry! Can't Created Invoice";
                }
            }
            catch (Exception e)
            {
                rs = e.Message;
            }
            return rs;
        }

        public List<Invoice> GetTopInvoice(int num)
        {
            List<Invoice> temp = new List<Invoice>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("select * from invoice i, booking b, customer c, room r where i.bookingid = b.bookingid and c.customerid = b.customerid and r.roomid = b.roomid order by i.totalprice desc FETCH FIRST {0} ROWS ONLY", num);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Invoice t = new Invoice();
                        t.OrderId = rd.GetInt32(0);
                        t.Booking.BookingId = rd.GetInt32(1);
                        t.TotalPrice = rd.GetInt32(3);
                        t.CreatedBy = rd.GetInt32(4);
                        t.TimeEnd = rd.GetString(2);
                        t.Booking.Room.RoomId = rd.GetInt32(6);
                        t.Booking.Emp.EmployeeId = rd.GetInt32(7);
                        t.Booking.Cus.CustomerId = rd.GetInt32(8);
                        t.Booking.TimeStart = rd.GetString(9);
                        t.Booking.Cus.CustomerName = rd.GetString(12);
                        t.Booking.Cus.Phone = rd.GetString(13);
                        t.Booking.Room.RoomId = rd.GetInt32(14);
                        t.Booking.Room.RoomName = rd.GetString(15);
                        t.Booking.Room.Type = rd.GetString(16);
                        t.Booking.Room.PricePerHours = rd.GetInt32(17);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }
        public List<Invoice> GetInvoiceByDay(string day)
        {
            List<Invoice> temp = new List<Invoice>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("select * from invoice i, booking b, customer c, room r where i.bookingid = b.bookingid and c.customerid = b.customerid and r.roomid = b.roomid and i.timeend like '%{0}' order by i.totalprice desc", day);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Invoice t = new Invoice();
                        t.OrderId = rd.GetInt32(0);
                        t.Booking.BookingId = rd.GetInt32(1);
                        t.TotalPrice = rd.GetInt32(3);
                        t.CreatedBy = rd.GetInt32(4);
                        t.TimeEnd = rd.GetString(2);
                        t.Booking.Room.RoomId = rd.GetInt32(6);
                        t.Booking.Emp.EmployeeId = rd.GetInt32(7);
                        t.Booking.Cus.CustomerId = rd.GetInt32(8);
                        t.Booking.TimeStart = rd.GetString(9);
                        t.Booking.Cus.CustomerName = rd.GetString(12);
                        t.Booking.Cus.Phone = rd.GetString(13);
                        t.Booking.Room.RoomId = rd.GetInt32(14);
                        t.Booking.Room.RoomName = rd.GetString(15);
                        t.Booking.Room.Type = rd.GetString(16);
                        t.Booking.Room.PricePerHours = rd.GetInt32(17);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }
        public List<Invoice> GetInvoiceByCusPhone(string phone)
        {
            List<Invoice> temp = new List<Invoice>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("select * from invoice i, booking b, customer c, room r where i.bookingid = b.bookingid and c.customerid = b.customerid and r.roomid = b.roomid and c.phone = '{0}' order by i.totalprice desc", phone);
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Invoice t = new Invoice();
                        t.OrderId = rd.GetInt32(0);
                        t.Booking.BookingId = rd.GetInt32(1);
                        t.TotalPrice = rd.GetInt32(3);
                        t.CreatedBy = rd.GetInt32(4);
                        t.TimeEnd = rd.GetString(2);
                        t.Booking.Room.RoomId = rd.GetInt32(6);
                        t.Booking.Emp.EmployeeId = rd.GetInt32(7);
                        t.Booking.Cus.CustomerId = rd.GetInt32(8);
                        t.Booking.TimeStart = rd.GetString(9);
                        t.Booking.Cus.CustomerName = rd.GetString(12);
                        t.Booking.Cus.Phone = rd.GetString(13);
                        t.Booking.Room.RoomId = rd.GetInt32(14);
                        t.Booking.Room.RoomName = rd.GetString(15);
                        t.Booking.Room.Type = rd.GetString(16);
                        t.Booking.Room.PricePerHours = rd.GetInt32(17);
                        temp.Add(t);
                    }
                conn.Close();
            }
            catch (Exception e)
            {

            }
            return temp;
        }
        public List<Invoice> GetAllInvoice()
        {
            List<Invoice> temp = new List<Invoice>();
            OracleConnection conn = Connect.ConnecttoDB();
            string query = string.Format("select * from invoice i, booking b, customer c, room r where i.bookingid = b.bookingid and c.customerid = b.customerid and r.roomid = b.roomid order by i.totalprice desc");
            OracleCommand cmd = new OracleCommand(query, conn);
            OracleDataReader rd;
            try
            {
                conn.Open();
                rd = cmd.ExecuteReader();

                if (rd.HasRows)
                    while (rd.Read())
                    {
                        Invoice t = new Invoice();
                        t.OrderId = rd.GetInt32(0);
                        t.Booking.BookingId = rd.GetInt32(1);
                        t.TotalPrice = rd.GetInt32(3);
                        t.CreatedBy = rd.GetInt32(4);
                        t.TimeEnd = rd.GetString(2);
                        t.Booking.Room.RoomId = rd.GetInt32(6);
                        t.Booking.Emp.EmployeeId = rd.GetInt32(7);
                        t.Booking.Cus.CustomerId = rd.GetInt32(8);
                        t.Booking.TimeStart = rd.GetString(9);
                        t.Booking.Cus.CustomerName = rd.GetString(12);
                        t.Booking.Cus.Phone = rd.GetString(13);
                        t.Booking.Room.RoomId = rd.GetInt32(14);
                        t.Booking.Room.RoomName = rd.GetString(15);
                        t.Booking.Room.Type = rd.GetString(16);
                        t.Booking.Room.PricePerHours = rd.GetInt32(17);
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