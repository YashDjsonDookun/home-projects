using System;
using System.Windows.Forms;

namespace Question1_LoginForm
{
    public partial class MovieTicket : Form
    {
        public MovieTicket()
        {
            InitializeComponent();
        }
        //Exit Button
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Clear Button
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        public void calculateTotal()
        {
            int adults = int.Parse(adultInput.Text);
            int children = int.Parse(childrenInput.Text);
            int fare;

            if (optMorning.Checked)
            {
                fare = (adults * 100) + (children * 60);
            }
            else if (optAfternoon.Checked)
            {
                fare = (adults * 125) + (children * 75);
            }
            else
            {
                fare = (adults * 150) + (children * 90);
            }
            printFare(fare);
        }

        public void printFare(int x)
        {
            output.Text = x.ToString("C2");
        }

        private void Btn_Calc_Click(object sender, EventArgs e)
        {
            calculateTotal();
        }
    }
}
