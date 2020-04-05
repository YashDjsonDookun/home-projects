using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassPractice1
{
    public partial class Cylinder : Form
    {
        public Cylinder()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double r = double.Parse(txtR.Text);
            double h1 = double.Parse(txtH1.Text);
            double h2 = h - h1;
            double r1 = double.Parse(txtR1.Text);
            double r2 = double.Parse(txtR2.Text);
            Debug.WriteLine("h = " + h);
            Debug.WriteLine("r = " + r);
            Debug.WriteLine("h1 = " + h1);
            Debug.WriteLine("h2 = " + h2);
            Debug.WriteLine("r1 = " + r1);
            Debug.WriteLine("r2 = " + r2);

            //Volume of cylinder=πr2h
            double volBigCylinder = Math.PI * Math.Pow(r, 2) * h;
            double volCylinder1 = Math.PI * Math.Pow(r1, 2) * h1;
            double volCylinder2 = Math.PI * Math.Pow(r2, 2) * h2;

            Debug.WriteLine("volBigCylinder = " + volBigCylinder);
            Debug.WriteLine("volCylinder1 = " + volCylinder1);
            Debug.WriteLine("volCylinder2 = " + volCylinder2);
            //Volume of Concrete required = BigCylinder - (Cylinder1+Cylinder2)
            double volConcrete = volBigCylinder - (volCylinder1 + volCylinder2);

            Debug.WriteLine("volConcrete = " + volConcrete);
            txtVolume.Text = volConcrete.ToString("#.##");
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
