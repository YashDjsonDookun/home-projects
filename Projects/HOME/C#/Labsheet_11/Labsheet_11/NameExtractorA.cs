using System;
using System.Windows.Forms;

namespace Labsheet_11
{
    public partial class NameExtractorA : Form
    {
        public NameExtractorA()
        {
            InitializeComponent();
        }

        private void Btn_Display_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_middleName.Clear();
            txt_lastname.Clear();

            string[] tokens = (txt_input.Text).Split(null);
            /* First Name */
            txt_fname.Text = tokens[0];

            
            /* Middle Names */

            // Method 1

            if (tokens.Length > 2)
            {
                string middleName = "";
                for (int i = 1; i < tokens.Length - 1; i++)
                {
                    middleName += tokens[i] + " ";
                }
                middleName.TrimEnd();
                txt_middleName.Text = middleName;
            }


            // Method 2

            //if (tokens.Length > 2)
            //{
            //    List<string> tokens2 = new List<string>();
            //    for (int i = 1; i < tokens.Length - 1; i++)
            //    {
            //        tokens2.Add(tokens[i]);
            //    }
            //    string middleName = "";
            //    foreach (string token in tokens2)
            //    {
            //        middleName += token + " ";
            //    }
            //    middleName.TrimEnd();
            //    txt_middleName.Text = middleName;
            //}


            /* Last Name */
            if (tokens.Length > 1)
            {
                txt_lastname.Text = tokens[tokens.Length - 1];
            }
        }
    }
}
