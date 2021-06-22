using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class Customer_BUS
    {
        private DBContext model = new DBContext();
        
        public List<Customer> GetAllCustomer()
        {
            List<Customer> ls = new List<Customer>();
            ls = model.GetAllCustomer();
            return ls;
        }

        public string InsertCus(Customer e)
        {
            string rs = model.InsertCus(e);
            return rs;
        }

        public string DeleteCus(int id)
        {
            string rs = model.DeleteCus(id);
            return rs;
        }

        public string EditCus(Customer e)
        {
            string rs = model.EditCus(e);
            return rs;
        }

        public Customer GetCusByPhone(string phone)
        {
            Customer rs = new Customer();
            rs = model.GetCusByPhone(phone);
            return rs;
        }
    }
}
