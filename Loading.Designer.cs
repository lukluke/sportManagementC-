namespace WindowsFormsApplication1
{
    partial class Loading
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Icon1 = new System.Windows.Forms.PictureBox();
            this.Icon2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(67, 218);
            this.progressBar1.MarqueeAnimationSpeed = 25;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(360, 14);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 1;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Icon1
            // 
            this.Icon1.Image = ((System.Drawing.Image)(resources.GetObject("Icon1.Image")));
            this.Icon1.Location = new System.Drawing.Point(34, 207);
            this.Icon1.Name = "Icon1";
            this.Icon1.Size = new System.Drawing.Size(72, 90);
            this.Icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icon1.TabIndex = 2;
            this.Icon1.TabStop = false;
            // 
            // Icon2
            // 
            this.Icon2.Image = ((System.Drawing.Image)(resources.GetObject("Icon2.Image")));
            this.Icon2.Location = new System.Drawing.Point(56, 207);
            this.Icon2.Name = "Icon2";
            this.Icon2.Size = new System.Drawing.Size(456, 90);
            this.Icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Icon2.TabIndex = 3;
            this.Icon2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(106, 63);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(321, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 358);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Icon1);
            this.Controls.Add(this.Icon2);
            this.Controls.Add(this.progressBar1);
            this.Name = "Loading";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.TransparencyKey = System.Drawing.Color.RoyalBlue;
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Icon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox Icon1;
        private System.Windows.Forms.PictureBox Icon2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}