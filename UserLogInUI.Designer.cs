namespace VideoOCRDemo
{
    partial class UserLogInUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogInUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTtextBox = new System.Windows.Forms.TextBox();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.pictureBoxTopBanner = new System.Windows.Forms.PictureBox();
            this.loginInfoLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "USER NAME :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(236, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "PASSWORD :";
            // 
            // passwordTtextBox
            // 
            this.passwordTtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTtextBox.Location = new System.Drawing.Point(350, 417);
            this.passwordTtextBox.Name = "passwordTtextBox";
            this.passwordTtextBox.PasswordChar = '*';
            this.passwordTtextBox.Size = new System.Drawing.Size(196, 23);
            this.passwordTtextBox.TabIndex = 33;
            this.passwordTtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.Location = new System.Drawing.Point(350, 368);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(196, 23);
            this.userNameTextBox.TabIndex = 33;
            this.userNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logInButton
            // 
            this.logInButton.AccessibleName = "logInButton";
            this.logInButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(350, 474);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(167, 36);
            this.logInButton.TabIndex = 34;
            this.logInButton.Text = "LOG IN";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // pictureBoxTopBanner
            // 
            this.pictureBoxTopBanner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopBanner.Image")));
            this.pictureBoxTopBanner.ImageLocation = "";
            this.pictureBoxTopBanner.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxTopBanner.Name = "pictureBoxTopBanner";
            this.pictureBoxTopBanner.Size = new System.Drawing.Size(815, 107);
            this.pictureBoxTopBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTopBanner.TabIndex = 35;
            this.pictureBoxTopBanner.TabStop = false;
            // 
            // loginInfoLabel
            // 
            this.loginInfoLabel.AutoSize = true;
            this.loginInfoLabel.Location = new System.Drawing.Point(338, 464);
            this.loginInfoLabel.Name = "loginInfoLabel";
            this.loginInfoLabel.Size = new System.Drawing.Size(0, 13);
            this.loginInfoLabel.TabIndex = 36;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VideoOCRDemo.Properties.Resources.TML_Round;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(302, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // UserLogInUI
            // 
            this.AcceptButton = this.logInButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(854, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginInfoLabel);
            this.Controls.Add(this.pictureBoxTopBanner);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.userNameTextBox);
            this.Controls.Add(this.passwordTtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "UserLogInUI";
            this.Text = "UserLogInUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTtextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.PictureBox pictureBoxTopBanner;
        private System.Windows.Forms.Label loginInfoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}