using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Customer
    {
        private int customerId;
        private string customerName;
        private string phone;
        private int score;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Phone { get => phone; set => phone = value; }
        public int Score { get => score; set => score = value; }

        public Customer()
        {
            this.customerId = 0;
            this.customerName = "";
            this.phone = "";
            this.score = 0;
        }
        public Customer(int id, string name, string phone, string cmnd, int score)
        {
            this.customerId = id;
            this.customerName = name;
            this.phone = phone;
            this.score = score;
        }
    }
}
