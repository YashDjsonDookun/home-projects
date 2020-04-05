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
    public partial class Vowels_and_Consonants : Form
    {
        public Vowels_and_Consonants()
        {
            InitializeComponent();
        }

        private void Btn_find_Click(object sender, EventArgs e)
        {
            txt_output.Text = "There are " + FindVowel(txt_input.Text) + " vowels and " + FindConsonant(txt_input.Text, numVowel) + " consonants.";
        }

        int numVowel = 0;
        private int FindVowel(String str)
        {
            foreach (char ch in str)
            {
                switch (char.ToLower(ch))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        numVowel++;
                        break;
                }
            }
            return numVowel;
        }

        private int FindConsonant(String str, int numVowel)
        {
            int numLetter = 0;


            foreach (char ch in str)
            {
                if(char.IsLetter(ch))
                {
                    numLetter++;
                }
            }
            return numLetter - numVowel;
        }
    }
}
