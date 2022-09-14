using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class HomePage_ui : UserControl

    {
        public HomePage_ui()
        {
            InitializeComponent();

            webBrowser1.Navigate("https://www.google.com/finance/converter");
            timer1.Start();
        }

        private void SendEmail_btn_Click(object sender, EventArgs e)
        {
            new sendEmail().ShowDialog();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void selection_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void HomePage_ui_Load(object sender, EventArgs e)
        {

         
        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Today;
            Time_label.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
