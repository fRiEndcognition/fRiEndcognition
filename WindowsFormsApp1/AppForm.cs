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
    public partial class AppForm : Form
    {
        public AppForm()
        {
            InitializeComponent();
            this.CenterToParent();
            this.FormClosed += new FormClosedEventHandler(closingThisForm);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        void closingThisForm(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
