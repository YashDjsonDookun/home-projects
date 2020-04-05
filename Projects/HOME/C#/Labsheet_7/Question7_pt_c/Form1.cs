using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int count = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                count++;
                if (nameEntered.Equals(listBox1.Items[i]))
                {
                    exists = true;
                    MessageBox.Show("Searched " + count + " items. President " + nameEntered + " is found at index " + i + ".");
                    i++;
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
