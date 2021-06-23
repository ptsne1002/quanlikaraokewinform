using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class OrderService_BUS
    {
        private DBContext model = new DBContext();

        public string InsertOrderService(OrderService s)
        {

            string rs = "";
            rs = model.InsertOrderService(s);
            return rs;
        }

        public List<OrderService> GetOSByBookingID(int id)
        {
            List<OrderService> ls = new List<OrderService>();
            ls = model.GetOSByBookingID(id);
            return ls;
        }


    }
}
