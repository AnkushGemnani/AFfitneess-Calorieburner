using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; // Import OleDb namespace


namespace AGFitness
{
    internal class DatabaseHelper
    {
        private static string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/91968/source/repos/AGFitness/Ddocp_project.mdb";

        public static string RetrievePassword(string username, string selectedQuestion, string answer)
        {
            string password = null;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT password FROM users WHERE username = @username AND security_question = @question AND security_answer = @answer";
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@question", selectedQuestion);
                    command.Parameters.AddWithValue("@answer", answer);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        password = result.ToString();
                    }
                }
            }

            return password;
        }
    }
}

