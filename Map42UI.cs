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
    public partial class Map42UI : UserControl
    {
        public Map42UI()
        {
            InitializeComponent();
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

        private void CheckPoint2_21_btn_Click(object sender, EventArgs e)
        {
            CheckPoin1_21.Visible = true;
            CheckPoint2_21.Visible = true;
        }

        private void CheckPoint1_21_btn_Click(object sender, EventArgs e)
        {
            CheckPoin1_21.Visible = true;
            CheckPoint2_21.Visible = false;
        }

        private void Drink_2_btn_Click(object sender, EventArgs e)
        {
            Drink Dk = new Drink();
            Dk.Show();
        }

        private void Energy_2_btn_Click(object sender, EventArgs e)
        {
            Energy En = new Energy();
            En.Show();
        }

        private void Medical_2_btn_Click(object sender, EventArgs e)
        {
            Medical md = new Medical();
            md.Show();
        }

        private void Retunn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
