using DTO;
using System;

namespace BUS
{
    public class Account_BUS
    {
        private DBContext model = new DBContext();
        
        public int CheckAccount(Account login)
        {
            int employeeid = this.model.CheckAccount(login);
            return employeeid;
        }

    }
}
