using System;
using System.Windows.Forms;

namespace BenefitsMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (DrugChk.Checked)
            {
                sum += 39.15;
            }
            if (MedicalChk.Checked)
            {
                sum += 55.52;
            }
            if (VisionChk.Checked)
            {
                sum += 2.25;
            }
            if (DentalChk.Checked)
            {
                sum += 10.81;
            }

            output.Text = sum.ToString("C");
        }
    }
}
