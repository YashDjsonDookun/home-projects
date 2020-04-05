using System;
using System.Windows.Forms;

namespace Question3
{
    public partial class frmSources : Form
    {
        public static string calculatedTotalIncome;
        public frmSources()
        {
            InitializeComponent();
        }

        private void FrmSources_Load(object sender, EventArgs e)
        {
            txt_name.Text = frmIncome.name;
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            txt_wages.Clear();
            txt_interest.Clear();
            txt_dividend.Clear();
        }

        private void Btn_computeIncome_Click(object sender, EventArgs e)
        {
            calculatedTotalIncome = ((int.Parse(txt_wages.Text)) + (int.Parse(txt_interest.Text)) + (int.Parse(txt_dividend.Text))).ToString("C2");
            this.Close();
        }
    }
}
