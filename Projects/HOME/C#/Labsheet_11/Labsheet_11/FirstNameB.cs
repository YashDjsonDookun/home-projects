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
    public partial class FirstNameB : Form
    {
        public FirstNameB()
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
            string fname = "";
            if (tokens.Length>1)
            {
                fname = tokens[0];
            }
            else
            {
                MessageBox.Show("Invalid Name! Name must follow the format:\n" +
                    "First Name [Optional Middle Name(s)] Last Name", "Name entered NOT valid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return fname;
        }
    }
}
