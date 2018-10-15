namespace FaceRecognitionApp
{
    partial class OpenForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.CameraFormExitButton = new System.Windows.Forms.Button();
            this.CameraPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.LogoutButton);
            this.panel1.Controls.Add(this.CameraFormExitButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 56);
            this.panel1.TabIndex = 2;
            // 
            // LogoutButton
            // 
            this.LogoutButton.AutoSize = true;
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.LogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LogoutButton.FlatAppearance.BorderSize = 0;
            this.LogoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.LogoutButton.ForeColor = System.Drawing.Color.Transparent;
            this.LogoutButton.Image = global::friendcognition.Properties.Resources.if_82_output_3044701__1_;
            this.LogoutButton.Location = new System.Drawing.Point(3, 2);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(33, 30);
            this.LogoutButton.TabIndex = 1;
            this.LogoutButton.Tag = "exit_button";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
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
            this.CameraFormExitButton.Location = new System.Drawing.Point(958, 2);
            this.CameraFormExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraFormExitButton.Name = "CameraFormExitButton";
            this.CameraFormExitButton.Size = new System.Drawing.Size(33, 30);
            this.CameraFormExitButton.TabIndex = 0;
            this.CameraFormExitButton.Tag = "exit_button";
            this.CameraFormExitButton.UseVisualStyleBackColor = false;
            this.CameraFormExitButton.Click += new System.EventHandler(this.CameraFormExitButton_Click);
            // 
            // CameraPictureBox
            // 
            this.CameraPictureBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.CameraPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraPictureBox.Location = new System.Drawing.Point(0, 0);
            this.CameraPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraPictureBox.Name = "CameraPictureBox";
            this.CameraPictureBox.Size = new System.Drawing.Size(994, 536);
            this.CameraPictureBox.TabIndex = 1;
            this.CameraPictureBox.TabStop = false;
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(994, 536);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CameraPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OpenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "fRiEndcognition";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OpenForm_Closing);
            this.Load += new System.EventHandler(this.OpenForm_Load);
            this.Activated += new System.EventHandler(this.OpenForm_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox CameraPictureBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CameraFormExitButton;
        private System.Windows.Forms.Button LogoutButton;
    }
}

