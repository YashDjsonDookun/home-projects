using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question7
{
    public partial class Question7 : Form
    {
        public Question7()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string nameEntered = txtInput.Text;
            bool exist = false;
            for (int i =0; i < listBox1.Items.Count; i++)
            {
                if (nameEntered.Equals(listBox1.Items[i]))
                {
                    exist = true;
                    MessageBox.Show("President " + nameEntered +" is found at index " + i +".");
                    i++;
                    break;
                }
            }
            if (!exist)
            {
                MessageBox.Show("No Match Found!");
            }
        }
    }
}
