using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                if (string.IsNullOrEmpty(txtSurname.Text))
                {
                    MessageBox.Show("Please fill in yout Surname");
                }
                else
                {
                    if (cbmGender.SelectedItem == null)
                    {
                        MessageBox.Show("Select your gender please");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txtEmail.Text))
                        {
                            MessageBox.Show("Please enter your email");
                        }
                        else
                        {
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
                            if (SelectedGoals != "")
                            {
                                // Remove last comma and space
                                SelectedGoals = SelectedGoals.Substring(0, SelectedGoals.Length - 2);
                                MessageBox.Show("Selected goals: " + SelectedGoals);

                                //If everyting is filled in then this will go to the next page
                                Signup2 s2 = new Signup2();
                                s2.Show();
                                this.Hide();
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
