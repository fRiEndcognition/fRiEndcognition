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

        public OpenForm()
        {

            InitializeComponent();
            this.CenterToScreen();

        }

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

        private void button1_Click_2(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(this);
            
            

            registerForm.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OpenForm_Load(object sender, EventArgs e)
        {
            if (FSDK.FSDKE_OK != FSDK.ActivateLibrary("colDhMxd3noCHRGBUPPlRrUW2NPTos6UGG6O8WkiZxzqS7R6e1KhzsJztksKgl1iWdePMcg9ransUedZAX7LAKegwtXLVT7FLXWH5/suefXLR6Ujl/CH5Yf2Ur+E06hTR93X8ODBQdhjQH4RBZB1bCBalylvewvpusFjHQkgTZk="))
            {
                MessageBox.Show("Error activating FaceSDK - please enter license key","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}
