using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaCity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void citiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.citiesBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.citiesDbDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'citiesDbDataSet.cities' table. You can move, or remove it, as needed.
            //this.citiesTableAdapter.Fill(this.citiesDbDataSet.cities);

            UpdateGrid("SELECT * FROM cities;");


        }

        private void UpdateGrid(string sqlStr)
        {
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\citiesDb.mdf;Integrated Security=True";

            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            citiesDataGridView.DataSource = dt;
            sda.Dispose();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.citiesTableAdapter.FillBy(this.citiesDbDataSet.cities);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
