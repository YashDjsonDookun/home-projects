using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP1Q1
{
    public partial class Form1 : Form
    {
        static double area;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(radiusInput.Text);
            CalculateArea(radius);
            output.Text = $"Area of circle:  {area}!";
        }
        public static double CalculateArea(double x)
        {
            const double pi = Math.PI;
            area = (pi * Math.Pow(x, 2));
            return area;
        }
    }
}
