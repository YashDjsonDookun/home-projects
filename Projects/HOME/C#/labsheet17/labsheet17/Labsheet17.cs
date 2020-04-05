using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labsheet17
{
    public partial class Labsheet17 : Form
    {
        public Labsheet17()
        {
            InitializeComponent();
        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            Question1 question1 = new Question1();
            question1.Show();
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            Question2 question2 = new Question2();
            question2.Show();
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            Question3 question3 = new Question3();
            question3.Show();
        }
    }
}
