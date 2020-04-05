using System;
using System.Diagnostics;
using System.Windows.Forms;
using Question1;
using Question2;
using Question3;
using Question3_pt_b;
using Question4;
using Question4_pt_b;
using Question5;
using Question6;
using Question7;
using Question7_pt_b;
using Question7_pt_c;

namespace Labsheet7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("Question1.exe");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Question2.Form1 question2 = new Question2.Form1();
            question2.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Question3.Question3 question3 = new Question3.Question3();
            question3.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Question3_pt_b.Form1 question3ptb = new Question3_pt_b.Form1();
            question3ptb.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Question4.Question4 question4 = new Question4.Question4();
            question4.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Question4_pt_b.Form1 question4ptb = new Question4_pt_b.Form1();
            question4ptb.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Question5.Question5 question5 = new Question5.Question5();
            question5.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Question6.Question6 question6 = new Question6.Question6();
            question6.Show();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            Question7.Question7 question7 = new Question7.Question7();
            question7.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Question7_pt_b.Form1 question7ptb = new Question7_pt_b.Form1();
            question7ptb.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Question7_pt_c.Form1 question7ptc = new Question7_pt_c.Form1();
            question7ptc.Show();
        }
    }
}
