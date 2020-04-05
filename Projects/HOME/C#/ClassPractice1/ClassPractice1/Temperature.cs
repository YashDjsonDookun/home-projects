using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPractice1
{
    public partial class frmTemperature : Form
    {
        public frmTemperature()
        {
            InitializeComponent();
        }

        private void BtnCalculateTemp_Click(object sender, EventArgs e)
        {
            double depth = double.Parse(txtDepth.Text);
            double celsius = (10 * depth) + 20;
            double farenheit = (1.8 * celsius) + 32;

            txtCelsius.Text = celsius.ToString();
            txtFarenheit.Text = farenheit.ToString();

            groupBox1.Visible = true;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
