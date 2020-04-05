using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3_pt_b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, EventArgs e) {
            outputListBox.Items.Clear();
            int number = int.Parse(txtInput.Text);
                {
                    for (int i = 0; i <= number; i = i+2)
                    {
                        outputListBox.Items.Add(i);
                    }
                }
            }
        }
    }


