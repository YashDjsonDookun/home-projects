using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Labsheet_10
{
    public partial class Labsheet_10 : Form
    {
        public Labsheet_10()
        {
            InitializeComponent();
        }

        private void Btn_question1_Click(object sender, EventArgs e)
        {
            Process.Start("Question_1.exe");
        }

        private void Btn_Question1_b_Click(object sender, EventArgs e)
        {
            Process.Start("Question_1_b.exe");
        }

        private void Btn_Question1_c_Click(object sender, EventArgs e)
        {
            Process.Start("Question_1_c.exe");
        }

        private void Btn_Question2_Click(object sender, EventArgs e)
        {
            Process.Start("Question_2.exe");
        }

        private void Btn_Question3_Click(object sender, EventArgs e)
        {
            Process.Start("Question_3.exe");
        }

        private void Btn_Question4_Click(object sender, EventArgs e)
        {
            Process.Start("Question_4.exe");
        }

        private void Btn_Question5_Click(object sender, EventArgs e)
        {
            Process.Start("Question_5.exe");
        }

        private void Btn_Question5_b_Click(object sender, EventArgs e)
        {
            Process.Start("Question_5_b.exe");
        }

        private void Btn_Question6_Click(object sender, EventArgs e)
        {
            Process.Start("Question_6.exe");
        }

        private void Btn_Question7_Click(object sender, EventArgs e)
        {
            Process.Start("Question_7.exe");
        }
    }
}
