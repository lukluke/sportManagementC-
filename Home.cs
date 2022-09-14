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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void menue_Click(object sender, EventArgs e)
        {
            //animation
            if (sidemenu.Width == 44)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 200;
                PanelAnimator.ShowSync(sidemenu);
                LogoAnimator.ShowSync(logo);
            }
            else
            {
                sidemenu.Visible = false;
                sidemenu.Width = 44;

                PanelAnimator.ShowSync(sidemenu);
                LogoAnimator.Hide(logo);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Information_btn_Click(object sender, EventArgs e)
        {
           
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = true;
            sponsorContorUI1.Visible = false;
            chBMIR_UI1.Visible = false;
          
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = false;
            sponsorContorUI1.Visible = false;
            chBMIR_UI1.Visible = false;
   




        }

        private void sponsor_btn_Click(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = false;
            sponsorContorUI1.Visible = true;
            chBMIR_UI1.Visible = false;
         
        }

        private void BMI_btu_Click(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = false;
            sponsorContorUI1.Visible = false;
            chBMIR_UI1.Visible = true;
           
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login1 Login = new Login1();
            Login.Show();
            this.Hide();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now; //get Today time and Day
            //this.time_btn.Text = datetime.ToString();
            int hour = datetime.Hour; // get current hour
            int EndTime = 0;
            int min = datetime.Minute; //get Minute
            int EndMinute = 0;
            DateTime newDate = new DateTime(2017, 9, 18); //set the last day of time


            // Difference in days, hours, and minutes.
            TimeSpan ts = newDate - datetime; // day
            int LastHour = hour - EndTime; //Hour
            int LastMinute = min - EndMinute; // Minute

           Rtime.Text = datetime.ToString();



            // Difference in days.
            int differenceInDays = ts.Days;
            if (LastHour == 0 && LastMinute == 0 && differenceInDays == 0)
            {
                timer1.Stop();

                this.Rtime.ForeColor = Color.Red;
                this.Rtime.Text = "0 Day" + "  "+ "0 Hour" + " " + "and" + " " +  "0  minute " + " " + "until race start";



            }
            else
            {
                this.Rtime.Text = differenceInDays.ToString() + " " + "Day" + "  " + LastHour + "Hour" + " " + "and" + " " + LastMinute + " minute " + " " + "until race start";
            }
        }

        private void loginUI11_Load(object sender, EventArgs e)
        {

        }
    }
}
