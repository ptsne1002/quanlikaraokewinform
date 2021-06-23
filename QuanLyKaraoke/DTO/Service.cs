using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Service
    {
        private int serviceID;
        private string serviceName;
        private int price;

        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int Price { get => price; set => price = value; }

        public Service()
        {
            this.serviceID = 0;
            this.serviceName = "";
            this.price = 0;
        }

        public Service(int id, string name, int price)
        {
            this.serviceID = id;
            this.serviceName = name;
            this.price = price;
        }

    }
}
