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

        public Account GetAccountByIdEmp(int EmpId)
        {
            Account temp = new Account();
            temp = model.GetAccountByIdEmp(EmpId);

            return temp;

        }

        public string ChangePwd(Account temp)
        {
            string rs = model.ChangePwd(temp);
            return rs;
        }
    }
}
