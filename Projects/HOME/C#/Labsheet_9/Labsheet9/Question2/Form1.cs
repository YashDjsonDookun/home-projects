using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Question2
{
    public partial class Question2 : Form
    {
        int id;
        string name, course;
        int index;
        List<int> ids = new List<int>();
        List<string> names = new List<string>();
        List<string> courses = new List<string>();

        public Question2()
        {
            InitializeComponent();
        }

        private void AddToList(object sender, EventArgs e)
        {
            if (txt_id.TextLength > 0 && txt_name.TextLength > 0 && txt_course.TextLength > 0)
            {
                id = int.Parse(txt_id.Text);
                name = txt_name.Text;
                course = txt_course.Text;
                if (!lst_idList.Items.Contains(id))
                {
                    ids.Add(id);
                    names.Add(name);
                    courses.Add(course);
                    lst_idList.Items.Add(id);
                }
                else
                {
                    MessageBox.Show("This ID is already taken! Please select another one!","OOps",MessageBoxButtons.OK);
                }
            }
            lst_idList.Sorted = true;
        }

        private void ClearBtn(object sender, EventArgs e)
        {
            Clear();
        }

        private void SelectionButton(object sender, EventArgs e)
        {
            Selection();
        }

        private int Selection()
        {
            index = lst_idList.SelectedIndex;
            if (index >= 0)
            {
                //ids.Sort();
                txt_id.Text = ids[index].ToString();
                txt_name.Text = names[index];
                txt_course.Text = courses[index];
                txt_id.ReadOnly = true;
                btn_add.Enabled = false;
            }
            return index;
        }

        private void Clear()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_course.Clear();
        }

        private void EditButton(object sender, EventArgs e)
        {
            txt_id.ReadOnly = false;
            name = txt_name.Text;
            course = txt_course.Text;

            names[index] = name;
            courses[index] = course;
            btn_add.Enabled = true;
        }

        private void DeleteButton(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Are you sure you want to delete this entry?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Delete(index);
            }
        }

        private void Delete(int x)
        {
            lst_idList.Items.RemoveAt(x);
            if (lst_idList.Items.Count > 1)
            {
                lst_idList.SetSelected(x, true);
                lst_idList.Items[lst_idList.SelectedIndex] = ids[x + 1].ToString(); ;
                ids[x] = ids[x+1];
                names[x] = names[x+1];
                courses[x] = courses[x+1];

                txt_id.Text = ids[x].ToString();
                txt_name.Text = names[x];
                txt_course.Text = courses[x];
            }
            else {
                if (x <= lst_idList.Items.Count)
                {
                    lst_idList.SetSelected(x, true);
                    lst_idList.Items[lst_idList.SelectedIndex] = ids[x + 1].ToString(); ;
                    ids[x] = ids[x - 1];
                    names[x] = names[x - 1];
                    courses[x] = courses[x - 1];

                    txt_id.Text = ids[x].ToString();
                    txt_name.Text = names[x];
                }
                else
                {
                    Clear();
                }
            }
            btn_add.Enabled = true;
        }
    }
}
