using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

public class DBHelper
{
    public MySqlConnection GetConnection()
    {
        string connStr = ConfigurationManager.ConnectionStrings["HotelDB"].ConnectionString;
        return new MySqlConnection(connStr);
    }

    public void TestConnection()
    {
        try
        {
            using (var conn = GetConnection())
            {
                conn.Open();
                MessageBox.Show("Connection successful!");}
        }
        catch (Exception ex)
        {
            MessageBox.Show("Connection failed: " + ex.Message);
        }
    }
}
