using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP1Q5
{
    public partial class Form1 : Form
    {
        static double heightOne, heighTwo, radiusOne, radiusTwo, h, r, vOne, vTwo, bigVol, volume ;
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateH_Click(object sender, EventArgs e)
        {
            inputVariables();
            findHeight(heightOne, heighTwo);
            volumeOne(heightOne, radiusOne);
            volumeTwo(heighTwo, radiusTwo);
            bigVolume(h, r);
            findVolumeNeeded(bigVol, vOne, vTwo);
        }

        public double findHeight(double x, double y)
        {
            h = x + y;
            heightH.Text = h.ToString();
            return h;
        }

        public void inputVariables()
        {
            heightOne = double.Parse(hOne.Text);
            heighTwo = double.Parse(hTwo.Text);
            radiusOne = double.Parse(rOne.Text);
            radiusTwo = double.Parse(rTwo.Text);
            r = double.Parse(radiusR.Text);
        }

        public double volumeOne(double x, double y)
        {
            vOne = (Math.PI * Math.Pow(x, 2) * y);
            return vOne;
        }
        public double volumeTwo(double x, double y)
        {
            vTwo = (Math.PI * Math.Pow(x, 2) * y);
            return vTwo;
        }

        public double bigVolume(double x, double y)
        {
            
            bigVol = (Math.PI * Math.Pow(x, 2) * y);
            return bigVol;
        }

        public void findVolumeNeeded(double x, double y, double z)
        {
            volume = (bigVol - (vOne + vTwo));
            output.Text = volume.ToString("0.00") + " m3";
        }
    }
}
