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
    public partial class AboutINformation_UI : UserControl
    {
        public AboutINformation_UI()
        {
            InitializeComponent();
        }

        private void Km21_btn_Click(object sender, EventArgs e)
        {
            map21UI1.Visible = true;
            howLongUI1.Visible = false;
            map5UI1.Visible = false;
            map42UI1.Visible = false;
        }

        private void HowLongMarathon_btn_Click(object sender, EventArgs e)
        {
            howLongUI1.Visible = true;
            map5UI1.Visible = false;
            map21UI1.Visible = false;
            map42UI1.Visible = false;
        }

        private void AboutINformation_UI_Load(object sender, EventArgs e)
        {
       
        }

        private void Map5_btn_Click(object sender, EventArgs e)
        {
            map5UI1.Visible = true;
            howLongUI1.Visible = false;
            map21UI1.Visible = false;
            map42UI1.Visible = false;
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            map5UI1.Visible = false;
            howLongUI1.Visible = false;
            map21UI1.Visible = false;
            map42UI1.Visible = true;
        }
    }
}
