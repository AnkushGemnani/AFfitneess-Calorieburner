using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AGFitness
{
    public partial class ForgotPass : Form
    {
        private string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/91968/source/repos/AGFitness/Ddocp_project.mdb";  // Replace with your path
        public ForgotPass()
        {
            InitializeComponent();

        }

        private void forgot_login_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string selectedQuestion = txtsquestion.SelectedItem?.ToString(); // Get selected security question
            string answer = txtsanswer.Text;

            // Example: Retrieve password from database based on username, question, and answer
            string correctPassword = DatabaseHelper.RetrievePassword(username, selectedQuestion, answer);

            if (!string.IsNullOrEmpty(correctPassword))
            {
                MessageBox.Show($"Your password is: {correctPassword}", "Password Retrieval", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Incorrect username or security question/answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Increment sign-in attempts
            string incrementQuery = "UPDATE users SET sign_in_attempts = 0 WHERE username = ?";
            OleDbConnection connection = new OleDbConnection(connString);
            connection.Open();
            using (OleDbCommand incrementCommand = new OleDbCommand(incrementQuery, connection))
            {
                incrementCommand.Parameters.AddWithValue("@username", username);
                incrementCommand.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void lblForgotpass_Click(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsquestion_Click(object sender, EventArgs e)
        {

        }

        private void txtsquestion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtsanswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void ForgotPass_Load(object sender, EventArgs e)
        {

        }
    }
}
