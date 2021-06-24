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
    public partial class fmInvoice : Form
    {
        private Invoice_BUS controllerInvoice = new Invoice_BUS();
        private List<Invoice> lsTopInvoice = new List<Invoice>();
        private List<Invoice> lsInvoiceByCus = new List<Invoice>();
        private List<Invoice> lsInvoiceByDay = new List<Invoice>();
        private OrderService_BUS controllerOS = new OrderService_BUS();
        private double rmCharge;
        public fmInvoice()
        {
            InitializeComponent();
        }

        

        private void btnSearchTop_Click(object sender, EventArgs e)
        {
            cbTopInvoice.Items.Clear();
            int number = int.Parse(nbNum.Value.ToString());
            lsTopInvoice = controllerInvoice.GetTopInvoice(number);
            for(int i  = 1; i < lsTopInvoice.Count + 1;i++)
            {
                string n = "Top " + i;
                cbTopInvoice.Items.Add(n);
            }

        }

        private void cbTopInvoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            int index = cbTopInvoice.SelectedIndex;
            txtNameCus.Text = lsTopInvoice[index].Booking.Cus.CustomerName;
            txtRoomName.Text = lsTopInvoice[index].Booking.Room.RoomName;
            txtRoomType.Text = lsTopInvoice[index].Booking.Room.Type;
            txtCusPhone.Text = lsTopInvoice[index].Booking.Cus.Phone;
            txtPH.Text = lsTopInvoice[index].Booking.Room.PricePerHours.ToString("C2");
            txtTimeBooking.Text = lsTopInvoice[index].Booking.TimeStart;
            txtCheckOut.Text = lsTopInvoice[index].TimeEnd;
            DateTime start = DateTime.ParseExact(txtTimeBooking.Text, "HH:mm dd/MM/yyyy", provider);
            DateTime end = DateTime.ParseExact(txtCheckOut.Text, "HH:mm dd/MM/yyyy", provider);
            double totalHour = Math.Round((end - start).TotalHours,1);
            txtTotalHour.Text = totalHour.ToString();
            var roomCharge =  totalHour * lsTopInvoice[index].Booking.Room.PricePerHours;
            rmCharge = roomCharge;
            txtRoomCharge.Text = roomCharge.ToString("C2");
            loadDBSerVice(1, index);
            CaculateTotalPriceService(1, index);
        }

        private void loadDBSerVice(int type,int index)
        {
            if(type == 1)
            {
                lsTopInvoice[index].Booking.LsOrder = controllerOS.GetOSByBookingID(lsTopInvoice[index].Booking.BookingId);
                tblSerVice.Rows.Clear();
                for (int i = 0; i < lsTopInvoice[index].Booking.LsOrder.Count; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(tblSerVice);
                    newRow.Cells[0].Value = lsTopInvoice[index].Booking.LsOrder[i].NameService;
                    newRow.Cells[1].Value = lsTopInvoice[index].Booking.LsOrder[i].Amount;
                    newRow.Cells[2].Value = lsTopInvoice[index].Booking.LsOrder[i].TimeCreated;
                    newRow.Cells[3].Value = lsTopInvoice[index].Booking.LsOrder[i].UnitPrice.ToString("C2");
                    newRow.Cells[4].Value = lsTopInvoice[index].Booking.LsOrder[i].Total.ToString("C2");
                    tblSerVice.Rows.Add(newRow);
                }
            }else if(type == 2)
            {
                lsInvoiceByDay[index].Booking.LsOrder = controllerOS.GetOSByBookingID(lsInvoiceByDay[index].Booking.BookingId);
                tblSerVice.Rows.Clear();
                for (int i = 0; i < lsInvoiceByDay[index].Booking.LsOrder.Count; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(tblSerVice);
                    newRow.Cells[0].Value = lsInvoiceByDay[index].Booking.LsOrder[i].NameService;
                    newRow.Cells[1].Value = lsInvoiceByDay[index].Booking.LsOrder[i].Amount;
                    newRow.Cells[2].Value = lsInvoiceByDay[index].Booking.LsOrder[i].TimeCreated;
                    newRow.Cells[3].Value = lsInvoiceByDay[index].Booking.LsOrder[i].UnitPrice.ToString("C2");
                    newRow.Cells[4].Value = lsInvoiceByDay[index].Booking.LsOrder[i].Total.ToString("C2");
                    tblSerVice.Rows.Add(newRow);
                }
            }else if(type ==3)
            {
                lsInvoiceByCus[index].Booking.LsOrder = controllerOS.GetOSByBookingID(lsInvoiceByCus[index].Booking.BookingId);
                tblSerVice.Rows.Clear();
                for (int i = 0; i < lsInvoiceByCus[index].Booking.LsOrder.Count; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(tblSerVice);
                    newRow.Cells[0].Value = lsInvoiceByCus[index].Booking.LsOrder[i].NameService;
                    newRow.Cells[1].Value = lsInvoiceByCus[index].Booking.LsOrder[i].Amount;
                    newRow.Cells[2].Value = lsInvoiceByCus[index].Booking.LsOrder[i].TimeCreated;
                    newRow.Cells[3].Value = lsInvoiceByCus[index].Booking.LsOrder[i].UnitPrice.ToString("C2");
                    newRow.Cells[4].Value = lsInvoiceByCus[index].Booking.LsOrder[i].Total.ToString("C2");
                    tblSerVice.Rows.Add(newRow);
                }
            }    
        }    

        private void CaculateTotalPriceService(int type, int index)
        {

            int totalPriceService = 0;
            if (type == 1)
            {
                for (int i = 0; i < lsTopInvoice[index].Booking.LsOrder.Count(); i++)
                {
                    totalPriceService += lsTopInvoice[index].Booking.LsOrder[i].Amount * lsTopInvoice[index].Booking.LsOrder[i].UnitPrice;
                }
                lbPriceService.Text = totalPriceService.ToString("C2");
                double allPrice = double.Parse(totalPriceService.ToString()) + rmCharge;
                lbAllMoney.Text = (allPrice).ToString("C2");
            }else if(type == 2)
            {
                for (int i = 0; i < lsInvoiceByDay[index].Booking.LsOrder.Count(); i++)
                {
                    totalPriceService += lsInvoiceByDay[index].Booking.LsOrder[i].Amount * lsInvoiceByDay[index].Booking.LsOrder[i].UnitPrice;
                }
                lbPriceService.Text = totalPriceService.ToString("C2");
                double allPrice = double.Parse(totalPriceService.ToString()) + rmCharge;
                lbAllMoney.Text = (allPrice).ToString("C2");
            }else if(type ==3)
            {
                for (int i = 0; i < lsInvoiceByCus[index].Booking.LsOrder.Count(); i++)
                {
                    totalPriceService += lsInvoiceByCus[index].Booking.LsOrder[i].Amount * lsInvoiceByCus[index].Booking.LsOrder[i].UnitPrice;
                }
                lbPriceService.Text = totalPriceService.ToString("C2");
                double allPrice = double.Parse(totalPriceService.ToString()) + rmCharge;
                lbAllMoney.Text = (allPrice).ToString("C2");
            }    
        }

        private void btnSearchDay_Click(object sender, EventArgs e)
        {
            string day = pickDate.Value.ToString("dd/MM/yyyy");
            cbDay.Items.Clear();
            lsInvoiceByDay = controllerInvoice.GetInvoiceByDay(day);
            if (lsInvoiceByDay.Count < 1)
            {
                MessageBox.Show("Not Found Invoice", "Notification");
            }
            for (int i = 0; i < lsInvoiceByDay.Count; i++)
            {

                cbDay.Items.Add(lsInvoiceByDay[i].TimeEnd);
            }
        }

        private void cbDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            int index = cbDay.SelectedIndex;
            txtNameCus.Text = lsInvoiceByDay[index].Booking.Cus.CustomerName;
            txtRoomName.Text = lsInvoiceByDay[index].Booking.Room.RoomName;
            txtRoomType.Text = lsInvoiceByDay[index].Booking.Room.Type;
            txtCusPhone.Text = lsInvoiceByDay[index].Booking.Cus.Phone;
            txtPH.Text = lsInvoiceByDay[index].Booking.Room.PricePerHours.ToString("C2");
            txtTimeBooking.Text = lsInvoiceByDay[index].Booking.TimeStart;
            txtCheckOut.Text = lsInvoiceByDay[index].TimeEnd;
            DateTime start = DateTime.ParseExact(txtTimeBooking.Text, "HH:mm dd/MM/yyyy", provider);
            DateTime end = DateTime.ParseExact(txtCheckOut.Text, "HH:mm dd/MM/yyyy", provider);
            double totalHour = Math.Round((end - start).TotalHours, 1);
            txtTotalHour.Text = totalHour.ToString();
            var roomCharge = totalHour * lsInvoiceByDay[index].Booking.Room.PricePerHours;
            rmCharge = roomCharge;
            txtRoomCharge.Text = roomCharge.ToString("C2");
            loadDBSerVice(2, index);
            CaculateTotalPriceService(2, index);
        }

        private void btnSeachPhone_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            cbInPhone.Items.Clear();
            lsInvoiceByCus = controllerInvoice.GetInvoiceByCusPhone(phone);
            if (lsInvoiceByCus.Count < 1)
            {
                MessageBox.Show("Not Found Invoice", "Notification");
            }
            for (int i = 0; i < lsInvoiceByCus.Count; i++)
            {

                cbInPhone.Items.Add(lsInvoiceByDay[i].TimeEnd);
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            int index = cbInPhone.SelectedIndex;
            txtNameCus.Text = lsInvoiceByCus[index].Booking.Cus.CustomerName;
            txtRoomName.Text = lsInvoiceByCus[index].Booking.Room.RoomName;
            txtRoomType.Text = lsInvoiceByCus[index].Booking.Room.Type;
            txtPH.Text = lsInvoiceByCus[index].Booking.Room.PricePerHours.ToString("C2");
            txtCusPhone.Text = lsInvoiceByCus[index].Booking.Cus.Phone;
            txtTimeBooking.Text = lsInvoiceByCus[index].Booking.TimeStart;
            txtCheckOut.Text = lsInvoiceByCus[index].TimeEnd;
            DateTime start = DateTime.ParseExact(txtTimeBooking.Text, "HH:mm dd/MM/yyyy", provider);
            DateTime end = DateTime.ParseExact(txtCheckOut.Text, "HH:mm dd/MM/yyyy", provider);
            double totalHour = Math.Round((end - start).TotalHours, 1);
            txtTotalHour.Text = totalHour.ToString();
            var roomCharge = totalHour * lsInvoiceByCus[index].Booking.Room.PricePerHours;
            rmCharge = roomCharge;
            txtRoomCharge.Text = roomCharge.ToString("C2");
            loadDBSerVice(3, index);
            CaculateTotalPriceService(3, index);
        }
    }
}
