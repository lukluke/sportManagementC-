namespace WindowsFormsApplication1
{
    partial class Conordinator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conordinator));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.Logout_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.time_btn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.User_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Manage_txt_label = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sponsor_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BMI_btu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo = new CCWin.SkinControl.SkinPictureBox();
            this.menue = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Rtime = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.sidemenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menue)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.time_btn);
            this.panel2.Controls.Add(this.Close);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 35);
            this.panel2.TabIndex = 3;
            // 
            // Logout_btn
            // 
            this.Logout_btn.Activecolor = System.Drawing.Color.Silver;
            this.Logout_btn.BackColor = System.Drawing.Color.Transparent;
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_btn.BorderRadius = 0;
            this.Logout_btn.ButtonText = "Logout";
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logout_btn.ForeColor = System.Drawing.Color.Red;
            this.Logout_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Logout_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Logout_btn.Iconimage")));
            this.Logout_btn.Iconimage_right = null;
            this.Logout_btn.Iconimage_right_Selected = null;
            this.Logout_btn.Iconimage_Selected = null;
            this.Logout_btn.IconZoom = 50D;
            this.Logout_btn.IsTab = false;
            this.Logout_btn.Location = new System.Drawing.Point(697, 3);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Logout_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Logout_btn.OnHoverTextColor = System.Drawing.Color.Black;
            this.Logout_btn.selected = false;
            this.Logout_btn.Size = new System.Drawing.Size(126, 32);
            this.Logout_btn.TabIndex = 11;
            this.Logout_btn.Textcolor = System.Drawing.Color.Black;
            this.Logout_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // time_btn
            // 
            this.time_btn.AutoSize = true;
            this.time_btn.Location = new System.Drawing.Point(585, 12);
            this.time_btn.Name = "time_btn";
            this.time_btn.Size = new System.Drawing.Size(25, 12);
            this.time_btn.TabIndex = 1;
            this.time_btn.Text = "time";
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageActive = null;
            this.Close.Location = new System.Drawing.Point(842, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(16, 16);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Zoom = 20;
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.sidemenu.Controls.Add(this.User_btn);
            this.sidemenu.Controls.Add(this.Manage_txt_label);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.sponsor_btn);
            this.sidemenu.Controls.Add(this.BMI_btu);
            this.sidemenu.Controls.Add(this.home);
            this.sidemenu.Controls.Add(this.panel3);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 35);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(200, 434);
            this.sidemenu.TabIndex = 6;
            // 
            // User_btn
            // 
            this.User_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.User_btn.BackColor = System.Drawing.Color.Transparent;
            this.User_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.User_btn.BorderRadius = 0;
            this.User_btn.ButtonText = "  User";
            this.User_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.User_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.User_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("User_btn.Iconimage")));
            this.User_btn.Iconimage_right = null;
            this.User_btn.Iconimage_right_Selected = null;
            this.User_btn.Iconimage_Selected = null;
            this.User_btn.IconZoom = 40D;
            this.User_btn.IsTab = false;
            this.User_btn.Location = new System.Drawing.Point(-3, 279);
            this.User_btn.Name = "User_btn";
            this.User_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.User_btn.OnHovercolor = System.Drawing.Color.DarkRed;
            this.User_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.User_btn.selected = false;
            this.User_btn.Size = new System.Drawing.Size(200, 44);
            this.User_btn.TabIndex = 24;
            this.User_btn.Textcolor = System.Drawing.Color.White;
            this.User_btn.TextFont = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Manage_txt_label
            // 
            this.Manage_txt_label.AutoSize = true;
            this.Manage_txt_label.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manage_txt_label.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Manage_txt_label.Location = new System.Drawing.Point(3, 261);
            this.Manage_txt_label.Name = "Manage_txt_label";
            this.Manage_txt_label.Size = new System.Drawing.Size(93, 15);
            this.Manage_txt_label.TabIndex = 23;
            this.Manage_txt_label.Text = "Management";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "  About Marathon";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 103);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 44);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // sponsor_btn
            // 
            this.sponsor_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.sponsor_btn.BackColor = System.Drawing.Color.Transparent;
            this.sponsor_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sponsor_btn.BorderRadius = 0;
            this.sponsor_btn.ButtonText = "  Sponsor";
            this.sponsor_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sponsor_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.sponsor_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("sponsor_btn.Iconimage")));
            this.sponsor_btn.Iconimage_right = null;
            this.sponsor_btn.Iconimage_right_Selected = null;
            this.sponsor_btn.Iconimage_Selected = null;
            this.sponsor_btn.IconZoom = 40D;
            this.sponsor_btn.IsTab = false;
            this.sponsor_btn.Location = new System.Drawing.Point(0, 153);
            this.sponsor_btn.Name = "sponsor_btn";
            this.sponsor_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.sponsor_btn.OnHovercolor = System.Drawing.Color.DarkRed;
            this.sponsor_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.sponsor_btn.selected = false;
            this.sponsor_btn.Size = new System.Drawing.Size(200, 44);
            this.sponsor_btn.TabIndex = 3;
            this.sponsor_btn.Textcolor = System.Drawing.Color.White;
            this.sponsor_btn.TextFont = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BMI_btu
            // 
            this.BMI_btu.Activecolor = System.Drawing.Color.DarkRed;
            this.BMI_btu.BackColor = System.Drawing.Color.Transparent;
            this.BMI_btu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMI_btu.BorderRadius = 0;
            this.BMI_btu.ButtonText = "  BMI &&& BMR";
            this.BMI_btu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BMI_btu.Iconcolor = System.Drawing.Color.Transparent;
            this.BMI_btu.Iconimage = ((System.Drawing.Image)(resources.GetObject("BMI_btu.Iconimage")));
            this.BMI_btu.Iconimage_right = null;
            this.BMI_btu.Iconimage_right_Selected = null;
            this.BMI_btu.Iconimage_Selected = null;
            this.BMI_btu.IconZoom = 40D;
            this.BMI_btu.IsTab = false;
            this.BMI_btu.Location = new System.Drawing.Point(0, 214);
            this.BMI_btu.Name = "BMI_btu";
            this.BMI_btu.Normalcolor = System.Drawing.Color.Transparent;
            this.BMI_btu.OnHovercolor = System.Drawing.Color.DarkRed;
            this.BMI_btu.OnHoverTextColor = System.Drawing.Color.White;
            this.BMI_btu.selected = false;
            this.BMI_btu.Size = new System.Drawing.Size(200, 44);
            this.BMI_btu.TabIndex = 2;
            this.BMI_btu.Textcolor = System.Drawing.Color.White;
            this.BMI_btu.TextFont = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // home
            // 
            this.home.Activecolor = System.Drawing.Color.DarkRed;
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.home.BorderRadius = 0;
            this.home.ButtonText = "  Home";
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Iconcolor = System.Drawing.Color.Transparent;
            this.home.Iconimage = ((System.Drawing.Image)(resources.GetObject("home.Iconimage")));
            this.home.Iconimage_right = null;
            this.home.Iconimage_right_Selected = null;
            this.home.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("home.Iconimage_Selected")));
            this.home.IconZoom = 40D;
            this.home.IsTab = false;
            this.home.Location = new System.Drawing.Point(0, 61);
            this.home.Name = "home";
            this.home.Normalcolor = System.Drawing.Color.Transparent;
            this.home.OnHovercolor = System.Drawing.Color.DarkRed;
            this.home.OnHoverTextColor = System.Drawing.Color.White;
            this.home.selected = false;
            this.home.Size = new System.Drawing.Size(200, 36);
            this.home.TabIndex = 1;
            this.home.Textcolor = System.Drawing.Color.White;
            this.home.TextFont = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.logo);
            this.panel3.Controls.Add(this.menue);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 61);
            this.panel3.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(70, 5);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(100, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // menue
            // 
            this.menue.BackColor = System.Drawing.Color.Transparent;
            this.menue.Image = ((System.Drawing.Image)(resources.GetObject("menue.Image")));
            this.menue.ImageActive = null;
            this.menue.Location = new System.Drawing.Point(12, 22);
            this.menue.Name = "menue";
            this.menue.Size = new System.Drawing.Size(26, 23);
            this.menue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menue.TabIndex = 0;
            this.menue.TabStop = false;
            this.menue.Zoom = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.Rtime);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(200, 440);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 29);
            this.panel4.TabIndex = 23;
            // 
            // Rtime
            // 
            this.Rtime.AutoSize = true;
            this.Rtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Rtime.Location = new System.Drawing.Point(287, 8);
            this.Rtime.Name = "Rtime";
            this.Rtime.Size = new System.Drawing.Size(48, 12);
            this.Rtime.TabIndex = 1;
            this.Rtime.Text = "LastTime";
            // 
            // Main
            // 
            this.Main.Location = new System.Drawing.Point(200, 35);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(681, 410);
            this.Main.TabIndex = 24;
            // 
            // Conordinator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 469);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Conordinator";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Logout_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel time_btn;
        private Bunifu.Framework.UI.BunifuImageButton Close;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuFlatButton User_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel Manage_txt_label;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton sponsor_btn;
        private Bunifu.Framework.UI.BunifuFlatButton BMI_btu;
        private Bunifu.Framework.UI.BunifuFlatButton home;
        private System.Windows.Forms.Panel panel3;
        private CCWin.SkinControl.SkinPictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton menue;
        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Rtime;
    }
}