using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmMain : Form
    {
        private Employee currentEmp = new Employee();
        public fmMain(Employee e)
        {
            currentEmp = e;

            InitializeComponent();
            lb1.Text = currentEmp.EmployeeName +" "+ currentEmp.Role;
        }

        private void fmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
