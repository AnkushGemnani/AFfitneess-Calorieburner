using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace AGFitness
{
    internal class DataInsertion
    {
        String connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/91968/source/repos/AGFitness/Ddocp_project.mdb";
   

        public bool insertUser(String username,String password,String firstname, String lastname, String secquestion, String secanswer)
        {
            
            string query = "INSERT INTO users([username],[password], [first_name],[last_name],[security_question], [security_answer],[sign_in_attempts]) VALUES(?,?,?,?,?,?,0);";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userName", username);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@firstName", firstname);
                    command.Parameters.AddWithValue("@lastName", lastname);
                    command.Parameters.AddWithValue("@secquestion", secquestion);
                    command.Parameters.AddWithValue("@secanswer", secanswer);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            return true;

          
        }

    }
}
