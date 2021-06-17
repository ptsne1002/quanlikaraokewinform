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
    }
}
