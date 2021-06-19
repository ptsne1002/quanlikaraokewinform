
namespace GUI
{
    partial class fmEmp
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEmp));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdr = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dateBD = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.txtPhone = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblEmp = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpBirthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteEmp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnEditEmp = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Manager";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditEmp);
            this.groupBox1.Controls.Add(this.btnDeleteEmp);
            this.groupBox1.Controls.Add(this.txtAdr);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dateBD);
            this.groupBox1.Controls.Add(this.cbGender);
            this.groupBox1.Controls.Add(this.cbRole);
            this.groupBox1.Controls.Add(this.numSalary);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(17, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1013, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Information";
            // 
            // txtAdr
            // 
            this.txtAdr.AcceptsReturn = false;
            this.txtAdr.AcceptsTab = false;
            this.txtAdr.AnimationSpeed = 200;
            this.txtAdr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAdr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAdr.BackColor = System.Drawing.Color.Transparent;
            this.txtAdr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAdr.BackgroundImage")));
            this.txtAdr.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtAdr.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAdr.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtAdr.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtAdr.BorderRadius = 1;
            this.txtAdr.BorderThickness = 1;
            this.txtAdr.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAdr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdr.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdr.DefaultText = "";
            this.txtAdr.FillColor = System.Drawing.Color.White;
            this.txtAdr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtAdr.HideSelection = true;
            this.txtAdr.IconLeft = null;
            this.txtAdr.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdr.IconPadding = 10;
            this.txtAdr.IconRight = null;
            this.txtAdr.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdr.Lines = new string[0];
            this.txtAdr.Location = new System.Drawing.Point(857, 38);
            this.txtAdr.MaxLength = 32767;
            this.txtAdr.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtAdr.Modified = false;
            this.txtAdr.Multiline = false;
            this.txtAdr.Name = "txtAdr";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdr.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAdr.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdr.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.InfoText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtAdr.OnIdleState = stateProperties4;
            this.txtAdr.Padding = new System.Windows.Forms.Padding(3);
            this.txtAdr.PasswordChar = '\0';
            this.txtAdr.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtAdr.PlaceholderText = "Address";
            this.txtAdr.ReadOnly = false;
            this.txtAdr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdr.SelectedText = "";
            this.txtAdr.SelectionLength = 0;
            this.txtAdr.SelectionStart = 0;
            this.txtAdr.ShortcutsEnabled = true;
            this.txtAdr.Size = new System.Drawing.Size(150, 35);
            this.txtAdr.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtAdr.TabIndex = 18;
            this.txtAdr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAdr.TextMarginBottom = 0;
            this.txtAdr.TextMarginLeft = 3;
            this.txtAdr.TextMarginTop = 0;
            this.txtAdr.TextPlaceholder = "Address";
            this.txtAdr.UseSystemPasswordChar = false;
            this.txtAdr.WordWrap = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(784, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Address";
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Add Employee";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(170, 181);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 54);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateBD
            // 
            this.dateBD.BackColor = System.Drawing.Color.Transparent;
            this.dateBD.BorderRadius = 1;
            this.dateBD.Color = System.Drawing.Color.Silver;
            this.dateBD.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dateBD.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dateBD.DisabledColor = System.Drawing.Color.Gray;
            this.dateBD.DisplayWeekNumbers = false;
            this.dateBD.DPHeight = 0;
            this.dateBD.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateBD.FillDatePicker = false;
            this.dateBD.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBD.ForeColor = System.Drawing.Color.Linen;
            this.dateBD.Icon = ((System.Drawing.Image)(resources.GetObject("dateBD.Icon")));
            this.dateBD.IconColor = System.Drawing.Color.LightCyan;
            this.dateBD.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dateBD.LeftTextMargin = 5;
            this.dateBD.Location = new System.Drawing.Point(456, 109);
            this.dateBD.MinimumSize = new System.Drawing.Size(4, 32);
            this.dateBD.Name = "dateBD";
            this.dateBD.Size = new System.Drawing.Size(209, 32);
            this.dateBD.TabIndex = 15;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(607, 38);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(150, 29);
            this.cbGender.TabIndex = 14;
            this.cbGender.Text = "Male";
            // 
            // cbRole
            // 
            this.cbRole.DisplayMember = "(none)dfdfd";
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Staff",
            "Manager"});
            this.cbRole.Location = new System.Drawing.Point(327, 38);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(150, 29);
            this.cbRole.TabIndex = 13;
            this.cbRole.Text = "Staff";
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(119, 114);
            this.numSalary.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(150, 27);
            this.numSalary.TabIndex = 12;
            this.numSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPhone
            // 
            this.txtPhone.AcceptsReturn = false;
            this.txtPhone.AcceptsTab = false;
            this.txtPhone.AnimationSpeed = 200;
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtPhone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPhone.BackgroundImage")));
            this.txtPhone.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPhone.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPhone.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPhone.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPhone.BorderRadius = 1;
            this.txtPhone.BorderThickness = 1;
            this.txtPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.DefaultText = "";
            this.txtPhone.FillColor = System.Drawing.Color.White;
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPhone.HideSelection = true;
            this.txtPhone.IconLeft = null;
            this.txtPhone.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.IconPadding = 10;
            this.txtPhone.IconRight = null;
            this.txtPhone.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(818, 109);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPhone.Modified = false;
            this.txtPhone.Multiline = false;
            this.txtPhone.Name = "txtPhone";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPhone.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPhone.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPhone.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.InfoText;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPhone.OnIdleState = stateProperties8;
            this.txtPhone.Padding = new System.Windows.Forms.Padding(3);
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPhone.PlaceholderText = "01234";
            this.txtPhone.ReadOnly = false;
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(150, 35);
            this.txtPhone.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPhone.TabIndex = 11;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhone.TextMarginBottom = 0;
            this.txtPhone.TextMarginLeft = 3;
            this.txtPhone.TextMarginTop = 0;
            this.txtPhone.TextPlaceholder = "01234";
            this.txtPhone.UseSystemPasswordChar = false;
            this.txtPhone.WordWrap = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(707, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(530, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "BirthDay";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(274, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Role";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salary";
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
            this.txtName.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.txtName.Location = new System.Drawing.Point(102, 38);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtName.Modified = false;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtName.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.SystemColors.InfoText;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtName.OnIdleState = stateProperties12;
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
            this.txtName.Size = new System.Drawing.Size(150, 35);
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
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblEmp);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.groupBox2.Location = new System.Drawing.Point(0, 327);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1042, 261);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Employee";
            // 
            // tblEmp
            // 
            this.tblEmp.AllowUserToAddRows = false;
            this.tblEmp.AllowUserToDeleteRows = false;
            this.tblEmp.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.tblEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EmpName,
            this.EmpRole,
            this.EmpSalary,
            this.EmpPhone,
            this.Address,
            this.EmpBirthDay,
            this.EmpGender});
            this.tblEmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEmp.Location = new System.Drawing.Point(3, 19);
            this.tblEmp.Name = "tblEmp";
            this.tblEmp.ReadOnly = true;
            this.tblEmp.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tblEmp.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tblEmp.Size = new System.Drawing.Size(1036, 239);
            this.tblEmp.TabIndex = 0;
            this.tblEmp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEmp_CellClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 657.868F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 52;
            // 
            // EmpName
            // 
            this.EmpName.FillWeight = 19.88225F;
            this.EmpName.HeaderText = "Employee Name";
            this.EmpName.Name = "EmpName";
            this.EmpName.ReadOnly = true;
            this.EmpName.Width = 200;
            // 
            // EmpRole
            // 
            this.EmpRole.FillWeight = 19.88225F;
            this.EmpRole.HeaderText = "Role";
            this.EmpRole.Name = "EmpRole";
            this.EmpRole.ReadOnly = true;
            this.EmpRole.Width = 110;
            // 
            // EmpSalary
            // 
            this.EmpSalary.FillWeight = 19.88225F;
            this.EmpSalary.HeaderText = "Salary";
            this.EmpSalary.Name = "EmpSalary";
            this.EmpSalary.ReadOnly = true;
            this.EmpSalary.Width = 120;
            // 
            // EmpPhone
            // 
            this.EmpPhone.FillWeight = 19.88225F;
            this.EmpPhone.HeaderText = "Phone Number";
            this.EmpPhone.Name = "EmpPhone";
            this.EmpPhone.ReadOnly = true;
            this.EmpPhone.Width = 130;
            // 
            // Address
            // 
            this.Address.FillWeight = 22.8385F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // EmpBirthDay
            // 
            this.EmpBirthDay.FillWeight = 19.88225F;
            this.EmpBirthDay.HeaderText = "BirthDay";
            this.EmpBirthDay.Name = "EmpBirthDay";
            this.EmpBirthDay.ReadOnly = true;
            this.EmpBirthDay.Width = 130;
            // 
            // EmpGender
            // 
            this.EmpGender.FillWeight = 19.88225F;
            this.EmpGender.HeaderText = "Gender";
            this.EmpGender.Name = "EmpGender";
            this.EmpGender.ReadOnly = true;
            // 
            // btnDeleteEmp
            // 
            this.btnDeleteEmp.ActiveBorderThickness = 1;
            this.btnDeleteEmp.ActiveCornerRadius = 20;
            this.btnDeleteEmp.ActiveFillColor = System.Drawing.Color.Crimson;
            this.btnDeleteEmp.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteEmp.ActiveLineColor = System.Drawing.Color.Crimson;
            this.btnDeleteEmp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnDeleteEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteEmp.BackgroundImage")));
            this.btnDeleteEmp.ButtonText = "Delete Employee";
            this.btnDeleteEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteEmp.IdleBorderThickness = 1;
            this.btnDeleteEmp.IdleCornerRadius = 20;
            this.btnDeleteEmp.IdleFillColor = System.Drawing.Color.White;
            this.btnDeleteEmp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnDeleteEmp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnDeleteEmp.Location = new System.Drawing.Point(710, 181);
            this.btnDeleteEmp.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteEmp.Name = "btnDeleteEmp";
            this.btnDeleteEmp.Size = new System.Drawing.Size(181, 54);
            this.btnDeleteEmp.TabIndex = 19;
            this.btnDeleteEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteEmp.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.ActiveBorderThickness = 1;
            this.btnEditEmp.ActiveCornerRadius = 20;
            this.btnEditEmp.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnEditEmp.ActiveForecolor = System.Drawing.Color.White;
            this.btnEditEmp.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditEmp.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditEmp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditEmp.BackgroundImage")));
            this.btnEditEmp.ButtonText = "Edit Employee";
            this.btnEditEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmp.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEditEmp.IdleBorderThickness = 1;
            this.btnEditEmp.IdleCornerRadius = 20;
            this.btnEditEmp.IdleFillColor = System.Drawing.Color.White;
            this.btnEditEmp.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnEditEmp.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnEditEmp.Location = new System.Drawing.Point(440, 181);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(181, 54);
            this.btnEditEmp.TabIndex = 20;
            this.btnEditEmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // fmEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1042, 588);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fmEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Manager";
            this.Load += new System.EventHandler(this.fmEmp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView tblEmp;
        private Bunifu.UI.WinForms.BunifuDatePicker dateBD;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.NumericUpDown numSalary;
        private Bunifu.UI.WinForms.BunifuTextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuTextBox txtName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpBirthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpGender;
        private Bunifu.UI.WinForms.BunifuTextBox txtAdr;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteEmp;
        private Bunifu.Framework.UI.BunifuThinButton2 btnEditEmp;
    }
}