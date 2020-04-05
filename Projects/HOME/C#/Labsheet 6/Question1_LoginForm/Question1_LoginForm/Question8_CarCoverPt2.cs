using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1_LoginForm
{
    public partial class Question8_CarCoverPt2 : Form
    {
        
        public Question8_CarCoverPt2()
        {
            InitializeComponent();
        }

        private void sumInsuredInput_TextChanged(object sender, EventArgs e)
        {
            output.Text = sumInsuredInput.Text;
        }

        public void calculatePremium()
        {
            double sumInsured = double.Parse(sumInsuredInput.Text);
            double basicPremium;
            const int riot = 2000;
            const int theft = 4500;
            const int fire = 3750;
            double premium;

            // basic premium = 0.05 * sum insuured
            basicPremium = (0.05 * sumInsured);

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

        private void OptRiot_CheckedChanged(object sender, EventArgs e)
        {
            calculatePremium();
        }

        private void OptTheft_CheckedChanged(object sender, EventArgs e)
        {
            calculatePremium();
        }

        private void OptFire_CheckedChanged(object sender, EventArgs e)
        {
            calculatePremium();
        }
    }
}
