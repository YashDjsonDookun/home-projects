using System;
using System.Windows.Forms;

namespace Labsheet_11
{
    public partial class NameExtractorB : Form
    {
        public NameExtractorB()
        {
            InitializeComponent();
        }
        private void Btn_Display_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_middleName.Clear();
            txt_lastname.Clear();

            string[] tokens = (txt_input.Text).Split(null);
            bool numberFound = false;
            foreach (string token in tokens)
            {
                for (int i=0; i < token.Length; i++)
                {
                    if (char.IsDigit(token, i))
                    {
                        numberFound = true;                     
                    }
                }
            }
            if ((!(tokens.Length > 1)) || string.IsNullOrWhiteSpace(tokens[0]) || string.IsNullOrWhiteSpace(tokens[tokens.Length -1]) || numberFound)
            {
                MessageBox.Show("Invalid Name! Name must follow the format:\n" +
                    "First Name [Optional Middle Name(s).] Last Name", "Name entered NOT valid!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /* First Name */
                txt_fname.Text = tokens[0];

                /* Middle Names */
                if (tokens.Length > 2)
                {
                    string middleName = "";
                    for (int i = 1; i < tokens.Length - 1; i++)
                    {
                        middleName += tokens[i] + " ";
                    }
                    //middleName.TrimEnd();
                    txt_middleName.Text = middleName;
                }

                /* Last Name */
                if (tokens.Length > 1)
                {
                    txt_lastname.Text = tokens[tokens.Length - 1];
                }
            }
        }
    }
}
