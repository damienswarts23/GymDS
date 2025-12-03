using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace gymApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void lblText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Added the validation to the fields that is collecting the data
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please fill in your Name");
            }
            else
            {
                string Name = txtUsername.Text;
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    MessageBox.Show("Please fill in yout Surname");
                }
                else
                {
                    string Surname = txtSurname.Text;
                    if (cbmGender.SelectedItem == null)
                    {
                        MessageBox.Show("Select your gender please");
                    }
                    else
                    {
                        string Gender = cbmGender.SelectedItem.ToString();
                        if (string.IsNullOrEmpty(txtEmail.Text))
                        {
                            MessageBox.Show("Please enter your email");
                        }
                        else
                        {
                            string Email = txtEmail.Text;
                            //This part here is the validation that is for the selected goals
                            string SelectedGoals = "";

                            if (chkLegs.Checked)
                            {
                                SelectedGoals += "Legs, ";
                            }
                            if (chkUpperBody.Checked)
                            {
                                SelectedGoals += "UpperBody, ";
                            }
                            if (chkArms.Checked)
                            {
                                SelectedGoals += "Arms, ";
                            }
                            if (chkGlutes.Checked)
                            {
                                SelectedGoals += "Glutes, ";
                            }
                            if (chkCore.Checked)
                            {
                                SelectedGoals += "Core, ";
                            }
                            //Check if the user has selected atleast one gym plan
                            if (SelectedGoals != "")
                            {
                                SelectedGoals = SelectedGoals.Substring(0, SelectedGoals.Length - 2);//remobing the spaces between the different chekboxes
                                

                                DateTime date = dob.Value;//Placing the date of birth into a string variable so that it can go into the database and 
                                string Dob = date.ToString();//Pharsing the date to string

                                DBConnection db = new DBConnection();//object of database class
                                try
                                {
                                    // Use your connection class
                                    using (MySqlConnection conn = db.Connect())
                                    {
                                        //This is the sql query that will place the data into the database
                                        string query = "INSERT INTO members (name, surname, gender, date_of_birth, email,gym_goals) VALUES (@name, @surname,@gender,@date_of_birth, @email,@gym_goals)";
                                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                                        {
                                            //Placing the variables with the user data into their placeholders 
                                            cmd.Parameters.AddWithValue("@name", Name);
                                            cmd.Parameters.AddWithValue("@surname", Surname);
                                            cmd.Parameters.AddWithValue("@gender", Gender);
                                            cmd.Parameters.AddWithValue("@date_of_birth", Dob);
                                            cmd.Parameters.AddWithValue("@email", Email);
                                            cmd.Parameters.AddWithValue("@gym_goals",SelectedGoals);



                                            int rowsAffected = cmd.ExecuteNonQuery();//executing the command so that it can happen in the database
                                            MessageBox.Show(rowsAffected > 0 ? "User added successfully!" : "Failed to add user.");


                                            //This is only done so that i can move on to the next page
                                            Signup2 s2 = new Signup2();
                                            s2.Show();
                                            this.Hide();
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No goals selected.");
                            }

                           
                        }
                    }
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
