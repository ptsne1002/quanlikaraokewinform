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
        private int salary;
        private string birthDay;
        private string gender;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Role { get => role; set => role = value; }
        public int Salary { get => salary; set => salary = value; }
        public string BirthDay { get => birthDay; set => birthDay = value; }
        public string Gender { get => gender; set => gender = value; }

        public Employee()
        {
            this.employeeId = 0;
            this.employeeName = "";
            this.phone = "";
            this.address = "";
            this.role = "";
            this.salary = 0;
            this.birthDay = "";
            this.gender = "";
        }
        public Employee(int id, string name, string phone, string add,string role,int salary, string bd, string gender)
        {
            this.employeeId = id;
            this.employeeName = name;
            this.phone = phone;
            this.address = add;
            this.role = role;
            this.salary = salary;
            this.birthDay = bd;
            this.gender = gender;
        }


    }
}
