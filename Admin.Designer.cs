namespace WindowsFormsApplication1
{
    partial class Admin
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.PanelAnimator = new BunifuAnimatorNS.Animator(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.skinPictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            this.Logout_btn = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.Close = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Rtime = new System.Windows.Forms.Label();
            this.sidemenu = new System.Windows.Forms.Panel();
            this.Information_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.sponsor_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BMI_btu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logo = new CCWin.SkinControl.SkinPictureBox();
            this.menue = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Management_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.QR_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.management1 = new WindowsFormsApplication1.Management();
            this.chBMIR_UI1 = new WindowsFormsApplication1.ChBMIR_UI();
            this.sponsorContorUI1 = new WindowsFormsApplication1.SponsorContorUI();
            this.aboutINformation_UI1 = new WindowsFormsApplication1.AboutINformation_UI();
            this.homePage_ui1 = new WindowsFormsApplication1.HomePage_ui();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.panel4.SuspendLayout();
            this.sidemenu.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menue)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.PanelAnimator.DefaultAnimation = animation1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.skinPictureBox1);
            this.panel2.Controls.Add(this.Logout_btn);
            this.panel2.Controls.Add(this.Close);
            this.PanelAnimator.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 35);
            this.panel2.TabIndex = 3;
            // 
            // skinPictureBox1
            // 
            this.skinPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.skinPictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.skinPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("skinPictureBox1.Image")));
            this.skinPictureBox1.Location = new System.Drawing.Point(631, 3);
            this.skinPictureBox1.Name = "skinPictureBox1";
            this.skinPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.skinPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.skinPictureBox1.TabIndex = 2;
            this.skinPictureBox1.TabStop = false;
            // 
            // Logout_btn
            // 
            this.Logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logout_btn.BackgroundImage")));
            this.Logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logout_btn.ButtonText = "Logout";
            this.Logout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.Logout_btn, BunifuAnimatorNS.DecorationType.None);
            this.Logout_btn.ForeColor = System.Drawing.Color.Gray;
            this.Logout_btn.ForeColorHoverState = System.Drawing.Color.Black;
            this.Logout_btn.Iconimage = null;
            this.Logout_btn.IconVisible = true;
            this.Logout_btn.IconZoom = 90D;
            this.Logout_btn.ImageIconOverlay = false;
            this.Logout_btn.Location = new System.Drawing.Point(665, 2);
            this.Logout_btn.Name = "Logout_btn";
            this.Logout_btn.Size = new System.Drawing.Size(134, 30);
            this.Logout_btn.TabIndex = 3;
            this.Logout_btn.Click += new System.EventHandler(this.Account_btn_Click);
            this.Logout_btn.DoubleClick += new System.EventHandler(this.off);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Transparent;
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
            this.Close.Click += new System.EventHandler(this.Close_Click_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel4.Controls.Add(this.Rtime);
            this.PanelAnimator.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(200, 418);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(689, 26);
            this.panel4.TabIndex = 20;
            // 
            // Rtime
            // 
            this.Rtime.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.Rtime, BunifuAnimatorNS.DecorationType.None);
            this.Rtime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.Rtime.Location = new System.Drawing.Point(195, 7);
            this.Rtime.Name = "Rtime";
            this.Rtime.Size = new System.Drawing.Size(48, 12);
            this.Rtime.TabIndex = 0;
            this.Rtime.Text = "LastTime";
            // 
            // sidemenu
            // 
            this.sidemenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.sidemenu.Controls.Add(this.QR_btn);
            this.sidemenu.Controls.Add(this.label2);
            this.sidemenu.Controls.Add(this.Management_btn);
            this.sidemenu.Controls.Add(this.label1);
            this.sidemenu.Controls.Add(this.Information_btn);
            this.sidemenu.Controls.Add(this.sponsor_btn);
            this.sidemenu.Controls.Add(this.BMI_btu);
            this.sidemenu.Controls.Add(this.bunifuFlatButton1);
            this.sidemenu.Controls.Add(this.panel3);
            this.PanelAnimator.SetDecoration(this.sidemenu, BunifuAnimatorNS.DecorationType.None);
            this.sidemenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenu.Location = new System.Drawing.Point(0, 35);
            this.sidemenu.Name = "sidemenu";
            this.sidemenu.Size = new System.Drawing.Size(200, 409);
            this.sidemenu.TabIndex = 19;
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
            this.sponsor_btn.Click += new System.EventHandler(this.sponsor_btn_Click_1);
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
            this.BMI_btu.Click += new System.EventHandler(this.BMI_btu_Click_1);
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
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.logo);
            this.panel3.Controls.Add(this.menue);
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("DFKai-SB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Management";
            // 
            // Management_btn
            // 
            this.Management_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.Management_btn.BackColor = System.Drawing.Color.Transparent;
            this.Management_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Management_btn.BorderRadius = 0;
            this.Management_btn.ButtonText = "   Management";
            this.Management_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.Management_btn, BunifuAnimatorNS.DecorationType.None);
            this.Management_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Management_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Management_btn.Iconimage")));
            this.Management_btn.Iconimage_right = null;
            this.Management_btn.Iconimage_right_Selected = null;
            this.Management_btn.Iconimage_Selected = null;
            this.Management_btn.IconZoom = 40D;
            this.Management_btn.IsTab = false;
            this.Management_btn.Location = new System.Drawing.Point(0, 244);
            this.Management_btn.Name = "Management_btn";
            this.Management_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Management_btn.OnHovercolor = System.Drawing.Color.DarkRed;
            this.Management_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Management_btn.selected = false;
            this.Management_btn.Size = new System.Drawing.Size(200, 37);
            this.Management_btn.TabIndex = 6;
            this.Management_btn.Textcolor = System.Drawing.Color.White;
            this.Management_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Management_btn.Click += new System.EventHandler(this.Management_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.PanelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("DFKai-SB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "QRCode";
            // 
            // QR_btn
            // 
            this.QR_btn.Activecolor = System.Drawing.Color.DarkRed;
            this.QR_btn.BackColor = System.Drawing.Color.Transparent;
            this.QR_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QR_btn.BorderRadius = 0;
            this.QR_btn.ButtonText = "   QR&&BarCode";
            this.QR_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.QR_btn, BunifuAnimatorNS.DecorationType.None);
            this.QR_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.QR_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("QR_btn.Iconimage")));
            this.QR_btn.Iconimage_right = null;
            this.QR_btn.Iconimage_right_Selected = null;
            this.QR_btn.Iconimage_Selected = null;
            this.QR_btn.IconZoom = 40D;
            this.QR_btn.IsTab = false;
            this.QR_btn.Location = new System.Drawing.Point(0, 300);
            this.QR_btn.Name = "QR_btn";
            this.QR_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.QR_btn.OnHovercolor = System.Drawing.Color.DarkRed;
            this.QR_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.QR_btn.selected = false;
            this.QR_btn.Size = new System.Drawing.Size(200, 37);
            this.QR_btn.TabIndex = 8;
            this.QR_btn.Textcolor = System.Drawing.Color.White;
            this.QR_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QR_btn.Click += new System.EventHandler(this.QR_btn_Click);
            // 
            // management1
            // 
            this.management1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.management1, BunifuAnimatorNS.DecorationType.None);
            this.management1.Location = new System.Drawing.Point(198, 33);
            this.management1.Name = "management1";
            this.management1.Size = new System.Drawing.Size(689, 386);
            this.management1.TabIndex = 25;
            this.management1.Visible = false;
            // 
            // chBMIR_UI1
            // 
            this.chBMIR_UI1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.chBMIR_UI1, BunifuAnimatorNS.DecorationType.None);
            this.chBMIR_UI1.Location = new System.Drawing.Point(200, 34);
            this.chBMIR_UI1.Name = "chBMIR_UI1";
            this.chBMIR_UI1.Size = new System.Drawing.Size(689, 386);
            this.chBMIR_UI1.TabIndex = 24;
            this.chBMIR_UI1.Visible = false;
            // 
            // sponsorContorUI1
            // 
            this.sponsorContorUI1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.sponsorContorUI1, BunifuAnimatorNS.DecorationType.None);
            this.sponsorContorUI1.Location = new System.Drawing.Point(201, 34);
            this.sponsorContorUI1.Name = "sponsorContorUI1";
            this.sponsorContorUI1.Size = new System.Drawing.Size(686, 385);
            this.sponsorContorUI1.TabIndex = 23;
            this.sponsorContorUI1.Visible = false;
            // 
            // aboutINformation_UI1
            // 
            this.aboutINformation_UI1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.aboutINformation_UI1, BunifuAnimatorNS.DecorationType.None);
            this.aboutINformation_UI1.Location = new System.Drawing.Point(200, 35);
            this.aboutINformation_UI1.Name = "aboutINformation_UI1";
            this.aboutINformation_UI1.Size = new System.Drawing.Size(689, 385);
            this.aboutINformation_UI1.TabIndex = 22;
            this.aboutINformation_UI1.Visible = false;
            // 
            // homePage_ui1
            // 
            this.homePage_ui1.BackColor = System.Drawing.Color.White;
            this.PanelAnimator.SetDecoration(this.homePage_ui1, BunifuAnimatorNS.DecorationType.None);
            this.homePage_ui1.Location = new System.Drawing.Point(200, 35);
            this.homePage_ui1.Name = "homePage_ui1";
            this.homePage_ui1.Size = new System.Drawing.Size(687, 377);
            this.homePage_ui1.TabIndex = 21;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(889, 444);
            this.Controls.Add(this.management1);
            this.Controls.Add(this.chBMIR_UI1);
            this.Controls.Add(this.sponsorContorUI1);
            this.Controls.Add(this.aboutINformation_UI1);
            this.Controls.Add(this.homePage_ui1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.sidemenu);
            this.Controls.Add(this.panel2);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.sidemenu.ResumeLayout(false);
            this.sidemenu.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BunifuAnimatorNS.Animator PanelAnimator;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinPictureBox skinPictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton Logout_btn;
        private Bunifu.Framework.UI.BunifuImageButton Close;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Rtime;
        private System.Windows.Forms.Panel sidemenu;
        private Bunifu.Framework.UI.BunifuFlatButton Information_btn;
        private Bunifu.Framework.UI.BunifuFlatButton sponsor_btn;
        private Bunifu.Framework.UI.BunifuFlatButton BMI_btu;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel3;
        private CCWin.SkinControl.SkinPictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton menue;
        private HomePage_ui homePage_ui1;
        private AboutINformation_UI aboutINformation_UI1;
        private SponsorContorUI sponsorContorUI1;
        private ChBMIR_UI chBMIR_UI1;
        private Bunifu.Framework.UI.BunifuFlatButton Management_btn;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton QR_btn;
        private System.Windows.Forms.Label label2;
        private Management management1;
    }
}