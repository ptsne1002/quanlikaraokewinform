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
    public partial class fmService : Form
    {
        private Room_BUS controllerRoom = new Room_BUS();
        private OrderService_BUS controllerOS = new OrderService_BUS();
        private Service_BUS controllerService = new Service_BUS();
        private Booking_BUS controllerBooking = new Booking_BUS();
        private List<Service> lsService = new List<Service>();
        private List<OrderService> lsOrder = new List<OrderService>();
        private List<Booking> lsBooking = new List<Booking>();
        private bool t = false;
        private bool chooseRoom = false;
        private bool chooseService = false;
        private bool checkReturn = false;
        public fmService()
        {
            lsBooking = controllerBooking.GetBookingUsing();
            InitializeComponent();
            LoadDBRoom();
            LoadDBService();
            LoadCbService();
        }

        private void LoadDBRoom()
        {
            
            for (int i = 0; i < lsBooking.Count; i++)
            {
                cbRoom.Items.Add(lsBooking[i].Room.RoomName);
            }
        }

        private void LoadCbService()
        {
            cbService.Items.Clear();
            lsService = controllerService.GetAllService();
            for (int i = 0; i < lsService.Count; i++)
            {
                cbService.Items.Add(lsService[i].ServiceName);
            }
        }

        private void LoadDBService()
        {
            lsService = controllerService.GetAllService();
            tblService.Rows.Clear();
            for (int i = 0; i < lsService.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblService);
                newRow.Cells[0].Value = lsService[i].ServiceID;
                newRow.Cells[1].Value = lsService[i].ServiceName;
                newRow.Cells[2].Value = lsService[i].Price.ToString("C2");
                tblService.Rows.Add(newRow);
            }
        }

        private void fmRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Service newService = new Service();
            newService.ServiceName = txtName.Text;
            newService.Price = int.Parse(nbPrice.Value.ToString());
            DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Add new This Service?", "Notification", MessageBoxButtons.YesNo);
            if (confimDialog == DialogResult.Yes)
            {
                string rs = controllerService.InsertService(newService);
                MessageBox.Show(rs, "Notification");
                ResetForm();
                LoadDBService();
                LoadCbService();
            }

        }

        private void ResetForm()
        {
            txtName.Text = "";
            nbPrice.Value = 0;
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(t)
            {
                int index = tblService.CurrentCell.RowIndex;
                Service del = lsService[index];
                DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Delete This Service?", "Warning", MessageBoxButtons.YesNo);
                if (confimDialog == DialogResult.Yes)
                {
                    string rs = controllerService.DeleteService(del.ServiceID);
                    MessageBox.Show(rs, "Notification");
                    ResetForm();
                    LoadDBService();
                    LoadCbService();
                }
            }
            else
            {
                MessageBox.Show("You Must Choice One Service","Notification");
            }
        }

        

        private void btnAddToList_Click(object sender, EventArgs e)
        {

        }

        private void btnEditService_Click(object sender, EventArgs e)
        {
            if(t)
            {
                int index = tblService.CurrentCell.RowIndex;
                Service newService = new Service();
                newService.ServiceID = lsService[index].ServiceID;
                newService.ServiceName = txtName.Text;
                newService.Price = int.Parse(nbPrice.Value.ToString());
                DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Edit This Service?", "Notification", MessageBoxButtons.YesNo);
                if (confimDialog == DialogResult.Yes)
                {
                    string rs = controllerService.EditService(newService);
                    MessageBox.Show(rs, "Notification");
                    ResetForm();
                    LoadDBService();
                    LoadCbService();
                }
            }
            else
            {
                MessageBox.Show("You Must Choice One Service", "Notification");
            }
            
        }

        private void tblService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            t = true;
            int index = tblService.CurrentCell.RowIndex;
            txtName.Text = lsService[index].ServiceName;
            nbPrice.Value = lsService[index].Price;



        }

        private void AddToLsOrder()
        {
            //tạo 1 orderService để lưu trữ các servicer order
            int indexService = cbService.SelectedIndex;
            int indexRoom = cbRoom.SelectedIndex;
            OrderService od = new OrderService();
            od.BookingId = lsBooking[indexRoom].BookingId;
            od.ServiceId = lsService[indexService].ServiceID;
            od.Amount = int.Parse(nbAmount.Value.ToString());
            od.UnitPrice = lsService[indexService].Price;
            od.TimeCreated = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            lsBooking[indexRoom].LsOrder.Add(od);
        }

        private void AddToTblOrderService()
        {
            int indexService = cbService.SelectedIndex;
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(tblOrder);
            newRow.Cells[0].Value = lsService[indexService].ServiceName;
            newRow.Cells[1].Value = nbAmount.Value;
            newRow.Cells[2].Value = lsService[indexService].Price.ToString("C2");
            int total = int.Parse(nbAmount.Value.ToString()) * lsService[indexService].Price;
            newRow.Cells[3].Value = total.ToString("C2");
            tblOrder.Rows.Add(newRow);
        }

        private void CaculateTotalPrice()
        {
            int totalPrice = 0;
            for (int i = 0; i < lsBooking[cbRoom.SelectedIndex].LsOrder.Count(); i++)
            {
                totalPrice += lsBooking[cbRoom.SelectedIndex].LsOrder[i].Amount * lsBooking[cbRoom.SelectedIndex].LsOrder[i].UnitPrice;
            }
            lbTotalPrice.Text = totalPrice.ToString("C2");
        }


        private void btnOrderService_Click(object sender, EventArgs e)
        {
            if(chooseRoom)
            {
                if(chooseService)
                {
                    if (nbAmount.Value > 0)
                    {
                        AddToTblOrderService();
                        AddToLsOrder();
                        CaculateTotalPrice();
                    }
                    else
                    {
                        MessageBox.Show("Amount Must Be Greater Than 0 !", "Notification");
                    }
            }
                else
                {
                    MessageBox.Show("You Must Choose Service !", "Notification");
                }
            }
            else
            {
                MessageBox.Show("You Must Choose Room !", "Notification");
            } 
            
        }

        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseRoom = true;
            tblOrder.Rows.Clear();
        }

        private void cbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            chooseService = true;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if(checkReturn)
            {
                int index = tblOrder.CurrentCell.RowIndex;
                if(lsBooking[cbRoom.SelectedIndex].LsOrder[index].Amount >1)
                {
                    lsBooking[cbRoom.SelectedIndex].LsOrder[index].Amount -= 1;
                    tblOrder.Rows[index].Cells[1].Value = lsBooking[cbRoom.SelectedIndex].LsOrder[index].Amount;
                    tblOrder.Rows[index].Cells[3].Value = 
                        (lsBooking[cbRoom.SelectedIndex].LsOrder[index].Amount * lsBooking[cbRoom.SelectedIndex].LsOrder[index].UnitPrice).ToString("C2");
                }
                else
                {
                    lsBooking[cbRoom.SelectedIndex].LsOrder.RemoveAt(index);
                    tblOrder.Rows.RemoveAt(index);
                }
                CaculateTotalPrice();


            }    
        }

        private void tblOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkReturn = true;
        }

        private void lbTotalPrice_Click(object sender, EventArgs e)
        {
            CaculateTotalPrice();
        }

        private void btnOke_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < lsBooking[cbRoom.SelectedIndex].LsOrder.Count; i++)
            {
                OrderService os = new OrderService();
                os = lsBooking[cbRoom.SelectedIndex].LsOrder[i];
                controllerOS.InsertOrderService(os);
            }
            MessageBox.Show("Done", "Notification");
        }
    }
}
