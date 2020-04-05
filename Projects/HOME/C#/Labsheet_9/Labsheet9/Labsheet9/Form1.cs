using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labsheet9
{
    public partial class Labsheet9 : Form
    {
        public Labsheet9()
        {
            InitializeComponent();
        }

        private void Btn_Question1_Click(object sender, EventArgs e)
        {
            Question1.Question1 question1 = new Question1.Question1();
            question1.ShowDialog();
        }

        private void Btn_Question2_Click(object sender, EventArgs e)
        {
            Question2.Question2 question2 = new Question2.Question2();
            question2.ShowDialog();
        }

        private void Btn_Question3_Click(object sender, EventArgs e)
        {
            Process.Start("Question3.exe");
        }
    }
}
