using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("Name", name));
            sqlParams.Add(new SqlParameter("Surname", surname));
            sqlParams.Add(new SqlParameter("Email", email));
            sqlParams.Add(new SqlParameter("Password", password));

            DataController.Instance().ExecSP("Register", sqlParams);

            if (DataController.Instance().Register(name, surname, email, password))
            {
                RegisterCamera registerCamera = new RegisterCamera(email,password);
                registerCamera.Show();
                this.Hide();
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

            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("Email", email));
            sqlParams.Add(new SqlParameter("Password", password));

            DataTable dt = DataController.Instance().ExecSP("Login", sqlParams);

            if (dt.Rows.Count == 1)
            {
                DataController.Instance().setId(Convert.ToInt32(dt.Rows[0]["Id"]));
                OpenForm openForm = new OpenForm();
                openForm.Show();
                this.Hide();
            }        
        }
        private void LoginExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
