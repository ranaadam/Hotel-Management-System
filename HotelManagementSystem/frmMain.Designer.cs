namespace HotelManagementSystem
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGoToAddGuest = new System.Windows.Forms.Button();
            this.btnViewGuestsPanel = new System.Windows.Forms.Button();
            this.btnSearchGuestPanel = new System.Windows.Forms.Button();
            this.btnCheckOutPanel = new System.Windows.Forms.Button();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.panelAddGuest = new System.Windows.Forms.Panel();
            this.AddGuestlabel = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddGuest = new System.Windows.Forms.Button();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panelViewGuests = new System.Windows.Forms.Panel();
            this.dgvGuests = new System.Windows.Forms.DataGridView();
            this.viewGuests = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelWelcome.SuspendLayout();
            this.panelAddGuest.SuspendLayout();
            this.panelViewGuests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-283, -97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(827, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Hotel Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGoToAddGuest
            // 
            this.btnGoToAddGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToAddGuest.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGoToAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToAddGuest.Location = new System.Drawing.Point(-308, 77);
            this.btnGoToAddGuest.Name = "btnGoToAddGuest";
            this.btnGoToAddGuest.Size = new System.Drawing.Size(190, 70);
            this.btnGoToAddGuest.TabIndex = 1;
            this.btnGoToAddGuest.Text = "Add Guest";
            this.btnGoToAddGuest.UseVisualStyleBackColor = false;
            this.btnGoToAddGuest.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnViewGuestsPanel
            // 
            this.btnViewGuestsPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnViewGuestsPanel.BackColor = System.Drawing.Color.BurlyWood;
            this.btnViewGuestsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewGuestsPanel.Location = new System.Drawing.Point(-80, 77);
            this.btnViewGuestsPanel.Name = "btnViewGuestsPanel";
            this.btnViewGuestsPanel.Size = new System.Drawing.Size(190, 70);
            this.btnViewGuestsPanel.TabIndex = 2;
            this.btnViewGuestsPanel.Text = "View Guests";
            this.btnViewGuestsPanel.UseVisualStyleBackColor = false;
            this.btnViewGuestsPanel.Click += new System.EventHandler(this.btnViewGuestsPanel_Click);
            // 
            // btnSearchGuestPanel
            // 
            this.btnSearchGuestPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchGuestPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSearchGuestPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchGuestPanel.Location = new System.Drawing.Point(145, 77);
            this.btnSearchGuestPanel.Name = "btnSearchGuestPanel";
            this.btnSearchGuestPanel.Size = new System.Drawing.Size(190, 70);
            this.btnSearchGuestPanel.TabIndex = 3;
            this.btnSearchGuestPanel.Text = "Search Guest";
            this.btnSearchGuestPanel.UseVisualStyleBackColor = false;
            // 
            // btnCheckOutPanel
            // 
            this.btnCheckOutPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCheckOutPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.btnCheckOutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOutPanel.Location = new System.Drawing.Point(370, 77);
            this.btnCheckOutPanel.Name = "btnCheckOutPanel";
            this.btnCheckOutPanel.Size = new System.Drawing.Size(190, 70);
            this.btnCheckOutPanel.TabIndex = 4;
            this.btnCheckOutPanel.Text = "Check Out";
            this.btnCheckOutPanel.UseVisualStyleBackColor = false;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelWelcome.Controls.Add(this.btnCheckOutPanel);
            this.panelWelcome.Controls.Add(this.btnSearchGuestPanel);
            this.panelWelcome.Controls.Add(this.btnViewGuestsPanel);
            this.panelWelcome.Controls.Add(this.btnGoToAddGuest);
            this.panelWelcome.Controls.Add(this.label1);
            this.panelWelcome.Location = new System.Drawing.Point(27, 12);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(267, 138);
            this.panelWelcome.TabIndex = 0;
            // 
            // panelAddGuest
            // 
            this.panelAddGuest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelAddGuest.Controls.Add(this.AddGuestlabel);
            this.panelAddGuest.Controls.Add(this.btnBack);
            this.panelAddGuest.Controls.Add(this.btnAddGuest);
            this.panelAddGuest.Controls.Add(this.txtRoomNumber);
            this.panelAddGuest.Controls.Add(this.lblDate);
            this.panelAddGuest.Controls.Add(this.lblRoom);
            this.panelAddGuest.Controls.Add(this.dtpCheckIn);
            this.panelAddGuest.Controls.Add(this.txtName);
            this.panelAddGuest.Controls.Add(this.lblName);
            this.panelAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelAddGuest.Location = new System.Drawing.Point(746, 38);
            this.panelAddGuest.Name = "panelAddGuest";
            this.panelAddGuest.Size = new System.Drawing.Size(172, 112);
            this.panelAddGuest.TabIndex = 17;
            this.panelAddGuest.Visible = false;
            // 
            // AddGuestlabel
            // 
            this.AddGuestlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddGuestlabel.AutoSize = true;
            this.AddGuestlabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuestlabel.Location = new System.Drawing.Point(-34, -187);
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
            this.btnBack.Location = new System.Drawing.Point(-114, 161);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(216, 51);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnAddGuest
            // 
            this.btnAddGuest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddGuest.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGuest.Location = new System.Drawing.Point(-342, 161);
            this.btnAddGuest.Name = "btnAddGuest";
            this.btnAddGuest.Size = new System.Drawing.Size(216, 51);
            this.btnAddGuest.TabIndex = 6;
            this.btnAddGuest.Text = "Add Guest";
            this.btnAddGuest.UseVisualStyleBackColor = false;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRoomNumber.Location = new System.Drawing.Point(-117, -2);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(219, 35);
            this.txtRoomNumber.TabIndex = 5;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(-348, 68);
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
            this.lblRoom.Location = new System.Drawing.Point(-348, -2);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(216, 32);
            this.lblRoom.TabIndex = 3;
            this.lblRoom.Text = "Room Number:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(-117, 68);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(216, 35);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.Location = new System.Drawing.Point(-117, -78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(219, 35);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(-348, -78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(191, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Guest Name:";
            // 
            // panelViewGuests
            // 
            this.panelViewGuests.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelViewGuests.Controls.Add(this.dgvGuests);
            this.panelViewGuests.Controls.Add(this.viewGuests);
            this.panelViewGuests.Controls.Add(this.button1);
            this.panelViewGuests.Controls.Add(this.button2);
            this.panelViewGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelViewGuests.Location = new System.Drawing.Point(169, 241);
            this.panelViewGuests.Name = "panelViewGuests";
            this.panelViewGuests.Size = new System.Drawing.Size(158, 114);
            this.panelViewGuests.TabIndex = 18;
            this.panelViewGuests.Visible = false;
            // 
            // dgvGuests
            // 
            this.dgvGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuests.Location = new System.Drawing.Point(61, 87);
            this.dgvGuests.Name = "dgvGuests";
            this.dgvGuests.ReadOnly = true;
            this.dgvGuests.RowHeadersWidth = 62;
            this.dgvGuests.RowTemplate.Height = 28;
            this.dgvGuests.Size = new System.Drawing.Size(855, 358);
            this.dgvGuests.TabIndex = 10;
            this.dgvGuests.Visible = false;
            // 
            // viewGuests
            // 
            this.viewGuests.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewGuests.AutoSize = true;
            this.viewGuests.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewGuests.Location = new System.Drawing.Point(-52, -195);
            this.viewGuests.Name = "viewGuests";
            this.viewGuests.Size = new System.Drawing.Size(275, 55);
            this.viewGuests.TabIndex = 9;
            this.viewGuests.Text = "View Guests";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(118, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 51);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(-134, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 51);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add Guest";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.panelViewGuests);
            this.Controls.Add(this.panelAddGuest);
            this.Controls.Add(this.panelWelcome);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.panelAddGuest.ResumeLayout(false);
            this.panelAddGuest.PerformLayout();
            this.panelViewGuests.ResumeLayout(false);
            this.panelViewGuests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGoToAddGuest;
        private System.Windows.Forms.Button btnViewGuestsPanel;
        private System.Windows.Forms.Button btnSearchGuestPanel;
        private System.Windows.Forms.Button btnCheckOutPanel;
        private System.Windows.Forms.Panel panelWelcome;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

