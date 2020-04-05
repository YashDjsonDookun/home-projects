using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hypotenuse
{
    public partial class RightTriangle : Form
    {
        public RightTriangle()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt_a.Text);
            double b = double.Parse(txt_b.Text);
            txt_hypotenuse.Text = FunctionHypotenuse(a, b).ToString();
        }

        private double FunctionHypotenuse(double a, double b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
