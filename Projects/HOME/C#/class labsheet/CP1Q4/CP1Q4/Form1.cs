using System;

using System.Windows.Forms;

namespace CP1Q4
{
    public partial class Form1 : Form
    {
        static double gradient;
        static double distance;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            double[] Coord1 = new double[2];
            double[] Coord2 = new double[2];

            Coord1[0] = double.Parse(xOneInput.Text);
            Coord1[1] = double.Parse(yOneInput.Text);
            Coord2[0] = double.Parse(xTwoInput.Text);
            Coord2[1] = double.Parse(yTwoInput.Text);

            FindGradient(Coord1, Coord2);
            FindDistance(Coord1, Coord2);

            Output.Text = $"Slope of the line: {gradient}\r\nDistance between the 2 Coordinates: {distance} units.";
        }

         public double FindGradient(double[] Arr1, double[] Arr2)
        {
            // gradient,m = (y2 – y1)/(x2 – x1)
            gradient = (Arr2[1] - Arr1[1]) / (Arr2[0] - Arr1[0]);
            return gradient;
        }

         public double FindDistance(double[] Arr1, double[] Arr2)
        {
            // distance,d = √((x2 – x1)2 + (y2 – y1)2)
            distance = Math.Sqrt(Math.Pow((Arr2[0] - Arr1[0]), 2) + Math.Pow((Arr2[1] - Arr1[1]), 2));
            return distance;
        }
    }
}
