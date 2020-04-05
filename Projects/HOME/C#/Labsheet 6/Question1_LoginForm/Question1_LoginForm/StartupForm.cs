using System;
using System.Windows.Forms;
using System.Diagnostics;



namespace Question1_LoginForm
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void BtnQuestion1_Click(object sender, EventArgs e)
        {
            Question1_LoginForm LoginForm = new Question1_LoginForm();
            LoginForm.ShowDialog();
        }

        private void BtnQuestion2_Click(object sender, EventArgs e)
        {
            Process.Start("Question2_MinMaxTotalAvg");
        }

        private void BtnWageCalculator_Click(object sender, EventArgs e)
        {
            Question3_WageCalculator wageCalculator = new Question3_WageCalculator();
            wageCalculator.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Process.Start("Question4_MonthsDays");
        }

        private void BtnSpeedingTicket_Click(object sender, EventArgs e)
        {
            Question5_SpeedingTicket speedingTicket = new Question5_SpeedingTicket();
            speedingTicket.ShowDialog();
        }

        private void BtnMovieTicket_Click(object sender, EventArgs e)
        {
            MovieTicket movieTicket = new MovieTicket();
            movieTicket.ShowDialog();
        }

        private void BtnCarCoverPt1_Click(object sender, EventArgs e)
        {
            Question7_carCoverPt1 carCoverOne = new Question7_carCoverPt1();
            carCoverOne.ShowDialog();
        }

        private void BtnCarCoverPt2_Click(object sender, EventArgs e)
        {
            Question8_CarCoverPt2 carCoverTwo = new Question8_CarCoverPt2();
            carCoverTwo.ShowDialog();
        }

        private void BtnKFC_Click(object sender, EventArgs e)
        {
            Question9_KFC kfc = new Question9_KFC();
            kfc.ShowDialog();
        }

        private void BtnIceCream_Click(object sender, EventArgs e)
        {
            Question10_IceCream iceCream = new Question10_IceCream();
            iceCream.ShowDialog();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
