
namespace GUI
{
    partial class fmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmInvoice));
            this.lbAllMoney = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbPriceService = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchTop = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cbTopInvoice = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nbNum = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearchDay = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pickDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSeachPhone = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbInPhone = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnSearchAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label18 = new System.Windows.Forms.Label();
            this.lbAllIncome = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSerVice)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNum)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAllMoney
            // 
            this.lbAllMoney.AutoSize = true;
            this.lbAllMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbAllMoney.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllMoney.ForeColor = System.Drawing.Color.Crimson;
            this.lbAllMoney.Location = new System.Drawing.Point(759, 619);
            this.lbAllMoney.Name = "lbAllMoney";
            this.lbAllMoney.Size = new System.Drawing.Size(36, 25);
            this.lbAllMoney.TabIndex = 10;
            this.lbAllMoney.Text = "$0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(518, 619);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(237, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Money Payable :";
            // 
            // lbPriceService
            // 
            this.lbPriceService.AutoSize = true;
            this.lbPriceService.BackColor = System.Drawing.Color.Transparent;
            this.lbPriceService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceService.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbPriceService.Location = new System.Drawing.Point(798, 578);
            this.lbPriceService.Name = "lbPriceService";
            this.lbPriceService.Size = new System.Drawing.Size(27, 19);
            this.lbPriceService.TabIndex = 8;
            this.lbPriceService.Text = "$0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(615, 578);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total Price Service :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtCusPhone);
            this.groupBox2.Controls.Add(this.label9);
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
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(299, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(615, 520);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information About Invoice";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Enabled = false;
            this.txtCusPhone.Location = new System.Drawing.Point(462, 46);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(136, 24);
            this.txtCusPhone.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(320, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Phone Customer :";
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
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox3.Location = new System.Drawing.Point(3, 318);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(609, 199);
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
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tblSerVice.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblSerVice.Size = new System.Drawing.Size(603, 179);
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
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(8, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 21;
            this.label12.Text = "Customer :";
            // 
            // txtRoomCharge
            // 
            this.txtRoomCharge.Enabled = false;
            this.txtRoomCharge.Location = new System.Drawing.Point(324, 274);
            this.txtRoomCharge.Name = "txtRoomCharge";
            this.txtRoomCharge.Size = new System.Drawing.Size(136, 24);
            this.txtRoomCharge.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(182, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Room Charge :";
            // 
            // txtTotalHour
            // 
            this.txtTotalHour.Enabled = false;
            this.txtTotalHour.Location = new System.Drawing.Point(462, 224);
            this.txtTotalHour.Name = "txtTotalHour";
            this.txtTotalHour.Size = new System.Drawing.Size(136, 24);
            this.txtTotalHour.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(320, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 21);
            this.label6.TabIndex = 14;
            this.label6.Text = "Total Hour :";
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Enabled = false;
            this.txtCheckOut.Location = new System.Drawing.Point(462, 168);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(136, 24);
            this.txtCheckOut.TabIndex = 13;
            // 
            // txtTimeBooking
            // 
            this.txtTimeBooking.Enabled = false;
            this.txtTimeBooking.Location = new System.Drawing.Point(462, 109);
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
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(320, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Time Checkout :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(320, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Time Booking :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(6, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSearchAll);
            this.groupBox1.Controls.Add(this.btnSearchTop);
            this.groupBox1.Controls.Add(this.cbTopInvoice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.nbNum);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Location = new System.Drawing.Point(7, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 174);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Top Invoice";
            // 
            // btnSearchTop
            // 
            this.btnSearchTop.ActiveBorderThickness = 1;
            this.btnSearchTop.ActiveCornerRadius = 20;
            this.btnSearchTop.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSearchTop.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchTop.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchTop.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchTop.BackgroundImage")));
            this.btnSearchTop.ButtonText = "Search";
            this.btnSearchTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchTop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTop.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearchTop.IdleBorderThickness = 1;
            this.btnSearchTop.IdleCornerRadius = 20;
            this.btnSearchTop.IdleFillColor = System.Drawing.Color.White;
            this.btnSearchTop.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSearchTop.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchTop.Location = new System.Drawing.Point(15, 123);
            this.btnSearchTop.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchTop.Name = "btnSearchTop";
            this.btnSearchTop.Size = new System.Drawing.Size(121, 39);
            this.btnSearchTop.TabIndex = 27;
            this.btnSearchTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchTop.Click += new System.EventHandler(this.btnSearchTop_Click);
            // 
            // cbTopInvoice
            // 
            this.cbTopInvoice.FormattingEnabled = true;
            this.cbTopInvoice.Location = new System.Drawing.Point(159, 80);
            this.cbTopInvoice.Name = "cbTopInvoice";
            this.cbTopInvoice.Size = new System.Drawing.Size(121, 26);
            this.cbTopInvoice.TabIndex = 26;
            this.cbTopInvoice.Text = "Top Invoice";
            this.cbTopInvoice.SelectedIndexChanged += new System.EventHandler(this.cbTopInvoice_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(6, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Result";
            // 
            // nbNum
            // 
            this.nbNum.Location = new System.Drawing.Point(159, 36);
            this.nbNum.Name = "nbNum";
            this.nbNum.Size = new System.Drawing.Size(101, 24);
            this.nbNum.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(6, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Select Top Invoice";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnSearchDay);
            this.groupBox4.Controls.Add(this.pickDate);
            this.groupBox4.Controls.Add(this.cbDay);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox4.Location = new System.Drawing.Point(7, 252);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 176);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search Invoice By Day";
            // 
            // btnSearchDay
            // 
            this.btnSearchDay.ActiveBorderThickness = 1;
            this.btnSearchDay.ActiveCornerRadius = 20;
            this.btnSearchDay.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSearchDay.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchDay.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchDay.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchDay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchDay.BackgroundImage")));
            this.btnSearchDay.ButtonText = "Search";
            this.btnSearchDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchDay.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchDay.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearchDay.IdleBorderThickness = 1;
            this.btnSearchDay.IdleCornerRadius = 20;
            this.btnSearchDay.IdleFillColor = System.Drawing.Color.White;
            this.btnSearchDay.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSearchDay.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchDay.Location = new System.Drawing.Point(47, 127);
            this.btnSearchDay.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchDay.Name = "btnSearchDay";
            this.btnSearchDay.Size = new System.Drawing.Size(181, 41);
            this.btnSearchDay.TabIndex = 28;
            this.btnSearchDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchDay.Click += new System.EventHandler(this.btnSearchDay_Click);
            // 
            // pickDate
            // 
            this.pickDate.BackColor = System.Drawing.Color.Transparent;
            this.pickDate.BorderRadius = 1;
            this.pickDate.Color = System.Drawing.Color.Silver;
            this.pickDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.pickDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.pickDate.DisabledColor = System.Drawing.Color.Gray;
            this.pickDate.DisplayWeekNumbers = false;
            this.pickDate.DPHeight = 0;
            this.pickDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.pickDate.FillDatePicker = false;
            this.pickDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pickDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pickDate.Icon = ((System.Drawing.Image)(resources.GetObject("pickDate.Icon")));
            this.pickDate.IconColor = System.Drawing.Color.Gray;
            this.pickDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.pickDate.LeftTextMargin = 5;
            this.pickDate.Location = new System.Drawing.Point(99, 32);
            this.pickDate.MinimumSize = new System.Drawing.Size(4, 32);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(181, 32);
            this.pickDate.TabIndex = 27;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(99, 83);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(121, 26);
            this.cbDay.TabIndex = 26;
            this.cbDay.Text = "Day";
            this.cbDay.SelectedIndexChanged += new System.EventHandler(this.cbDay_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label14.Location = new System.Drawing.Point(6, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 25;
            this.label14.Text = "Result";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(6, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "Select Day";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.btnSeachPhone);
            this.groupBox5.Controls.Add(this.txtPhone);
            this.groupBox5.Controls.Add(this.cbInPhone);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox5.Location = new System.Drawing.Point(7, 465);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 179);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Search Invoice By Phone Customer";
            // 
            // btnSeachPhone
            // 
            this.btnSeachPhone.ActiveBorderThickness = 1;
            this.btnSeachPhone.ActiveCornerRadius = 20;
            this.btnSeachPhone.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSeachPhone.ActiveForecolor = System.Drawing.Color.White;
            this.btnSeachPhone.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSeachPhone.BackColor = System.Drawing.Color.Transparent;
            this.btnSeachPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeachPhone.BackgroundImage")));
            this.btnSeachPhone.ButtonText = "Search";
            this.btnSeachPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeachPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeachPhone.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSeachPhone.IdleBorderThickness = 1;
            this.btnSeachPhone.IdleCornerRadius = 20;
            this.btnSeachPhone.IdleFillColor = System.Drawing.Color.White;
            this.btnSeachPhone.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSeachPhone.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSeachPhone.Location = new System.Drawing.Point(47, 130);
            this.btnSeachPhone.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeachPhone.Name = "btnSeachPhone";
            this.btnSeachPhone.Size = new System.Drawing.Size(181, 41);
            this.btnSeachPhone.TabIndex = 28;
            this.btnSeachPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeachPhone.Click += new System.EventHandler(this.btnSeachPhone_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 35);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 24);
            this.txtPhone.TabIndex = 27;
            // 
            // cbInPhone
            // 
            this.cbInPhone.FormattingEnabled = true;
            this.cbInPhone.Location = new System.Drawing.Point(117, 86);
            this.cbInPhone.Name = "cbInPhone";
            this.cbInPhone.Size = new System.Drawing.Size(121, 26);
            this.cbInPhone.TabIndex = 26;
            this.cbInPhone.Text = "Top Invoice";
            this.cbInPhone.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label16.Location = new System.Drawing.Point(21, 88);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 25;
            this.label16.Text = "Result";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label17.Location = new System.Drawing.Point(21, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(87, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "Cus Phone";
            // 
            // btnSearchAll
            // 
            this.btnSearchAll.ActiveBorderThickness = 1;
            this.btnSearchAll.ActiveCornerRadius = 20;
            this.btnSearchAll.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnSearchAll.ActiveForecolor = System.Drawing.Color.White;
            this.btnSearchAll.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchAll.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchAll.BackgroundImage")));
            this.btnSearchAll.ButtonText = "Search All";
            this.btnSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAll.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSearchAll.IdleBorderThickness = 1;
            this.btnSearchAll.IdleCornerRadius = 20;
            this.btnSearchAll.IdleFillColor = System.Drawing.Color.White;
            this.btnSearchAll.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnSearchAll.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnSearchAll.Location = new System.Drawing.Point(146, 123);
            this.btnSearchAll.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchAll.Name = "btnSearchAll";
            this.btnSearchAll.Size = new System.Drawing.Size(121, 39);
            this.btnSearchAll.TabIndex = 28;
            this.btnSearchAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchAll.Click += new System.EventHandler(this.btnSearchAll_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label18.Location = new System.Drawing.Point(570, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 25);
            this.label18.TabIndex = 14;
            this.label18.Text = "All Income :";
            // 
            // lbAllIncome
            // 
            this.lbAllIncome.AutoSize = true;
            this.lbAllIncome.BackColor = System.Drawing.Color.Transparent;
            this.lbAllIncome.Font = new System.Drawing.Font("Century Gothic", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAllIncome.ForeColor = System.Drawing.Color.Crimson;
            this.lbAllIncome.Location = new System.Drawing.Point(710, 15);
            this.lbAllIncome.Name = "lbAllIncome";
            this.lbAllIncome.Size = new System.Drawing.Size(36, 25);
            this.lbAllIncome.TabIndex = 15;
            this.lbAllIncome.Text = "$0";
            // 
            // fmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(924, 660);
            this.Controls.Add(this.lbAllIncome);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbAllMoney);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbPriceService);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSerVice)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbNum)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAllMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbPriceService;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCusPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView tblSerVice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitprice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbTopInvoice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nbNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bunifu.UI.WinForms.BunifuDatePicker pickDate;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbInPhone;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchTop;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchDay;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSeachPhone;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSearchAll;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbAllIncome;
    }
}