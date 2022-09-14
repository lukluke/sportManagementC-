namespace WindowsFormsApplication1
{
    partial class Home
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.Login_btn = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.Information_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sponsor_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BMI_btu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo = new CCWin.SkinControl.SkinPictureBox();
            this.menue = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Rtime = new System.Windows.Forms.Label();
            this.PanelAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.chBMIR_UI1 = new WindowsFormsApplication1.ChBMIR_UI();
            this.sponsorContorUI1 = new WindowsFormsApplication1.SponsorContorUI();
            this.aboutINformation_UI1 = new WindowsFormsApplication1.AboutINformation_UI();
            this.homePage_ui1 = new WindowsFormsApplication1.HomePage_ui();
            this.LogoAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.sidemenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menue)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.skinPictureBox1);
            this.panel2.Controls.Add(this.Login_btn);
            this.panel2.Controls.Add(this.Close);
            this.LogoAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(897, 35);
            this.panel2.TabIndex = 2;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.skinPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.skinPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(631, 3);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.skinPictureBox1.TabIndex = 2;
            this.skinPictureBox1.TabStop = false;
            // 
            // Login_btn
            // 
            this.Login_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_btn.BackgroundImage")));
            this.Login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_btn.ButtonText = "Login Account";
            this.Login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoAnimator.SetDecoration(this.Login_btn, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Login_btn, BunifuAnimatorNS.DecorationType.None);
            this.Login_btn.ForeColor = System.Drawing.Color.Gray;
            this.Login_btn.ForeColorHoverState = System.Drawing.Color.Black;
            this.Login_btn.Iconimage = null;
            this.Login_btn.IconVisible = true;
            this.Login_btn.IconZoom = 90D;
            this.Login_btn.ImageIconOverlay = false;
            this.Login_btn.Location = new System.Drawing.Point(665, 2);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(134, 30);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.Close, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Close, BunifuAnimatorNS.DecorationType.None);
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.ImageActive = null;
            this.Close.Location = new System.Drawing.Point(862, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(16, 16);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Close.TabIndex = 0;
            this.Close.TabStop = false;
            this.Close.Zoom = 20;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.sidemenu.Controls.Add(this.Information_btn);
            this.sidemenu.Controls.Add(this.sponsor_btn);
            this.sidemenu.Controls.Add(this.BMI_btu);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.panel3);
            this.LogoAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 35);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(200, 404);
            this.sidemenu.TabIndex = 3;
            // 
            // Information_btn
            // 
            this.Information_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.Information_btn.BackColor = System.Drawing.Color.Transparent;
            this.Information_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Information_btn.BorderRadius = 0;
            this.Information_btn.ButtonText = "  About Marathon";
            this.Information_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.Information_btn, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Information_btn, BunifuAnimatorNS.DecorationType.None);
            this.Information_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Information_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Information_btn.Iconimage")));
            this.Information_btn.Iconimage_right = null;
            this.Information_btn.Iconimage_right_Selected = null;
            this.Information_btn.Iconimage_Selected = null;
            this.Information_btn.IconZoom = 40D;
            this.Information_btn.IsTab = false;
            this.Information_btn.Location = new System.Drawing.Point(0, 97);
            this.Information_btn.Name = "Information_btn";
            this.Information_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Information_btn.OnHovercolor = System.Drawing.Color.DarkRed;
            this.Information_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Information_btn.selected = false;
            this.Information_btn.Size = new System.Drawing.Size(200, 37);
            this.Information_btn.TabIndex = 4;
            this.Information_btn.Textcolor = System.Drawing.Color.White;
            this.Information_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information_btn.Click += new System.EventHandler(this.Information_btn_Click);
            // 
            // sponsor_btn
            // 
            this.sponsor_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.sponsor_btn.BackColor = System.Drawing.Color.Transparent;
            this.sponsor_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sponsor_btn.BorderRadius = 0;
            this.sponsor_btn.ButtonText = "  Sponsor";
            this.sponsor_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.sponsor_btn, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.sponsor_btn, BunifuAnimatorNS.DecorationType.None);
            this.sponsor_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.sponsor_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("sponsor_btn.Iconimage")));
            this.sponsor_btn.Iconimage_right = null;
            this.sponsor_btn.Iconimage_right_Selected = null;
            this.sponsor_btn.Iconimage_Selected = null;
            this.sponsor_btn.IconZoom = 40D;
            this.sponsor_btn.IsTab = false;
            this.sponsor_btn.Location = new System.Drawing.Point(0, 138);
            this.sponsor_btn.Name = "sponsor_btn";
            this.sponsor_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.sponsor_btn.OnHovercolor = System.Drawing.Color.DarkRed;
            this.sponsor_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.sponsor_btn.selected = false;
            this.sponsor_btn.Size = new System.Drawing.Size(200, 37);
            this.sponsor_btn.TabIndex = 3;
            this.sponsor_btn.Textcolor = System.Drawing.Color.White;
            this.sponsor_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sponsor_btn.Click += new System.EventHandler(this.sponsor_btn_Click);
            // 
            // BMI_btu
            // 
            this.BMI_btu.Activecolor = System.Drawing.Color.DarkRed;
            this.BMI_btu.BackColor = System.Drawing.Color.Transparent;
            this.BMI_btu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BMI_btu.BorderRadius = 0;
            this.BMI_btu.ButtonText = "  BMI &&& BMR";
            this.BMI_btu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.BMI_btu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.BMI_btu, BunifuAnimatorNS.DecorationType.None);
            this.BMI_btu.Iconcolor = System.Drawing.Color.Transparent;
            this.BMI_btu.Iconimage = ((System.Drawing.Image)(resources.GetObject("BMI_btu.Iconimage")));
            this.BMI_btu.Iconimage_right = null;
            this.BMI_btu.Iconimage_right_Selected = null;
            this.BMI_btu.Iconimage_Selected = null;
            this.BMI_btu.IconZoom = 40D;
            this.BMI_btu.IsTab = false;
            this.BMI_btu.Location = new System.Drawing.Point(0, 188);
            this.BMI_btu.Name = "BMI_btu";
            this.BMI_btu.Normalcolor = System.Drawing.Color.Transparent;
            this.BMI_btu.OnHovercolor = System.Drawing.Color.DarkRed;
            this.BMI_btu.OnHoverTextColor = System.Drawing.Color.White;
            this.BMI_btu.selected = false;
            this.BMI_btu.Size = new System.Drawing.Size(200, 37);
            this.BMI_btu.TabIndex = 2;
            this.BMI_btu.Textcolor = System.Drawing.Color.White;
            this.BMI_btu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI_btu.Click += new System.EventHandler(this.BMI_btu_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "  Home";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage_Selected")));
            this.bunifuFlatButton1.IconZoom = 40D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 54);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(200, 37);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.logo);
            this.panel3.Controls.Add(this.menue);
            this.LogoAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 55);
            this.panel3.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(69, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(112, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // menue
            // 
            this.menue.BackColor = System.Drawing.Color.Transparent;
            this.LogoAnimator.SetDecoration(this.menue, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.menue, BunifuAnimatorNS.DecorationType.None);
            this.menue.Image = ((System.Drawing.Image)(resources.GetObject("menue.Image")));
            this.menue.ImageActive = null;
            this.menue.Location = new System.Drawing.Point(12, 12);
            this.menue.Name = "menue";
            this.menue.Size = new System.Drawing.Size(26, 23);
            this.menue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menue.TabIndex = 0;
            this.menue.TabStop = false;
            this.menue.Zoom = 10;
            this.menue.Click += new System.EventHandler(this.menue_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.Rtime);
            this.LogoAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(200, 411);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(697, 28);
            this.panel4.TabIndex = 18;
            // 
            // Rtime
            // 
            this.Rtime.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.Rtime, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.Rtime, BunifuAnimatorNS.DecorationType.None);
            this.Rtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Rtime.Location = new System.Drawing.Point(195, 7);
            this.Rtime.Name = "Rtime";
            this.Rtime.Size = new System.Drawing.Size(48, 12);
            this.Rtime.TabIndex = 0;
            this.Rtime.Text = "LastTime";
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation6;
            // 
            // chBMIR_UI1
            // 
            this.chBMIR_UI1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.chBMIR_UI1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.chBMIR_UI1, BunifuAnimatorNS.DecorationType.None);
            this.chBMIR_UI1.Location = new System.Drawing.Point(200, 34);
            this.chBMIR_UI1.Name = "chBMIR_UI1";
            this.chBMIR_UI1.Size = new System.Drawing.Size(697, 376);
            this.chBMIR_UI1.TabIndex = 22;
            this.chBMIR_UI1.Visible = false;
            // 
            // sponsorContorUI1
            // 
            this.sponsorContorUI1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.sponsorContorUI1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.sponsorContorUI1, BunifuAnimatorNS.DecorationType.None);
            this.sponsorContorUI1.Location = new System.Drawing.Point(200, 35);
            this.sponsorContorUI1.Name = "sponsorContorUI1";
            this.sponsorContorUI1.Size = new System.Drawing.Size(697, 376);
            this.sponsorContorUI1.TabIndex = 21;
            this.sponsorContorUI1.Visible = false;
            // 
            // aboutINformation_UI1
            // 
            this.aboutINformation_UI1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.aboutINformation_UI1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.aboutINformation_UI1, BunifuAnimatorNS.DecorationType.None);
            this.aboutINformation_UI1.Location = new System.Drawing.Point(200, 34);
            this.aboutINformation_UI1.Name = "aboutINformation_UI1";
            this.aboutINformation_UI1.Size = new System.Drawing.Size(697, 377);
            this.aboutINformation_UI1.TabIndex = 20;
            this.aboutINformation_UI1.Visible = false;
            // 
            // homePage_ui1
            // 
            this.homePage_ui1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.homePage_ui1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.homePage_ui1, BunifuAnimatorNS.DecorationType.None);
            this.homePage_ui1.Location = new System.Drawing.Point(200, 34);
            this.homePage_ui1.Name = "homePage_ui1";
            this.homePage_ui1.Size = new System.Drawing.Size(697, 377);
            this.homePage_ui1.TabIndex = 19;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(30);
            animation5.RotateCoeff = 0.5F;
            animation5.RotateLimit = 0.2F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 439);
            this.Controls.Add(this.chBMIR_UI1);
            this.Controls.Add(this.sponsorContorUI1);
            this.Controls.Add(this.aboutINformation_UI1);
            this.Controls.Add(this.homePage_ui1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.sidemenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menue)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton Login_btn;
        private Bunifu.Framework.UI.BunifuImageButton Close;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuFlatButton Information_btn;
        private Bunifu.Framework.UI.BunifuFlatButton sponsor_btn;
        private Bunifu.Framework.UI.BunifuFlatButton BMI_btu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private CCWin.SkinControl.SkinPictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton menue;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Rtime;
        private BunifuAnimatorNS.Animator PanelAnimator;
        private BunifuAnimatorNS.Animator LogoAnimator;
        private HomePage_ui homePage_ui1;
        private AboutINformation_UI aboutINformation_UI1;
        private SponsorContorUI sponsorContorUI1;
        private ChBMIR_UI chBMIR_UI1;
        private System.Windows.Forms.Timer timer1;
    }
}