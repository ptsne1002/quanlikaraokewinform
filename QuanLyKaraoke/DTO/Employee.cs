using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Employee
    {
        private int employeeId;
        private string employeeName;
        private string phone;
        private string address;
        private string role;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Role { get => role; set => role = value; }

        public Employee()
        {
            this.employeeId = 0;
            this.employeeName = "";
            this.phone = "";
            this.address = "";
            this.role = "";
        }
        public Employee(int id, string name, string phone, string add,string role)
        {
            this.employeeId = id;
            this.employeeName = name;
            this.phone = phone;
            this.address = add;
            this.role = role;
        }
    }
}
