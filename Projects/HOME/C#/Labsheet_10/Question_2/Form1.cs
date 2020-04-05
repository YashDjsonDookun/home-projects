using System;
using System.Windows.Forms;

namespace Question_2
{
    public partial class Question2 : Form
    {
        public Question2()
        {
            InitializeComponent();
        }

        private void Btn_calc_Click(object sender, EventArgs e)
        {
            double length = double.Parse(txt_length.Text);
            double width = double.Parse(txt_width.Text);

            txt_area.Text = AreaOfRectangle(length, width).ToString();
            txt_perimeter.Text = PerimeterOfRectangle(length, width).ToString();
        }
        private static double AreaOfRectangle(double x, double y)
        {
            double area = x * y;
            return area;
        }

        private static double PerimeterOfRectangle(double x, double y)
        {
            double perimeter = ((2 * x) + (2 * y));
            return perimeter;
        }
    }
}
