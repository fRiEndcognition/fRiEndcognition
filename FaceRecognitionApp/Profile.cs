using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace friendcognition
{
    public partial class Profile : Form
    {
        private int id = 0;

        public Profile()
        {
            id = DataController.Instance().getId();
            InitializeComponent();
        }

        public Profile(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void CameraFormExitButton_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
            menu.Show();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            List<SqlParameter> sqlParams = new List<SqlParameter>();
            sqlParams.Add(new SqlParameter("Id", id));
            DataTable dt = DataController.Instance().ExecSP("LoadInfo", sqlParams);

            ProfilePicture.Image = Image.FromStream(new MemoryStream((byte[])dt.Rows[0]["Image"]));
            ProfileName.Text = Convert.ToString(dt.Rows[0]["Name"]);
            ProfileSurname.Text = Convert.ToString(dt.Rows[0]["Surname"]);
            ProfileEmail.Text = Convert.ToString(dt.Rows[0]["Email"]);
            
        }

        private void ProfileAgeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
