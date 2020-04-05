using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineSession
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
        List<Student> allStudents = new List<Student>();
        private void btnEnter_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.Name = txtName.Text;
            stud.Sid = int.Parse(txtId.Text);
            stud.Midterm = double.Parse(txtMid.Text);
            stud.Final = double.Parse(txtFinal.Text);

            allStudents.Add(stud);
            lstGrades.Items.Clear();
            lstGrades.Items.Add($"Student {stud.Name} recorded!");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string fmtStr = "{0,-20}{1,-40}{2,-4}";

            lstGrades.Items.Clear();
            
            foreach (Student stud in allStudents)
            {
                lstGrades.Items.Add(String.Format(fmtStr, stud.Sid, stud.Name, stud.CalcSemGrade()));
            }
        }
    }
}
