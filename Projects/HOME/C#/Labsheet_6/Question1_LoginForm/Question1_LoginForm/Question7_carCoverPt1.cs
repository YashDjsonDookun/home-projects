using System;
using System.Windows.Forms;

namespace Question1_LoginForm
{
    public partial class Question7_carCoverPt1 : Form
    {
        public Question7_carCoverPt1()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            double sumInsured = double.Parse(sumInsuredInput.Text);
            calculatePremium(sumInsured);
        }

        public void calculatePremium(double x)
        {
            double basicPremium;
            const int riot = 2000;
            const int theft = 4500;
            const int fire = 3750;
            double premium;

            // basic premium = 0.05 * sum insuured
            basicPremium = (0.05 * x);

            // premium = basic Premium if no options were checked
            premium = basicPremium;

            if (optRiot.Checked)
            {
                premium += riot;
            }
            if (optTheft.Checked)
            {
                premium += theft;
            }
            if (optFire.Checked)
            {
                premium += fire;
            }
            output.Text = $"{premium}";
        }
    }
}
