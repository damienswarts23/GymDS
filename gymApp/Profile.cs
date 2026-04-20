using System;
using System.Windows.Forms;

namespace gymApp
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            lblMemberName.Text = "John Daniels";
            lblMemberId.Text = "GYM-10245";
            lblEmail.Text = "johndaniels@gmail.com";
            lblPhone.Text = "073 456 7890";
            lblPlan.Text = "Premium Membership";
            lblGoal.Text = "Build Muscle / Stay Fit";
            lblBranch.Text = "Cape Town Branch";
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit Profile clicked.");
        }
    }
}