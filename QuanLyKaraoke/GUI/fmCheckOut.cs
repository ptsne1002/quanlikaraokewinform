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
    public partial class fmCheckOut : Form
    {
        private Booking_BUS controllerBooking = new Booking_BUS();
        private OrderService_BUS controllerOS = new OrderService_BUS();
        private double rmCharge;
        private List<Booking> lsBooking;
        //private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public fmCheckOut()
        {
            InitializeComponent();
            LoadBooking();
        }

        public void LoadBooking()
        {
            lsBooking = controllerBooking.GetBookingUsing();
            tblRoomBooking.Rows.Clear();
            for (int i = 0; i < lsBooking.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblRoomBooking);
                newRow.Cells[0].Value = lsBooking[i].Room.RoomId;
                newRow.Cells[1].Value = lsBooking[i].Room.RoomName;
                newRow.Cells[2].Value = lsBooking[i].Room.Type;
                tblRoomBooking.Rows.Add(newRow);
            }
        }


        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadDBService(int bookingID)
        {
            tblSerVice.Rows.Clear();
            List<OrderService> lsOS = new List<OrderService>();
            lsOS = controllerOS.GetOSByBookingID(bookingID);
            lsBooking[tblRoomBooking.CurrentCell.RowIndex].LsOrder = lsOS;
            for (int i = 0; i < lsOS.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblSerVice);
                newRow.Cells[0].Value = lsOS[i].NameService;
                newRow.Cells[1].Value = lsOS[i].Amount;
                newRow.Cells[2].Value = lsOS[i].TimeCreated;
                newRow.Cells[3].Value = lsOS[i].UnitPrice.ToString("C2");
                newRow.Cells[4].Value = lsOS[i].Total.ToString("C2");
                tblSerVice.Rows.Add(newRow);
            }
        }

        private void tblRoomBooking_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            int index = tblRoomBooking.CurrentCell.RowIndex;
            txtNameCus.Text = lsBooking[index].Cus.CustomerName;
            txtRoomName.Text = lsBooking[index].Room.RoomName;
            txtRoomType.Text = lsBooking[index].Room.Type;
            txtPH.Text = lsBooking[index].Room.PricePerHours.ToString("C2");
            txtTimeBooking.Text = lsBooking[index].TimeStart;
            txtCheckOut.Text = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
            DateTime start = DateTime.ParseExact(txtTimeBooking.Text, "HH:mm dd/MM/yyyy", provider);
            DateTime end = DateTime.ParseExact(txtCheckOut.Text, "HH:mm dd/MM/yyyy", provider);
            double totalHour = Math.Round((end - start).TotalHours,1);
            txtTotalHour.Text = totalHour.ToString();
            var roomCharge =  totalHour * lsBooking[index].Room.PricePerHours;
            rmCharge = roomCharge;
            txtRoomCharge.Text = roomCharge.ToString("C2");

            //LoadDBService
            LoadDBService(lsBooking[index].BookingId);
            CaculateTotalPriceService();
        }

        private void CaculateTotalPriceService()
        {
            int totalPriceService = 0;
            int index = tblRoomBooking.CurrentCell.RowIndex;
            for (int i = 0; i < lsBooking[index].LsOrder.Count(); i++)
            {
                totalPriceService += lsBooking[index].LsOrder[i].Amount * lsBooking[index].LsOrder[i].UnitPrice;
            }
            lbPriceService.Text = totalPriceService.ToString("C2");
            double allPay = double.Parse(totalPriceService.ToString()) + rmCharge;
            lbAllMoney.Text = (allPay).ToString("C2");
        }

        
    }
}
