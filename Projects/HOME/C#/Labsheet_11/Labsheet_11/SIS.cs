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
    public partial class SIS : Form
    {
        List<Student> allStudents = new List<Student>();

        public SIS()
        {
            InitializeComponent();
        }

        struct Student
        {
            public int id;
            public string name;
            public double cpa;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            Student myStud = new Student();
            myStud.id = int.Parse(txt_id.Text);
            myStud.name = txt_name.Text;
            myStud.cpa = double.Parse(txt_cpa.Text);

            allStudents.Add(myStud);
            lst_ids.Items.Add(myStud.id);
            Clear();
        }

        private void Lst_ids_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student myStud = allStudents[lst_ids.SelectedIndex];

            txt_id.Text = myStud.id.ToString();
            txt_name.Text = myStud.name.ToString();
            txt_cpa.Text = myStud.cpa.ToString();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            allStudents.RemoveAt(lst_ids.SelectedIndex);
            lst_ids.Items.RemoveAt(lst_ids.SelectedIndex);
        }

        private void Btn_edit_Click(object sender, EventArgs e)
        {
            int index = lst_ids.SelectedIndex;

            Student myStud = new Student();
            myStud.id = int.Parse(txt_id.Text);
            myStud.name = txt_name.Text;
            myStud.cpa = double.Parse(txt_cpa.Text);

            allStudents.RemoveAt(index);
            allStudents.Insert(index, myStud);
            lst_ids.Items.RemoveAt(index);
            lst_ids.Items.Insert(index, myStud.id);
            Clear();
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txt_cpa.Clear();
            txt_id.Clear();
            txt_name.Clear();
        }
    }
}
