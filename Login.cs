using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AGFitness
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            // Get username and password from text boxes (assuming you have them)
            string username = usernametxt.Text;
            string password = passtxt.Text;
            ValidateUser authenticator = new ValidateUser();

            // Check if any fields are empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate the user using the authenticator
            int validateUser = authenticator.validateuser(username, password);

            if (validateUser == 1)
            {
                MessageBox.Show("Logged in successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Navigate to the main application form
                // Assuming you have a main application form
                this.Hide();
                HomePage homepage = new HomePage(username, password);
                homepage.Show();
            }
            else if (validateUser == 2)
            {
                MessageBox.Show("Invalid user and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validateUser == 3)
            {
                MessageBox.Show("Database error.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (validateUser == 0)
            {
                MessageBox.Show("Your account has been locked due to multiple wrong attempts. Please recover your account.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            passtxt.UseSystemPasswordChar = !checkBox1.Checked;

        }

        private void lblRegisterpage_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerPage = new RegisterForm();
            registerPage.Show();
            this.Hide();
        }

        private void lblforgetpass_Click(object sender, EventArgs e)
        {
            var forget = new ForgotPass();
            forget.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            passtxt.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
