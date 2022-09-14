namespace WindowsFormsApplication1
{
    partial class Camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camera));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Save_btn = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.Open_btn = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(9, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 320);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Save_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save_btn.BackgroundImage")));
            this.Save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Save_btn.ButtonText = "Save";
            this.Save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Save_btn.ForeColorHoverState = System.Drawing.SystemColors.Menu;
            this.Save_btn.Iconimage = null;
            this.Save_btn.IconVisible = true;
            this.Save_btn.IconZoom = 90D;
            this.Save_btn.ImageIconOverlay = false;
            this.Save_btn.Location = new System.Drawing.Point(319, 389);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(139, 42);
            this.Save_btn.TabIndex = 10;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Open_btn
            // 
            this.Open_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Open_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Open_btn.BackgroundImage")));
            this.Open_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Open_btn.ButtonText = "Open Camera";
            this.Open_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Open_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Open_btn.ForeColorHoverState = System.Drawing.SystemColors.Menu;
            this.Open_btn.Iconimage = null;
            this.Open_btn.IconVisible = true;
            this.Open_btn.IconZoom = 90D;
            this.Open_btn.ImageIconOverlay = false;
            this.Open_btn.Location = new System.Drawing.Point(53, 389);
            this.Open_btn.Name = "Open_btn";
            this.Open_btn.Size = new System.Drawing.Size(139, 42);
            this.Open_btn.TabIndex = 11;
            this.Open_btn.Click += new System.EventHandler(this.Open_btn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "jpg Image|*.jpg";
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 454);
            this.Controls.Add(this.Open_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Camera";
            this.Text = "Take a Photo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton Save_btn;
        private WindowsFormsControlLibrary1.BunifuThinButton Open_btn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}