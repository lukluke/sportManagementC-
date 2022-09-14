using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RegiserU : MetroFramework.Forms.MetroForm
    {
        public RegiserU()
        {
            InitializeComponent();
        }

        private void Selet_btn_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            //if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //{
              //  pictureBox4.Image = Image.FromFile(openFileDialog1.FileName);
            //}
        }

        private void RegiserU_Load(object sender, EventArgs e)
        {
            using (var country = new marathonskills2017Entities()) // search and display all the country in combox
            {
                //select countryName from country 
                var CoType = from list in country.country
                              select list.CountryName;

                foreach (var loopUser in CoType.ToList())
                {
                    ContryType_com.Items.Add(loopUser);
                }
            }
        }

        private void Create_btn_Click(object sender, EventArgs e)
        {
            using(var Register = new marathonskills2017Entities())
            {
                var reg = new user
                {
                    Email = Email_txt.Text,
                    Password = Pwd_txt.Text,
                    FirstName = FName_txt.Text,
                    LastName = LName_txt.Text,
                    RoleId = "R",
                   
                };
            }
        }

        private void ContryType_com_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Camera_btn_Click(object sender, EventArgs e)
        {
            Camera cre = new Camera();
            cre.Show();
        }
    }
}
