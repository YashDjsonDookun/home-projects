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
    public partial class Question3_WageCalculator : Form
    {
        public Question3_WageCalculator()
        {
            InitializeComponent();
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_calculate_Click(object sender, EventArgs e)
        {
            CalculateGrossPay();
        }

        public void CalculateGrossPay()
        {
            double hoursWorked = double.Parse(hoursWorkedInput.Text);
            int hourlyPayRate = int.Parse(payRateInput.Text);
            double grossPay;
            if (hoursWorked <= 40)
            {
                grossPay = hoursWorked * hourlyPayRate;
                lbl_grossPay.Text = grossPay.ToString("C2");
            }
            else
            {
                grossPay = ((40 * hourlyPayRate) + ((hoursWorked - 40) * (hourlyPayRate) * (1.5)));
                lbl_grossPay.Text = grossPay.ToString("C2");
            }
        }
    }
}
