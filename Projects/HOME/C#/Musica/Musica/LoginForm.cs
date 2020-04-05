using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Musica
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegisterLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPanel.Visible = true;
            txtRegisterUsername.Text = "Username";
            txtRegisterFirstName.Text = "First Name";
            txtRegisterLastName.Text = "Last Name";
            txtRegisterEmail.Text = "Email";
            txtRegisterEmailConfirm.Text = "Confirm Email";
            txtRegisterPassword.Text = "Password";
            txtRegisterPasswordConfirm.Text = "Password";
        }

        private void LoginLinkButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPanel.Visible = false;
            LoginPanel.Visible = true;
            txtLoginUsername.Text = "Username";
            txtLoginPassword.Text = "Password";
        }

        private void FirstNamePlaceholderRemove(object sender, EventArgs e)
        {
            if (txtRegisterFirstName.Text.Equals("First Name"))
            {
                txtRegisterFirstName.Text = "";
            }
        }
        private void FirstNamePlaceholderAdd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisterFirstName.Text))
                txtRegisterFirstName.Text = "First Name";
        }

        private void LastNamePlaceholderRemove(object sender, EventArgs e)
        {
            if (txtRegisterLastName.Text.Equals("Last Name"))
            {
                txtRegisterLastName.Text = "";
            }
        }
        private void LastNamePlaceholderAdd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisterLastName.Text))
                txtRegisterLastName.Text = "Last Name";
        }

        private void EmailPlaceholderRemove(object sender, EventArgs e)
        {
            if (txtRegisterEmail.Text.Equals("Email"))
            {
                txtRegisterEmail.Text = "";
            }
        }
        private void EmailNamePlaceholderAdd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisterEmail.Text))
                txtRegisterEmail.Text = "Email";
        }

        private void EmailConfirmPlaceholderRemove(object sender, EventArgs e)
        {
            if (txtRegisterEmailConfirm.Text.Equals("Confirm Email"))
            {
                txtRegisterEmailConfirm.Text = "";
            }
        }
        private void EmailConfirmNamePlaceholderAdd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisterEmailConfirm.Text))
                txtRegisterEmailConfirm.Text = "Confirm Email";
        }

        private void PasswordLoginPlaceholderRemove(object sender, EventArgs e)
        {
            if (txtLoginPassword.Text.Equals("Password"))
            {
                txtLoginPassword.Text = "";
            }
        }
        private void PasswordLoginPlaceholderAdd(object sender, EventArgs e)
        {
            if (!(txtLoginPassword.Text.Length > 0))
                txtLoginPassword.Text = "Password";
        }

        private void PasswordRegisterPlaceholderRemove(object sender, EventArgs e)
        {
            if (txtRegisterPassword.Text.Equals("Password"))
            {
                txtRegisterPassword.Text = "";
            }
        }
        private void PasswordRegisterPlaceholderAdd(object sender, EventArgs e)
        {
            if (!(txtRegisterPassword.Text.Length > 0))
                txtRegisterPassword.Text = "Password";
        }

        private void PasswordConfirmPlaceholderRemove(object sender, EventArgs e)
        {
            if (txtRegisterPasswordConfirm.Text.Equals("Password"))
            {
                txtRegisterPasswordConfirm.Text = "";
            }
        }
        private void PasswordConfirmPlaceholderAdd(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRegisterPasswordConfirm.Text))
                txtRegisterPasswordConfirm.Text = "Password";
        }

        private void UsernameLoginPlaceholderRemove(object sender, EventArgs e)
        {

            if (txtLoginUsername.Text.Equals("Username"))
            {
                txtLoginUsername.Text = "";
            }
        }
        private void UsernameLoginPlaceholderAdd(object sender, EventArgs e)
        {
            if (!(txtLoginUsername.Text.Length > 0))
            {
                txtLoginUsername.Text = "Username";
            }
        }

        private void UsernameRegisterPlaceholderRemove(object sender, EventArgs e)
        {

            if (txtRegisterUsername.Text.Equals("Username"))
            {
                txtRegisterUsername.Text = "";
            }
        }
        private void UsernameRegisterPlaceholderAdd(object sender, EventArgs e)
        {
            if (!(txtRegisterUsername.Text.Length > 0))
            {
                txtRegisterUsername.Text = "Username";
            }
        }
   
        private void OpenHomePage(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.FormClosed += new FormClosedEventHandler(CloseAll);
            home.ShowDialog();
        }

        private void OpenHomePageRegister(object sender, EventArgs e)
        {
            string usernameRegister = txtRegisterUsername.Text;
            string firstName = txtRegisterFirstName.Text;
            string lastName = txtRegisterLastName.Text;
            string passwordRegister = txtRegisterPassword.Text;
            string confirmPasswordRegister = txtRegisterPasswordConfirm.Text;
            string encryptedPassword = "";
            string email = txtRegisterEmail.Text;
            string emailConfirm = txtRegisterEmailConfirm.Text;
            

            if (usernameRegister.Length > 0 && firstName.Length > 0 && lastName.Length > 0 && passwordRegister.Length > 0 && confirmPasswordRegister.Length > 0 && email.Length > 0 && emailConfirm.Length > 0)
            {
                if (ValidMail(email))
                {
                    if (ConfirmEmail(email, emailConfirm))
                    {
                        if (passwordRegister.Equals(confirmPasswordRegister))
                        {
                           encryptedPassword =  MD5Hash(passwordRegister);

                            using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=U:\Desktop\Musica\Musica\MusicaDB.mdf;Integrated Security=True"))
                            {
                                string query = "INSERT INTO dbo.Users (id,username,password,email) VALUES (@username,@firstName,@lastName,@password,@email)";

                                using (SqlCommand command = new SqlCommand(query, conn))
                                {
                                    conn.Open();
                                    command.Parameters.AddWithValue("@username", usernameRegister);
                                    command.Parameters.AddWithValue("@password", encryptedPassword);
                                    command.Parameters.AddWithValue("@email", email);
                                    command.Parameters.AddWithValue("@firstName", firstName);
                                    command.Parameters.AddWithValue("@lastName", lastName);                                    
                                    command.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }                            
                        }
                    }
                }
            }

            this.Hide();
            Home home = new Home();
            home.FormClosed += new FormClosedEventHandler(CloseAll);
            home.ShowDialog();
        }

        private bool ValidMail(string address)
        {
            EmailAddressAttribute e = new EmailAddressAttribute();
            if (e.IsValid(address))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Email Address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private bool ConfirmEmail(string address, string addressConfirm)
        {
            if (address.Equals(addressConfirm))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Emails do not match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void CloseAll(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
