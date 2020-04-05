using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question4_pt_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            int n = int.Parse(inputNumberOfSubjects.Text);
            double total = 0;
            int numberOfItems = listBox1.Items.Count;
            for (int i = 0; i < n; i++)
            {
                total = total + double.Parse(listBox1.Items[numberOfItems - 1].ToString());
                numberOfItems--;
            }
            outputTotal.Text = $"{total}";
            double average = total / n;
            outputAvg.Text = average.ToString("#.#");
        }
    }
}
