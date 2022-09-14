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
    public partial class HowLongUI : UserControl
    {
        public HowLongUI()
        {
            InitializeComponent();
        }

        private void Tiger_btn_Click(object sender, EventArgs e)
        {
            Tiger_panel.Visible = true;
            dog_panel.Visible = false;
            lion_panel.Visible = false;
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

        private void Car_btn_Click(object sender, EventArgs e)
        {
            Elephant_panel.Visible = true;
            Tiger_panel.Visible = true;
            dog_panel.Visible = true;
            lion_panel.Visible = true;
            Car_panel.Visible = true;
            Bike_panel.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Retunn_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
