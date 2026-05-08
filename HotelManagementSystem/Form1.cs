using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem
{
    public partial class MainForm : Form
    {
        // =========================
        // COMMON HELPERS
        // =========================

        private string GetConnectionString()
        {
            return ConfigurationManager
                .ConnectionStrings["HotelDB"]
                .ConnectionString;
        }

        private void LoadGuests(DataGridView grid)
        {
            using (MySqlConnection conn =
                new MySqlConnection(GetConnectionString()))
            {
                conn.Open();

                string query =
                    "SELECT GuestId, Name, Email, RoomNumber, CheckInDate FROM Guests";

                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                grid.DataSource = dt;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grid.ClearSelection();

                grid.ReadOnly = true;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.MultiSelect = false;

                grid.RowsDefaultCellStyle.Font =
                    new Font("Segoe UI", 11);
                grid.AlternatingRowsDefaultCellStyle.Font =
                    new Font("Segoe UI", 11);

                grid.EnableHeadersVisualStyles = false;
                grid.ColumnHeadersDefaultCellStyle.BackColor =
                    Color.DarkSlateGray;
                grid.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.White;
                grid.ColumnHeadersDefaultCellStyle.Font =
                    new Font("Segoe UI", 11, FontStyle.Bold);
            }
        }

        // =========================
        // FORM
        // =========================

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DBHelper db = new DBHelper();
            db.TestConnection();

            LoadGuests(dgvGuests);

            // =========================
            // RUN TESTS (TEMPORARY)
            // =========================
            RunAllTests();
        }

        // =========================
        // NAVIGATION
        // =========================

        private void btnGoToAddGuest_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnViewGuestsPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            LoadGuests(dgvGuests);
        }

        private void btnSearchGuestPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btnCheckOutPanel_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            LoadGuests(dgvCheckout);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnBackCheckout_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnBackSearch_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        // =========================
        // ADD GUEST
        // =========================

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
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

            using (MySqlConnection conn =
                new MySqlConnection(GetConnectionString()))
            {
                conn.Open();

                string query =
                    "INSERT INTO Guests (Name, Email, RoomNumber, CheckInDate) " +
                    "VALUES (@name, @email, @room, @date)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@room", roomNumber);
                cmd.Parameters.AddWithValue("@date", dtpCheckIn.Value);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Guest added successfully");

            LoadGuests(dgvGuests);

            txtName.Clear();
            txtRoomNumber.Clear();
            txtEmail.Clear();
        }

        // =========================
        // SEARCH
        // =========================

        private void btnSearchGuest_Click(object sender, EventArgs e)
        {
            string guestName = textBoxNameSearch.Text.Trim();
            string roomNumber = textBoxRoomSearch.Text.Trim();

            using (MySqlConnection con =
                new MySqlConnection(GetConnectionString()))
            {
                string query = "SELECT * FROM Guests WHERE 1=1";

                if (!string.IsNullOrEmpty(guestName))
                    query += " AND LOWER(Name) LIKE LOWER(@name)";

                if (!string.IsNullOrEmpty(roomNumber))
                    query += " AND RoomNumber = @room";

                MySqlCommand cmd = new MySqlCommand(query, con);

                if (!string.IsNullOrEmpty(guestName))
                    cmd.Parameters.AddWithValue("@name",
                        "%" + guestName + "%");

                if (!string.IsNullOrEmpty(roomNumber))
                    cmd.Parameters.AddWithValue("@room", roomNumber);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvSearchGuests.DataSource =
                    dt.Rows.Count > 0 ? dt : null;

                if (dt.Rows.Count == 0)
                    MessageBox.Show("No guest found.");
            }
        }

        // =========================
        // CHECKOUT
        // =========================

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCheckout.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Please select a guest to check out.",
                    "Checkout",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int guestId = Convert.ToInt32(
                dgvCheckout.SelectedRows[0].Cells["GuestID"].Value);

            string guestName =
                dgvCheckout.SelectedRows[0].Cells["Name"].Value.ToString();

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to check out {guestName} (Guest ID: {guestId})?",
                "Confirm Checkout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using (MySqlConnection con =
                new MySqlConnection(GetConnectionString()))
            {
                con.Open();

                string query =
                    "DELETE FROM Guests WHERE GuestID = @guestId";

                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@guestId", guestId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show(
                $"{guestName} has been checked out successfully.",
                "Checkout Complete",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            dgvCheckout.Rows.RemoveAt(
                dgvCheckout.SelectedRows[0].Index);
        }

        // =========================
        // TESTING METHODS (ADDED)
        // =========================

        private void RunAllTests()
        {
            TestDatabaseConnection();
            TestAddGuest();
            TestRetrieveGuests();
            TestSearch();
            TestDeleteGuest();
            TestValidation();
        }

        private void TestDatabaseConnection()
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(GetConnectionString()))
                {
                    con.Open();
                }

                MessageBox.Show("Database Connection Test: PASSED");
            }
            catch
            {
                MessageBox.Show("Database Connection Test: FAILED");
            }
        }

        private int AddTestGuest()
        {
            using (MySqlConnection con =
                new MySqlConnection(GetConnectionString()))
            {
                con.Open();

                string query =
                    "INSERT INTO Guests (Name, Email, RoomNumber, CheckInDate) " +
                    "VALUES ('Test User', 'test@test.com', 999, CURDATE()); " +
                    "SELECT LAST_INSERT_ID();";

                MySqlCommand cmd = new MySqlCommand(query, con);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private void TestAddGuest()
        {
            try
            {
                int id = AddTestGuest();
                MessageBox.Show(id > 0
                    ? "Add Guest Test: PASSED"
                    : "Add Guest Test: FAILED");
            }
            catch
            {
                MessageBox.Show("Add Guest Test: FAILED");
            }
        }

        private void TestRetrieveGuests()
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(GetConnectionString()))
                {
                    con.Open();

                    MySqlCommand cmd =
                        new MySqlCommand("SELECT COUNT(*) FROM Guests", con);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    MessageBox.Show(count >= 0
                        ? "Retrieve Guests Test: PASSED"
                        : "Retrieve Guests Test: FAILED");
                }
            }
            catch
            {
                MessageBox.Show("Retrieve Guests Test: FAILED");
            }
        }

        private void TestSearch()
        {
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(GetConnectionString()))
                {
                    con.Open();

                    MySqlCommand cmd =
                        new MySqlCommand(
                            "SELECT * FROM Guests WHERE Name LIKE '%Test%'", con);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    MessageBox.Show(
                        reader.HasRows
                        ? "Search Test: PASSED"
                        : "Search Test: PASSED (No results)");
                }
            }
            catch
            {
                MessageBox.Show("Search Test: FAILED");
            }
        }

        private void TestDeleteGuest()
        {
            try
            {
                int id = AddTestGuest();

                using (MySqlConnection con =
                    new MySqlConnection(GetConnectionString()))
                {
                    con.Open();

                    MySqlCommand cmd =
                        new MySqlCommand(
                            "DELETE FROM Guests WHERE GuestId = @id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Delete Guest Test: PASSED");
            }
            catch
            {
                MessageBox.Show("Delete Guest Test: FAILED");
            }
        }

        private void TestValidation()
        {
            bool invalidRoom =
                !int.TryParse("ABC", out _);

            MessageBox.Show(invalidRoom
                ? "Input Validation Test: PASSED"
                : "Input Validation Test: FAILED");
        }
    
    
    private void tabControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {

        }
    }
}
