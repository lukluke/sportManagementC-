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
    public partial class Map5UI : UserControl
    {
        public Map5UI()
        {
            InitializeComponent();
        }

        private void Drink_5_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
         
        }

        private void Medical_5_btn_Click(object sender, EventArgs e)
        {

            Medical md = new Medical();
            md.Show();
        }

        private void Energy_5_btn_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        private void CheckPoin1_5_btn_Click(object sender, EventArgs e)
        {
            CheckPoint1_5_panel.Visible = true;
            CheckPoint2_5_panel.Visible = false;
        }

        private void CheckPoint2_5_btn_Click(object sender, EventArgs e)
        {
            CheckPoint2_5_panel.Visible = true;
            CheckPoint1_5_panel.Visible = true;
        }

        private void Retunn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
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
    }
}
