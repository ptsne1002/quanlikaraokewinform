
namespace GUI
{
    partial class fmService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmService));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nbPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditService = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteService = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblService = new System.Windows.Forms.DataGridView();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnOke = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnReturn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnOrderService = new Bunifu.Framework.UI.BunifuThinButton2();
            this.nbAmount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tblOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrice)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblService)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAmount)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.nbPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnEditService);
            this.groupBox1.Controls.Add(this.btnDeleteService);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Information";
            // 
            // nbPrice
            // 
            this.nbPrice.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nbPrice.Location = new System.Drawing.Point(372, 45);
            this.nbPrice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nbPrice.Name = "nbPrice";
            this.nbPrice.Size = new System.Drawing.Size(120, 31);
            this.nbPrice.TabIndex = 22;
            this.nbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Price";
            // 
            // btnEditService
            // 
            this.btnEditService.ActiveBorderThickness = 1;
            this.btnEditService.ActiveCornerRadius = 20;
            this.btnEditService.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEditService.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditService.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditService.BackColor = System.Drawing.Color.Transparent;
            this.btnEditService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditService.BackgroundImage")));
            this.btnEditService.ButtonText = "Edit Service";
            this.btnEditService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditService.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditService.IdleBorderThickness = 1;
            this.btnEditService.IdleCornerRadius = 20;
            this.btnEditService.IdleFillColor = System.Drawing.Color.White;
            this.btnEditService.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEditService.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditService.Location = new System.Drawing.Point(178, 129);
            this.btnEditService.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditService.Name = "btnEditService";
            this.btnEditService.Size = new System.Drawing.Size(114, 54);
            this.btnEditService.TabIndex = 20;
            this.btnEditService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditService.Click += new System.EventHandler(this.btnEditService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.ActiveBorderThickness = 1;
            this.btnDeleteService.ActiveCornerRadius = 20;
            this.btnDeleteService.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btnDeleteService.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteService.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btnDeleteService.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteService.BackgroundImage")));
            this.btnDeleteService.ButtonText = "Delete Service";
            this.btnDeleteService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteService.IdleBorderThickness = 1;
            this.btnDeleteService.IdleCornerRadius = 20;
            this.btnDeleteService.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteService.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDeleteService.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteService.Location = new System.Drawing.Point(314, 129);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(131, 54);
            this.btnDeleteService.TabIndex = 19;
            this.btnDeleteService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteService.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add Service";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(32, 129);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 54);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AnimationSpeed = 200;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtName.BorderRadius = 1;
            this.txtName.BorderThickness = 1;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.White;
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(121, 38);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Modified = false;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.InfoText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnIdleState = stateProperties4;
            this.txtName.Padding = new System.Windows.Forms.Padding(3);
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtName.PlaceholderText = "Name";
            this.txtName.ReadOnly = false;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(150, 42);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginBottom = 0;
            this.txtName.TextMarginLeft = 3;
            this.txtName.TextMarginTop = 0;
            this.txtName.TextPlaceholder = "Name";
            this.txtName.UseSystemPasswordChar = false;
            this.txtName.WordWrap = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.tblService);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Location = new System.Drawing.Point(12, 313);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 336);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Service";
            // 
            // tblService
            // 
            this.tblService.AllowUserToAddRows = false;
            this.tblService.AllowUserToDeleteRows = false;
            this.tblService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblService.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tblService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.Price});
            this.tblService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblService.Location = new System.Drawing.Point(3, 23);
            this.tblService.Name = "tblService";
            this.tblService.ReadOnly = true;
            this.tblService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tblService.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblService.Size = new System.Drawing.Size(507, 310);
            this.tblService.TabIndex = 0;
            this.tblService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblService_CellClick);
            // 
            // ServiceID
            // 
            this.ServiceID.HeaderText = "ServiceID";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Service Name";
            this.ServiceName.Name = "ServiceName";
            this.ServiceName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.btnOke);
            this.groupBox3.Controls.Add(this.lbTotalPrice);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnReturn);
            this.groupBox3.Controls.Add(this.btnOrderService);
            this.groupBox3.Controls.Add(this.nbAmount);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbService);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbRoom);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Location = new System.Drawing.Point(531, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(548, 637);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Service Select";
            // 
            // btnOke
            // 
            this.btnOke.AllowAnimations = true;
            this.btnOke.AllowMouseEffects = true;
            this.btnOke.AllowToggling = false;
            this.btnOke.AnimationSpeed = 200;
            this.btnOke.AutoGenerateColors = false;
            this.btnOke.AutoRoundBorders = false;
            this.btnOke.AutoSizeLeftIcon = true;
            this.btnOke.AutoSizeRightIcon = true;
            this.btnOke.BackColor = System.Drawing.Color.Transparent;
            this.btnOke.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.btnOke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOke.BackgroundImage")));
            this.btnOke.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOke.ButtonText = "Confirm Order";
            this.btnOke.ButtonTextMarginLeft = 0;
            this.btnOke.ColorContrastOnClick = 45;
            this.btnOke.ColorContrastOnHover = 45;
            this.btnOke.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnOke.CustomizableEdges = borderEdges1;
            this.btnOke.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOke.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOke.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOke.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOke.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnOke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOke.ForeColor = System.Drawing.Color.White;
            this.btnOke.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOke.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnOke.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOke.IconMarginLeft = 11;
            this.btnOke.IconPadding = 10;
            this.btnOke.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOke.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnOke.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOke.IconSize = 25;
            this.btnOke.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOke.IdleBorderRadius = 1;
            this.btnOke.IdleBorderThickness = 1;
            this.btnOke.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnOke.IdleIconLeftImage = null;
            this.btnOke.IdleIconRightImage = null;
            this.btnOke.IndicateFocus = false;
            this.btnOke.Location = new System.Drawing.Point(320, 537);
            this.btnOke.Name = "btnOke";
            this.btnOke.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOke.OnDisabledState.BorderRadius = 1;
            this.btnOke.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOke.OnDisabledState.BorderThickness = 1;
            this.btnOke.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnOke.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnOke.OnDisabledState.IconLeftImage = null;
            this.btnOke.OnDisabledState.IconRightImage = null;
            this.btnOke.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnOke.onHoverState.BorderRadius = 1;
            this.btnOke.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOke.onHoverState.BorderThickness = 1;
            this.btnOke.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnOke.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnOke.onHoverState.IconLeftImage = null;
            this.btnOke.onHoverState.IconRightImage = null;
            this.btnOke.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnOke.OnIdleState.BorderRadius = 1;
            this.btnOke.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOke.OnIdleState.BorderThickness = 1;
            this.btnOke.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnOke.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnOke.OnIdleState.IconLeftImage = null;
            this.btnOke.OnIdleState.IconRightImage = null;
            this.btnOke.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnOke.OnPressedState.BorderRadius = 1;
            this.btnOke.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnOke.OnPressedState.BorderThickness = 1;
            this.btnOke.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnOke.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnOke.OnPressedState.IconLeftImage = null;
            this.btnOke.OnPressedState.IconRightImage = null;
            this.btnOke.Size = new System.Drawing.Size(156, 51);
            this.btnOke.TabIndex = 22;
            this.btnOke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOke.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOke.TextMarginLeft = 0;
            this.btnOke.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOke.UseDefaultRadiusAndThickness = true;
            this.btnOke.Click += new System.EventHandler(this.btnOke_Click);
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTotalPrice.Location = new System.Drawing.Point(431, 488);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(38, 25);
            this.lbTotalPrice.TabIndex = 21;
            this.lbTotalPrice.Text = "0$";
            this.lbTotalPrice.Click += new System.EventHandler(this.lbTotalPrice_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 28);
            this.label7.TabIndex = 20;
            this.label7.Text = "Total Price :";
            // 
            // btnReturn
            // 
            this.btnReturn.ActiveBorderThickness = 1;
            this.btnReturn.ActiveCornerRadius = 20;
            this.btnReturn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.ActiveForecolor = System.Drawing.Color.White;
            this.btnReturn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.BackColor = System.Drawing.Color.Transparent;
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.ButtonText = "Return Service";
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.IdleBorderThickness = 1;
            this.btnReturn.IdleCornerRadius = 20;
            this.btnReturn.IdleFillColor = System.Drawing.Color.White;
            this.btnReturn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnReturn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnReturn.Location = new System.Drawing.Point(320, 139);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(138, 47);
            this.btnReturn.TabIndex = 19;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnOrderService
            // 
            this.btnOrderService.ActiveBorderThickness = 1;
            this.btnOrderService.ActiveCornerRadius = 20;
            this.btnOrderService.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnOrderService.ActiveForecolor = System.Drawing.Color.White;
            this.btnOrderService.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnOrderService.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOrderService.BackgroundImage")));
            this.btnOrderService.ButtonText = "Order Service";
            this.btnOrderService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrderService.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderService.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOrderService.IdleBorderThickness = 1;
            this.btnOrderService.IdleCornerRadius = 20;
            this.btnOrderService.IdleFillColor = System.Drawing.Color.White;
            this.btnOrderService.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnOrderService.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnOrderService.Location = new System.Drawing.Point(52, 139);
            this.btnOrderService.Margin = new System.Windows.Forms.Padding(5);
            this.btnOrderService.Name = "btnOrderService";
            this.btnOrderService.Size = new System.Drawing.Size(136, 47);
            this.btnOrderService.TabIndex = 18;
            this.btnOrderService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOrderService.Click += new System.EventHandler(this.btnOrderService_Click);
            // 
            // nbAmount
            // 
            this.nbAmount.Location = new System.Drawing.Point(417, 91);
            this.nbAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nbAmount.Name = "nbAmount";
            this.nbAmount.Size = new System.Drawing.Size(120, 27);
            this.nbAmount.TabIndex = 17;
            this.nbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Choose Service :";
            // 
            // cbService
            // 
            this.cbService.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbService.FormattingEnabled = true;
            this.cbService.Location = new System.Drawing.Point(166, 88);
            this.cbService.Name = "cbService";
            this.cbService.Size = new System.Drawing.Size(132, 28);
            this.cbService.TabIndex = 14;
            this.cbService.Text = "Chose Service";
            this.cbService.SelectedIndexChanged += new System.EventHandler(this.cbService_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choose Room :";
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(166, 34);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(121, 29);
            this.cbRoom.TabIndex = 7;
            this.cbRoom.Text = "Chose Room";
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.tblOrder);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox4.Location = new System.Drawing.Point(6, 203);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(548, 272);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "List Order Service";
            // 
            // tblOrder
            // 
            this.tblOrder.AllowUserToAddRows = false;
            this.tblOrder.AllowUserToDeleteRows = false;
            this.tblOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblOrder.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.tblOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Amount,
            this.dataGridViewTextBoxColumn3,
            this.Total});
            this.tblOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblOrder.Location = new System.Drawing.Point(3, 19);
            this.tblOrder.Name = "tblOrder";
            this.tblOrder.ReadOnly = true;
            this.tblOrder.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.tblOrder.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblOrder.Size = new System.Drawing.Size(542, 250);
            this.tblOrder.TabIndex = 0;
            this.tblOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblOrder_CellClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Service Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Unit Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // fmService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Manager";
            this.Load += new System.EventHandler(this.fmRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbPrice)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblService)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbAmount)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblService;
        private Bunifu.UI.WinForms.BunifuTextBox txtName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteService;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditService;
        private System.Windows.Forms.NumericUpDown nbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView tblOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReturn;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOrderService;
        private System.Windows.Forms.NumericUpDown nbAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbService;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnOke;
    }
}