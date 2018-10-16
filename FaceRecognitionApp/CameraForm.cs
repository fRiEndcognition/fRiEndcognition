using friendcognition;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class OpenForm : Form
    {
        public OpenForm()
        {
            InitializeComponent();
        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            CameraController.Instance().InitializeCamera(CameraPictureBox);
            CameraPictureBox.Width = CameraController.Instance().getVideoFormat().Width;
            CameraPictureBox.Height = CameraController.Instance().getVideoFormat().Height;
            this.Width = CameraController.Instance().getVideoFormat().Width;
            this.Height = CameraController.Instance().getVideoFormat().Height;
            this.CenterToScreen();
        }
        private void OpenForm_Shown(object sender, EventArgs e)
        {
            CameraController.Instance().StartStreaming(false,this.Location);
        }
        private void CameraFormExitButton_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }
        private void OpenForm_Closing(object sender, FormClosingEventArgs e)
        {
                CameraController.Instance().StopStreaming();
        }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            friendcognition.Menu menu = new friendcognition.Menu();
            menu.Show();
            
        }
    }
}
