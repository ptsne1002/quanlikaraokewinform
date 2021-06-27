using BUS;
using DTO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmCheckOut : Form
    {
        private Booking_BUS controllerBooking = new Booking_BUS();
        private Invoice_BUS controllerInvoice = new Invoice_BUS();
        private OrderService_BUS controllerOS = new OrderService_BUS();
        private double rmCharge;
        private List<Booking> lsBooking;
        private double allPrice;
        private Employee currentEmp;
        private bool stt = false;
        //private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        public fmCheckOut(Employee c)
        {
            currentEmp = c;
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

        private void fmReset()
        {
            txtCheckOut.Text = "";
            txtNameCus.Text = "";
            txtPH.Text = "";
            txtRoomCharge.Text = "$0";
            txtRoomName.Text = "";
            txtRoomType.Text = "";
            txtTimeBooking.Text = "";
            txtTotalHour.Text = "";
            lbAllMoney.Text = "$0";
            lbPriceService.Text = "$0";
            LoadBooking();
            tblSerVice.Rows.Clear();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if(stt)
            {
                Invoice ins = new Invoice();
                int index = tblRoomBooking.CurrentCell.RowIndex;
                ins.Booking.BookingId = lsBooking[index].BookingId;
                ins.TimeEnd = DateTime.Now.ToString("HH:mm dd/MM/yyyy");
                ins.TotalPrice = allPrice;
                ins.CreatedBy = currentEmp.EmployeeId;
                string rs = controllerInvoice.InsertInvoice(ins);
                MessageBox.Show(rs, "Notification");
                PrintReport();
                fmReset();
            }
            else
            {
                MessageBox.Show("You Must Choose One Room","NOTIFICATION");
            }   
            
            
        }

        private void PrintReport()
        {
            int index = tblRoomBooking.CurrentCell.RowIndex;
            Document doc = new Document();
            string day = txtCheckOut.Text.Substring(6).Replace('/','-');
            string room = txtRoomName.Text.Replace('.', '_');
            string folder = string.Format("E:/ReportOfKaraManager/[{2}]_[{0}]_[{1}].pdf", txtRoomName.Text, day,lsBooking[index].BookingId);
            PdfWriter.GetInstance(doc, new FileStream(folder, FileMode.Create));
            doc.Open();
            string sv = "";
            
            for (int i  = 0; i < lsBooking[index].LsOrder.Count;i++)
            {
                sv += string.Format("\t\t {0}   *{1}  =  {2}\n", lsBooking[index].LsOrder[i].NameService, lsBooking[index].LsOrder[i].Amount, lsBooking[index].LsOrder[i].Total.ToString("C2"));
            }
            string nds = string.Format("__**__KARAOKE 3 BOY HANDSOME__**___\n\n" +
                                     "Time Created : {0}\n" +
                                     "Customer Name : {1}   Phone : {2}\n" +
                                     "Room : {3}-{4} Price/Hour : {5}\n" +
                                     "Time check in : {6} - Time check out : {7}\n" +
                                     "Total Hour : {8} => Room Charge : {9}\n" +
                                     "Service : \n" +
                                     "{10}\n" +
                                     "Total : {11}", txtCheckOut.Text, txtNameCus.Text, lsBooking[index].Cus.Phone,txtRoomName.Text,txtRoomType.Text,txtPH.Text,txtTimeBooking.Text,txtCheckOut.Text,txtTotalHour.Text,txtRoomCharge.Text,sv, lbAllMoney.Text);
            Paragraph line1 = new Paragraph(nds);
            doc.Add(line1);
            doc.Close();

        }


        private void LoadDBService(int bookingID)
        {
            
            List<OrderService> lsOS = new List<OrderService>();
            lsOS = controllerOS.GetOSByBookingID(bookingID);
            lsBooking[tblRoomBooking.CurrentCell.RowIndex].LsOrder = lsOS;
            tblSerVice.Rows.Clear();
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
            stt = true;
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
            allPrice = double.Parse(totalPriceService.ToString()) + rmCharge;
            lbAllMoney.Text = (allPrice).ToString("C2");
        }

        private void bunifuTileButton1_Click_1(object sender, EventArgs e)
        {
            PrintReport();
        }
    }
}
