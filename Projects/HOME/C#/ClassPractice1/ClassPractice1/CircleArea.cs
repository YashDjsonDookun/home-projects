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
    public partial class frmCircleArea : Form
    {
        public frmCircleArea()
        {
            InitializeComponent();
        }


        private void BtnCalculateArea_Click(object sender, EventArgs e)
        {
            double radius = int.Parse(txtRadius.Text);
            double area = Math.PI * radius * radius;

            String output = ($"Area of circle with radius {radius} is {area.ToString("#.##")}");
            lblCalculatedArea.Text = output;
            lblCalculatedArea.Visible = true;

        }

        private void CircleArea_Load(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
