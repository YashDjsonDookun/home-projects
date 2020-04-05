using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question6
{
    public partial class Question6 : Form
    {
        public Question6()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int index = 0;
            int[] arr = new int [lstAge.Items.Count];

            // Put all element of list box in an array
            for (int i = 0; i < lstAge.Items.Count; i++)
            {
                arr[i] = int.Parse((lstAge.Items[i]).ToString());
            }

            // bubble sort to place the array in order
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }


            // find min
            int min = arr[index];
            txtMin.Text = min.ToString();

            // finx max
            int max = arr[arr.Length - 1];
            txtMax.Text = max.ToString();

            // find average
            double avg = (min + max) / 2;
            txtAvg.Text = avg.ToString();
        }
    }
}
