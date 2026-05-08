using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class frmMain : Form
    {
        private void ShowOnlyPanel(Panel panel)
        {
            panelWelcome.Visible = false;
            panelAddGuest.Visible = false;
            panelViewGuests.Visible = false;

            panel.Visible = true;
            panel.BringToFront();
        }

        public frmMain()
        {
            InitializeComponent();
            panelWelcome.Visible = true;
            panelAddGuest.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            db.TestConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnViewGuestsPanel_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(panelViewGuests);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(panelAddGuest);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            ShowOnlyPanel(panelWelcome);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(panelWelcome);
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
        string.IsNullOrWhiteSpace(txtRoomNumber.Text))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (!int.TryParse(txtRoomNumber.Text, out int roomNumber))
            {
                MessageBox.Show("Room number must be numeric");
                return;
            }

            string connStr =
                ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connStr))
                {
                    conn.Open();

                    string query =
                        "INSERT INTO Guests (Name, RoomNumber, CheckInDate) " +
                        "VALUES (@name, @room, @date)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@room", txtRoomNumber.Text);
                        cmd.Parameters.AddWithValue("@date", dtpCheckIn.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Guest added successfully");

                // Optional: clear fields
                txtName.Clear();
                txtRoomNumber.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panelViewGuests_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click_2(object sender, EventArgs e)
        {
            ShowOnlyPanel(panelWelcome);
        }
    }
}
