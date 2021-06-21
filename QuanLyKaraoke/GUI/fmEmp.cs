using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmEmp : Form
    {
        private Employee_BUS controllerEmp = new Employee_BUS();
        private List<Employee> listEmp = new List<Employee>();
        private bool t = false;
        public fmEmp()
        {
            InitializeComponent();
            LoadDBEmployee();
        }

        private void LoadDBEmployee()
        {
            tblEmp.Rows.Clear();
            listEmp = controllerEmp.GetAllEmp();
            for (int i = 0; i < listEmp.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblEmp);
                newRow.Cells[0].Value = this.listEmp[i].EmployeeId;
                newRow.Cells[1].Value = this.listEmp[i].EmployeeName;
                newRow.Cells[2].Value = this.listEmp[i].Role;
                newRow.Cells[3].Value = this.listEmp[i].Salary;
                newRow.Cells[4].Value = this.listEmp[i].Phone;
                newRow.Cells[5].Value = this.listEmp[i].Address;
                newRow.Cells[6].Value = this.listEmp[i].BirthDay;
                newRow.Cells[7].Value = this.listEmp[i].Gender;
                tblEmp.Rows.Add(newRow);
            }
        }

        private void fmEmp_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee newEmp = new Employee();
            newEmp.EmployeeName = txtName.Text;
            newEmp.Role = cbRole.SelectedItem.ToString();
            newEmp.Gender = cbGender.SelectedItem.ToString();
            newEmp.BirthDay = DateTime.Parse(dateBD.Value.ToShortDateString()).ToString("dd-MM-yyyy");
            newEmp.Salary = Int32.Parse(numSalary.Value.ToString());
            newEmp.Phone = txtPhone.Text;
            newEmp.Address = txtAdr.Text;
            DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Add new This Employee?", "Notification", MessageBoxButtons.YesNo);
            if (confimDialog == DialogResult.Yes)
            {
                string rs = controllerEmp.InsertEmp(newEmp);
                MessageBox.Show(rs, "Notification");
                ResetForm();
                LoadDBEmployee();
            }
            
        }

        private void ResetForm()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            numSalary.Value = 0;
        }

        private void tblEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            t = true;
            int index = tblEmp.CurrentCell.RowIndex;
            txtName.Text = listEmp[index].EmployeeName ;
            dateBD.Value = DateTime.Parse(listEmp[index].BirthDay);
            numSalary.Value = Int32.Parse(listEmp[index].Salary.ToString());
            txtPhone.Text = listEmp[index].Phone;
            txtAdr.Text = listEmp[index].Address;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(t)
            {
                int index = tblEmp.CurrentCell.RowIndex;
                Employee del = listEmp[index];
                DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Delete This Employee?", "Warning", MessageBoxButtons.YesNo);
                if (confimDialog == DialogResult.Yes)
                {
                    string rs = controllerEmp.DeleteEmp(del.EmployeeId);
                    MessageBox.Show(rs, "Notification");
                    ResetForm();
                    LoadDBEmployee();
                }
            }
            else
            {
                MessageBox.Show("You Must Choice One Employee","Notification");
            }
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            int index = tblEmp.CurrentCell.RowIndex;
            Employee newEmp = new Employee();
            newEmp.EmployeeId = listEmp[index].EmployeeId;
            newEmp.EmployeeName = txtName.Text;
            newEmp.Role = cbRole.SelectedItem.ToString();
            newEmp.Gender = cbGender.SelectedItem.ToString();
            newEmp.BirthDay = DateTime.Parse(dateBD.Value.ToShortDateString()).ToString("dd/MM/yyyy");
            newEmp.Salary = Int32.Parse(numSalary.Value.ToString());
            newEmp.Phone = txtPhone.Text;
            newEmp.Address = txtAdr.Text;
            DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Edit This Employee?", "Notification", MessageBoxButtons.YesNo);
            if (confimDialog == DialogResult.Yes)
            {
                string rs = controllerEmp.EditEmp(newEmp);
                MessageBox.Show(rs, "Notification");
                ResetForm();
                LoadDBEmployee();
            }
        }
    }
}
