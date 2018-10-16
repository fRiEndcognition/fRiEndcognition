namespace friendcognition
{
    partial class RegisterCamera
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
            this.CameraPictureBox = new System.Windows.Forms.PictureBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraPictureBox
            // 
            this.CameraPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CameraPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CameraPictureBox.Location = new System.Drawing.Point(0, 0);
            this.CameraPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraPictureBox.Name = "CameraPictureBox";
            this.CameraPictureBox.Size = new System.Drawing.Size(884, 390);
            this.CameraPictureBox.TabIndex = 1;
            this.CameraPictureBox.TabStop = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.SubmitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SubmitButton.FlatAppearance.BorderSize = 0;
            this.SubmitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.SubmitButton.Location = new System.Drawing.Point(0, 390);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(884, 39);
            this.SubmitButton.TabIndex = 0;
            this.SubmitButton.Tag = "photo_button";
            this.SubmitButton.Text = "Take a photo";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RegisterCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 429);
            this.ControlBox = false;
            this.Controls.Add(this.CameraPictureBox);
            this.Controls.Add(this.SubmitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RegisterCamera";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "fRiEndcognition";
            this.Shown += new System.EventHandler(this.RegisterCamera_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterCamera_Closing);
            this.Load += new System.EventHandler(this.RegisterCamera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox CameraPictureBox;
        private System.Windows.Forms.Button SubmitButton;
    }
}