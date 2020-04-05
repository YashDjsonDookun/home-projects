using System;
using System.Windows.Forms;

namespace Question7_pt_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string nameEntered = txtInput.Text;
            bool exists = false;
            int count = 1;
            int indexFound = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                count++;
                if (nameEntered.Equals(listBox1.Items[i]))
                {
                    exists = true;
                    indexFound = i;
                    i++;
                }
            }
            if (!exists)
            {
                MessageBox.Show("No Match Found!");
            }

            MessageBox.Show("Searched " + count + " items. President " + nameEntered + " is found at index " + indexFound + ".");
        }
    }
}
