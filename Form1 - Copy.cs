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
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(Load));
            t.Start();
            Thread.Sleep(2500);
            InitializeComponent();
               
            t.Abort();
            timer1.Start();

            main_UI.Visible = true;
            Main1_UI.Visible = false;

        }
        void Load()
        {
            Loading frm = new Loading();
            Application.Run(frm);
        }

        //Don't revise this code . otherwise the program will error.
        //close the window form button on the top
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        //cal the time from start to end //
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

            Time_label.Text = datetime.ToString(); 
             
  

            // Difference in days.
            int differenceInDays = ts.Days;
            if (LastHour == 0 && LastMinute == 0 && differenceInDays == 0)
            {
           
                this.Rtime.ForeColor = Color.Red;
                
                
            }
            else
            {
                this.Rtime.Text = differenceInDays.ToString() + " " + "Day" + "  " + LastHour + "Hour" + " " + "and" + " " + LastMinute + " minute " + " " + "until race start";
            }
         
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

        private void sponsor_btn_Click(object sender, EventArgs e)
        {
            main_UI.Visible = true;
            Main1_UI.Visible = true;
            BMIR_UI.Visible = true;
            BMI_UI.Visible = true;
            BMR_UI.Visible = true;
            About_Information_ui.Visible = true;
            Map21_ui.Visible = true;
            Map42_ui.Visible = true;
            Map5_ui.Visible = true;
            HowLong_ui.Visible = true;
            
            Sponsor_ui.Visible = true;
            // BMR_UI.Visible = false;
        }
        //control UI button in left//
        private void BMI_btu_Click(object sender, EventArgs e)
        {
            main_UI.Visible = true;
            Main1_UI.Visible = true;
            BMIR_UI.Visible = true;
            BMI_UI.Visible = false;
            BMR_UI.Visible = false;
            About_Information_ui.Visible = false;
            UnderWeight_txt.BackColor = Color.White;
            Obese_txt.BackColor = Color.White;
            Normal_txt.BackColor = Color.White;
            OverWeight_txt.BackColor = Color.White;

            //BMR Reset
            BMR_lable.Visible = false;
            H_txt.Clear();
            W_txt.Clear();
            Age_txt.Clear();
            F_Radio.Checked = false;
            Male_Radio.Checked = false;


            //BMR_UI.Visible = false;
        }

        private void ChBMI_Click_1(object sender, EventArgs e)
        {
            main_UI.Visible = true;
            Main1_UI.Visible = true;
            BMIR_UI.Visible = true;
            BMI_UI.Visible = true;
         
            BMR_UI.Visible = false;

            //reset 
            Weight_txt.Clear();
            Height_txt.Clear();
            Message.Visible = false;
            BMIOutput.Visible = false;

            //BMI icon visibe//
            thin_icon.Visible = false;
            normal_icon.Visible = false;
            Obese_icon.Visible = false;
            overWeight_btn.Visible = false;
        }

        private void ChBMR_Click(object sender, EventArgs e)
        {
            main_UI.Visible = true;
            Main1_UI.Visible = true;
            BMIR_UI.Visible = true;
            BMI_UI.Visible = false;
            BMR_UI.Visible = true;
            //BMR_UI.Visible = true;

            
        }
 /*--------------------------------------------------------------------------------------------------------*/
        //Main Function :
        //BMI Function
        //Reset the BMI 
        private void skinButton1_Click(object sender, EventArgs e)
        {
            Weight_txt.Clear();
            Height_txt.Clear();
            Message.Visible = false;
            BMIOutput.Visible = false;

            //BMI icon visibe//
            thin_icon.Visible = false;
            normal_icon.Visible = false;
            Obese_icon.Visible = false;
            overWeight_btn.Visible = false;
            UnderWeight_txt.BackColor = Color.White;
            Obese_txt.BackColor = Color.White;
            Normal_txt.BackColor = Color.White;
            OverWeight_txt.BackColor = Color.White;
        }

        //Cal the BMI//
        private void CheckBMI_btn_Click(object sender, EventArgs e)
        {
        
            try
            {
                double h, w, total;
                BMIOutput.Visible = true;
                Message.Visible = true;
                h = double.Parse(Height_txt.Text) / 100.0;
                w = double.Parse(Weight_txt.Text);
                total = w / (h * h);
                BMIOutput.Text = "BMI is " + total.ToString("#0.00");
                UnderWeight_txt.BackColor = Color.White;
                Obese_txt.BackColor = Color.White;
                Normal_txt.BackColor = Color.White;
                OverWeight_txt.BackColor = Color.White;

                if (total < 18.5)
                {
                    Message.Text = "You are UnderWeight !!";
                    Message.BackColor = Color.White;
                    Message.ForeColor = Color.Red;
                    UnderWeight_txt.BackColor = Color.Red;
                    thin_icon.Visible = true;
                    normal_icon.Visible = false;
                    overWeight_btn.Visible = false;
                    Obese_icon.Visible = false;
                }
                else if (total >= 18.5 && total < 24.9)
                {
                    Message.Text = "You are Normal!!";
                    
                    Message.ForeColor = Color.DarkGoldenrod;
                    Normal_txt.BackColor = Color.DarkGoldenrod;
                    thin_icon.Visible = false;
                    Obese_icon.Visible = false;
                    overWeight_btn.Visible = false;
                    normal_icon.Visible = true;
                }
                else if (total >= 25 && total < 29.9)
                {
                    Message.Text = "You are OverWeight!!";
                    Message.ForeColor = Color.Green;
                    OverWeight_txt.BackColor = Color.Green;
                    thin_icon.Visible = false;
                    normal_icon.Visible = false;
                    Obese_icon.Visible = false;
                    overWeight_btn.Visible = true;
                }
                else
                {
                    Message.Text = "You are Obese!!";
                    Message.ForeColor = Color.DarkOrange;
                    Obese_txt.BackColor = Color.DarkOrange;
                    thin_icon.Visible = false;
                    normal_icon.Visible = false;
                    overWeight_btn.Visible = false;
                    Obese_icon.Visible = true;
                }
            }catch (Exception )
            {
                Message.Text = "Please input data";
                Message.ForeColor = Color.Blue;
                BMIOutput.Visible = false;
                thin_icon.Visible = false;
                normal_icon.Visible = false;
                Obese_icon.Visible = false;
                overWeight_btn.Visible = false;
                UnderWeight_txt.BackColor = Color.White;
                Obese_txt.BackColor = Color.White;
                Normal_txt.BackColor = Color.White;
                OverWeight_txt.BackColor = Color.White;
            }
        }
        

        private void BMI_UI_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void Information_btn_Click(object sender, EventArgs e)
        {
            main_UI.Visible = true;
            Main1_UI.Visible = true;
            BMIR_UI.Visible = true;
            BMI_UI.Visible = true;
            BMR_UI.Visible = true;
            About_Information_ui.Visible = true;
            Map21_ui.Visible = false;
            Map42_ui.Visible = false;
            Map5_ui.Visible = false;
            CheckPoint1_5_panel.Visible = false;
            CheckPoin1_21.Visible = false;
            CheckPoint1_panel.Visible = false;
            


           

        }
        private void home_Click(object sender, EventArgs e)
        {
            
            main_UI.Visible = true;
            Main1_UI.Visible = false;
           
        }

        private void CkP_button_Click(object sender, EventArgs e)
        {
            
         
        }

        private void Medical_btn_Click(object sender, EventArgs e)
        {
           
        }

        //for medical close button
        private void CKP1_Close_btn_Click(object sender, EventArgs e)
        {
      
            
        }
        //check pint2
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
          
            
        }

 

        private void CheckPoint1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Km21_btn_Click(object sender, EventArgs e)
        {
            Map21_ui.Visible = true;
        }

        private void Drink_btn_Click(object sender, EventArgs e)
        {
           
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void CKP1_M_Close_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          
        }

        private void Rtime_Click(object sender, EventArgs e)
        {

        }

        private void skinButton1_Click_1(object sender, EventArgs e)
        {
            double height;
            double wight ;
            double age;
            double BMR = 0;
            try
            {
                height =  double.Parse(H_txt.Text);
                wight =  double.Parse(W_txt.Text);
                age = int.Parse(Age_txt.Text);
           
                if (F_Radio.Checked)
                {
                    BMR = 10 * wight + 6.25 * height - 5 * age - 161;
                    BMR_lable.Visible = true;
                    BMR_lable.Text = BMR.ToString("#0.00");

                }
                if (Male_Radio.Checked)
                {
                    BMR = 10 * wight + 6.25 * height - 5 * age + 5;
                    BMR_lable.Visible = true;
                    BMR_lable.Text = BMR.ToString("#0.00");

                }
            }
            catch (Exception)
            {
                BMR_lable.Visible = true;
                BMR_lable.Text ="The detail is not enough";
                BMR_lable.ForeColor = Color.Red;
            }


        }
        //Reset BMR

        
        private void skinButton4_Click(object sender, EventArgs e)
        {
            BMR_lable.Visible = false;
            H_txt.Clear();
            W_txt.Clear();
            Age_txt.Clear();
            F_Radio.Checked = false;
            Male_Radio.Checked = false;

        }
        //-------------------------------------------------------------------------
        //Interactive Map Function
        private void CheckPoint1_Click(object sender, EventArgs e)
        {
            CheckPoint1_panel.Visible = true;
            CheckPoint2_Panel.Visible = false;
        }

        //CheckPoint1
        private void Medical_btn_Click_1(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();

        }

        private void Drinl_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
        }

        private void CheckPoint2_Click(object sender, EventArgs e)
        {
            CheckPoint2_Panel.Visible = true;
            CheckPoint1_panel.Visible = true;

        }

        //CheckPoint2
        private void Drink_btn_Click_1(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
        }

        private void Medic_btn_Click(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }

        private void Energy_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        private void Drink_2_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
        }

        private void Medical_2_btn_Click(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }

        private void Energy_2_btn_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        private void CheckPoint1_21_btn_Click(object sender, EventArgs e)
        {
            CheckPoin1_21.Visible = true;
            CheckPoint2_21.Visible = false;
        }

        private void CheckPoint2_21_btn_Click(object sender, EventArgs e)
        {
            CheckPoin1_21.Visible = true;
            CheckPoint2_21.Visible = true;
        }

        private void Drink_21_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
        }

        private void Medical_21_btn_Click(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }

        private void Energy_21_btn_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Map42_ui.Visible = true;
            Map21_ui.Visible = true;
            Map5_ui.Visible = false;

        }

        private void CheckPoin1_5_btn_Click(object sender, EventArgs e)
        {
            CheckPoint1_5_panel.Visible = true;
            CheckPoint2_5_panel.Visible = false;
        }

        private void Map5_btn_Click_1(object sender, EventArgs e)
        {
            Map21_ui.Visible = true;
            Map42_ui.Visible = true;
            Map5_ui.Visible = true;
            HowLong_ui.Visible = false;
        }

        private void Km42_Label_Click(object sender, EventArgs e)
        {

        }

        private void CheckPoint2_5_btn_Click(object sender, EventArgs e)
        {
            CheckPoint2_5_panel.Visible = true;
            CheckPoint1_5_panel.Visible = true;
        }

        private void Drink_5_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
            Medical Dd = new Medical();
            Dd.Close();
        }

        private void Energy_5_btn_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        private void Medical_5_btn_Click(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }

        private void Drink1_5_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
        }

        private void Medical1_5_btn_Click(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }

        private void Energy1_5_btn_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        //--------------------------------------------------------------------------
        private void HowLongMarathon_btn_Click(object sender, EventArgs e)
        {
            Map21_ui.Visible = true;
            Map42_ui.Visible = true;
            Map5_ui.Visible = true;
            HowLong_ui.Visible = true;
            Sponsor_ui.Visible = false;
        }

        private void sidemenu_Paint(object sender, PaintEventArgs e)
        {

        }

      
        private void Tiger_btn_Click(object sender, EventArgs e)
        {
            Tiger_panel.Visible = true;
            dog_panel.Visible = false;
            lion_panel.Visible = false;
            Elephant_panel.Visible = false;
        }

        private void sponsor_UI_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dog_btn_Click(object sender, EventArgs e)
        {
            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = false;
        }

        private void Lion_btn_Click(object sender, EventArgs e)
        {

            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = true;
            Elephant_panel.Visible = false;

        }

        private void Elephant_btn_Click(object sender, EventArgs e)
        {
            Elephant_panel.Visible = true;
            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = true;
            Car_panel.Visible = false;
        }

        private void Car_btn_Click(object sender, EventArgs e)
        {
            Elephant_panel.Visible = true;
            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = true;
            Car_panel.Visible = true;
            Bike_panel.Visible = false ;
        }

        private void Bike_btn_Click(object sender, EventArgs e)
        {
            Elephant_panel.Visible = true;
            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = true;
            Car_panel.Visible = true;
            Bike_panel.Visible = true;
            Train_oanel.Visible = false;
        }

        private void Train_btn_Click(object sender, EventArgs e)
        {
            Elephant_panel.Visible = true;
            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = true;
            Car_panel.Visible = true;
            Bike_panel.Visible = true;
            Train_oanel.Visible = true;
            Airplane_panel.Visible = false;
        }

        private void airplane_btn_Click(object sender, EventArgs e)
        {
            Elephant_panel.Visible = true;
            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = true;
            Car_panel.Visible = true;
            Bike_panel.Visible = true;
            Train_oanel.Visible = true;
            Airplane_panel.Visible = true;
        }

        private void About_label_Click(object sender, EventArgs e)
        {
            line.Width = About_label.Width;
            line.Left = About_label.Left;
        }

        private void photo_label_Click(object sender, EventArgs e)
        {
            line.Width = photo_label.Width;
            line.Left = photo_label.Left;
            photo.Visible = true;
        }

        private void HowLong_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Pay_btn_Click(object sender, EventArgs e)
        {
            using (SaveData save = new SaveData(SaveSucess))
            {
                save.ShowDialog(this);
            }
        }
        void SaveSucess()
        {
            for(int i = 0; i<=500;i++)
                Thread.Sleep(8);
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Login1 lg = new Login1();
            lg.Show();
           
        }

        private void CardType_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CardType_CB.SelectedItem == "VISA")
            {
                Visa_picture.Visible = true;
                Paypal_picture.Visible = false;
            }
            else if (CardType_CB.SelectedItem == "PayPal")
            {
                Visa_picture.Visible = true;
                Paypal_picture.Visible = true;
                Master_picture.Visible = false;
            }
            else if (CardType_CB.SelectedItem == "MasterCard") {
                Visa_picture.Visible = true;
                Paypal_picture.Visible = true;
                Master_picture.Visible = true;
            }
        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------------------------
    }
}
