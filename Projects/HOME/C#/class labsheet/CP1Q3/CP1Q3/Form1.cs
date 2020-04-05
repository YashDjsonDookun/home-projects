using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP1Q3
{
    public partial class Form1 : Form
    {
        static double distance;
        static double estimatedDistance;
        static double costPerLiter;
        static double numberOfLitersRequired;
        static double cost;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            distance = double.Parse(distanceInput.Text);
            estimatedDistance = double.Parse(estimatedDistanceInput.Text);
            costPerLiter = double.Parse(costPerLiterInput.Text);

            CalculateLitres(distance, estimatedDistance);
            CalculateCost(costPerLiter, numberOfLitersRequired);

            output.Text = $"Number of litres required for {distance} Km = {numberOfLitersRequired}L\r\nThe estimated cost for the {distance}Km trip is ${cost}";
        }

        public static double CalculateLitres(double x, double y)
        {
            //estimatedDistance / distance
            numberOfLitersRequired = (x / y);
            return numberOfLitersRequired;
        }

        public static double CalculateCost(double x, double y)
        {
            cost = x * y;
            return cost;
        }
    }
}
