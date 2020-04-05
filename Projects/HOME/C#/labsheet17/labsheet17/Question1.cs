using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace labsheet17
{
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void CitiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.CitiesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.cityDbDataSet);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDbDataSet.Cities' table. You can move, or remove it, as needed.
            //this.CitiesTableAdapter.Fill(this.cityDbDataSet.Cities);
            UpdateGrid("Select * From Cities");

        }

        private void UpdateGrid(string sqlStr)
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CityDb.mdf;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            citiesDataGridView.DataSource = dt;
            sda.Dispose();
        }

        private void btnOrderPopulation_Click(object sender, EventArgs e)
        {
            UpdateGrid("Select * From Cities Order By pop2005 ASC");

        }

        private void btnShowMonetary_Click(object sender, EventArgs e)
        {
            //UpdateGrid("SELECT city, countryName, pop2005, monetaryUnit FROM Cities ORDER BY city ASC");
            citiesDataGridView.Columns[4].HeaderText = "monetaryUnit";
            citiesDataGridView.Columns[4].DataPropertyName = "monetaryUnit";

            string sqlString = "SELECT countries.countryName, countries.pop2005, countries.monetaryUnit FROM countries";
            UpdateGrid(sqlString);

        }
    }
}
