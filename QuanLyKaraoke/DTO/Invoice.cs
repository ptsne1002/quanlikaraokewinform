using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Invoice
    {
        private int orderId;
        private int bookingId;
        private string timeEnd;
        private int totalPrice;
        private int createdBy;

        public int OrderId { get => orderId; set => orderId = value; }
        public int BookingId { get => bookingId; set => bookingId = value; }
        public string TimeEnd { get => timeEnd; set => timeEnd = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int CreatedBy { get => createdBy; set => createdBy = value; }

        public Invoice()
        {
            this.orderId = 0;
            this.bookingId = 0;
            this.timeEnd = "";
            this.totalPrice = 0;
            this.createdBy = 0;
        }
        public Invoice(int oid, int bid, string t, int total, int empid)
        {
            this.orderId = oid;
            this.bookingId = bid;
            this.timeEnd = t;
            this.totalPrice = total;
            this.createdBy = empid;
        }

    }
}
