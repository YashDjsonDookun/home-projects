using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labsheet__13
{
    public partial class EntryPoint : Form
    {
        public EntryPoint()
        {
            InitializeComponent();
        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            Question1 question1 = new Question1();
            question1.Show();
        }
    }
}
