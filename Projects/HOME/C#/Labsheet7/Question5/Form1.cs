using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question5
{
    public partial class Question5 : Form
    {
        public Question5()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lstSorted.Items.Clear();
            int n = lstStates.Items.Count;
            for (int i=0; i < 10; i++)
            {
                lstSorted.Items.Add(lstStates.Items[n - 1]);
                n--;
            }
        }
    }
}
