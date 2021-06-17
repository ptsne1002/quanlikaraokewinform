using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Account
    {
        private string userName;
        private string password;
        private int employeeId;

        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        public Account()
        {
            this.userName = "";
            this.password = "";
            this.EmployeeId = -1;
        }

        public Account(string username,string pass, int id)
        {
            this.userName = username;
            this.password = pass;
            this.EmployeeId = id;
        }
    }
}
