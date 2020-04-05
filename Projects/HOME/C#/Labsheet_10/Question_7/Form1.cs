using System;
using System.Windows.Forms;

namespace Question_7
{
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double numberOfHoursWorked = double.Parse(txt_num.Text);
            double hourlyPayRate = double.Parse(txt_rate.Text);
            txt_grossPay.Text =  CalcGrossPay(numberOfHoursWorked, hourlyPayRate).ToString();
        }
        private static double CalcGrossPay(double num, double rate)
        {
            double grossPay;
            if (num <= 40)
            {
                grossPay = num * rate;
            }
            else
            {
                grossPay = ((40 * rate) + ((num - 40) * (1.5 * rate)));
            }
            return grossPay;
        }

    }
}
