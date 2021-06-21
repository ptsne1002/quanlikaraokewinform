using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Room
    {
        private int roomId;
        private string roomName;
        private string type;
        private int pricePerHours;
        private string status;
        public int RoomId { get => roomId; set => roomId = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public string Type { get => type; set => type = value; }
        public int PricePerHours { get => pricePerHours; set => pricePerHours = value; }
        public string Status { get => status; set => status = value; }

        public Room()
        {
            this.roomId = 0;
            this.roomName = ""; 
            this.type = "";
            this.pricePerHours = 0;
            this.status = "";
        }
        public Room(int id, string name, string title, int price,string status)
        {
            this.roomId = id;
            this.roomName = name;
            this.type = title;
            this.pricePerHours = price;
            this.status = status;
        }
    }
}
