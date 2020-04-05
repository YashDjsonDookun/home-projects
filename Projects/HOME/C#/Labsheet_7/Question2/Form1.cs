using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddToList();
        }

        public void AddToList()
        {
            for (int i=10; i >= 0; i--)
            {
                if (i > 0)
                {
                    listBox.Items.Add(i);
                }
                else if (i == 0)
                {
                    listBox.Items.Add("The rocket is now launched!");
                }
            }
        }
    }
}
