using System;
using System.Windows.Forms;

namespace Question1_LoginForm
{
    public partial class Question9_KFC : Form
    {
        int unitPrice;
        public Question9_KFC()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Selection();
            CalculateTotal();
        }

        public int Selection()
        {
            const int zinger = 90;
            const int lPiece = 50;
            const int strips = 80;
            const int wedges = 75;

            if (selectionList.SelectedIndex.Equals(0))
            {
                unitPrice = zinger;
            }
            else if (selectionList.SelectedIndex.Equals(1))
            {
                unitPrice = lPiece;
            }
            else if(selectionList.SelectedIndex.Equals(2))
            {
                unitPrice = strips;
            }
            else
            {
                unitPrice = wedges;
            }
            unitPriceOut.Text = unitPrice.ToString();
            return unitPrice;
        }

        public void CalculateTotal()
        {
            int total = int.Parse(quantityInput.Text) * unitPrice;
            totalOut.Text = total.ToString();
        }
    }
}
