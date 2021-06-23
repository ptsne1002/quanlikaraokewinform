using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Booking
    {
        private int bookingId;
        private string timeStart;
        private Employee emp;
        private Customer cus;
        private Room room;
        private string status;
        private List<OrderService> lsOrder = new List<OrderService>();
        public int BookingId { get => bookingId; set => bookingId = value; }
        public string TimeStart { get => timeStart; set => timeStart = value; }
        public Employee Emp { get => emp; set => emp = value; }
        public Customer Cus { get => cus; set => cus = value; }
        public Room Room { get => room; set => room = value; }
        public string Status { get => status; set => status = value; }
        public List<OrderService> LsOrder { get => lsOrder; set => lsOrder = value; }

        public Booking()
        {
            this.bookingId = 0;
            this.TimeStart = "";
            this.emp = new Employee();
            this.cus = new Customer();
            this.room = new Room();
            this.status = "";
            this.lsOrder = new List<OrderService>();
        }
        public Booking(int id, string time, Employee e, Customer c, Room r, string stt, List<OrderService> ls)
        {
            this.bookingId = id;
            this.TimeStart = time;
            this.emp = e;
            this.cus = c;
            this.room = r;
            this.status = stt;
            this.lsOrder = ls;
        }


    }
}
