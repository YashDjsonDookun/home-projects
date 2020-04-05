using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2ptA
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
            else
            {
                txt_selectedItem.Text = "";
            }
        }

        private void Btn_addItem_Click(object sender, EventArgs e)
        {
            lst_fruitList.Items.Add(txt_addItem.Text);
            txt_addItem.Clear();
        }

        public void RemoveSelectedItem(object sender, EventArgs e)
        {
            if (lst_fruitList.SelectedIndex >= 0)
            {
                lst_fruitList.Items.Remove(lst_fruitList.SelectedItem);
            }
        }
    }
}
