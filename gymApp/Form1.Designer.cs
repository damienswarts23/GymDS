namespace gymApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblText = new System.Windows.Forms.Label();
            this.btnChangeText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("STCaiyun", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblText.Location = new System.Drawing.Point(307, 57);
            this.lblText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(284, 28);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "This will be a gym app";
            // 
            // btnChangeText
            // 
            this.btnChangeText.Location = new System.Drawing.Point(355, 240);
            this.btnChangeText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnChangeText.Name = "btnChangeText";
            this.btnChangeText.Size = new System.Drawing.Size(202, 90);
            this.btnChangeText.TabIndex = 1;
            this.btnChangeText.Text = "Change Text";
            this.btnChangeText.UseVisualStyleBackColor = true;
            this.btnChangeText.Click += new System.EventHandler(this.btnChangeText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 452);
            this.Controls.Add(this.btnChangeText);
            this.Controls.Add(this.lblText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnChangeText;
    }
}

