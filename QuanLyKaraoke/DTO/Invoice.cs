using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Invoice
    {
        private int orderId;
        private Booking booking;
        private string timeEnd;
        private double totalPrice;
        private int createdBy;

        public int OrderId { get => orderId; set => orderId = value; }
        public string TimeEnd { get => timeEnd; set => timeEnd = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public int CreatedBy { get => createdBy; set => createdBy = value; }
        public Booking Booking { get => booking; set => booking = value; }

        public Invoice()
        {
            this.orderId = 0;
            this.booking = new Booking();
            this.timeEnd = "";
            this.totalPrice = 0;
            this.createdBy = 0;
        }
        public Invoice(int oid, Booking bid, string t, double total, int empid)
        {
            this.orderId = oid;
            this.booking = bid;
            this.timeEnd = t;
            this.totalPrice = total;
            this.createdBy = empid;
        }

    }
}
