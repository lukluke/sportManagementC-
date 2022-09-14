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
    public partial class BMI_UI : UserControl
    {
        public BMI_UI()
        {
            InitializeComponent();
        }

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
                    BMI_ICON.Visible = false;
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
                    BMI_ICON.Visible = false;
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
                    BMI_ICON.Visible = false;
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
                    BMI_ICON.Visible = false;
                }
            }
            catch (Exception)
            {
                Message.Text = "Please input data";
                Message.ForeColor = Color.Blue;
                BMIOutput.Visible = false;
                thin_icon.Visible = false;
                normal_icon.Visible = false;
                Obese_icon.Visible = false;
                overWeight_btn.Visible = false;
                BMI_ICON.Visible = true;
                UnderWeight_txt.BackColor = Color.White;
                Obese_txt.BackColor = Color.White;
                Normal_txt.BackColor = Color.White;
                OverWeight_txt.BackColor = Color.White;
            }
        }

        private void OverWeight_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Normal_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void overWeight_btn_Click(object sender, EventArgs e)
        {

        }

        private void UnderWeight_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Obese_icon_Click(object sender, EventArgs e)
        {

        }

        private void normal_icon_Click(object sender, EventArgs e)
        {

        }

        private void thin_icon_Click(object sender, EventArgs e)
        {

        }

        private void Reset_btn_Click(object sender, EventArgs e)
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
            BMI_ICON.Visible = true;
            UnderWeight_txt.BackColor = Color.White;
            Obese_txt.BackColor = Color.White;
            Normal_txt.BackColor = Color.White;
            OverWeight_txt.BackColor = Color.White;

        }

        private void Obese_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void BMIOutput_Click(object sender, EventArgs e)
        {

        }

        private void Height_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Weight_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Type_Click(object sender, EventArgs e)
        {

        }

        private void Retunn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BMI_UI_Load(object sender, EventArgs e)
        {
            this.OverWeight_txt.Visible = true;
        }
    }
}
