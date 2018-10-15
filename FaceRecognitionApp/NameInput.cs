using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace friendcognition
{
    public partial class NameInput : Form
    {
        public string username;

        public NameInput()
        {
            InitializeComponent();
        }
        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {
            username = InputTextbox.Text;
        }
        private void InputButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
