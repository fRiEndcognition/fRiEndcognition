using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

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
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
        }
        private void button6_Click(object sender, EventArgs e)
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
        private void button7_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            LoginPanel.Visible = true;
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            LoginPanel.Visible = false;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            string email = LoginEmailInput.Text;
            string password = LoginPasswordInput.Text;

            if (DataController.Instance().Login(email, password))
            {
                OpenForm openForm = new OpenForm();
                openForm.Show();
            }
            
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
