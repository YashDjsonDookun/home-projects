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
    public partial class Labsheet_11 : Form
    {
        public Labsheet_11()
        {
            InitializeComponent();
        }

        private void Btn_Question1_Click(object sender, EventArgs e)
        {
            Vowels_and_Consonants vowelsAndConsonants = new Vowels_and_Consonants();
            vowelsAndConsonants.ShowDialog();
        }

        private void Btn_Question2a_Click(object sender, EventArgs e)
        {
            FirstName FN = new FirstName();
            FN.ShowDialog();
        }

        private void Btn_Question2b_Click(object sender, EventArgs e)
        {
            FirstNameB FNb = new FirstNameB();
            FNb.ShowDialog();
        }

        private void Btn_Question3a_Click(object sender, EventArgs e)
        {
            NameExtractorA NEa = new NameExtractorA();
            NEa.ShowDialog();
        }

        private void Btn_Question3b_Click(object sender, EventArgs e)
        {
            NameExtractorB NEb = new NameExtractorB();
            NEb.ShowDialog();
        }

        private void Btn_Question4_Click(object sender, EventArgs e)
        {
            NameSplitter NS = new NameSplitter();
            NS.ShowDialog();
        }

        private void Btn_Question5_Click(object sender, EventArgs e)
        {
            SIS sis = new SIS();
            sis.ShowDialog();
        }
    }
}
