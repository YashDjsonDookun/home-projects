using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2ptB
{
    public partial class Fruit_List : Form
    {
        public Fruit_List()
        {
            InitializeComponent();
        }

        public void DisplaySelectedItem(object sender, EventArgs e)
        {
            if (lst_fruitList.SelectedIndex >= 0)
            {
                txt_selectedItem.Text = lst_fruitList.SelectedItem.ToString();
            }
        }

        public void Btn_addItem_Click(object sender, EventArgs e)
        {
            if (!lst_fruitList.Items.Contains(txt_addItem.Text))
            {
                if (txt_addItem.Text.Length > 0)
                {
                    lst_fruitList.Items.Add(txt_addItem.Text);
                    txt_addItem.Clear();
                    txt_selectedItem.Clear();
                }
            }
            else
            {
                MessageBox.Show($"Fruit {txt_addItem.Text} already exists!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RemoveSelectedItem(object sender, EventArgs e)
        {
            if (lst_fruitList.SelectedIndex >= 0)
            {
                lst_fruitList.Items.Remove(lst_fruitList.SelectedItem);
                txt_selectedItem.Clear();
            }
        }
    }
}
