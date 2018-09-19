using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Luxand;

namespace WindowsFormsApp1
{
    public partial class OpenForm : Form
    {
        String cameraName;
        bool cameraWorking = true;

        public OpenForm()
        {

            InitializeComponent();
            this.CenterToScreen();
            this.FormClosed += new FormClosedEventHandler(closingThisForm);

        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("colDhMxd3noCHRGBUPPlRrUW2NPTos6UGG6O8WkiZxzqS7R6e1KhzsJztksKgl1iWdePMcg9ransUedZAX7LAKegwtXLVT7FLXWH5/suefXLR6Ujl/CH5Yf2Ur+E06hTR93X8ODBQdhjQH4RBZB1bCBalylvewvpusFjHQkgTZk="))
            {
                MessageBox.Show("Error activating FaceSDK - please enter license key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            FSDK.InitializeLibrary();
            FSDKCam.InitializeCapturing();

            string [] cameraList;
            int cameraCount;
            FSDKCam.GetCameraList(out cameraList, out cameraCount);

            if (cameraCount == 0)
            {
                MessageBox.Show("No camera found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            cameraName = cameraList[0];
            FSDKCam.VideoFormatInfo[] formatList;
            FSDKCam.GetVideoFormatList(ref cameraName, out formatList, out cameraCount);

            int videoFormat = 0;
            pictureBox1.Width = formatList[videoFormat].Width;
            pictureBox1.Height = formatList[videoFormat].Height;
            this.Width = formatList[videoFormat].Width + 50;
            this.Height = formatList[videoFormat].Height + 100;

        }

        /*
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "START")
            {
                button1.Text = "SUBMIT";
                int cameraHandle = 0;
                if (FSDKCam.OpenVideoCamera(ref cameraName, ref cameraHandle) != FSDK.FSDKE_OK)
                {
                    MessageBox.Show("Error opening the camera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }

                while (cameraWorking)
                {
                    Application.DoEvents();
                    Int32 imageHandle = 0;
                    FSDKCam.GrabFrame(cameraHandle, ref imageHandle);
                    FSDK.CImage image = new FSDK.CImage(imageHandle);
                    Image frameImage = image.ToCLRImage();
                    pictureBox1.Image = frameImage;
                }

                FSDKCam.CloseVideoCamera(cameraHandle);
                FSDKCam.FinalizeCapturing();
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
            cameraWorking = false;
            Application.Exit();
        }

    }
}
