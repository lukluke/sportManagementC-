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
    public partial class Map21UI : UserControl
    {
        public Map21UI()
        {
            InitializeComponent();
        }

        private void CheckPoint1_Click(object sender, EventArgs e)
        {

            CheckPoint1_panel.Visible = true;
            CheckPoint2_Panel.Visible = false;
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {

        }

        private void CheckPoint2_Click(object sender, EventArgs e)
        {
            CheckPoint2_Panel.Visible = true;
            CheckPoint1_panel.Visible = true;
        }

        private void CheckPoint1_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {

        }

        private void Drink_btn_Click(object sender, EventArgs e)
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

        private void Retunn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Drinl_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
        }

        private void Energy_btn_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        private void Medical_btn_Click(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }
    }
}
