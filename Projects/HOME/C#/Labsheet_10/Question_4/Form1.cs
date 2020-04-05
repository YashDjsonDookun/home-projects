using System;
using System.Windows.Forms;

namespace Question_4
{
    public partial class Question4 : Form
    {
        public Question4()
        {
            InitializeComponent();
        }

        private void marks_TextChanged(object sender, EventArgs e)
        {
            if (txt_mark.Text.Length > 0)
            {
                int marks = int.Parse(txt_mark.Text);
                txt_grade.Text = Grade(marks).ToString();
            }
           else
            {
                txt_grade.Clear();
            }
        }

        private static char Grade(int x)
        {
            char grade = ' ';
            int temp = x / 10;
            switch (temp)
            {
                case 10:
                case 9:
                case 8:
                    grade = 'A';
                    break;
                case 7:
                case 6:
                    grade = 'B';
                    break;
                case 5:
                case 4:
                    grade = 'C';
                    break;
                case 3:
                case 2:
                case 1:
                case 0:
                    grade = 'D';
                    break;
            }
            return grade;
        }

    }
}
