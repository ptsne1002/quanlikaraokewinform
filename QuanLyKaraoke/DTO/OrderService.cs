using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class OrderService
    {
        private int bookingId;
        private int serviceId;
        private int amount;
        private int total;
        private int unitPrice;
        private string nameService;
        private string timeCreated;
        public int BookingId { get => bookingId; set => bookingId = value; }
        public int ServiceId { get => serviceId; set => serviceId = value; }
        public int Amount { get => amount; set => amount = value; }
        public int Total { get => total; set => total = value; }
        public int UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string NameService { get => nameService; set => nameService = value; }
        public string TimeCreated { get => timeCreated; set => timeCreated = value; }

        public OrderService()
        {
            this.bookingId = 0;
            this.serviceId = 0;
            this.amount = 0;
            this.total = 0;
            this.unitPrice = 0;
            this.nameService = "";
            this.timeCreated = "";
        }
        public OrderService(int bid, int sid, int a, int t, string name, string date )
        {
            this.bookingId = bid;
            this.serviceId = sid;
            this.amount = a;
            this.total = t;
            this.nameService = name;
            this.timeCreated = date;
        }
    }
}
