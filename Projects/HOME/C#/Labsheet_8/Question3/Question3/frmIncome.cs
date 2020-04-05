using System;
using System.Windows.Forms;

namespace Question3
{
    public partial class frmIncome : Form
    {
        public static string name;
        public static bool flag = true;
        public frmIncome()
        {
            InitializeComponent();
        }

        private void Btn_determineIncome_Click(object sender, EventArgs e)
        {
            
            name = txt_name.Text;
            /* STEP 6 */
            //frmSources sources = new frmSources();
            //sources.ShowDialog();
            //txt_TotalIncome.Text = frmSources.calculatedTotalIncome;

            /* STEP 12*/
            this.Hide();
            frmSources sources = new frmSources();
            sources.FormClosed += new FormClosedEventHandler(showIncomeForm);
            sources.Show();
        }

        private void showIncomeForm(object sender, EventArgs e)
        {
            this.Show();
            txt_TotalIncome.Text = frmSources.calculatedTotalIncome;
        }

        private void ClosingDialogue(object sender, EventArgs e)
        {
            MessageBox.Show("Good Bye!", "GoodBye!", MessageBoxButtons.OK);
        }
    }
}
