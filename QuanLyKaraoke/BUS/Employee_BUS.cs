using DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace BUS
{
    public class Employee_BUS
    {
        private DBContext model = new DBContext();

        public Employee GetEmployee(int id)
        {
            Employee temp = this.model.GetEmployee(id);
            return temp;
        }

        public List<Employee> GetAllEmp()
        {
            List<Employee> temp = new List<Employee>();
            temp = model.GetAllEmp();
            return temp;
        }
    }
}
