namespace WindowsFormsApp1
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
            this.CameraFormExitButton = new System.Windows.Forms.Button();
            this.CameraPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CameraFormExitButton
            // 
            this.CameraFormExitButton.BackColor = System.Drawing.Color.DarkOrange;
            this.CameraFormExitButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CameraFormExitButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CameraFormExitButton.FlatAppearance.BorderSize = 0;
            this.CameraFormExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CameraFormExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CameraFormExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CameraFormExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.CameraFormExitButton.Location = new System.Drawing.Point(0, 390);
            this.CameraFormExitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraFormExitButton.Name = "CameraFormExitButton";
            this.CameraFormExitButton.Size = new System.Drawing.Size(884, 39);
            this.CameraFormExitButton.TabIndex = 0;
            this.CameraFormExitButton.Tag = "exit_button";
            this.CameraFormExitButton.Text = "EXIT";
            this.CameraFormExitButton.UseVisualStyleBackColor = false;
            this.CameraFormExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CameraPictureBox
            // 
            this.CameraPictureBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.CameraPictureBox.Location = new System.Drawing.Point(0, 0);
            this.CameraPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CameraPictureBox.Name = "CameraPictureBox";
            this.CameraPictureBox.Size = new System.Drawing.Size(884, 390);
            this.CameraPictureBox.TabIndex = 1;
            this.CameraPictureBox.TabStop = false;
            this.CameraPictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // OpenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 429);
            this.ControlBox = false;
            this.Controls.Add(this.CameraPictureBox);
            this.Controls.Add(this.CameraFormExitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "OpenForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "fRiEndcognition";
            this.Load += new System.EventHandler(this.OpenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CameraPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CameraFormExitButton;
        private System.Windows.Forms.PictureBox CameraPictureBox;
    }
}

