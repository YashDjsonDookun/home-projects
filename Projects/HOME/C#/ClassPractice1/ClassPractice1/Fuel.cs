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
    public partial class frmFuel : Form
    {
        public frmFuel()
        {
            InitializeComponent();
        }

        private void FrmFuel_Load(object sender, EventArgs e)
        {

        }

        private void LblX2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double distanceInKm = double.Parse(txtDistance.Text);
            double kmPerLitre = double.Parse(txtKmPerLItre.Text);
            double costOfLitre = double.Parse(txtCostLitre.Text);

            double noOfLitres = distanceInKm / kmPerLitre;
            double estimatedCost = noOfLitres * costOfLitre;

            lblLitresNeeded.Text = ($"This trip will require {noOfLitres.ToString("#.##")} litres of fuel.");
            lblEstimatedCost.Text = ($"Cost of Trip is estimated at Rs {estimatedCost.ToString("#.##")}.");

            groupBox1.Visible = true;

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
