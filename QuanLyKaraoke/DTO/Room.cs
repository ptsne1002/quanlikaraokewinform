using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class Room
    {
        private int roomId;
        private string roomName;
        private string title;
        private int pricePerHours;

        public int RoomId { get => roomId; set => roomId = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public string Title { get => title; set => title = value; }
        public int PricePerHours { get => pricePerHours; set => pricePerHours = value; }

        public Room()
        {
            this.roomId = 0;
            this.roomName = "";
            this.title = "";
            this.pricePerHours = 0;
        }
        public Room(int id, string name, string title, int price)
        {
            this.roomId = id;
            this.roomName = name;
            this.title = title;
            this.pricePerHours = price;
        }
    }
}
