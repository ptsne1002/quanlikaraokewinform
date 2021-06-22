using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class Booking_BUS
    {
        private DBContext model = new DBContext();

        public string InsertBooking(Booking b)
        {
            string rs = "";
            rs = model.InsertBooking(b);
            return rs;
        }

        public List<Booking> GetBookingUsing()
        {
            List<Booking> ls = new List<Booking>();
            ls = model.GetBookingUsing();
            return ls;
        }
    }
}
