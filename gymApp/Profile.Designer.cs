namespace gymApp
{
    partial class Profile
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelLeftDivider = new System.Windows.Forms.Panel();
            this.panelMiddleDivider = new System.Windows.Forms.Panel();
            this.panelRightDivider = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelProfileCard = new System.Windows.Forms.Panel();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.lblPlan = new System.Windows.Forms.Label();
            this.lblMemberIdTitle = new System.Windows.Forms.Label();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblEmailTitle = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneTitle = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblGoalTitle = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblBranchTitle = new System.Windows.Forms.Label();
            this.lblBranch = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelProfileCard.SuspendLayout();
            this.panelTopRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Gray;
            this.panelTop.Location = new System.Drawing.Point(-8, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(830, 66);
            this.panelTop.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.Gray;
            this.panelBottom.Location = new System.Drawing.Point(-8, 392);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(830, 66);
            this.panelBottom.TabIndex = 1;
            // 
            // panelLeftDivider
            // 
            this.panelLeftDivider.BackColor = System.Drawing.Color.Silver;
            this.panelLeftDivider.Location = new System.Drawing.Point(127, 0);
            this.panelLeftDivider.Name = "panelLeftDivider";
            this.panelLeftDivider.Size = new System.Drawing.Size(86, 458);
            this.panelLeftDivider.TabIndex = 2;
            // 
            // panelMiddleDivider
            // 
            this.panelMiddleDivider.BackColor = System.Drawing.Color.Silver;
            this.panelMiddleDivider.Location = new System.Drawing.Point(356, 0);
            this.panelMiddleDivider.Name = "panelMiddleDivider";
            this.panelMiddleDivider.Size = new System.Drawing.Size(86, 458);
            this.panelMiddleDivider.TabIndex = 3;
            // 
            // panelRightDivider
            // 
            this.panelRightDivider.BackColor = System.Drawing.Color.Silver;
            this.panelRightDivider.Location = new System.Drawing.Point(580, 0);
            this.panelRightDivider.Name = "panelRightDivider";
            this.panelRightDivider.Size = new System.Drawing.Size(86, 458);
            this.panelRightDivider.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Gainsboro;
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.panelProfileCard);
            this.panelMain.Location = new System.Drawing.Point(0, 66);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(804, 326);
            this.panelMain.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(285, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Profile";
            // 
            // panelProfileCard
            // 
            this.panelProfileCard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProfileCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfileCard.Controls.Add(this.panelPicture);
            this.panelProfileCard.Controls.Add(this.lblMemberName);
            this.panelProfileCard.Controls.Add(this.lblPlan);
            this.panelProfileCard.Controls.Add(this.lblMemberIdTitle);
            this.panelProfileCard.Controls.Add(this.lblMemberId);
            this.panelProfileCard.Controls.Add(this.lblEmailTitle);
            this.panelProfileCard.Controls.Add(this.lblEmail);
            this.panelProfileCard.Controls.Add(this.lblPhoneTitle);
            this.panelProfileCard.Controls.Add(this.lblPhone);
            this.panelProfileCard.Controls.Add(this.lblGoalTitle);
            this.panelProfileCard.Controls.Add(this.lblGoal);
            this.panelProfileCard.Controls.Add(this.lblBranchTitle);
            this.panelProfileCard.Controls.Add(this.lblBranch);
            this.panelProfileCard.Controls.Add(this.panelLine);
            this.panelProfileCard.Controls.Add(this.btnEditProfile);
            this.panelProfileCard.Location = new System.Drawing.Point(55, 77);
            this.panelProfileCard.Name = "panelProfileCard";
            this.panelProfileCard.Size = new System.Drawing.Size(666, 220);
            this.panelProfileCard.TabIndex = 1;
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.Color.Silver;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPicture.Location = new System.Drawing.Point(28, 24);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(120, 120);
            this.panelPicture.TabIndex = 0;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.Black;
            this.lblMemberName.Location = new System.Drawing.Point(175, 24);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(201, 31);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Member Name";
            // 
            // lblPlan
            // 
            this.lblPlan.AutoSize = true;
            this.lblPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lblPlan.ForeColor = System.Drawing.Color.Gray;
            this.lblPlan.Location = new System.Drawing.Point(177, 62);
            this.lblPlan.Name = "lblPlan";
            this.lblPlan.Size = new System.Drawing.Size(156, 20);
            this.lblPlan.TabIndex = 2;
            this.lblPlan.Text = "Premium Member";
            // 
            // lblMemberIdTitle
            // 
            this.lblMemberIdTitle.AutoSize = true;
            this.lblMemberIdTitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblMemberIdTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMemberIdTitle.Location = new System.Drawing.Point(177, 102);
            this.lblMemberIdTitle.Name = "lblMemberIdTitle";
            this.lblMemberIdTitle.Size = new System.Drawing.Size(118, 22);
            this.lblMemberIdTitle.TabIndex = 3;
            this.lblMemberIdTitle.Text = "Member ID:";
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblMemberId.Location = new System.Drawing.Point(292, 104);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(73, 20);
            this.lblMemberId.TabIndex = 4;
            this.lblMemberId.Text = "GYM001";
            // 
            // lblEmailTitle
            // 
            this.lblEmailTitle.AutoSize = true;
            this.lblEmailTitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblEmailTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblEmailTitle.Location = new System.Drawing.Point(177, 132);
            this.lblEmailTitle.Name = "lblEmailTitle";
            this.lblEmailTitle.Size = new System.Drawing.Size(71, 22);
            this.lblEmailTitle.TabIndex = 5;
            this.lblEmailTitle.Text = "Email:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblEmail.Location = new System.Drawing.Point(292, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(164, 20);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "email@example.com";
            // 
            // lblPhoneTitle
            // 
            this.lblPhoneTitle.AutoSize = true;
            this.lblPhoneTitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblPhoneTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblPhoneTitle.Location = new System.Drawing.Point(177, 162);
            this.lblPhoneTitle.Name = "lblPhoneTitle";
            this.lblPhoneTitle.Size = new System.Drawing.Size(73, 22);
            this.lblPhoneTitle.TabIndex = 7;
            this.lblPhoneTitle.Text = "Phone:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblPhone.Location = new System.Drawing.Point(292, 164);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(100, 20);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "000 000 000";
            // 
            // lblGoalTitle
            // 
            this.lblGoalTitle.AutoSize = true;
            this.lblGoalTitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblGoalTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblGoalTitle.Location = new System.Drawing.Point(491, 101);
            this.lblGoalTitle.Name = "lblGoalTitle";
            this.lblGoalTitle.Size = new System.Drawing.Size(57, 22);
            this.lblGoalTitle.TabIndex = 9;
            this.lblGoalTitle.Text = "Goal:";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblGoal.Location = new System.Drawing.Point(552, 103);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(44, 20);
            this.lblGoal.TabIndex = 10;
            this.lblGoal.Text = "Goal";
            // 
            // lblBranchTitle
            // 
            this.lblBranchTitle.AutoSize = true;
            this.lblBranchTitle.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.lblBranchTitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblBranchTitle.Location = new System.Drawing.Point(474, 131);
            this.lblBranchTitle.Name = "lblBranchTitle";
            this.lblBranchTitle.Size = new System.Drawing.Size(83, 22);
            this.lblBranchTitle.TabIndex = 11;
            this.lblBranchTitle.Text = "Branch:";
            // 
            // lblBranch
            // 
            this.lblBranch.AutoSize = true;
            this.lblBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblBranch.Location = new System.Drawing.Point(552, 133);
            this.lblBranch.Name = "lblBranch";
            this.lblBranch.Size = new System.Drawing.Size(63, 20);
            this.lblBranch.TabIndex = 12;
            this.lblBranch.Text = "Branch";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.Black;
            this.panelLine.Location = new System.Drawing.Point(28, 190);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(580, 5);
            this.panelLine.TabIndex = 13;
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.BackColor = System.Drawing.Color.Silver;
            this.btnEditProfile.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditProfile.ForeColor = System.Drawing.Color.White;
            this.btnEditProfile.Location = new System.Drawing.Point(495, 23);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(143, 38);
            this.btnEditProfile.TabIndex = 14;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = false;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // panelTopRight
            // 
            this.panelTopRight.Controls.Add(this.btnHome);
            this.panelTopRight.Location = new System.Drawing.Point(580, 4);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(219, 57);
            this.panelTopRight.TabIndex = 6;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Silver;
            this.btnHome.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(3, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(213, 53);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelTopRight);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelRightDivider);
            this.Controls.Add(this.panelMiddleDivider);
            this.Controls.Add(this.panelLeftDivider);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelProfileCard.ResumeLayout(false);
            this.panelProfileCard.PerformLayout();
            this.panelTopRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelLeftDivider;
        private System.Windows.Forms.Panel panelMiddleDivider;
        private System.Windows.Forms.Panel panelRightDivider;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelProfileCard;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblMemberIdTitle;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblEmailTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGoalTitle;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblBranchTitle;
        private System.Windows.Forms.Label lblBranch;
        private System.Windows.Forms.Panel panelLine;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Button btnHome;
    }
}