using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question3
{
    public partial class Question3 : Form
    {
        public Question3()
        {
            InitializeComponent();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            outputListBox.Items.Clear();
            int number = int.Parse(txtInput.Text);
            if (number >= 0)
            {
                for (int i = 1; i < number + 1; i++)
                {
                    outputListBox.Items.Add(i);
                }
            }
        }
    }
}
