using System;
using System.Windows.Forms;

namespace Question7_pt_c
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
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (nameEntered.Equals(listBox1.Items[i]))
                {
                    exists = true;
                    MessageBox.Show("Searched " + (i+1) + " items. President " + nameEntered + " is found at index " + i + ".");
                    break;
                }
            }
            if (!exists)
            {
                MessageBox.Show("No Match Found!");
            }
        }
    }
}
