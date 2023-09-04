using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace WarehouseFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.TextChanged += txtPassword_TextChanged;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate the credentials (replace with your actual logic)
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateCredentials(username, password))
            {
                labelLoginSuccess.ForeColor = Color.Green;
                labelLoginSuccess.Text = "Login successful! \n Please wait...";

                Thread.Sleep(2000);

                DialogResult = DialogResult.OK;


            }
            else
            {
                lblErrorMessage.Text = "Incorrect username or password!";
                lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            ClearErrorMessage();
        }
        private void ClearErrorMessage()
        {
            lblErrorMessage.Text = string.Empty;
        }
        private Dictionary<string, string> validCredentials = new Dictionary<string, string>
        {
           { "admin", "123456" },
           { "Martin", "02092001" },
           { "user2", "22222" },


        };

        private bool ValidateCredentials(string username, string password)
        {
            if (validCredentials.ContainsKey(username))
            {
                return validCredentials[username] == password;
            }
            return false;
        }


        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            // Check if the Show Password checkbox is checked
            if (chkShowPassword.Checked)
            {
                // Show the actual password characters
                txtPassword.PasswordChar = '\0'; // Set to '\0' to show characters
            }
            else
            {
                // Mask the password characters with asterisks
                txtPassword.PasswordChar = '*'; // Set to '*' to show asterisks
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Update the UseSystemPasswordChar property based on the checkbox state
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

    }
}
