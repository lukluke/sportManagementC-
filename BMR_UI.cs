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
    public partial class BMR_UI : UserControl
    {
        public BMR_UI()
        {
            InitializeComponent();
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            double height;
            double wight;
            double age;
            double BMR = 0;
            try
            {
                height = double.Parse(H_txt.Text);
                wight = double.Parse(W_txt.Text);
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
                BMR_lable.Text = "The detail is not enough";
                BMR_lable.ForeColor = Color.Red;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void W_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Age_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void H_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Male_Radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void skinButton4_Click(object sender, EventArgs e)
        {
            BMR_lable.Visible = false;
            H_txt.Clear();
            W_txt.Clear();
            Age_txt.Clear();
            F_Radio.Checked = false;
            Male_Radio.Checked = false;
        }

        private void BMR_lable_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Retunn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
