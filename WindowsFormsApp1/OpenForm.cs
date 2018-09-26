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
            CameraController.Instance().InitializeCamera(pictureBox1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Tag.Equals(Constants.START_BUTTON))
            {
                button1.Text = "SUBMIT";
                button1.Tag = Constants.SUBMIT_BUTTON;

                CameraController.Instance().StartStreaming();
            }
            else
            {
                RegisterForm registerForm = new RegisterForm(this);

                registerForm.Show();
            }

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
