using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ForgotPwd : MetroFramework.Forms.MetroForm
    {
        public ForgotPwd()
        {
            InitializeComponent();
        }
    
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            string Email = Email_Txt.Text;
            string name = FirstName_txt.Text;
            string Lname = LastName_txt.Text;
       //&& list.FirstName.Equals(FirstName_txt.Text) && list.LastName.Equals(LastName_txt)
            if (!string.IsNullOrEmpty(this.Email_Txt.Text)|| !string.IsNullOrEmpty(this.FirstName_txt.Text)|| !string.IsNullOrEmpty(this.LastName_txt.Text))
            {
                using (var getName = new marathonskills2017Entities())
                {
                    var username = from list in getName.user
                                   where (list.Email.Equals(Email_Txt.Text)&&list.FirstName.Equals(FirstName_txt.Text)&&list.LastName.Equals(LastName_txt.Text))
                                   select list;
                  
                    foreach (var loopUser in username.ToList())
                    {

                   
                        using (LoadingData save = new LoadingData(LoadingProcess))
                            {
                                save.ShowDialog(this);
                            }
                     

                            NewPwd newP = new NewPwd(string.Format( Email_Txt.Text)); // From NewPwd to get Email
                            newP.Show();
                            this.Hide();
                        
                    }
                

                }
            }else
            {
                MessageBox.Show("Please inp");
            }
           
        }
        void LoadingProcess()
        {
            for (int i = 0; i <= 500; i++)
                Thread.Sleep(8);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ID_Txt_Click(object sender, EventArgs e)
        {

        }

        private void Name_txt_Click(object sender, EventArgs e)
        {

        }
    }
}
