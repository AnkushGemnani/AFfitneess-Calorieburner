using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;

namespace AGFitness
{
    internal class RetrieveData
    {
        public String fullName, Age, Gender, Height, calGoal, username,
        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/91968/source/repos/AGFitness/Ddocp_project.mdb";
        public double Weight, calBurned;
        public RetrieveData(String username)
        {
            this.username = username;
        }
        public void viewDetails()
        {
            String query = "SELECT * FROM userdetails WHERE UserName = '" + username + "';";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(query, conn);
            conn.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if (!(reader.HasRows))
            {
                
            }
            else
            {
                while (reader.Read())
                {                    
                    fullName = reader["full_name"].ToString();
                    Age = reader["age"].ToString();
                    Weight = double.Parse(reader["Weight"].ToString());
                    Gender = reader["Gender"].ToString();
                    Height = reader["height"].ToString();
                    calGoal = reader["cal_goal"].ToString();
                }
            }
        }

        public double GetCaloriesBurnt(DateTime date)
        {
            double calBurned = 0.0;

            string query = "SELECT cal_burnt FROM CalBurned WHERE UserName = @username AND cal_burn_date = @date";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(query, conn);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd")); // Assuming cal_burn_date is in DATE format in the database
                conn.Open();

                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        calBurned = Convert.ToDouble(reader["cal_burnt"]);
                    }
                }
            }

            return calBurned;
        }


    }
}
