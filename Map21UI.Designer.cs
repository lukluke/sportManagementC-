namespace WindowsFormsApplication1
{
    partial class Map21UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Map21UI));
            this.CheckPoint1_panel = new System.Windows.Forms.Panel();
            this.CheckPoint2_Panel = new System.Windows.Forms.Panel();
            this.Energy = new Bunifu.Framework.UI.BunifuTileButton();
            this.Medic_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Drink_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.CheckPoint_2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Energy_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Medical_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Drinl_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Toilet_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.CheckPoint2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.CheckPoint1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.Retunn_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.CheckPoint1_panel.SuspendLayout();
            this.CheckPoint2_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPoint2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPoint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retunn_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // CheckPoint1_panel
            // 
            this.CheckPoint1_panel.BackColor = System.Drawing.SystemColors.Menu;
            this.CheckPoint1_panel.Controls.Add(this.CheckPoint2_Panel);
            this.CheckPoint1_panel.Controls.Add(this.label15);
            this.CheckPoint1_panel.Controls.Add(this.Energy_btn);
            this.CheckPoint1_panel.Controls.Add(this.Medical_btn);
            this.CheckPoint1_panel.Controls.Add(this.Drinl_btn);
            this.CheckPoint1_panel.Controls.Add(this.Toilet_btn);
            this.CheckPoint1_panel.Location = new System.Drawing.Point(478, 42);
            this.CheckPoint1_panel.Name = "CheckPoint1_panel";
            this.CheckPoint1_panel.Size = new System.Drawing.Size(200, 293);
            this.CheckPoint1_panel.TabIndex = 15;
            this.CheckPoint1_panel.Visible = false;
            this.CheckPoint1_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckPoint1_panel_Paint);
            // 
            // CheckPoint2_Panel
            // 
            this.CheckPoint2_Panel.BackColor = System.Drawing.SystemColors.Menu;
            this.CheckPoint2_Panel.Controls.Add(this.Energy);
            this.CheckPoint2_Panel.Controls.Add(this.Medic_btn);
            this.CheckPoint2_Panel.Controls.Add(this.Drink_btn);
            this.CheckPoint2_Panel.Controls.Add(this.bunifuTileButton4);
            this.CheckPoint2_Panel.Controls.Add(this.CheckPoint_2);
            this.CheckPoint2_Panel.Location = new System.Drawing.Point(0, 2);
            this.CheckPoint2_Panel.Name = "CheckPoint2_Panel";
            this.CheckPoint2_Panel.Size = new System.Drawing.Size(200, 291);
            this.CheckPoint2_Panel.TabIndex = 14;
            this.CheckPoint2_Panel.Visible = false;
            // 
            // Energy
            // 
            this.Energy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Energy.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Energy.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Energy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Energy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Energy.ForeColor = System.Drawing.Color.White;
            this.Energy.Image = ((System.Drawing.Image)(resources.GetObject("Energy.Image")));
            this.Energy.ImagePosition = 17;
            this.Energy.ImageZoom = 50;
            this.Energy.LabelPosition = 34;
            this.Energy.LabelText = "Energy Bar";
            this.Energy.Location = new System.Drawing.Point(101, 179);
            this.Energy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Energy.Name = "Energy";
            this.Energy.Size = new System.Drawing.Size(91, 100);
            this.Energy.TabIndex = 13;
            this.Energy.Click += new System.EventHandler(this.Energy_Click);
            // 
            // Medic_btn
            // 
            this.Medic_btn.BackColor = System.Drawing.Color.Red;
            this.Medic_btn.color = System.Drawing.Color.Red;
            this.Medic_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Medic_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medic_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Medic_btn.ForeColor = System.Drawing.Color.White;
            this.Medic_btn.Image = ((System.Drawing.Image)(resources.GetObject("Medic_btn.Image")));
            this.Medic_btn.ImagePosition = 20;
            this.Medic_btn.ImageZoom = 50;
            this.Medic_btn.LabelPosition = 41;
            this.Medic_btn.LabelText = "Medical";
            this.Medic_btn.Location = new System.Drawing.Point(10, 179);
            this.Medic_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Medic_btn.Name = "Medic_btn";
            this.Medic_btn.Size = new System.Drawing.Size(86, 100);
            this.Medic_btn.TabIndex = 12;
            this.Medic_btn.Click += new System.EventHandler(this.Medic_btn_Click);
            // 
            // Drink_btn
            // 
            this.Drink_btn.BackColor = System.Drawing.Color.Aqua;
            this.Drink_btn.color = System.Drawing.Color.Aqua;
            this.Drink_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Drink_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drink_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Drink_btn.ForeColor = System.Drawing.Color.Black;
            this.Drink_btn.Image = ((System.Drawing.Image)(resources.GetObject("Drink_btn.Image")));
            this.Drink_btn.ImagePosition = 20;
            this.Drink_btn.ImageZoom = 50;
            this.Drink_btn.LabelPosition = 41;
            this.Drink_btn.LabelText = "Drink";
            this.Drink_btn.Location = new System.Drawing.Point(106, 68);
            this.Drink_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Drink_btn.Name = "Drink_btn";
            this.Drink_btn.Size = new System.Drawing.Size(86, 100);
            this.Drink_btn.TabIndex = 11;
            this.Drink_btn.Click += new System.EventHandler(this.Drink_btn_Click);
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.Gray;
            this.bunifuTileButton4.color = System.Drawing.Color.Gray;
            this.bunifuTileButton4.colorActive = System.Drawing.Color.Silver;
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Toilet";
            this.bunifuTileButton4.Location = new System.Drawing.Point(11, 68);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(86, 100);
            this.bunifuTileButton4.TabIndex = 10;
            // 
            // CheckPoint_2
            // 
            this.CheckPoint_2.AutoSize = true;
            this.CheckPoint_2.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CheckPoint_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CheckPoint_2.Location = new System.Drawing.Point(46, 26);
            this.CheckPoint_2.Name = "CheckPoint_2";
            this.CheckPoint_2.Size = new System.Drawing.Size(105, 15);
            this.CheckPoint_2.TabIndex = 10;
            this.CheckPoint_2.Text = "CheckPoint   2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(51, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 15);
            this.label15.TabIndex = 10;
            this.label15.Text = "CheckPoint   1";
            // 
            // Energy_btn
            // 
            this.Energy_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Energy_btn.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Energy_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Energy_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Energy_btn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Energy_btn.ForeColor = System.Drawing.Color.White;
            this.Energy_btn.Image = ((System.Drawing.Image)(resources.GetObject("Energy_btn.Image")));
            this.Energy_btn.ImagePosition = 17;
            this.Energy_btn.ImageZoom = 50;
            this.Energy_btn.LabelPosition = 34;
            this.Energy_btn.LabelText = "Energy Bar";
            this.Energy_btn.Location = new System.Drawing.Point(101, 179);
            this.Energy_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Energy_btn.Name = "Energy_btn";
            this.Energy_btn.Size = new System.Drawing.Size(91, 100);
            this.Energy_btn.TabIndex = 13;
            this.Energy_btn.Click += new System.EventHandler(this.Energy_btn_Click);
            // 
            // Medical_btn
            // 
            this.Medical_btn.BackColor = System.Drawing.Color.Red;
            this.Medical_btn.color = System.Drawing.Color.Red;
            this.Medical_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Medical_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Medical_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Medical_btn.ForeColor = System.Drawing.Color.White;
            this.Medical_btn.Image = ((System.Drawing.Image)(resources.GetObject("Medical_btn.Image")));
            this.Medical_btn.ImagePosition = 20;
            this.Medical_btn.ImageZoom = 50;
            this.Medical_btn.LabelPosition = 41;
            this.Medical_btn.LabelText = "Medical";
            this.Medical_btn.Location = new System.Drawing.Point(10, 179);
            this.Medical_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Medical_btn.Name = "Medical_btn";
            this.Medical_btn.Size = new System.Drawing.Size(86, 100);
            this.Medical_btn.TabIndex = 12;
            this.Medical_btn.Click += new System.EventHandler(this.Medical_btn_Click);
            // 
            // Drinl_btn
            // 
            this.Drinl_btn.BackColor = System.Drawing.Color.Aqua;
            this.Drinl_btn.color = System.Drawing.Color.Aqua;
            this.Drinl_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Drinl_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Drinl_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Drinl_btn.ForeColor = System.Drawing.Color.Black;
            this.Drinl_btn.Image = ((System.Drawing.Image)(resources.GetObject("Drinl_btn.Image")));
            this.Drinl_btn.ImagePosition = 20;
            this.Drinl_btn.ImageZoom = 50;
            this.Drinl_btn.LabelPosition = 41;
            this.Drinl_btn.LabelText = "Drink";
            this.Drinl_btn.Location = new System.Drawing.Point(106, 68);
            this.Drinl_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Drinl_btn.Name = "Drinl_btn";
            this.Drinl_btn.Size = new System.Drawing.Size(86, 100);
            this.Drinl_btn.TabIndex = 11;
            this.Drinl_btn.Click += new System.EventHandler(this.Drinl_btn_Click);
            // 
            // Toilet_btn
            // 
            this.Toilet_btn.BackColor = System.Drawing.Color.Gray;
            this.Toilet_btn.color = System.Drawing.Color.Gray;
            this.Toilet_btn.colorActive = System.Drawing.Color.Silver;
            this.Toilet_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Toilet_btn.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.Toilet_btn.ForeColor = System.Drawing.Color.White;
            this.Toilet_btn.Image = ((System.Drawing.Image)(resources.GetObject("Toilet_btn.Image")));
            this.Toilet_btn.ImagePosition = 20;
            this.Toilet_btn.ImageZoom = 50;
            this.Toilet_btn.LabelPosition = 41;
            this.Toilet_btn.LabelText = "Toilet";
            this.Toilet_btn.Location = new System.Drawing.Point(11, 68);
            this.Toilet_btn.Margin = new System.Windows.Forms.Padding(6);
            this.Toilet_btn.Name = "Toilet_btn";
            this.Toilet_btn.Size = new System.Drawing.Size(86, 100);
            this.Toilet_btn.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(333, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 12);
            this.label14.TabIndex = 14;
            this.label14.Text = "Click CheckPoint";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(287, 292);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(32, 32);
            this.pictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox21.TabIndex = 13;
            this.pictureBox21.TabStop = false;
            this.pictureBox21.Click += new System.EventHandler(this.pictureBox21_Click);
            // 
            // CheckPoint2
            // 
            this.CheckPoint2.BackColor = System.Drawing.Color.Honeydew;
            this.CheckPoint2.Image = ((System.Drawing.Image)(resources.GetObject("CheckPoint2.Image")));
            this.CheckPoint2.ImageActive = null;
            this.CheckPoint2.Location = new System.Drawing.Point(229, 217);
            this.CheckPoint2.Name = "CheckPoint2";
            this.CheckPoint2.Size = new System.Drawing.Size(32, 32);
            this.CheckPoint2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CheckPoint2.TabIndex = 12;
            this.CheckPoint2.TabStop = false;
            this.CheckPoint2.Zoom = 40;
            this.CheckPoint2.Click += new System.EventHandler(this.CheckPoint2_Click);
            // 
            // CheckPoint1
            // 
            this.CheckPoint1.BackColor = System.Drawing.Color.Honeydew;
            this.CheckPoint1.Image = ((System.Drawing.Image)(resources.GetObject("CheckPoint1.Image")));
            this.CheckPoint1.ImageActive = null;
            this.CheckPoint1.Location = new System.Drawing.Point(301, 146);
            this.CheckPoint1.Name = "CheckPoint1";
            this.CheckPoint1.Size = new System.Drawing.Size(32, 32);
            this.CheckPoint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CheckPoint1.TabIndex = 11;
            this.CheckPoint1.TabStop = false;
            this.CheckPoint1.Zoom = 40;
            this.CheckPoint1.Click += new System.EventHandler(this.CheckPoint1_Click);
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(19, 42);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(447, 292);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 10;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox16_Click);
            // 
            // Retunn_btn
            // 
            this.Retunn_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.Retunn_btn.Image = ((System.Drawing.Image)(resources.GetObject("Retunn_btn.Image")));
            this.Retunn_btn.ImageActive = null;
            this.Retunn_btn.Location = new System.Drawing.Point(19, 19);
            this.Retunn_btn.Name = "Retunn_btn";
            this.Retunn_btn.Size = new System.Drawing.Size(34, 33);
            this.Retunn_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Retunn_btn.TabIndex = 16;
            this.Retunn_btn.TabStop = false;
            this.Retunn_btn.Zoom = 10;
            this.Retunn_btn.Click += new System.EventHandler(this.Retunn_btn_Click);
            // 
            // Map21UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Retunn_btn);
            this.Controls.Add(this.CheckPoint1_panel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox21);
            this.Controls.Add(this.CheckPoint2);
            this.Controls.Add(this.CheckPoint1);
            this.Controls.Add(this.pictureBox16);
            this.Name = "Map21UI";
            this.Size = new System.Drawing.Size(697, 377);
            this.CheckPoint1_panel.ResumeLayout(false);
            this.CheckPoint1_panel.PerformLayout();
            this.CheckPoint2_Panel.ResumeLayout(false);
            this.CheckPoint2_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPoint2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckPoint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retunn_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CheckPoint1_panel;
        private System.Windows.Forms.Panel CheckPoint2_Panel;
        private Bunifu.Framework.UI.BunifuTileButton Energy;
        private Bunifu.Framework.UI.BunifuTileButton Medic_btn;
        private Bunifu.Framework.UI.BunifuTileButton Drink_btn;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private System.Windows.Forms.Label CheckPoint_2;
        private System.Windows.Forms.Label label15;
        private Bunifu.Framework.UI.BunifuTileButton Energy_btn;
        private Bunifu.Framework.UI.BunifuTileButton Medical_btn;
        private Bunifu.Framework.UI.BunifuTileButton Drinl_btn;
        private Bunifu.Framework.UI.BunifuTileButton Toilet_btn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox21;
        private Bunifu.Framework.UI.BunifuImageButton CheckPoint2;
        private Bunifu.Framework.UI.BunifuImageButton CheckPoint1;
        private System.Windows.Forms.PictureBox pictureBox16;
        private Bunifu.Framework.UI.BunifuImageButton Retunn_btn;
    }
}
