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
    public partial class frmPointsPlane : Form
    {
        public frmPointsPlane()
        {
            InitializeComponent();
        }

        private void LblDistance_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txtX1.Text);
            double y1 = double.Parse(txtY1.Text);

            double x2 = double.Parse(txtX2.Text);
            double y2 = double.Parse(txtY2.Text);

            double slope = (y2 - y1) / (x2 - x1);
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            lblSlope.Text = ($"Slope = {slope}");
            lblDistance.Text = ($"Distance = {distance}");

            groupBox1.Visible = true;



        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
