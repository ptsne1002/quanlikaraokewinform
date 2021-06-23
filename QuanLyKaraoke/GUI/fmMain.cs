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
        private Customer_BUS controllerCus = new Customer_BUS();
        private Customer cusUsing = new Customer();
        private List<Booking> listBooking = new List<Booking>();
        private List<Room> listRoom = new List<Room>();
        private List<Employee> listEmp = new List<Employee>();
        private Booking_BUS controllerBooking = new Booking_BUS();
        private int empIndex;
        private int roomIndex;
        public fmMain(Employee e)
        {
            currentEmp = e;
            InitializeComponent();
            Thread.Sleep(1000);
            MessageBox.Show("\t  Hello " + currentEmp.EmployeeName+ "\t\n\tWish You A Good Day!", "Wellcome to PtSKaraoke");
            timer1.Start();
            LoadDBRoom();
            LoadDBEmployee();
            LoadBooking();
        }

        private void LoadDBEmployee()
        {
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
            listRoom = controllerRoom.GetAllRoom();
            tblRoom.Rows.Clear();
            for(int i = 0; i < listRoom.Count;i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblRoom);
                newRow.Cells[0].Value = listRoom[i].RoomId;
                newRow.Cells[1].Value = listRoom[i].RoomName;
                newRow.Cells[2].Value = listRoom[i].Type;
                newRow.Cells[3].Value = listRoom[i].Status;
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
            fmCheckOut fmCheckOut = new fmCheckOut();
            fmCheckOut.ShowDialog();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            fmEmp fmEmp = new fmEmp();
            fmEmp.ShowDialog();
            LoadDBEmployee();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            fmRoom fmRoom = new fmRoom();
            fmRoom.ShowDialog();
            LoadDBRoom();
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            string phonenumber = txtPhone.Text;
            cus = controllerCus.GetCusByPhone(phonenumber);
            if(cus.CustomerName == "")
            {
                MessageBox.Show("This Is New Customer");
                btnAddCus.Enabled = true;
            }
            else
            {
                tblCustomer.Visible = true;
                tblCustomer.Rows.Clear();
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblCustomer);
                newRow.Cells[0].Value = cus.CustomerName;
                newRow.Cells[1].Value = cus.Phone;
                tblCustomer.Rows.Add(newRow);
                cusUsing = cus;
            }

        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "")
            {
                Customer newCus = new Customer();
                newCus.CustomerName = txtName.Text;
                newCus.Phone = txtPhone.Text;
                string rs = controllerCus.InsertCus(newCus);
                MessageBox.Show(rs, "Notification");
                btnSearchCus_Click(sender,e);
            }
            else
            {
                MessageBox.Show("Insufficient Information ", "Notification");
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (tblCustomer.Visible)
            {
                Employee emp = new Employee();
                Room room = new Room();
                Booking book = new Booking();
                if (listRoom[roomIndex].Status != "Busy")
                {
                    room = listRoom[roomIndex];
                    emp = listEmp[empIndex];
                    book.Cus = cusUsing;
                    book.Emp = emp;
                    book.Room = room;
                    book.Status = "Using";
                    book.TimeStart = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                    listBooking.Add(book);
                    string rs = controllerBooking.InsertBooking(book);
                    MessageBox.Show(rs, "Notification");
                    LoadDBRoom();
                    LoadDBEmployee();
                    LoadBooking();
                    tblCustomer.Visible = false;
                }
                else
                {
                    MessageBox.Show("Room is Busy", "Notification");
                }
            }
            else
            {
                MessageBox.Show("Non Customer!!", "Notification");
            }
            
        }


        public void LoadBooking()
        {
            listBooking = controllerBooking.GetBookingUsing();
            tblBooking.Rows.Clear();
            for (int i = 0; i < listBooking.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblBooking);
                newRow.Cells[0].Value = listBooking[i].Room.RoomName;
                newRow.Cells[1].Value = listBooking[i].Room.Type;
                newRow.Cells[2].Value = listBooking[i].Cus.CustomerName;
                newRow.Cells[3].Value = listBooking[i].TimeStart;
                newRow.Cells[4].Value = listBooking[i].Cus.Phone;
                newRow.Cells[5].Value = listBooking[i].Emp.EmployeeName;
                tblBooking.Rows.Add(newRow);
            }
        }

        private void tblRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomIndex = tblRoom.CurrentCell.RowIndex;
        }

        private void tblEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empIndex = tblEmp.CurrentCell.RowIndex;
        }

       

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnSearchCus_Click(sender, e);
            }    
        }
    }
}
