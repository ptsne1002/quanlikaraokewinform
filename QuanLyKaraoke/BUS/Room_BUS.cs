using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace BUS
{
    public class Room_BUS
    {
        private DBContext model = new DBContext();

        public List<Room> GetAllRoom()
        {
            List<Room> temp = new List<Room>();
            temp = model.GetAllRoom();
            return temp;
        }

        public string InsertRoom(Room r)
        {
            string rs = "";
            rs = model.InsertRoom(r);
            return rs;
        }

        public string DeleteRoom(int id)
        {
            string rs = "";
            rs = model.DeleteRoom(id);
            return rs;
        }
        public string EditRoom(Room r)
        {
            string rs = "";
            rs = model.EdiRoom(r);
            return rs;
        }
    }
}
