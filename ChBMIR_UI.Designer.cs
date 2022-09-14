namespace WindowsFormsApplication1
{
    partial class ChBMIR_UI
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChBMIR_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.ChBMR = new Bunifu.Framework.UI.BunifuTileButton();
            this.ChBMI = new Bunifu.Framework.UI.BunifuTileButton();
            this.bmR_UI1 = new WindowsFormsApplication1.BMR_UI();
            this.bmI_UI1 = new WindowsFormsApplication1.BMI_UI();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(265, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose BMI or BMR";
            // 
            // ChBMR
            // 
            this.ChBMR.BackColor = System.Drawing.Color.DarkSalmon;
            this.ChBMR.color = System.Drawing.Color.DarkSalmon;
            this.ChBMR.colorActive = System.Drawing.Color.Sienna;
            this.ChBMR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChBMR.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ChBMR.ForeColor = System.Drawing.Color.White;
            this.ChBMR.Image = ((System.Drawing.Image)(resources.GetObject("ChBMR.Image")));
            this.ChBMR.ImagePosition = 20;
            this.ChBMR.ImageZoom = 50;
            this.ChBMR.LabelPosition = 41;
            this.ChBMR.LabelText = "BMR";
            this.ChBMR.Location = new System.Drawing.Point(398, 142);
            this.ChBMR.Margin = new System.Windows.Forms.Padding(6);
            this.ChBMR.Name = "ChBMR";
            this.ChBMR.Size = new System.Drawing.Size(128, 129);
            this.ChBMR.TabIndex = 4;
            this.ChBMR.Click += new System.EventHandler(this.ChBMR_Click);
            // 
            // ChBMI
            // 
            this.ChBMI.BackColor = System.Drawing.Color.Red;
            this.ChBMI.color = System.Drawing.Color.Red;
            this.ChBMI.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ChBMI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChBMI.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.ChBMI.ForeColor = System.Drawing.Color.White;
            this.ChBMI.Image = ((System.Drawing.Image)(resources.GetObject("ChBMI.Image")));
            this.ChBMI.ImagePosition = 20;
            this.ChBMI.ImageZoom = 50;
            this.ChBMI.LabelPosition = 41;
            this.ChBMI.LabelText = "BMI";
            this.ChBMI.Location = new System.Drawing.Point(170, 141);
            this.ChBMI.Margin = new System.Windows.Forms.Padding(6);
            this.ChBMI.Name = "ChBMI";
            this.ChBMI.Size = new System.Drawing.Size(128, 129);
            this.ChBMI.TabIndex = 3;
            this.ChBMI.Click += new System.EventHandler(this.ChBMI_Click);
            // 
            // bmR_UI1
            // 
            this.bmR_UI1.BackColor = System.Drawing.Color.White;
            this.bmR_UI1.Location = new System.Drawing.Point(3, 3);
            this.bmR_UI1.Name = "bmR_UI1";
            this.bmR_UI1.Size = new System.Drawing.Size(697, 376);
            this.bmR_UI1.TabIndex = 7;
            this.bmR_UI1.Visible = false;
            // 
            // bmI_UI1
            // 
            this.bmI_UI1.BackColor = System.Drawing.Color.White;
            this.bmI_UI1.Location = new System.Drawing.Point(0, 0);
            this.bmI_UI1.Name = "bmI_UI1";
            this.bmI_UI1.Size = new System.Drawing.Size(694, 373);
            this.bmI_UI1.TabIndex = 6;
            this.bmI_UI1.Visible = false;
            // 
            // ChBMIR_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bmR_UI1);
            this.Controls.Add(this.bmI_UI1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChBMR);
            this.Controls.Add(this.ChBMI);
            this.Name = "ChBMIR_UI";
            this.Size = new System.Drawing.Size(697, 376);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton ChBMR;
        private Bunifu.Framework.UI.BunifuTileButton ChBMI;
        private BMI_UI bmI_UI1;
        private BMR_UI bmR_UI1;
    }
}
