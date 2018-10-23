namespace friendcognition
{
    partial class Profile
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
            this.ProfileEmailLabel = new System.Windows.Forms.Label();
            this.ProfileSurnameLabel = new System.Windows.Forms.Label();
            this.ProfileNameLabel = new System.Windows.Forms.Label();
            this.ProfileMessageButton = new System.Windows.Forms.Button();
            this.CameraFormExitButton = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.ProfileSurname = new System.Windows.Forms.Label();
            this.ProfileEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfileEmailLabel
            // 
            this.ProfileEmailLabel.AutoSize = true;
            this.ProfileEmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileEmailLabel.Location = new System.Drawing.Point(12, 265);
            this.ProfileEmailLabel.Name = "ProfileEmailLabel";
            this.ProfileEmailLabel.Size = new System.Drawing.Size(46, 17);
            this.ProfileEmailLabel.TabIndex = 1;
            this.ProfileEmailLabel.Text = "Email:";
            // 
            // ProfileSurnameLabel
            // 
            this.ProfileSurnameLabel.AutoSize = true;
            this.ProfileSurnameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileSurnameLabel.Location = new System.Drawing.Point(12, 231);
            this.ProfileSurnameLabel.Name = "ProfileSurnameLabel";
            this.ProfileSurnameLabel.Size = new System.Drawing.Size(69, 17);
            this.ProfileSurnameLabel.TabIndex = 2;
            this.ProfileSurnameLabel.Text = "Surname:";
            this.ProfileSurnameLabel.Click += new System.EventHandler(this.ProfileAgeLabel_Click);
            // 
            // ProfileNameLabel
            // 
            this.ProfileNameLabel.AutoSize = true;
            this.ProfileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ProfileNameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileNameLabel.Location = new System.Drawing.Point(12, 195);
            this.ProfileNameLabel.Name = "ProfileNameLabel";
            this.ProfileNameLabel.Size = new System.Drawing.Size(49, 17);
            this.ProfileNameLabel.TabIndex = 3;
            this.ProfileNameLabel.Text = "Name:";
            // 
            // ProfileMessageButton
            // 
            this.ProfileMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfileMessageButton.BackColor = System.Drawing.Color.DarkOrange;
            this.ProfileMessageButton.Cursor = System.Windows.Forms.Cursors.No;
            this.ProfileMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProfileMessageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfileMessageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileMessageButton.Location = new System.Drawing.Point(50, 310);
            this.ProfileMessageButton.Name = "ProfileMessageButton";
            this.ProfileMessageButton.Size = new System.Drawing.Size(146, 28);
            this.ProfileMessageButton.TabIndex = 4;
            this.ProfileMessageButton.Text = "Message";
            this.ProfileMessageButton.UseVisualStyleBackColor = false;
            // 
            // CameraFormExitButton
            // 
            this.CameraFormExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CameraFormExitButton.AutoSize = true;
            this.CameraFormExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.CameraFormExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CameraFormExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CameraFormExitButton.FlatAppearance.BorderSize = 0;
            this.CameraFormExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.CameraFormExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.CameraFormExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CameraFormExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CameraFormExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.CameraFormExitButton.Image = global::friendcognition.Properties.Resources.if_85_remove_3044710__1_;
            this.CameraFormExitButton.Location = new System.Drawing.Point(219, -1);
            this.CameraFormExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraFormExitButton.Name = "CameraFormExitButton";
            this.CameraFormExitButton.Size = new System.Drawing.Size(30, 30);
            this.CameraFormExitButton.TabIndex = 5;
            this.CameraFormExitButton.Tag = "exit_button";
            this.CameraFormExitButton.UseVisualStyleBackColor = false;
            this.CameraFormExitButton.Click += new System.EventHandler(this.CameraFormExitButton_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProfilePicture.Image = global::friendcognition.Properties.Resources.if_profile_alt_4_299106;
            this.ProfilePicture.Location = new System.Drawing.Point(60, 60);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(130, 132);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ProfileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileName.Location = new System.Drawing.Point(91, 195);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(0, 17);
            this.ProfileName.TabIndex = 6;
            // 
            // ProfileSurname
            // 
            this.ProfileSurname.AutoSize = true;
            this.ProfileSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ProfileSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileSurname.Location = new System.Drawing.Point(91, 231);
            this.ProfileSurname.Name = "ProfileSurname";
            this.ProfileSurname.Size = new System.Drawing.Size(0, 17);
            this.ProfileSurname.TabIndex = 7;
            // 
            // ProfileEmail
            // 
            this.ProfileEmail.AutoSize = true;
            this.ProfileEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.ProfileEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ProfileEmail.Location = new System.Drawing.Point(91, 265);
            this.ProfileEmail.Name = "ProfileEmail";
            this.ProfileEmail.Size = new System.Drawing.Size(0, 17);
            this.ProfileEmail.TabIndex = 8;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.ProfileEmail);
            this.Controls.Add(this.ProfileSurname);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.CameraFormExitButton);
            this.Controls.Add(this.ProfileMessageButton);
            this.Controls.Add(this.ProfileNameLabel);
            this.Controls.Add(this.ProfileSurnameLabel);
            this.Controls.Add(this.ProfileEmailLabel);
            this.Controls.Add(this.ProfilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Label ProfileEmailLabel;
        private System.Windows.Forms.Label ProfileSurnameLabel;
        private System.Windows.Forms.Label ProfileNameLabel;
        private System.Windows.Forms.Button ProfileMessageButton;
        private System.Windows.Forms.Button CameraFormExitButton;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Label ProfileSurname;
        private System.Windows.Forms.Label ProfileEmail;
    }
}