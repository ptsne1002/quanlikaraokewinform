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
    public partial class fmRoom : Form
    {
        private Room_BUS controllerRoom = new Room_BUS();
        private List<Room> listRoom = new List<Room>();
        private bool t = false;
        
        public fmRoom()
        {
            InitializeComponent();
            LoadDBRoom();
        }

        private void LoadDBRoom()
        {
            tblRoom.Rows.Clear();
            listRoom = controllerRoom.GetAllRoom();
            for (int i = 0; i < listRoom.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(tblRoom);
                newRow.Cells[0].Value = this.listRoom[i].RoomId;
                newRow.Cells[1].Value = this.listRoom[i].RoomName;
                newRow.Cells[2].Value = this.listRoom[i].Type;
                newRow.Cells[3].Value = this.listRoom[i].PricePerHours;
                newRow.Cells[4].Value = this.listRoom[i].Status;

                tblRoom.Rows.Add(newRow);
            }
        }

        private void fmRoom_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Room newRoom = new Room();
            newRoom.RoomName = txtName.Text;
            newRoom.Type = cbType.SelectedItem.ToString() ;
            DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Add new This Room?", "Notification", MessageBoxButtons.YesNo);
            if (confimDialog == DialogResult.Yes)
            {
                string rs = controllerRoom.InsertRoom(newRoom);
                MessageBox.Show(rs, "Notification");
                ResetForm();
                LoadDBRoom();
            }

        }

        private void ResetForm()
        {
            txtName.Text = "";
        }

        private void tblEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            t = true;
            int index = tblRoom.CurrentCell.RowIndex;
            txtName.Text = listRoom[index].RoomName;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(t)
            {
                int index = tblRoom.CurrentCell.RowIndex;
                Room del = listRoom[index];
                DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Delete This Room?", "Warning", MessageBoxButtons.YesNo);
                if (confimDialog == DialogResult.Yes)
                {
                    string rs = controllerRoom.DeleteRoom(del.RoomId);
                    MessageBox.Show(rs, "Notification");
                    ResetForm();
                    LoadDBRoom();
                }
            }
            else
            {
                MessageBox.Show("You Must Choice One Room","Notification");
            }
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            int index = tblRoom.CurrentCell.RowIndex;
            Room newRoom = new Room();
            newRoom.RoomId = listRoom[index].RoomId;
            newRoom.RoomName = txtName.Text;
            newRoom.Type = cbType.SelectedItem.ToString();
            DialogResult confimDialog = MessageBox.Show("Are You Sure Want To Edit This Room?", "Notification", MessageBoxButtons.YesNo);
            if (confimDialog == DialogResult.Yes)
            {
                string rs = controllerRoom.EditRoom(newRoom);
                MessageBox.Show(rs, "Notification");
                ResetForm();
                LoadDBRoom();
            }
        }

        
    }
}
