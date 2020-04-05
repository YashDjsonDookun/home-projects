using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
            PopulateListBoxFromArray();
        }

        private void PopulateListBoxFromArray()
        {
            int[] ages = {
                57, 61, 57, 57, 58, 57, 61, 54, 68, 51, 49, 64,
                50, 48, 65, 52, 56, 46, 54, 49, 51, 47, 55, 55,
                54, 42, 51, 56, 55, 51, 54, 51, 60, 62, 43, 55,
                56, 61, 52, 69, 64, 46, 54, 47, 70
            };

            // Populate listbox using data from Array
            lstAge.DataSource = ages;

            int min = ages[0], max = ages[0], total = 0;

            foreach(int age in ages)
            {
                //find min
                if (age < min)
                    min = age;
                //find max
                if (age > max)
                    max = age;
                //find total
                total += age;
            }

            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();

            //find average
            double avg = total / ages.Length;
            txtAvg.Text = avg.ToString("N2");
        }
    }
}
