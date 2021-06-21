using BUS;
using DTO;
using GUI;
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
    public partial class fmCustomer : Form
    {
        private Customer_BUS controllerCus = new Customer_BUS();
        private List<Customer> listCus = new List<Customer>();
        private bool t = false;
        
        public fmCustomer()
        {
            InitializeComponent();
            LoadDBCustomer();
        }

        private void LoadDBCustomer()
        {
            tblCustomer.Rows.Clear();
            listCus = controllerCus.GetAllCustomer();
            for (int i = 0; i < listCus.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblCustomer);
                newRow.Cells[0].Value = this.listCus[i].CustomerId;
                newRow.Cells[1].Value = this.listCus[i].CustomerName;
                newRow.Cells[2].Value = this.listCus[i].Phone;
                tblCustomer.Rows.Add(newRow);
            }
        }

        private void fmCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Customer newCus = new Customer();
            newCus.CustomerName = txtName.Text;
            newCus.Phone = txtPhone.Text;
            DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Add new This Employee?", "Notification", MessageBoxButtons.YesNo);
            if (confimDialog == DialogResult.Yes)
            {
                string rs = controllerCus.InsertCus(newCus);
                MessageBox.Show(rs, "Notification");
                ResetForm();
                LoadDBCustomer();
            }

        }

        private void ResetForm()
        {
            txtName.Text = "";
            txtPhone.Text = "";
        }

        private void tblEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            t = true;
            int index = tblCustomer.CurrentCell.RowIndex;
            txtName.Text = listCus[index].CustomerName;
            txtPhone.Text = listCus[index].Phone;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(t)
            {
                int index = tblCustomer.CurrentCell.RowIndex;
                Customer del = listCus[index];
                DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Delete This Employee?", "Warning", MessageBoxButtons.YesNo);
                if (confimDialog == DialogResult.Yes)
                {
                    string rs = controllerCus.DeleteCus(del.CustomerId);
                    MessageBox.Show(rs, "Notification");
                    ResetForm();
                    LoadDBCustomer();
                }
            }
            else
            {
                MessageBox.Show("You Must Choice One Employee","Notification");
            }
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            int index = tblCustomer.CurrentCell.RowIndex;
            Customer newCus = new Customer();
            newCus.CustomerId = listCus[index].CustomerId;
            newCus.CustomerName = txtName.Text;
            newCus.Phone = txtPhone.Text;
            DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Edit This Employee?", "Notification", MessageBoxButtons.YesNo);
            if (confimDialog == DialogResult.Yes)
            {
                string rs = controllerCus.EditCus(newCus);
                MessageBox.Show(rs, "Notification");
                ResetForm();
                LoadDBCustomer();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
