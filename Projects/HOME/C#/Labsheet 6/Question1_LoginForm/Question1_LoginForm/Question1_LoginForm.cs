using System;
using System.Windows.Forms;

namespace Question1_LoginForm
{
    public partial class Question1_LoginForm : Form
    {
        public Question1_LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            verifyLogin(username, password);
        }

        public void verifyLogin(string x, string y)
        {
            if (((x.Equals("John")) && (y.Equals("Smith"))) || (x.Equals("Paula")) && (y.Equals("Jones")))
            {
                txtMessage.Text = "Login Successful";
            }
            else
            {
                txtMessage.Text = "Please try again";
            }
        }
    }
}
