﻿using System;
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
            DataContextDataContext dt = new DataContextDataContext();

           // var Image = from User in dt.GetTable<User>()
                     //  where User.Id == id
                     //  select User.Image.FromStream(new MemoryStream(User.toArray()));
           // ProfilePicture.Image = Image;
            var Name = from User in dt.GetTable<User>()
                       where User.Id == id
                       select User.Name;
            ProfileName.Text = Name.ToString();
            var Surname = from User in dt.GetTable<User>()
                       where User.Id == id
                       select User.Surname;
            ProfileSurname.Text = Surname.ToString();
            var Email = from User in dt.GetTable<User>()
                       where User.Id == id
                       select User.Email;
            ProfileEmail.Text = Email.ToString();
            
        }
        private void PictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "jpeg files (*.jpg)|*.jpg|png files (*.png)|*.png";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var img = Bitmap.FromStream(fileDialog.OpenFile());

                List<SqlParameter> sqlParams = new List<SqlParameter>();
                sqlParams.Add(new SqlParameter("Image", DataController.Instance().ConvertImageToByteArray(img)));
                sqlParams.Add(new SqlParameter("Id", id));
                DataController.Instance().ExecSP("StoreImage", sqlParams);
                ProfilePicture.Image = img;
            }
        }
    }
}
