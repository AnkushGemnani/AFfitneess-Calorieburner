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
    public partial class HomePage : Form
    {
        string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/91968/source/repos/AGFitness/Ddocp_project.mdb";
        String fname, lname,username,password;
        public HomePage(String username, String Password)
        {
            InitializeComponent();
            this.username = username;
            this.password = Password;
            String query = "SELECT * FROM users WHERE username = '" + username + "'";
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand command = new OleDbCommand(query, con);
            con.Open();
            OleDbDataReader reader = command.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    fname = reader["first_name"].ToString();
                    lname = reader["last_name"].ToString();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 5;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 3;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            LoadGoal();
        }



        private void lblpullup_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 1;
        }

        private void picwalk_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 0;

        }

        private void lblwalking_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 0;

        }

        private void picswim_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 1;
        }

        private void lblswim_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 1;
        }

        private void picpullup_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex =2;

        }

        private void picabs_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 3;
        }

        private void picaeroobics_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 4;
        }

        private void lblaerobics_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 4;
        }

        private void lblcycle_Click(object sender, EventArgs e)
        {
            HomeTab.SelectedIndex = 5;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }

        private void lbllogout_Click(object sender, EventArgs e)
        {
            var loginpage = new Login();
            loginpage.Show();
            this.Hide();
        }

        private void tabuserdetails_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabSwim_Click(object sender, EventArgs e)
        {

        }

        private void lblpullupt_Click(object sender, EventArgs e)
        {

        }

        private void lblcyclet_Click(object sender, EventArgs e)
        {

        }

        private void distance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsumbit_Click(object sender, EventArgs e)
        {
            string aerobicsType = cmbboxaero.Text;
            DateTime dateAerobics = datetimeaero.Value;
            double timeTaken = double.Parse(txtboxtimeaerobics.Text);

            CalculateCalories calculate = new CalculateCalories(username);
            double calBurn = calculate.CalculateAerobicsCalories(timeTaken, aerobicsType, dateAerobics);

            bool operationSuccess = calculate.AddTotalCalories(calBurn, dateAerobics);

            if (operationSuccess)
            {
                string message = $"You burned {calBurn} calories during this {aerobicsType} session.";
                MessageBox.Show(message, "Aerobics Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGoal();
            }
        }

        private void txtsteps_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsetepsenter_Click(object sender, EventArgs e)
        {

        }

        private void txtTimewalk_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void cmbowalking_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblfirstname_Click(object sender, EventArgs e)
        {

        }

        private void btnSumbitpofile_Click(object sender, EventArgs e)
        {
            String fullName = txtfullname.Text, Age = age.Text, Weight = weight.Text, Height = height.Text, Gender = gender.Text, calGoal = calBurnTextBox.Text;
            String query2 = "SELECT * FROM userdetails WHERE UserName = '" + username + "'";
            using (OleDbConnection conn2 = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command2 = new OleDbCommand(query2, conn2))
                {
                    conn2.Open();
                    OleDbDataReader reader2 = command2.ExecuteReader();
                    if (!(reader2.HasRows))
                    {
                        String query3 = "INSERT INTO userdetails (UserName, full_name, age, Weight, Gender, height, cal_goal) VALUES ('" + username + "', '" + fullName + "', " + Age + ", " + Weight + ", '" + Gender + "', " + Height + ", " + calGoal + ")";
                        using (OleDbConnection conn3 = new OleDbConnection(connectionString))
                        {
                            using (OleDbCommand command3 = new OleDbCommand(query3, conn3))
                            {
                                conn3.Open();
                                command3.ExecuteNonQuery();
                                conn3.Close();
                            }
                        }
                        MessageBox.Show("Profile created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        String query3 = "UPDATE userdetails SET age = " + Age + ", Weight = " + Weight + ", Gender = '" + Gender + "', height = " + Height + ", cal_goal = " + calGoal + " WHERE UserName = '" + username + "';";
                        using (OleDbConnection conn3 = new OleDbConnection(connectionString))
                        {
                            using (OleDbCommand command3 = new OleDbCommand(query3, conn3))
                            {
                                conn3.Open();
                                command3.ExecuteNonQuery();
                                conn3.Close();
                            }
                        }
                        MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    conn2.Close();
                }
            }
        }

        private void viewDetails_Click(object sender, EventArgs e)
        {
            RetrieveData user = new RetrieveData(username);
            user.viewDetails();
            if(false)
            {
                lbluserdetails.Text += " : Not Available";
            }
            else
            {
                lbluserdetails.Text = "User Details";
                String fullName, Age, Gender, Height, calGoal;
                double Weight;
                lblfullnameuser.Visible = true; lblagee.Visible = true; lblweightt.Visible = true; lblgenderr.Visible = true; lblheighttt.Visible = true; lblGoal.Visible = true;
                fullName = user.fullName;
                Age = user.Age;
                Weight = user.Weight;
                Gender = user.Gender;
                Height = user.Height;
                calGoal = user.calGoal;
                lblfullnameuser.Text += fullName; lblagee.Text += Age; lblweightt.Text += Weight; lblgenderr.Text += Gender; lblheighttt.Text += Height; lblGoal.Text += calGoal;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnsumbitswim_Click(object sender, EventArgs e)
        {
            string no_laps = txtnumlaps.Text, swimStroke = SwimmingStrokeBox.Text;
            DateTime dateSwim = walkDatePicker.Value;
            double timeTaken = double.Parse(txttimeswim.Text);
            CalculateCalories calculate = new CalculateCalories(username);
            double calBurn = calculate.calculateSwimmingCalories(timeTaken, swimStroke, no_laps, dateSwim.ToString("yyyy-MM-dd"));
            bool operationSuccess = calculate.AddTotalCalories(calBurn, dateSwim);

            if (operationSuccess)
            {
                string message = $"You burned {calBurn} calories during this swimming session.";
                MessageBox.Show(message, "Swim Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGoal();
            }
        }

        private void btnsumbitpull_Click(object sender, EventArgs e)
        {
            string pullups = txtboxpull.Text;
            double timeTaken = double.Parse(txtboxtime.Text);
            string typePullUp = cmboboxpull.Text;
            DateTime datePullUp = datetimepull.Value;  // Use DateTime directly

            // Calculate calorie burn for pull-ups
            CalculateCalories calculator = new CalculateCalories(username);
            double calBurn = calculator.CalculatePullUpCalories(timeTaken, typePullUp, datePullUp.ToString("yyyy-MM-dd"), pullups);

            // Add the calculated calories to the total for the specified date
            bool operationSuccess = calculator.AddTotalCalories(calBurn, datePullUp);

            // Show a message based on the operation result
            if (operationSuccess)
            {
                string message = $"You burned {calBurn} calories during this pull-up session.";
                MessageBox.Show(message, "Pull Up Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGoal();
            }
        }

        private void tabAbs_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
                
        }

        private void btnsumbitcycle_Click(object sender, EventArgs e)
        {
            double timeTaken = double.Parse(time.Text);
            double distanceTaken = double.Parse(distance.Text);
            string intensityTaken = cyclingIntensityComboBox.Text;
            DateTime dateTaken = cyclingDatePicker.Value;  // Use DateTime directly

            CalculateCalories calculate = new CalculateCalories(username);
            double calBurn = calculate.CalculateCyclingCalories(timeTaken, distanceTaken, intensityTaken, dateTaken);
            bool operationSuccess = calculate.AddTotalCalories(calBurn, dateTaken);

            if (operationSuccess)
            {
                string message = $"You burned {calBurn} calories during this cycling session.";
                MessageBox.Show(message, "Cycle Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGoal();
            }
        }





        private void btnsumbitabs_Click(object sender, EventArgs e)
        {
            string no_abs = txtabs.Text;
            double timetakenabs = double.Parse(txttimeabs.Text);
            string typeabs = cmbboxabs.Text;
            DateTime dateabs = datetimeabs.Value;  // Use DateTime directly

            CalculateCalories calculate = new CalculateCalories(username);
            double calBurn = calculate.CalculateAbsCalories(timetakenabs, no_abs, dateabs, typeabs);
            bool operationSuccess = calculate.AddTotalCalories(calBurn, dateabs);

            if (operationSuccess)
            {
                string message = $"You burned {calBurn} calories during this abs session.";
                MessageBox.Show("Details added successfully", "Abs Exercise Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGoal();
            }
        }

        private void datetimeswim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void masterDatePicker_ValueChanged(object sender, EventArgs e)
        {
            LoadGoal();
        }

        public void LoadGoal()
        {
            RetrieveData data = new RetrieveData(username);
            data.viewDetails();
            DateTime selectedDate = masterDatePicker.Value;  // Assuming masterDatePicker is a DateTimePicker control
            double calories = data.GetCaloriesBurnt(selectedDate);

            // Handling if calGoal is null or empty
            double goalRemaining = 0;
            if (!string.IsNullOrEmpty(data.calGoal))
            {
                if (double.TryParse(data.calGoal, out double goal))
                {
                    goalRemaining = goal - calories;
                }
                else
                {
                    // Handle the case where calGoal is not a valid double
                    Console.WriteLine("Error: calGoal is not a valid number.");
                }
            }
            else
            {
                // Handle the case where calGoal is null or empty
                Console.WriteLine("Warning: calGoal is null or empty.");
            }

            lblfirstname.Text = fname + " " + lname;
            lblcalburnedfetch.Text = "Cal Burned : " + calories;

            if (goalRemaining > 0)
            {
                lblcalleftfetch.Text = "Cal Left : " + goalRemaining;
            }
            else
            {
                lblcalleftfetch.Text = "Cal Left : Completed";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnwalksumbit_Click(object sender, EventArgs e)
        {
            String walkSteps = txtsteps.Text, walkIntensity = cmbowalking.Text;
            DateTime walkDate = walkDatePicker.Value;  // Use DateTime directly
            double walkDist = int.Parse(walkDistanceCovered.Text), walkTime = int.Parse(txtTimewalk.Text);

            CalculateCalories calculate = new CalculateCalories(username);
            double calBurn = calculate.calculateWalkingCalories(walkSteps, walkIntensity, walkDate, walkDist, walkTime);
            bool operationSuccess = calculate.AddTotalCalories(calBurn, walkDatePicker.Value);

            // Show calories burned in a message box
            string message = $"You burned {calBurn} calories during this walking session.";
            if (operationSuccess)
            {
                MessageBox.Show(message, "Walk Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGoal();
            }
        }

        public void updateCaloriesCount(double addNum)
        {

        }
    }
}
