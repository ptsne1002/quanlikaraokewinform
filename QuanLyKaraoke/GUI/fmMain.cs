using BUS;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmMain : Form
    {
        private Employee currentEmp = new Employee();
        private Room_BUS controllerRoom = new Room_BUS();
        private Employee_BUS controllerEmp = new Employee_BUS();
        private Account_BUS controllerAcc = new Account_BUS();

        public fmMain(Employee e)
        {
            currentEmp = e;
            InitializeComponent();
            Thread.Sleep(1000);
            MessageBox.Show("\t  Hello " + currentEmp.EmployeeName+ "\t\n\tWish You A Good Day!", "Wellcome to PtSKaraoke");
            LoadDBRoom();
            LoadDBEmployee();
        }

        private void LoadDBEmployee()
        {
            List<Employee> listEmp = new List<Employee>();
            listEmp = controllerEmp.GetAllEmpServe();
            tblEmp.Rows.Clear();
            for (int i = 0; i < listEmp.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblEmp);
                newRow.Cells[0].Value = listEmp[i].EmployeeId;
                newRow.Cells[1].Value = listEmp[i].EmployeeName;
                newRow.Cells[2].Value = listEmp[i].Role;
                tblEmp.Rows.Add(newRow);
            }
        }

        private void LoadDBRoom()
        {
            List<Room> listRoom = new List<Room>();
            listRoom = controllerRoom.GetAllRoom();
            tblRoom.Rows.Clear();
            for(int i = 0; i < listRoom.Count;i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblRoom);
                newRow.Cells[0].Value = listRoom[i].RoomId;
                newRow.Cells[1].Value = listRoom[i].RoomName;
                newRow.Cells[2].Value = listRoom[i].Title;
                tblRoom.Rows.Add(newRow);
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult boxLogout =  MessageBox.Show("Do You Want Go Sign Out?", "Notification!", MessageBoxButtons.YesNo);
            if(boxLogout == DialogResult.Yes)
            {
                Thread logOut = new Thread(LogOut);
                logOut.Start();
            }
        }

        private void LogOut()
        {
            this.Close();
            Application.Run(new fmLogin());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Account currentAcc = new Account();
           // MessageBox.Show(currentEmp.EmployeeId.ToString(), "ss");
            currentAcc = controllerAcc.GetAccountByIdEmp(1);
           // MessageBox.Show(currentAcc.EmployeeId.ToString(), "ss");
            fmAccount formAccount = new fmAccount(currentAcc,currentEmp);
            formAccount.ShowDialog();
        }

        private void OpenAccount()
        {
            
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            fmEmp fmEmp = new fmEmp();
            fmEmp.ShowDialog();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            fmCustomer fmCus = new fmCustomer();
            fmCus.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.facebook.com/pts1002");
        }
    }
}
