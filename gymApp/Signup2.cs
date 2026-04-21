using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gymApp
{
    public partial class Signup2 : Form
    {
        string connectionString = "server= localhost;database=gymds_db;uid=root;pwd=;";
        public Signup2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup3 s3 = new Signup3();
            s3.Show(); 
            this.Hide();
        }

        private void Signup2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();//object of database class

            DialogResult result = MessageBox.Show(

                "Are you sure you want to quite, Your records will be deleted", // message
                "Confirm",                                   // title
                MessageBoxButtons.YesNo,                     // buttons
                MessageBoxIcon.Question                      // icon
            );

            // Check what the user clicked
            if (result == DialogResult.Yes)
            {

                try
                {
                    // Use your connection class
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        //This is the sql query that will place the data into the database
                        string query = "DELETE FROM users WHERE user_id = (SELECT MAX(user_id) FROM users)";
                        conn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            int rowsAffected = cmd.ExecuteNonQuery();//executing the command so that it can happen in the database
                            MessageBox.Show(rowsAffected > 0 ? "Your details has been deleted." : "Details is not deleted.");
                        }
                    }

                    //This is only done so that i can move on to the next page
                    Form1 s2 = new Form1();
                    s2.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            else
            {
                // User clicked No → cancel action
                MessageBox.Show("Operation cancelled.");
            }
        }
    }
}
