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

        private bool wantsToExit = true;

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
            if (wantsToExit)
            {
                Application.Exit();
            }
                

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        void closingThisForm(object sender, FormClosedEventArgs e)
        {

            CameraController.Instance().StopStreaming();
            if (wantsToExit)
            {
                Application.Exit();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();
            wantsToExit = false;
            this.Close();
            login.Show();
            
        }
    }
}
