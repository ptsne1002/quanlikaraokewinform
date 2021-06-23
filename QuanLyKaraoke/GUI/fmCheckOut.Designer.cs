
namespace GUI
{
    partial class fmCheckOut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tblRoomBooking = new System.Windows.Forms.DataGridView();
            this.RoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tblSerVice = new System.Windows.Forms.DataGridView();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtRoomCharge = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalHour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCheckOut = new System.Windows.Forms.TextBox();
            this.txtTimeBooking = new System.Windows.Forms.TextBox();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbPriceService = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbAllMoney = new System.Windows.Forms.Label();
            this.btnCreateInvoice = new Bunifu.Framework.UI.BunifuTileButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBooking)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSerVice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tblRoomBooking);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 617);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Room Is Using";
            // 
            // tblRoomBooking
            // 
            this.tblRoomBooking.AllowUserToAddRows = false;
            this.tblRoomBooking.AllowUserToDeleteRows = false;
            this.tblRoomBooking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblRoomBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRoomBooking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RoomID,
            this.NameRoom,
            this.RoomType});
            this.tblRoomBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRoomBooking.Location = new System.Drawing.Point(3, 20);
            this.tblRoomBooking.Name = "tblRoomBooking";
            this.tblRoomBooking.ReadOnly = true;
            this.tblRoomBooking.Size = new System.Drawing.Size(357, 594);
            this.tblRoomBooking.TabIndex = 0;
            this.tblRoomBooking.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblRoomBooking_CellClick);
            // 
            // RoomID
            // 
            this.RoomID.HeaderText = "Room Id";
            this.RoomID.Name = "RoomID";
            this.RoomID.ReadOnly = true;
            // 
            // NameRoom
            // 
            this.NameRoom.HeaderText = "Room Name";
            this.NameRoom.Name = "NameRoom";
            this.NameRoom.ReadOnly = true;
            // 
            // RoomType
            // 
            this.RoomType.HeaderText = "Room Type";
            this.RoomType.Name = "RoomType";
            this.RoomType.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNameCus);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtRoomCharge);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotalHour);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtCheckOut);
            this.groupBox2.Controls.Add(this.txtTimeBooking);
            this.groupBox2.Controls.Add(this.txtPH);
            this.groupBox2.Controls.Add(this.txtRoomType);
            this.groupBox2.Controls.Add(this.txtRoomName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(370, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 496);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information About Invoice";
            // 
            // txtNameCus
            // 
            this.txtNameCus.Enabled = false;
            this.txtNameCus.Location = new System.Drawing.Point(131, 48);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(132, 24);
            this.txtNameCus.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tblSerVice);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 228);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List Of Order Service ";
            // 
            // tblSerVice
            // 
            this.tblSerVice.AllowUserToAddRows = false;
            this.tblSerVice.AllowUserToDeleteRows = false;
            this.tblSerVice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblSerVice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSerVice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceName,
            this.Amount,
            this.TimOrder,
            this.unitprice,
            this.Total});
            this.tblSerVice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSerVice.Location = new System.Drawing.Point(3, 17);
            this.tblSerVice.Name = "tblSerVice";
            this.tblSerVice.ReadOnly = true;
            this.tblSerVice.Size = new System.Drawing.Size(603, 208);
            this.tblSerVice.TabIndex = 0;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // TimOrder
            // 
            this.TimOrder.HeaderText = "Time Order";
            this.TimOrder.Name = "TimOrder";
            this.TimOrder.ReadOnly = true;
            // 
            // unitprice
            // 
            this.unitprice.HeaderText = "Unit Price";
            this.unitprice.Name = "unitprice";
            this.unitprice.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Customer :";
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Enabled = false;
            this.txtRoomCharge.Location = new System.Drawing.Point(462, 225);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.Size = new System.Drawing.Size(136, 24);
            this.txtRoomCharge.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(320, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Room Charge :";
            // 
            // txtTotalHour
            // 
            this.txtTotalHour.Enabled = false;
            this.txtTotalHour.Location = new System.Drawing.Point(462, 168);
            this.txtTotalHour.Name = "txtTotalHour";
            this.txtTotalHour.Size = new System.Drawing.Size(136, 24);
            this.txtTotalHour.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Hour :";
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Enabled = false;
            this.txtCheckOut.Location = new System.Drawing.Point(462, 109);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(136, 24);
            this.txtCheckOut.TabIndex = 13;
            // 
            // txtTimeBooking
            // 
            this.txtTimeBooking.Enabled = false;
            this.txtTimeBooking.Location = new System.Drawing.Point(462, 48);
            this.txtTimeBooking.Name = "txtTimeBooking";
            this.txtTimeBooking.Size = new System.Drawing.Size(136, 24);
            this.txtTimeBooking.TabIndex = 12;
            // 
            // txtPH
            // 
            this.txtPH.Enabled = false;
            this.txtPH.Location = new System.Drawing.Point(131, 224);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(132, 24);
            this.txtPH.TabIndex = 11;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Enabled = false;
            this.txtRoomType.Location = new System.Drawing.Point(131, 168);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(132, 24);
            this.txtRoomType.TabIndex = 10;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Enabled = false;
            this.txtRoomName.Location = new System.Drawing.Point(131, 109);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(132, 24);
            this.txtRoomName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(320, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time Checkout :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(320, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time Booking :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price / Hour :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Room Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(680, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total Price Service :";
            // 
            // lbPriceService
            // 
            this.lbPriceService.AutoSize = true;
            this.lbPriceService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceService.Location = new System.Drawing.Point(863, 540);
            this.lbPriceService.Name = "lbPriceService";
            this.lbPriceService.Size = new System.Drawing.Size(27, 19);
            this.lbPriceService.TabIndex = 3;
            this.lbPriceService.Text = "$0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(583, 586);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Total Money Payable :";
            // 
            // lbAllMoney
            // 
            this.lbAllMoney.AutoSize = true;
            this.lbAllMoney.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllMoney.ForeColor = System.Drawing.Color.Crimson;
            this.lbAllMoney.Location = new System.Drawing.Point(824, 586);
            this.lbAllMoney.Name = "lbAllMoney";
            this.lbAllMoney.Size = new System.Drawing.Size(36, 25);
            this.lbAllMoney.TabIndex = 5;
            this.lbAllMoney.Text = "$0";
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCreateInvoice.color = System.Drawing.Color.SeaGreen;
            this.btnCreateInvoice.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateInvoice.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Image = global::GUI.Properties.Resources.print;
            this.btnCreateInvoice.ImagePosition = 10;
            this.btnCreateInvoice.ImageZoom = 30;
            this.btnCreateInvoice.LabelPosition = 25;
            this.btnCreateInvoice.LabelText = "Pay";
            this.btnCreateInvoice.Location = new System.Drawing.Point(412, 540);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(113, 71);
            this.btnCreateInvoice.TabIndex = 6;
            this.btnCreateInvoice.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // fmCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnCreateInvoice);
            this.Controls.Add(this.lbAllMoney);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPriceService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmCheckOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Check Out";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomBooking)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSerVice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblRoomBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomType;
        private System.Windows.Forms.TextBox txtRoomCharge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCheckOut;
        private System.Windows.Forms.TextBox txtTimeBooking;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tblSerVice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPriceService;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbAllMoney;
        private Bunifu.Framework.UI.BunifuTileButton btnCreateInvoice;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}