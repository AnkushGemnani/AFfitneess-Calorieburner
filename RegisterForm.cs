using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AGFitness
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Get the text from the text boxes
            string userName = UserNametxt.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNametxt.Text;
            string email = Emailtxt.Text;
            string password = passtxt.Text;
            string confirmPassword = cnfrmpasstxt.Text;
            string securityQuestion = squescombo.Text;
            string securityAnswer = sanstxt.Text;

            // Check if any of the fields are empty
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(securityQuestion) ||
                string.IsNullOrEmpty(securityAnswer))
            {
                // Show a message to the user that some fields are empty
                MessageBox.Show("Please fill in all the required fields.", "Empty Fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("The password and confirm password do not match. Please enter them again.",
                    "Confirm Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate password requirements (minimum 12 characters, 1 uppercase, 1 lowercase)
            if (!ValidatePassword(password))
            {
                MessageBox.Show("Password must be at least 12 characters and contain at least one uppercase and one lowercase letter.",
                  "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidateUsernameFormat(userName))
            {
                MessageBox.Show("Username cannot contain special characters.", "Invalid Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of the DataInsertion class
            DataInsertion insertObj = new DataInsertion();

            // Insert the user data into the database
            bool inserted = insertObj.insertUser(userName, password, firstName, lastName, securityQuestion, securityAnswer);

            if (inserted)
            {
                // Show message box for successful insertion
                MessageBox.Show("User registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Navigate to the login page
                Login loginForm = new Login(); // Assuming Login is the name of your login form
                loginForm.Show();
                this.Hide();
            }
            else
            {
                // Handle potential insertion failure (e.g., database error)
                MessageBox.Show("An error occurred while registering the user. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePassword(string password)
        {
            // Regular expression for password validation
            const string passwordPattern = "^(?=.*?[A-Z])(?=.*?[a-z]).{12,}$";

            return Regex.IsMatch(password, passwordPattern);
        }
        private bool ValidateUsernameFormat(string username)
        {
            // Define a regular expression pattern to allow only letters and numbers
            string pattern = "^[a-zA-Z0-9]+$";

            // Create a Regex object and match the username against the pattern
            Regex regex = new Regex(pattern);
            return regex.IsMatch(username);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserNametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
