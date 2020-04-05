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

namespace labsheet17
{
    public partial class Question2 : Form
    {
        string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CityDb.mdf;Integrated Security=True";
        string sqlStr = "SELECT * FROM cities";
        DataTable dt = new DataTable();
        int inc = 0;
        public Question2()
        {
            InitializeComponent();
        }

        private void NavigateRecords()
        {
            // Display contents of row specified by inc variable
            txtCity.Text = dt.Rows[inc]["city"].ToString();
            txtCountry.Text = dt.Rows[inc]["countryName"].ToString();
            txt2005.Text = dt.Rows[inc]["pop2005"].ToString();
            txt2015.Text = dt.Rows[inc]["pop2015"].ToString();
        }

        private void Question2_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            sda.Fill(dt);
            sda.Dispose();
            NavigateRecords();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            // Show previous record if the current one is not the first
            if (inc > 0)
            {
                inc--;
            }
            NavigateRecords();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Show previous record if the current one is not the last
            if (inc < dt.Rows.Count -1)
            {
                inc++;
            }
            NavigateRecords();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            inc = 0;
            NavigateRecords();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            inc = dt.Rows.Count - 1;
            NavigateRecords();
        }

        private void Save()
        {
            SqlDataAdapter sda = new SqlDataAdapter(sqlStr, connStr);
            SqlCommandBuilder scb = new SqlCommandBuilder(sda);
            sda.Update(dt);
            sda.Dispose();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dt.Rows[inc]["city"] = txtCity.Text;
            dt.Rows[inc]["countryName"] = txtCountry.Text;
            dt.Rows[inc]["pop2005"] = txt2005.Text;
            dt.Rows[inc]["pop2015"] = txt2015.Text;
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(inc);
            // or dt.Rows[inc].Delete();
            Save();
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow newRow = dt.NewRow();

            newRow["city"] = txtCity.Text;
            newRow["countryName"] = txtCountry.Text;
            newRow["pop2005"] = txt2005.Text;
            newRow["pop2015"] = txt2015.Text;

            dt.Rows.Add(newRow);
            Save();
            clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtCountry.Clear();
            txtCity.Clear();
            txt2015.Clear();
            txt2005.Clear();
        }
    }
}
