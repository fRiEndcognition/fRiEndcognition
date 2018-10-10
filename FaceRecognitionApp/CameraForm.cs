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
            this.WindowState = FormWindowState.Maximized;
            this.CenterToScreen();
            this.FormClosed += new FormClosedEventHandler(closingThisForm);

        }


        private void OpenForm_Load(object sender, EventArgs e)
        {
            CameraController.Instance().InitializeCamera(CameraPictureBox);
            CameraController.Instance().StartStreaming(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
                Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void closingThisForm(object sender, FormClosedEventArgs e)
        {

            CameraController.Instance().StopStreaming();
            Application.Exit();
        }

    }
}
