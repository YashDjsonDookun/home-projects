using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labsheet_11
{
    public partial class FirstName : Form
    {
        public FirstName()
        {
            InitializeComponent();
        }

        private void Btn_determine_Click(object sender, EventArgs e)
        {
            txt_output.Text = Firstname(txt_input.Text);
        }

        private string Firstname(string fullname)
        {
            string[] tokens = fullname.Split(null);
            string fname = tokens[0];
            return fname;
        }
    }
}
