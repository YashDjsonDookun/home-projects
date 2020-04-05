using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace labsheet17
{
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CityDb.mdf;Integrated Security=True";
        string sqlStr = "SELECT * FROM cities";
        DataTable dt = new DataTable();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            sda.Fill(dt);
            dgvDisplay.DataSource = dt;
            sda.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            int changes = sda.Update(dt);

            if (changes > 0)
                MessageBox.Show($"{changes} records changed");
            else
                MessageBox.Show("No records changed");

        }
    }
}
