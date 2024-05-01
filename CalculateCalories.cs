using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Globalization;


namespace AGFitness
{
    internal class CalculateCalories
    {
        String username,
        connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/91968/source/repos/AGFitness/Ddocp_project.mdb";
        public CalculateCalories(String username)
        {
            this.username = username;
        }
        public double calculateWalkingCalories(String walkSteps, String walkIntensity, DateTime walkDate, double walkDist, double walkTime)
        {
            double calBurn = 0.0;
            RetrieveData user = new RetrieveData(username);
            user.viewDetails();
            if (walkIntensity == "Slow Walking")
            {
                calBurn = 2.0 * user.Weight * (walkTime / 60.0);
            }
            else if (walkIntensity == "Moderate Walking")
            {
                calBurn = 3.5 * user.Weight * (walkTime / 60.0);
            }
            else if (walkIntensity == "Brisk Walking")
            {
                calBurn = 4.5 * user.Weight * (walkTime / 60.0);
            }
            String queryWalk = "INSERT INTO Walking (UserName, walk_steps, time_taken, distance_covered, Intensity, calories_burned, walk_date) VALUES ('" + username + "', " + walkSteps + ", " + walkTime + ", " + walkDist + ", '" + walkIntensity + "', " + calBurn + ", '" + walkDate.ToString("yyyy-MM-dd") + "')";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(queryWalk, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            return calBurn;
        }


        public double calculateSwimmingCalories(double time, String style, String numoflaps, String swim_date)
        {
            double calBurn = 0.0;
            RetrieveData user = new RetrieveData(username);
            user.viewDetails();
            if (style == "FreeStyle(slowpace)")
            {
                calBurn = 5.8 * user.Weight * (time / 60);
            }
            else if (style == "FreeStyle(mediumpace)")
            {
                calBurn = 7.3 * user.Weight * (time / 60);
            }
            else if (style == "FreeStyle(fastpace)")
            {
                calBurn = 9.8 * user.Weight * (time / 60);
            }
            else if (style == "BreastStroke(moderate)")
            {
                calBurn = 7.8 * user.Weight * (time / 60);
            }
            else if (style == "Butterfly(fast)")
            {
                calBurn = 12.8 * user.Weight * (time / 60);
            }
            String querySwim = "INSERT INTO Swimming (UserName, time_taken, Numoflaps, SwimmingStroke, swim_Date, calburned) VALUES ('" + username + "', " + time + ", " + numoflaps + ", '" + style + "', '" + swim_date + "', " + calBurn + ")";
            OleDbConnection conn = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(querySwim, conn);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            return calBurn;
        }
        public double CalculatePullUpCalories(double time, string intensity, string date, String pullups)
        {
            double calBurn = 0.0;
            RetrieveData user = new RetrieveData(username);
            user.viewDetails();

            if (intensity == "Normal")
            {
                calBurn = 3.8 * user.Weight * (time / 60);
            }
            else if (intensity == "Wide")
            {
                calBurn = 5.8 * user.Weight * (time / 60);
            }
            else if (intensity == "Bicep pullup")
            {
                calBurn = 8.0 * user.Weight * (time / 60);
            }

            string queryPullUp = "INSERT INTO Pullup (UserName, TimeTaken, NumberofPullUps, dateofpullupact, calburned) VALUES ('" + username + "', " + time + ", '" + pullups + "', '" + date + "', " + calBurn + ");";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(queryPullUp, conn))
                {
                    command.ExecuteNonQuery();
                }
            }

            return calBurn;
        }

        public double CalculateCyclingCalories(double time, double distance, string intensity, DateTime date)
        {
            double calBurn = 0.0;
            RetrieveData user = new RetrieveData(username);
            user.viewDetails();

            if (intensity == "Low")
            {
                calBurn = 4.0 * user.Weight * (time / 60);
            }
            else if (intensity == "Moderate")
            {
                calBurn = 6.0 * user.Weight * (time / 60);
            }
            else if (intensity == "High")
            {
                calBurn = 8.0 * user.Weight * (time / 60);
            }

            // Use parameterized query to avoid SQL injection
            string querycycle = "INSERT INTO Cycle (UserName, cycling_time, Intensity, Distance, cycle_date, cal_burned) VALUES (?, ?, ?, ?, ?, ?)";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(querycycle, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@time", time);
                    command.Parameters.AddWithValue("@Intensity", intensity);
                    command.Parameters.AddWithValue("@cycle_date", date.ToString("yyyy-MM-dd"));  // Use formatted date string
                    command.Parameters.AddWithValue("@cal_burned", calBurn);

                }
            }

            return calBurn;
        }

        public double CalculateAerobicsCalories(double timeTaken, string aerobicsType, DateTime date)
        {
            double calBurn = 0.0;
            RetrieveData user = new RetrieveData(username);
            user.viewDetails();

            // Define MET values for different types of aerobics
            Dictionary<string, double> metValues = new Dictionary<string, double>()
    {
        { "Low-impact", 3.0 },  // Adjust MET values based on actual data
        { "High-impact", 5.0 },
        { "Dance aerobics (Zumba)", 4.0 },
        // Add more types and their MET values as needed
    };

            // Default MET value if type not found
            double defaultMET = 3.5;  // Adjust the default MET value as needed

            // Calculate calories burned based on MET, time, and aerobics type
            if (metValues.ContainsKey(aerobicsType))
            {
                double metValue = metValues[aerobicsType];
                calBurn = metValue * user.Weight * (timeTaken / 60.0);  // Assuming weight is in kg
            }
            else
            {
                calBurn = defaultMET * user.Weight * (timeTaken / 60.0); // Use default MET if type not found
            }

            // Convert date to string in "yyyy-MM-dd" format
            string formattedDate = date.ToString("yyyy-MM-dd");

            // Insert data into the database
            string queryAerobics = "INSERT INTO Aerobics (UserName, TimeTaken, AerobicsType, Adate, CalBurned) VALUES (@username, @time, @type, @date, @calBurn)";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(queryAerobics, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@time", timeTaken);
                    command.Parameters.AddWithValue("@type", aerobicsType);
                    command.Parameters.AddWithValue("@date", formattedDate);  // Use formatted date string
                    command.Parameters.AddWithValue("@calBurn", calBurn);

                    command.ExecuteNonQuery();
                }
            }

            return calBurn;
        }

        public double CalculateAbsCalories(double timetaken, string no_abs, DateTime dateabs, string typeabs)
        {
            double calBurn = 0.0;
            RetrieveData user = new RetrieveData(username);
            user.viewDetails();

            // Define MET values for different abs exercises
            Dictionary<string, double> metValues = new Dictionary<string, double>()
    {
        { "Crunches", 5.0 },
        { "Sit ups", 6.0 },
        { "Lying leg raise", 7.0 },
        // Add more exercises and their MET values as needed
    };

            // Default MET value if exercise not found
            double defaultMET = 4.0;

            // Calculate calories burned based on MET, time, and exercise type
            if (metValues.ContainsKey(typeabs))
            {
                double metValue = metValues[typeabs];
                calBurn = metValue * user.Weight * (timetaken / 60.0);
            }
            else
            {
                calBurn = defaultMET * user.Weight * (timetaken / 60.0); // Use default MET if exercise not found
            }

            string queryAbs = "INSERT INTO Abs (UserName, Typeabs, TimeTaken, NoOfReps, date_abs, CalBurn) VALUES(?, ?, ?, ?, ?, )";
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                using (OleDbCommand command = new OleDbCommand(queryAbs, conn))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@typeabs", typeabs);
                    command.Parameters.AddWithValue("@time", timetaken);
                    command.Parameters.AddWithValue("@reps", double.Parse(no_abs)); // Insert number of reps
                    command.Parameters.AddWithValue("@date", dateabs); // Assuming dateabs is a DateTime object
                    command.Parameters.AddWithValue("@calBurn", calBurn);

                    command.ExecuteNonQuery();
                }
            }

            return calBurn;
        }




        public bool AddTotalCalories(double calories, DateTime activityDate)
        {
            try
            {
                string formattedDate = activityDate.ToString("yyyy-MM-dd");

                string query = "SELECT * FROM CalBurned WHERE username = '" + username + "' AND cal_burn_date = #" + formattedDate + "#";
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();
                    using (OleDbCommand command = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                string totalCalAdd = "UPDATE CalBurned SET cal_burnt = cal_burnt + " + calories + " WHERE username = '" + username + "' AND cal_burn_date = #" + formattedDate + "#";
                                using (OleDbCommand command3 = new OleDbCommand(totalCalAdd, conn))
                                {
                                    command3.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                string insertCal = "INSERT INTO CalBurned (username, cal_burnt, cal_burn_date) VALUES ('" + username + "', " + calories + ", #" + formattedDate + "#)";
                                using (OleDbCommand command2 = new OleDbCommand(insertCal, conn))
                                {
                                    command2.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                return true;  // Operation successful
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log the error, show an error message)
                Console.WriteLine("Error adding total calories: " + ex.Message);
                return false;  // Operation failed
            }
        }
    }
}

