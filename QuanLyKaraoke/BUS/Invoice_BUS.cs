using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class Invoice_BUS
    {
        private DBContext model = new DBContext();
        
        public string InsertInvoice(Invoice ins)
        {
            string rs = "";
            rs = model.InsertInvoice(ins);
            return rs;
        } 

        public List<Invoice> GetTopInvoice(int num)
        {
            List<Invoice> ls = new List<Invoice>();
            ls = model.GetTopInvoice(num);
            return ls;
        }
        public List<Invoice> GetInvoiceByDay(string day)
        {
            List<Invoice> ls = new List<Invoice>();
            ls = model.GetInvoiceByDay(day);
            return ls;
        } 
        public List<Invoice> GetInvoiceByCusPhone(string phone)
        {
            List<Invoice> ls = new List<Invoice>();
            ls = model.GetInvoiceByCusPhone(phone);
            return ls;
        }
        public List<Invoice> GetAllInvoice()
        {
            List<Invoice> ls = new List<Invoice>();
            ls = model.GetAllInvoice();
            return ls;
        } 



    }
}
