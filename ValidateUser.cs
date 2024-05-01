using System;
using System.Data.OleDb;

namespace AGFitness
{
    internal class ValidateUser
    {
        private string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/91968/source/repos/AGFitness/Ddocp_project.mdb";  // Replace with your path

        public int validateuser(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM users WHERE username = ?";
                using (OleDbConnection connection = new OleDbConnection(connString))
                {
                    connection.Open();
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    int signInAttempts = Convert.ToInt32(reader["sign_in_attempts"]);

                                    if (signInAttempts >= 3)
                                    {
                                        return 0; // User has exceeded sign-in attempts
                                    }
                                    else if (password == reader["password"].ToString())
                                    {
                                        // Reset sign-in attempts
                                        string resetQuery = "UPDATE users SET sign_in_attempts = 0 WHERE username = ?";
                                        using (OleDbCommand resetCommand = new OleDbCommand(resetQuery, connection))
                                        {
                                            resetCommand.Parameters.AddWithValue("@username", username);
                                            resetCommand.ExecuteNonQuery();
                                        }

                                        return 1; // Successful login
                                    }
                                    else
                                    {
                                        // Increment sign-in attempts
                                        string incrementQuery = "UPDATE users SET sign_in_attempts = sign_in_attempts + 1 WHERE username = ?";
                                        using (OleDbCommand incrementCommand = new OleDbCommand(incrementQuery, connection))
                                        {
                                            incrementCommand.Parameters.AddWithValue("@username", username);
                                            incrementCommand.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                return 2; // Username not found
            }
            catch (Exception ex)
            {
                // Handle any exceptions here
                return 3; // Error occurred
            }
        }
    }
}
