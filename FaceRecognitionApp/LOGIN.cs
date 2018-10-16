using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognitionApp;

namespace friendcognition
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
            LoginPasswordInput.PasswordChar = '*';
            RegisterPasswordInput.PasswordChar = '*';
            this.CenterToScreen();
        }
        private void LoginButtonOff_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }
        private void RegisterButtonOn_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
        }
        private void Register_Click(object sender, EventArgs e)
        {
            string name = RegisterNameInput.Text;
            string surname = RegisterSurnameInput.Text;
            string email = RegisterEmailInput.Text;
            string password = RegisterPasswordInput.Text;

            if (DataController.Instance().Register(name, surname, email, password))
            {
                RegisterCamera registerCamera = new RegisterCamera(name, surname);
                registerCamera.Show();
            }
        }
        private void RegisterExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginButtonOn_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }
        private void RegisterButtonOff_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
        }
        private void LoginConfirmButton_Click(object sender, EventArgs e)
        {
            string email = LoginEmailInput.Text;
            string password = LoginPasswordInput.Text;

            if (DataController.Instance().Login(email, password))
            {
                OpenForm openForm = new OpenForm();
                openForm.Show();
            }           
        }
        private void LoginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
