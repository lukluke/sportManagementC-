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
    public partial class Login1 : MetroFramework.Forms.MetroForm
    {
        public Login1()
        {
            InitializeComponent();
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            bool isRunner = false;
            bool isAdmin = false;
            bool isC = false;
            user loingOK = null;

            string LoginID = EmailLogin_txt.Text;
            string pwd = Pwd_login_txt.Text;
            using (var login = new marathonskills2017Entities())
            {
                var us = (from list in login.user
                          where (list.Email == EmailLogin_txt.Text
                          && list.Password == pwd)
                          select list).FirstOrDefault();
                if (us == null)
                {
                    MessageBox.Show("Invalid login detail");
                    return;
                }
                loingOK = us;
                if (us.RoleId.Equals("R"))
                {
                    isRunner = true;
                }
                else
                {
                    isRunner = false;
                }

                if (us.RoleId.Equals("A"))
                {
                    isAdmin = true;
                }
                else
                {
                    isAdmin = false;
                }
                if (us.RoleId.Equals("C"))
                {
                    isC = true;
                }
                else
                {
                    isC = false;
                }

                if (isRunner)
                {
                    new Form2().ShowDialog();
                    this.Hide();

                }
                if (isAdmin)
                {
                    new Admin().ShowDialog();
                    this.Hide();
                }
                if (isC)
                {
                    new Form2().ShowDialog();
                    this.Hide();
                }
            }
            // MetroFramework.MetroMessageBox.Show(this, "UserID /Email or Password is not correct","Login Unsucessful",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void Forget_btn_Click(object sender, EventArgs e)
        {

            ForgotPwd getpwd = new ForgotPwd();
            getpwd.Show();

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            new RegiserU().ShowDialog();
        }

        private void Retunn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }
    }
}
