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
    public partial class NameSplitter : Form
    {
        public NameSplitter()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            lst_namelist.Items.Clear();
            string[] tokens = (txt_input.Text).Split(';');
            foreach (string token in tokens)
            {
                lst_namelist.Items.Add(token);
            }
        }
    }
}
