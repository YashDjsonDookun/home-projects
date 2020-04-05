using System;
using System.Windows.Forms;

namespace Question1_LoginForm
{
    public partial class Question10_IceCream : Form
    {
        char flavour;
        int price;
        public Question10_IceCream()
        {
            InitializeComponent();
        }

        public char CheckForFlavour()
        {
            if (optChoco.Checked)
            {
                flavour = 'c';
            }
            else if (optVanilla.Checked)
            {
                flavour = 'v';
            }
            else if (optStrawberry.Checked)
            {
                flavour = 's';
            }
            return flavour;
        }

        public void CheckForSize(char x)
        {
            if (optSmall.Checked)
            {
                if (x.Equals('c'))
                {
                    price = 60;
                }
                else if (x.Equals('v'))
                {
                    price = 45;
                }
                else
                {
                    price = 50;
                }
            }
            else if (optLarge.Checked)
            {
                if (x.Equals('c'))
                {
                    price = 75;
                }
                else if (x.Equals('v'))
                {
                    price = 65;
                }
                else
                {
                    price = 60;
                }
            }
            checkForAddons(price); ;
        }

        public void checkForAddons(int x)
        {
            if (chkChoco.Checked)
            {
                x += 25;
            }
            if (chkCookies.Checked)
            {
                x += 20;
            }
            if (chkNuts.Checked)
            {
                x += 15;
            }
            if (chkFruits.Checked)
            {
                x += 35;
            }
            priceOut.Text = x.ToString("C2");
        }

        public void ComputePrice()
        {
            CheckForFlavour();
            CheckForSize(flavour);
        }

        private void OptChoco_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void OptVanilla_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void OptStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void OptSmall_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void OptLarge_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void ChkFruits_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void ChkNuts_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void ChkCookies_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }

        private void ChkChoco_CheckedChanged(object sender, EventArgs e)
        {
            ComputePrice();
        }
    }
}
