using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace BUS
{
    public class Service_BUS
    {
        private DBContext model = new DBContext();

        public List<Service> GetAllService()
        {
            List<Service> ls = new List<Service>();
            ls = model.GetALLService();
            return ls;
        }

        public string InsertService(Service e)
        {
            string rs = model.InsertService(e);
            return rs;
        }

        public string DeleteService(int id)
        {
            string rs = model.DeleteService(id);
            return rs;
        }

        public string EditService(Service e)
        {
            string rs = model.EditService(e);
            return rs;
        }

    }
}
