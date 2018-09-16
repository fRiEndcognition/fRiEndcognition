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
    public partial class RegisterForm : Form
    {

        private Form originForm;

        public RegisterForm(Form originForm)
        {
            InitializeComponent();
            this.CenterToParent();
            this.originForm = originForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            AppForm appForm = new AppForm();
            appForm.Left = originForm.Left;
            appForm.Top = originForm.Top;
            appForm.Size = originForm.Size;

            originForm.Hide();

            appForm.Show();
            
            this.Hide();
            

           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
