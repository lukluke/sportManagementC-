namespace WindowsFormsApplication1
{
    partial class Login1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Login_btn1 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.Register_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Forget_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lin = new Bunifu.Framework.UI.BunifuSeparator();
            this.EmailLogin_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Pwd_login_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Retunn_btn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retunn_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(151, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login_btn1
            // 
            this.Login_btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Login_btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_btn1.BackgroundImage")));
            this.Login_btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_btn1.ButtonText = "Login";
            this.Login_btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Login_btn1.ForeColorHoverState = System.Drawing.SystemColors.Menu;
            this.Login_btn1.Iconimage = null;
            this.Login_btn1.IconVisible = true;
            this.Login_btn1.IconZoom = 90D;
            this.Login_btn1.ImageIconOverlay = false;
            this.Login_btn1.Location = new System.Drawing.Point(93, 265);
            this.Login_btn1.Name = "Login_btn1";
            this.Login_btn1.Size = new System.Drawing.Size(170, 42);
            this.Login_btn1.TabIndex = 9;
            this.Login_btn1.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Register_btn.BackColor = System.Drawing.Color.Transparent;
            this.Register_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Register_btn.BorderRadius = 0;
            this.Register_btn.ButtonText = "              Register ";
            this.Register_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Register_btn.Iconimage = null;
            this.Register_btn.Iconimage_right = null;
            this.Register_btn.Iconimage_right_Selected = null;
            this.Register_btn.Iconimage_Selected = null;
            this.Register_btn.IconZoom = 90D;
            this.Register_btn.IsTab = false;
            this.Register_btn.Location = new System.Drawing.Point(183, 322);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Register_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Register_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.Register_btn.selected = false;
            this.Register_btn.Size = new System.Drawing.Size(175, 44);
            this.Register_btn.TabIndex = 10;
            this.Register_btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Register_btn.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Forget_btn
            // 
            this.Forget_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Forget_btn.BackColor = System.Drawing.Color.Transparent;
            this.Forget_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forget_btn.BorderRadius = 0;
            this.Forget_btn.ButtonText = " Forget Password ";
            this.Forget_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Forget_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Forget_btn.Iconimage = null;
            this.Forget_btn.Iconimage_right = null;
            this.Forget_btn.Iconimage_right_Selected = null;
            this.Forget_btn.Iconimage_Selected = null;
            this.Forget_btn.IconZoom = 90D;
            this.Forget_btn.IsTab = false;
            this.Forget_btn.Location = new System.Drawing.Point(14, 322);
            this.Forget_btn.Name = "Forget_btn";
            this.Forget_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Forget_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Forget_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.Forget_btn.selected = false;
            this.Forget_btn.Size = new System.Drawing.Size(175, 44);
            this.Forget_btn.TabIndex = 11;
            this.Forget_btn.Textcolor = System.Drawing.Color.Red;
            this.Forget_btn.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forget_btn.Click += new System.EventHandler(this.Forget_btn_Click);
            // 
            // lin
            // 
            this.lin.BackColor = System.Drawing.Color.Transparent;
            this.lin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lin.LineThickness = 1;
            this.lin.Location = new System.Drawing.Point(14, 302);
            this.lin.Name = "lin";
            this.lin.Size = new System.Drawing.Size(344, 32);
            this.lin.TabIndex = 12;
            this.lin.Transparency = 255;
            this.lin.Vertical = false;
            // 
            // EmailLogin_txt
            // 
            this.EmailLogin_txt.Depth = 0;
            this.EmailLogin_txt.Hint = "UserID/Email";
            this.EmailLogin_txt.Location = new System.Drawing.Point(80, 163);
            this.EmailLogin_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailLogin_txt.Name = "EmailLogin_txt";
            this.EmailLogin_txt.PasswordChar = '\0';
            this.EmailLogin_txt.SelectedText = "";
            this.EmailLogin_txt.SelectionLength = 0;
            this.EmailLogin_txt.SelectionStart = 0;
            this.EmailLogin_txt.Size = new System.Drawing.Size(214, 23);
            this.EmailLogin_txt.TabIndex = 13;
            this.EmailLogin_txt.UseSystemPasswordChar = false;
            // 
            // Pwd_login_txt
            // 
            this.Pwd_login_txt.Depth = 0;
            this.Pwd_login_txt.Hint = "Password";
            this.Pwd_login_txt.Location = new System.Drawing.Point(80, 204);
            this.Pwd_login_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pwd_login_txt.Name = "Pwd_login_txt";
            this.Pwd_login_txt.PasswordChar = '*';
            this.Pwd_login_txt.SelectedText = "";
            this.Pwd_login_txt.SelectionLength = 0;
            this.Pwd_login_txt.SelectionStart = 0;
            this.Pwd_login_txt.Size = new System.Drawing.Size(214, 23);
            this.Pwd_login_txt.TabIndex = 14;
            this.Pwd_login_txt.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 162);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // Retunn_btn
            // 
            this.Retunn_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.Retunn_btn.Image = ((System.Drawing.Image)(resources.GetObject("Retunn_btn.Image")));
            this.Retunn_btn.ImageActive = null;
            this.Retunn_btn.Location = new System.Drawing.Point(23, 28);
            this.Retunn_btn.Name = "Retunn_btn";
            this.Retunn_btn.Size = new System.Drawing.Size(34, 33);
            this.Retunn_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Retunn_btn.TabIndex = 37;
            this.Retunn_btn.TabStop = false;
            this.Retunn_btn.Zoom = 10;
            this.Retunn_btn.Click += new System.EventHandler(this.Retunn_btn_Click);
            // 
            // Login1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 382);
            this.Controls.Add(this.Retunn_btn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Pwd_login_txt);
            this.Controls.Add(this.EmailLogin_txt);
            this.Controls.Add(this.Forget_btn);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Login_btn1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lin);
            this.Name = "Login1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Retunn_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private WindowsFormsControlLibrary1.BunifuThinButton Login_btn1;
        private Bunifu.Framework.UI.BunifuFlatButton Register_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Forget_btn;
        private Bunifu.Framework.UI.BunifuSeparator lin;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmailLogin_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Pwd_login_txt;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuImageButton Retunn_btn;
    }
}