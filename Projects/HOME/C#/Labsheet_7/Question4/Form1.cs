using System;
using System.Windows.Forms;

namespace Question4
{
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            int n = int.Parse(inputNumberOfSubjects.Text);
            double total = 0;
            for (int i = 0; i < n; i++)
            {
               total = total + double.Parse(listBox1.Items[i].ToString());
            }
            outputTotal.Text = $"{total}";
            double average = total / n;
            outputAvg.Text = average.ToString("#.#");
        }
    }
}
