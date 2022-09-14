namespace WindowsFormsApplication1
{
    partial class LoginUI1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUI1));
            this.Pwd_login_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EmailLogin_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Forget_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Register_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Login_btn2 = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.lin = new Bunifu.Framework.UI.BunifuSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            this.SuspendLayout();
            // 
            // Pwd_login_txt
            // 
            this.Pwd_login_txt.Depth = 0;
            this.Pwd_login_txt.Hint = "Password";
            this.Pwd_login_txt.Location = new System.Drawing.Point(231, 186);
            this.Pwd_login_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pwd_login_txt.Name = "Pwd_login_txt";
            this.Pwd_login_txt.PasswordChar = '*';
            this.Pwd_login_txt.SelectedText = "";
            this.Pwd_login_txt.SelectionLength = 0;
            this.Pwd_login_txt.SelectionStart = 0;
            this.Pwd_login_txt.Size = new System.Drawing.Size(276, 23);
            this.Pwd_login_txt.TabIndex = 30;
            this.Pwd_login_txt.UseSystemPasswordChar = false;
            // 
            // EmailLogin_txt
            // 
            this.EmailLogin_txt.Depth = 0;
            this.EmailLogin_txt.Hint = "UserID/Email";
            this.EmailLogin_txt.Location = new System.Drawing.Point(229, 132);
            this.EmailLogin_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailLogin_txt.Name = "EmailLogin_txt";
            this.EmailLogin_txt.PasswordChar = '\0';
            this.EmailLogin_txt.SelectedText = "";
            this.EmailLogin_txt.SelectionLength = 0;
            this.EmailLogin_txt.SelectionStart = 0;
            this.EmailLogin_txt.Size = new System.Drawing.Size(278, 23);
            this.EmailLogin_txt.TabIndex = 29;
            this.EmailLogin_txt.UseSystemPasswordChar = false;
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
            this.Forget_btn.Location = new System.Drawing.Point(110, 310);
            this.Forget_btn.Name = "Forget_btn";
            this.Forget_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Forget_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Forget_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.Forget_btn.selected = false;
            this.Forget_btn.Size = new System.Drawing.Size(175, 44);
            this.Forget_btn.TabIndex = 27;
            this.Forget_btn.Textcolor = System.Drawing.Color.Red;
            this.Forget_btn.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forget_btn.Click += new System.EventHandler(this.Forget_btn_Click);
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
            this.Register_btn.Location = new System.Drawing.Point(435, 312);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Register_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Register_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.Register_btn.selected = false;
            this.Register_btn.Size = new System.Drawing.Size(175, 44);
            this.Register_btn.TabIndex = 26;
            this.Register_btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Register_btn.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Login_btn2
            // 
            this.Login_btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Login_btn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login_btn2.BackgroundImage")));
            this.Login_btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login_btn2.ButtonText = "Login";
            this.Login_btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_btn2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Login_btn2.ForeColorHoverState = System.Drawing.SystemColors.Menu;
            this.Login_btn2.Iconimage = null;
            this.Login_btn2.IconVisible = true;
            this.Login_btn2.IconZoom = 90D;
            this.Login_btn2.ImageIconOverlay = false;
            this.Login_btn2.Location = new System.Drawing.Point(268, 231);
            this.Login_btn2.Name = "Login_btn2";
            this.Login_btn2.Size = new System.Drawing.Size(170, 42);
            this.Login_btn2.TabIndex = 25;
            this.Login_btn2.Click += new System.EventHandler(this.Login_btn2_Click);
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(327, 16);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(64, 64);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox36.TabIndex = 24;
            this.pictureBox36.TabStop = false;
            // 
            // lin
            // 
            this.lin.BackColor = System.Drawing.Color.Transparent;
            this.lin.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lin.LineThickness = 1;
            this.lin.Location = new System.Drawing.Point(7, 284);
            this.lin.Name = "lin";
            this.lin.Size = new System.Drawing.Size(682, 32);
            this.lin.TabIndex = 28;
            this.lin.Transparency = 255;
            this.lin.Vertical = false;
            // 
            // LoginUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Pwd_login_txt);
            this.Controls.Add(this.EmailLogin_txt);
            this.Controls.Add(this.Forget_btn);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Login_btn2);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.lin);
            this.Name = "LoginUI1";
            this.Size = new System.Drawing.Size(697, 373);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Pwd_login_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmailLogin_txt;
        private Bunifu.Framework.UI.BunifuFlatButton Forget_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Register_btn;
        private WindowsFormsControlLibrary1.BunifuThinButton Login_btn2;
        private System.Windows.Forms.PictureBox pictureBox36;
        private Bunifu.Framework.UI.BunifuSeparator lin;
    }
}
