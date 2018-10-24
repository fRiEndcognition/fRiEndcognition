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
        bool anotherUser = false;

        public Profile()
        {
            id = DataController.Instance().getId();
            InitializeComponent();
        }

        public Profile(int id)
        {
            this.id = id;
            anotherUser = true;
            InitializeComponent();
        }

        private void CameraFormExitButton_Click(object sender, EventArgs e)
        {
            if (anotherUser == false)
            {
                Menu menu = new Menu();
                menu.Show();
            }
            this.Close();
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
        private void PictureButton_Click(object sender, EventArgs e)
        {

        }
    }
}
