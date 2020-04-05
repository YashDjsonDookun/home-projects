using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question1
{
    public partial class Dental_Form : Form
    {
        public Dental_Form()
        {
            InitializeComponent();
        }

        public void FormLoad(object sender, EventArgs e)
        {
            Clicked();
        }

        public void Clicked()
        {
            if (rad_regular.Checked)
            {
                Regular();
            }
            else
            {
                Visiting();
            }
        }

        public void Regular()
        {
            if (chk_cleaning.Checked)
            {
                txt_cleaning.Text = "400";
            }
            else
            {
                txt_cleaning.Text = "0";
            }

            if (chk_filling.Checked)
            {
                txt_filling.Text = "600";
            }
            else
            {
                txt_filling.Text = "0";
            }

            if (chk_xray.Checked)
            {
                txt_xray.Text = "500";
            }
            else
            {
                txt_xray.Text = "0";
            }

            int total = (int.Parse(txt_cleaning.Text)) + (int.Parse(txt_filling.Text)) + (int.Parse(txt_xray.Text));
            txt_total.Text = total.ToString();
        }

        public void Visiting()
        {
            if (chk_cleaning.Checked)
            {
                txt_cleaning.Text = "500";
            }
            else
            {
                txt_cleaning.Text = "0";
            }

            if (chk_filling.Checked)
            {
                txt_filling.Text = "700";
            }
            else
            {
                txt_filling.Text = "0";
            }

            if (chk_xray.Checked)
            {
                txt_xray.Text = "600";
            }
            else
            {
                txt_xray.Text = "0";
            }
            int total = (int.Parse(txt_cleaning.Text)) + (int.Parse(txt_filling.Text)) + (int.Parse(txt_xray.Text));
            txt_total.Text = total.ToString();
        }
    }
}
