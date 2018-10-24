namespace friendcognition
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SpreadPanel = new System.Windows.Forms.Panel();
            this.IdentClicks = new System.Windows.Forms.Label();
            this.MenuReturn = new System.Windows.Forms.PictureBox();
            this.UnderConstruction = new System.Windows.Forms.PictureBox();
            this.MenuProfile = new System.Windows.Forms.PictureBox();
            this.UnderConstruction2 = new System.Windows.Forms.PictureBox();
            this.MenuLogout = new System.Windows.Forms.PictureBox();
            this.timerPrev = new System.Windows.Forms.Timer(this.components);
            this.timerNext = new System.Windows.Forms.Timer(this.components);
            this.MenuButtonNext = new System.Windows.Forms.PictureBox();
            this.MenuButtonPrev = new System.Windows.Forms.PictureBox();
            this.SpreadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderConstruction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderConstruction2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtonNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtonPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // SpreadPanel
            // 
            this.SpreadPanel.Controls.Add(this.IdentClicks);
            this.SpreadPanel.Controls.Add(this.MenuReturn);
            this.SpreadPanel.Controls.Add(this.UnderConstruction);
            this.SpreadPanel.Controls.Add(this.MenuProfile);
            this.SpreadPanel.Controls.Add(this.UnderConstruction2);
            this.SpreadPanel.Controls.Add(this.MenuLogout);
            this.SpreadPanel.Location = new System.Drawing.Point(-208, 14);
            this.SpreadPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SpreadPanel.Name = "SpreadPanel";
            this.SpreadPanel.Size = new System.Drawing.Size(1049, 169);
            this.SpreadPanel.TabIndex = 10;
            // 
            // IdentClicks
            // 
            this.IdentClicks.AutoSize = true;
            this.IdentClicks.Location = new System.Drawing.Point(401, 153);
            this.IdentClicks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdentClicks.Name = "IdentClicks";
            this.IdentClicks.Size = new System.Drawing.Size(0, 17);
            this.IdentClicks.TabIndex = 10;
            this.IdentClicks.Visible = false;
            // 
            // MenuReturn
            // 
            this.MenuReturn.BackgroundImage = global::friendcognition.Properties.Resources.if_error_1646012;
            this.MenuReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuReturn.Location = new System.Drawing.Point(684, 22);
            this.MenuReturn.Margin = new System.Windows.Forms.Padding(4);
            this.MenuReturn.Name = "MenuReturn";
            this.MenuReturn.Size = new System.Drawing.Size(133, 127);
            this.MenuReturn.TabIndex = 3;
            this.MenuReturn.TabStop = false;
            this.MenuReturn.Click += new System.EventHandler(this.MenuReturn_Click);
            // 
            // UnderConstruction
            // 
            this.UnderConstruction.BackgroundImage = global::friendcognition.Properties.Resources.if_cono_512542;
            this.UnderConstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnderConstruction.Cursor = System.Windows.Forms.Cursors.No;
            this.UnderConstruction.Location = new System.Drawing.Point(895, 22);
            this.UnderConstruction.Margin = new System.Windows.Forms.Padding(4);
            this.UnderConstruction.Name = "UnderConstruction";
            this.UnderConstruction.Size = new System.Drawing.Size(133, 127);
            this.UnderConstruction.TabIndex = 5;
            this.UnderConstruction.TabStop = false;
            // 
            // MenuProfile
            // 
            this.MenuProfile.BackgroundImage = global::friendcognition.Properties.Resources.if_user_1902268;
            this.MenuProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuProfile.Location = new System.Drawing.Point(465, 22);
            this.MenuProfile.Margin = new System.Windows.Forms.Padding(4);
            this.MenuProfile.Name = "MenuProfile";
            this.MenuProfile.Size = new System.Drawing.Size(133, 127);
            this.MenuProfile.TabIndex = 1;
            this.MenuProfile.TabStop = false;
            this.MenuProfile.Click += new System.EventHandler(this.MenuProfile_Click);
            // 
            // UnderConstruction2
            // 
            this.UnderConstruction2.BackgroundImage = global::friendcognition.Properties.Resources.if_cono_5125421;
            this.UnderConstruction2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnderConstruction2.Cursor = System.Windows.Forms.Cursors.No;
            this.UnderConstruction2.Location = new System.Drawing.Point(28, 22);
            this.UnderConstruction2.Margin = new System.Windows.Forms.Padding(4);
            this.UnderConstruction2.Name = "UnderConstruction2";
            this.UnderConstruction2.Size = new System.Drawing.Size(133, 127);
            this.UnderConstruction2.TabIndex = 4;
            this.UnderConstruction2.TabStop = false;
            // 
            // MenuLogout
            // 
            this.MenuLogout.BackgroundImage = global::friendcognition.Properties.Resources.if_sign_out_298869;
            this.MenuLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuLogout.Location = new System.Drawing.Point(248, 22);
            this.MenuLogout.Margin = new System.Windows.Forms.Padding(4);
            this.MenuLogout.Name = "MenuLogout";
            this.MenuLogout.Size = new System.Drawing.Size(133, 127);
            this.MenuLogout.TabIndex = 2;
            this.MenuLogout.TabStop = false;
            this.MenuLogout.Click += new System.EventHandler(this.MenuLogout_Click);
            // 
            // timerPrev
            // 
            this.timerPrev.Interval = 1;
            this.timerPrev.Tick += new System.EventHandler(this.timerPrev_Tick);
            // 
            // timerNext
            // 
            this.timerNext.Interval = 1;
            this.timerNext.Tick += new System.EventHandler(this.timerNext_Tick);
            // 
            // MenuButtonNext
            // 
            this.MenuButtonNext.BackColor = System.Drawing.Color.Transparent;
            this.MenuButtonNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MenuButtonNext.BackgroundImage")));
            this.MenuButtonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuButtonNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButtonNext.Location = new System.Drawing.Point(353, 209);
            this.MenuButtonNext.Margin = new System.Windows.Forms.Padding(4);
            this.MenuButtonNext.Name = "MenuButtonNext";
            this.MenuButtonNext.Size = new System.Drawing.Size(48, 44);
            this.MenuButtonNext.TabIndex = 9;
            this.MenuButtonNext.TabStop = false;
            this.MenuButtonNext.Click += new System.EventHandler(this.MenuButtonNext_Click);
            // 
            // MenuButtonPrev
            // 
            this.MenuButtonPrev.BackColor = System.Drawing.Color.Transparent;
            this.MenuButtonPrev.BackgroundImage = global::friendcognition.Properties.Resources.btnprev_BackgroundImage;
            this.MenuButtonPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuButtonPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButtonPrev.Location = new System.Drawing.Point(248, 209);
            this.MenuButtonPrev.Margin = new System.Windows.Forms.Padding(4);
            this.MenuButtonPrev.Name = "MenuButtonPrev";
            this.MenuButtonPrev.Size = new System.Drawing.Size(48, 44);
            this.MenuButtonPrev.TabIndex = 0;
            this.MenuButtonPrev.TabStop = false;
            this.MenuButtonPrev.Click += new System.EventHandler(this.MenuButtonPrev_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(652, 261);
            this.Controls.Add(this.SpreadPanel);
            this.Controls.Add(this.MenuButtonNext);
            this.Controls.Add(this.MenuButtonPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.SpreadPanel.ResumeLayout(false);
            this.SpreadPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderConstruction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderConstruction2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtonNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuButtonPrev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MenuButtonPrev;
        private System.Windows.Forms.PictureBox MenuButtonNext;
        private System.Windows.Forms.Panel SpreadPanel;
        private System.Windows.Forms.Label IdentClicks;
        private System.Windows.Forms.PictureBox MenuReturn;
        private System.Windows.Forms.PictureBox UnderConstruction;
        private System.Windows.Forms.PictureBox MenuProfile;
        private System.Windows.Forms.PictureBox UnderConstruction2;
        private System.Windows.Forms.PictureBox MenuLogout;
        private System.Windows.Forms.Timer timerPrev;
        private System.Windows.Forms.Timer timerNext;
    }
}