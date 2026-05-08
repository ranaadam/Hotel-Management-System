namespace HotelManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.welcomePage = new System.Windows.Forms.TabPage();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCheckOutPanel = new System.Windows.Forms.Button();
            this.btnSearchGuestPanel = new System.Windows.Forms.Button();
            this.btnViewGuestsPanel = new System.Windows.Forms.Button();
            this.btnGoToAddGuest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addGuestPage = new System.Windows.Forms.TabPage();
            this.panelAddGuest = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.AddGuestlabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.viewGuestsPage = new System.Windows.Forms.TabPage();
            this.panelViewGuests = new System.Windows.Forms.Panel();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.viewGuests = new System.Windows.Forms.Label();
            this.backButton2 = new System.Windows.Forms.Button();
            this.searchGuestPage = new System.Windows.Forms.TabPage();
            this.searchguestpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackSearch = new System.Windows.Forms.Button();
            this.btnSearchGuest = new System.Windows.Forms.Button();
            this.dgvSearchGuests = new System.Windows.Forms.DataGridView();
            this.textBoxRoomSearch = new System.Windows.Forms.TextBox();
            this.textBoxNameSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lablNameSearch = new System.Windows.Forms.Label();
            this.checkoutPage = new System.Windows.Forms.TabPage();
            this.checkoutpanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBackCheckout = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.dgvCheckout = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.welcomePage.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.addGuestPage.SuspendLayout();
            this.panelAddGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.viewGuestsPage.SuspendLayout();
            this.panelViewGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.searchGuestPage.SuspendLayout();
            this.searchguestpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGuests)).BeginInit();
            this.checkoutPage.SuspendLayout();
            this.checkoutpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.welcomePage);
            this.tabControl1.Controls.Add(this.addGuestPage);
            this.tabControl1.Controls.Add(this.viewGuestsPage);
            this.tabControl1.Controls.Add(this.searchGuestPage);
            this.tabControl1.Controls.Add(this.checkoutPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1309, 674);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            this.tabControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseDoubleClick);
            // 
            // welcomePage
            // 
            this.welcomePage.Controls.Add(this.panelWelcome);
            this.welcomePage.Location = new System.Drawing.Point(4, 29);
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Padding = new System.Windows.Forms.Padding(3);
            this.welcomePage.Size = new System.Drawing.Size(1301, 641);
            this.welcomePage.TabIndex = 0;
            this.welcomePage.Text = "Welcome";
            this.welcomePage.UseVisualStyleBackColor = true;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelWelcome.Controls.Add(this.pictureBox1);
            this.panelWelcome.Controls.Add(this.btnCheckOutPanel);
            this.panelWelcome.Controls.Add(this.btnSearchGuestPanel);
            this.panelWelcome.Controls.Add(this.btnViewGuestsPanel);
            this.panelWelcome.Controls.Add(this.btnGoToAddGuest);
            this.panelWelcome.Controls.Add(this.label1);
            this.panelWelcome.Controls.Add(this.pictureBox2);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWelcome.Location = new System.Drawing.Point(3, 3);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1295, 635);
            this.panelWelcome.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckOutPanel
            // 
            this.btnCheckOutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOutPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCheckOutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOutPanel.Location = new System.Drawing.Point(879, 381);
            this.btnCheckOutPanel.Name = "btnCheckOutPanel";
            this.btnCheckOutPanel.Size = new System.Drawing.Size(190, 70);
            this.btnCheckOutPanel.TabIndex = 4;
            this.btnCheckOutPanel.Text = "Check Out";
            this.btnCheckOutPanel.UseVisualStyleBackColor = false;
            this.btnCheckOutPanel.Click += new System.EventHandler(this.btnCheckOutPanel_Click);
            // 
            // btnSearchGuestPanel
            // 
            this.btnSearchGuestPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchGuestPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearchGuestPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGuestPanel.Location = new System.Drawing.Point(674, 381);
            this.btnSearchGuestPanel.Name = "btnSearchGuestPanel";
            this.btnSearchGuestPanel.Size = new System.Drawing.Size(190, 70);
            this.btnSearchGuestPanel.TabIndex = 3;
            this.btnSearchGuestPanel.Text = "Search Guest";
            this.btnSearchGuestPanel.UseVisualStyleBackColor = false;
            this.btnSearchGuestPanel.Click += new System.EventHandler(this.btnSearchGuestPanel_Click);
            // 
            // btnViewGuestsPanel
            // 
            this.btnViewGuestsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewGuestsPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.btnViewGuestsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGuestsPanel.Location = new System.Drawing.Point(466, 381);
            this.btnViewGuestsPanel.Name = "btnViewGuestsPanel";
            this.btnViewGuestsPanel.Size = new System.Drawing.Size(190, 70);
            this.btnViewGuestsPanel.TabIndex = 2;
            this.btnViewGuestsPanel.Text = "View Guests";
            this.btnViewGuestsPanel.UseVisualStyleBackColor = false;
            this.btnViewGuestsPanel.Click += new System.EventHandler(this.btnViewGuestsPanel_Click);
            // 
            // btnGoToAddGuest
            // 
            this.btnGoToAddGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToAddGuest.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGoToAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAddGuest.Location = new System.Drawing.Point(258, 381);
            this.btnGoToAddGuest.Name = "btnGoToAddGuest";
            this.btnGoToAddGuest.Size = new System.Drawing.Size(190, 70);
            this.btnGoToAddGuest.TabIndex = 1;
            this.btnGoToAddGuest.Text = "Add Guest";
            this.btnGoToAddGuest.UseVisualStyleBackColor = false;
            this.btnGoToAddGuest.Click += new System.EventHandler(this.btnGoToAddGuest_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Hotel Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-16, 290);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(376, 389);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // addGuestPage
            // 
            this.addGuestPage.Controls.Add(this.panelAddGuest);
            this.addGuestPage.Location = new System.Drawing.Point(4, 29);
            this.addGuestPage.Name = "addGuestPage";
            this.addGuestPage.Padding = new System.Windows.Forms.Padding(3);
            this.addGuestPage.Size = new System.Drawing.Size(1301, 641);
            this.addGuestPage.TabIndex = 1;
            this.addGuestPage.Text = "Add Guest";
            this.addGuestPage.UseVisualStyleBackColor = true;
            // 
            // panelAddGuest
            // 
            this.panelAddGuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddGuest.Controls.Add(this.txtEmail);
            this.panelAddGuest.Controls.Add(this.lblEmail);
            this.panelAddGuest.Controls.Add(this.pictureBox3);
            this.panelAddGuest.Controls.Add(this.AddGuestlabel);
            this.panelAddGuest.Controls.Add(this.btnBack);
            this.panelAddGuest.Controls.Add(this.btnAddGuest);
            this.panelAddGuest.Controls.Add(this.txtRoomNumber);
            this.panelAddGuest.Controls.Add(this.lblDate);
            this.panelAddGuest.Controls.Add(this.lblRoom);
            this.panelAddGuest.Controls.Add(this.dtpCheckIn);
            this.panelAddGuest.Controls.Add(this.txtName);
            this.panelAddGuest.Controls.Add(this.lblName);
            this.panelAddGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAddGuest.Location = new System.Drawing.Point(3, 3);
            this.panelAddGuest.Name = "panelAddGuest";
            this.panelAddGuest.Size = new System.Drawing.Size(1295, 635);
            this.panelAddGuest.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.Location = new System.Drawing.Point(413, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 35);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(175, 266);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 32);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(795, 66);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(363, 482);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // AddGuestlabel
            // 
            this.AddGuestlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddGuestlabel.AutoSize = true;
            this.AddGuestlabel.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuestlabel.Location = new System.Drawing.Point(293, 66);
            this.AddGuestlabel.Name = "AddGuestlabel";
            this.AddGuestlabel.Size = new System.Drawing.Size(244, 55);
            this.AddGuestlabel.TabIndex = 8;
            this.AddGuestlabel.Text = "Add Guest";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(416, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(216, 51);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddGuest.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(181, 490);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(216, 51);
            this.btnAddGuest.TabIndex = 6;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            this.btnAddGuest.Click += new System.EventHandler(this.btnAddGuest_Click);
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRoomNumber.Location = new System.Drawing.Point(413, 336);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(219, 35);
            this.txtRoomNumber.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(175, 407);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(215, 32);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Check-In Date:";
            // 
            // lblRoom
            // 
            this.lblRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(175, 339);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(216, 32);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Room Number:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(413, 404);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(219, 35);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(413, 193);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 35);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(175, 193);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Guest Name:";
            // 
            // viewGuestsPage
            // 
            this.viewGuestsPage.Controls.Add(this.panelViewGuests);
            this.viewGuestsPage.Location = new System.Drawing.Point(4, 29);
            this.viewGuestsPage.Name = "viewGuestsPage";
            this.viewGuestsPage.Padding = new System.Windows.Forms.Padding(3);
            this.viewGuestsPage.Size = new System.Drawing.Size(1301, 641);
            this.viewGuestsPage.TabIndex = 2;
            this.viewGuestsPage.Text = "View Guests";
            this.viewGuestsPage.UseVisualStyleBackColor = true;
            // 
            // panelViewGuests
            // 
            this.panelViewGuests.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelViewGuests.Controls.Add(this.dgvGuests);
            this.panelViewGuests.Controls.Add(this.viewGuests);
            this.panelViewGuests.Controls.Add(this.backButton2);
            this.panelViewGuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelViewGuests.Location = new System.Drawing.Point(3, 3);
            this.panelViewGuests.Name = "panelViewGuests";
            this.panelViewGuests.Size = new System.Drawing.Size(1295, 635);
            this.panelViewGuests.TabIndex = 19;
            // 
            // dgvGuests
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvGuests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGuests.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGuests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(78, 123);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowHeadersWidth = 62;
            this.dgvGuests.RowTemplate.Height = 28;
            this.dgvGuests.Size = new System.Drawing.Size(1133, 411);
            this.dgvGuests.TabIndex = 10;
            // 
            // viewGuests
            // 
            this.viewGuests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewGuests.AutoSize = true;
            this.viewGuests.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewGuests.Location = new System.Drawing.Point(523, 36);
            this.viewGuests.Name = "viewGuests";
            this.viewGuests.Size = new System.Drawing.Size(275, 55);
            this.viewGuests.TabIndex = 9;
            this.viewGuests.Text = "View Guests";
            // 
            // backButton2
            // 
            this.backButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton2.BackColor = System.Drawing.Color.RosyBrown;
            this.backButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton2.Location = new System.Drawing.Point(560, 556);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(216, 51);
            this.backButton2.TabIndex = 7;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = false;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // searchGuestPage
            // 
            this.searchGuestPage.Controls.Add(this.searchguestpanel);
            this.searchGuestPage.Location = new System.Drawing.Point(4, 29);
            this.searchGuestPage.Name = "searchGuestPage";
            this.searchGuestPage.Padding = new System.Windows.Forms.Padding(3);
            this.searchGuestPage.Size = new System.Drawing.Size(1301, 641);
            this.searchGuestPage.TabIndex = 3;
            this.searchGuestPage.Text = "Search Guest";
            this.searchGuestPage.UseVisualStyleBackColor = true;
            // 
            // searchguestpanel
            // 
            this.searchguestpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchguestpanel.Controls.Add(this.label2);
            this.searchguestpanel.Controls.Add(this.btnBackSearch);
            this.searchguestpanel.Controls.Add(this.btnSearchGuest);
            this.searchguestpanel.Controls.Add(this.dgvSearchGuests);
            this.searchguestpanel.Controls.Add(this.textBoxRoomSearch);
            this.searchguestpanel.Controls.Add(this.textBoxNameSearch);
            this.searchguestpanel.Controls.Add(this.label3);
            this.searchguestpanel.Controls.Add(this.lablNameSearch);
            this.searchguestpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchguestpanel.Location = new System.Drawing.Point(3, 3);
            this.searchguestpanel.Name = "searchguestpanel";
            this.searchguestpanel.Size = new System.Drawing.Size(1295, 635);
            this.searchguestpanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 55);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search Guests";
            // 
            // btnBackSearch
            // 
            this.btnBackSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBackSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSearch.Location = new System.Drawing.Point(682, 244);
            this.btnBackSearch.Name = "btnBackSearch";
            this.btnBackSearch.Size = new System.Drawing.Size(193, 51);
            this.btnBackSearch.TabIndex = 8;
            this.btnBackSearch.Text = "Back";
            this.btnBackSearch.UseVisualStyleBackColor = false;
            this.btnBackSearch.Click += new System.EventHandler(this.btnBackSearch_Click);
            // 
            // btnSearchGuest
            // 
            this.btnSearchGuest.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearchGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGuest.Location = new System.Drawing.Point(446, 244);
            this.btnSearchGuest.Name = "btnSearchGuest";
            this.btnSearchGuest.Size = new System.Drawing.Size(193, 51);
            this.btnSearchGuest.TabIndex = 6;
            this.btnSearchGuest.Text = "Search Guest";
            this.btnSearchGuest.UseVisualStyleBackColor = false;
            this.btnSearchGuest.Click += new System.EventHandler(this.btnSearchGuest_Click);
            // 
            // dgvSearchGuests
            // 
            this.dgvSearchGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchGuests.Location = new System.Drawing.Point(90, 326);
            this.dgvSearchGuests.Name = "dgvSearchGuests";
            this.dgvSearchGuests.RowHeadersWidth = 62;
            this.dgvSearchGuests.RowTemplate.Height = 28;
            this.dgvSearchGuests.Size = new System.Drawing.Size(1114, 261);
            this.dgvSearchGuests.TabIndex = 5;
            // 
            // textBoxRoomSearch
            // 
            this.textBoxRoomSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRoomSearch.Location = new System.Drawing.Point(956, 146);
            this.textBoxRoomSearch.Name = "textBoxRoomSearch";
            this.textBoxRoomSearch.Size = new System.Drawing.Size(193, 35);
            this.textBoxRoomSearch.TabIndex = 4;
            // 
            // textBoxNameSearch
            // 
            this.textBoxNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNameSearch.Location = new System.Drawing.Point(349, 140);
            this.textBoxNameSearch.Name = "textBoxNameSearch";
            this.textBoxNameSearch.Size = new System.Drawing.Size(193, 35);
            this.textBoxNameSearch.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(728, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Number: ";
            // 
            // lablNameSearch
            // 
            this.lablNameSearch.AutoSize = true;
            this.lablNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablNameSearch.Location = new System.Drawing.Point(132, 143);
            this.lablNameSearch.Name = "lablNameSearch";
            this.lablNameSearch.Size = new System.Drawing.Size(194, 32);
            this.lablNameSearch.TabIndex = 1;
            this.lablNameSearch.Text = " Guest Name: ";
            // 
            // checkoutPage
            // 
            this.checkoutPage.Controls.Add(this.checkoutpanel);
            this.checkoutPage.Location = new System.Drawing.Point(4, 29);
            this.checkoutPage.Name = "checkoutPage";
            this.checkoutPage.Padding = new System.Windows.Forms.Padding(3);
            this.checkoutPage.Size = new System.Drawing.Size(1301, 641);
            this.checkoutPage.TabIndex = 4;
            this.checkoutPage.Text = "Checkout";
            this.checkoutPage.UseVisualStyleBackColor = true;
            // 
            // checkoutpanel
            // 
            this.checkoutpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkoutpanel.Controls.Add(this.label4);
            this.checkoutpanel.Controls.Add(this.btnBackCheckout);
            this.checkoutpanel.Controls.Add(this.btnCheckout);
            this.checkoutpanel.Controls.Add(this.dgvCheckout);
            this.checkoutpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutpanel.Location = new System.Drawing.Point(3, 3);
            this.checkoutpanel.Name = "checkoutpanel";
            this.checkoutpanel.Size = new System.Drawing.Size(1295, 635);
            this.checkoutpanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(551, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 55);
            this.label4.TabIndex = 11;
            this.label4.Text = "Checkout";
            // 
            // btnBackCheckout
            // 
            this.btnBackCheckout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBackCheckout.BackColor = System.Drawing.Color.Silver;
            this.btnBackCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackCheckout.Location = new System.Drawing.Point(688, 559);
            this.btnBackCheckout.Name = "btnBackCheckout";
            this.btnBackCheckout.Size = new System.Drawing.Size(216, 51);
            this.btnBackCheckout.TabIndex = 10;
            this.btnBackCheckout.Text = "Back";
            this.btnBackCheckout.UseVisualStyleBackColor = false;
            this.btnBackCheckout.Click += new System.EventHandler(this.btnBackCheckout_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(429, 559);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(216, 51);
            this.btnCheckout.TabIndex = 9;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // dgvCheckout
            // 
            this.dgvCheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckout.Location = new System.Drawing.Point(80, 122);
            this.dgvCheckout.MultiSelect = false;
            this.dgvCheckout.Name = "dgvCheckout";
            this.dgvCheckout.ReadOnly = true;
            this.dgvCheckout.RowHeadersWidth = 62;
            this.dgvCheckout.RowTemplate.Height = 28;
            this.dgvCheckout.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckout.Size = new System.Drawing.Size(1146, 402);
            this.dgvCheckout.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 674);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.welcomePage.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.addGuestPage.ResumeLayout(false);
            this.panelAddGuest.ResumeLayout(false);
            this.panelAddGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.viewGuestsPage.ResumeLayout(false);
            this.panelViewGuests.ResumeLayout(false);
            this.panelViewGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.searchGuestPage.ResumeLayout(false);
            this.searchguestpanel.ResumeLayout(false);
            this.searchguestpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchGuests)).EndInit();
            this.checkoutPage.ResumeLayout(false);
            this.checkoutpanel.ResumeLayout(false);
            this.checkoutpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckout)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage welcomePage;
        private System.Windows.Forms.TabPage addGuestPage;
        private System.Windows.Forms.TabPage viewGuestsPage;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Button btnCheckOutPanel;
        private System.Windows.Forms.Button btnSearchGuestPanel;
        private System.Windows.Forms.Button btnViewGuestsPanel;
        private System.Windows.Forms.Button btnGoToAddGuest;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panelAddGuest;
        private System.Windows.Forms.Label AddGuestlabel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddGuest;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Panel panelViewGuests;
        private System.Windows.Forms.DataGridView dgvGuests;
        private System.Windows.Forms.Label viewGuests;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage searchGuestPage;
        private System.Windows.Forms.TabPage checkoutPage;
        private System.Windows.Forms.Panel searchguestpanel;
        private System.Windows.Forms.Panel checkoutpanel;
        private System.Windows.Forms.TextBox textBoxRoomSearch;
        private System.Windows.Forms.TextBox textBoxNameSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lablNameSearch;
        private System.Windows.Forms.DataGridView dgvSearchGuests;
        private System.Windows.Forms.Button btnSearchGuest;
        private System.Windows.Forms.Button btnBackSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBackCheckout;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView dgvCheckout;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
    }
}