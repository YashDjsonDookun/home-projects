using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP1Q2
{
    public partial class Form1 : Form
    {
        static double celsius;
        static double farenheit;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            double depth = double.Parse(depthInput.Text);
            CalculateCelsius(depth);
            ConvertToFarenheit(celsius);
            output.Text = ($"celsius: {celsius}   Farenheit: {farenheit}");
        }

        public static double CalculateCelsius(double x)
        {
            celsius = 10 * (x) + 20;
            return celsius;
        }

        public static double ConvertToFarenheit(double x)
        {
            farenheit = (1.8 * (x) + 32);
            return farenheit;
        }
    }
}
