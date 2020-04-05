using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeScheme_Form
{
    public partial class Form1 : Form
    {
         char grade;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double mark = double.Parse(GradeInput.Text);
            CheckGrade(mark);
        }

        public  void CheckGrade(double x)
        {
            do
            {
                if (x < 40)
                {
                    grade = 'F';
                }
                else if (x > 39 && x < 50)
                {
                    grade = 'D';
                }
                else if (x > 49 && x < 60)
                {
                    grade = 'C';
                }
                else if (x > 59 && x < 70)
                {
                    grade = 'B';
                }
                else
                {
                    grade = 'A';
                }
                Output.Text = $"Grade: {grade}";
                break;
            } while (true);
        }
    }
}
