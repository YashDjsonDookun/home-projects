using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBox_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (KennedyBtn.Checked)
            {
                output.Text = "You Voted for Kennedy";
            }
            else
            {
                output.Text = "You Votes for Nixon";
            }
        }
    }
}
