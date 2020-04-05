using System;
using System.Windows.Forms;

namespace Question1_LoginForm
{
    public partial class Question5_SpeedingTicket : Form
    {
        int fine;
        public Question5_SpeedingTicket()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            verifySpeed();
        }
        public void verifySpeed()
        {
            int speed = int.Parse(speedInput.Text);
            if (speed >= 0 && speed <= 300)
            {
                if (speed <= 110)
                {
                    inRage();
                }
                else
                {
                    fine = 1000 + ((speed - 110) * 50);
                    limitExceeded();
                }
            }
            else
            {
                inValidRange();
            }
        }

        public void inRage()
        {
            output.Text = "Speed Limit Has Not Been Exceeded!";
        }

        public void inValidRange()
        {
            output.Text = "Invalid Range!!\r\n" +
                          "Speed should be in range of 0-300 Km/h";
        }

        public void limitExceeded()
        {
            output.Text = "Speed Limit Exceeded!!!\r\n" +
                          "Fine: " + fine.ToString("C2");
        }
    }
}
