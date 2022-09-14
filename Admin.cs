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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = false;
            sponsorContorUI1.Visible = false;
            chBMIR_UI1.Visible = false;
            management1.Visible = false;
        }

        private void Information_btn_Click(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = true;
            sponsorContorUI1.Visible = false;
            chBMIR_UI1.Visible = false;
            management1.Visible = false;
        }

        private void sponsor_btn_Click_1(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = false;
            sponsorContorUI1.Visible = true;
            chBMIR_UI1.Visible = false;
            management1.Visible = false;
          
        }

        private void BMI_btu_Click_1(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = false;
            sponsorContorUI1.Visible = false;
            chBMIR_UI1.Visible = true;
            management1.Visible = false;
        }

        private void Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QR_btn_Click(object sender, EventArgs e)
        {
            ReadQR QR = new ReadQR();
            QR.Show();
        }

        private void Management_btn_Click(object sender, EventArgs e)
        {
            homePage_ui1.Visible = true;
            aboutINformation_UI1.Visible = false;
            sponsorContorUI1.Visible = false;
            chBMIR_UI1.Visible = false;
            management1.Visible = true;
        }

        private void Account_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }

        private void off(object sender, EventArgs e)
        {
       
        }
    }
}
