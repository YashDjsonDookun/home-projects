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
    public partial class frmStartUP : Form
    {
        public frmStartUP()
        {
            InitializeComponent();
        }

        private void BtnQ1_Click(object sender, EventArgs e)
        {
            frmCircleArea frmArea = new frmCircleArea();
            frmArea.ShowDialog();
        }

        private void BtnQ2_Click(object sender, EventArgs e)
        {
            frmTemperature frmTemp = new frmTemperature();
            frmTemp.ShowDialog();
        }

        private void BtnQ3_Click(object sender, EventArgs e)
        {
            frmFuel frmFuel = new frmFuel();
            frmFuel.ShowDialog();
        }

        private void BtnQ4_Click(object sender, EventArgs e)
        {
            frmPointsPlane pointsInPlane = new frmPointsPlane();
            pointsInPlane.ShowDialog();
        }

        private void BtnQ5_Click(object sender, EventArgs e)
        {
            Cylinder cylinder = new Cylinder();
            cylinder.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
