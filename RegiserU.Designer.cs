namespace WindowsFormsApplication1
{
    partial class RegiserU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegiserU));
            this.ShowPwd_CkB = new MaterialSkin.Controls.MaterialCheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HKID_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Birth = new Bunifu.Framework.UI.BunifuCalendar();
            this.Create_btn = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.Selet_btn = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.materialRadioButton2 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialRadioButton1 = new MaterialSkin.Controls.MaterialRadioButton();
            this.RePwd_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Pwd_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Email_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LName_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FName_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ContryType_com = new CCWin.SkinControl.SkinComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Camera_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowPwd_CkB
            // 
            this.ShowPwd_CkB.AutoSize = true;
            this.ShowPwd_CkB.Depth = 0;
            this.ShowPwd_CkB.Font = new System.Drawing.Font("Roboto", 10F);
            this.ShowPwd_CkB.Location = new System.Drawing.Point(344, 151);
            this.ShowPwd_CkB.Margin = new System.Windows.Forms.Padding(0);
            this.ShowPwd_CkB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ShowPwd_CkB.MouseState = MaterialSkin.MouseState.HOVER;
            this.ShowPwd_CkB.Name = "ShowPwd_CkB";
            this.ShowPwd_CkB.Ripple = true;
            this.ShowPwd_CkB.Size = new System.Drawing.Size(128, 30);
            this.ShowPwd_CkB.TabIndex = 74;
            this.ShowPwd_CkB.Text = "Show Password";
            this.ShowPwd_CkB.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(672, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 18);
            this.label9.TabIndex = 73;
            this.label9.Text = "Photo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(341, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 72;
            this.label7.Text = "LastName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "FirstName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(29, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 70;
            this.label4.Text = "Re-Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(54, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 69;
            this.label3.Text = "Password";
            // 
            // HKID_txt
            // 
            this.HKID_txt.Depth = 0;
            this.HKID_txt.Hint = "";
            this.HKID_txt.Location = new System.Drawing.Point(149, 231);
            this.HKID_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.HKID_txt.Name = "HKID_txt";
            this.HKID_txt.PasswordChar = '\0';
            this.HKID_txt.SelectedText = "";
            this.HKID_txt.SelectionLength = 0;
            this.HKID_txt.SelectionStart = 0;
            this.HKID_txt.Size = new System.Drawing.Size(160, 23);
            this.HKID_txt.TabIndex = 68;
            this.HKID_txt.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(82, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "HKID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(82, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 66;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(82, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 18);
            this.label6.TabIndex = 65;
            this.label6.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(47, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 64;
            this.label8.Text = "Date of Birth";
            // 
            // Birth
            // 
            this.Birth.BackColor = System.Drawing.Color.Transparent;
            this.Birth.BorderRadius = 0;
            this.Birth.ForeColor = System.Drawing.Color.Black;
            this.Birth.Location = new System.Drawing.Point(149, 304);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(191, 33);
            this.Birth.TabIndex = 63;
            this.Birth.Value = new System.DateTime(2017, 4, 26, 16, 58, 9, 628);
            // 
            // Create_btn
            // 
            this.Create_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Create_btn.BackgroundImage")));
            this.Create_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Create_btn.ButtonText = "Create Account";
            this.Create_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Create_btn.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Create_btn.ForeColorHoverState = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Create_btn.Iconimage = null;
            this.Create_btn.IconVisible = true;
            this.Create_btn.IconZoom = 90D;
            this.Create_btn.ImageIconOverlay = false;
            this.Create_btn.Location = new System.Drawing.Point(272, 360);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(184, 33);
            this.Create_btn.TabIndex = 62;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Selet_btn
            // 
            this.Selet_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Selet_btn.BackgroundImage")));
            this.Selet_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Selet_btn.ButtonText = "Select";
            this.Selet_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Selet_btn.ForeColor = System.Drawing.Color.Crimson;
            this.Selet_btn.ForeColorHoverState = System.Drawing.Color.White;
            this.Selet_btn.Iconimage = null;
            this.Selet_btn.IconVisible = true;
            this.Selet_btn.IconZoom = 90D;
            this.Selet_btn.ImageIconOverlay = false;
            this.Selet_btn.Location = new System.Drawing.Point(631, 208);
            this.Selet_btn.Name = "Selet_btn";
            this.Selet_btn.Size = new System.Drawing.Size(133, 28);
            this.Selet_btn.TabIndex = 61;
            this.Selet_btn.Click += new System.EventHandler(this.Selet_btn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Location = new System.Drawing.Point(631, 71);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(133, 131);
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // materialRadioButton2
            // 
            this.materialRadioButton2.AutoSize = true;
            this.materialRadioButton2.Depth = 0;
            this.materialRadioButton2.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton2.Location = new System.Drawing.Point(229, 271);
            this.materialRadioButton2.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton2.Name = "materialRadioButton2";
            this.materialRadioButton2.Ripple = true;
            this.materialRadioButton2.Size = new System.Drawing.Size(36, 30);
            this.materialRadioButton2.TabIndex = 59;
            this.materialRadioButton2.TabStop = true;
            this.materialRadioButton2.Text = "F";
            this.materialRadioButton2.UseVisualStyleBackColor = true;
            // 
            // materialRadioButton1
            // 
            this.materialRadioButton1.AutoSize = true;
            this.materialRadioButton1.Depth = 0;
            this.materialRadioButton1.Font = new System.Drawing.Font("Roboto", 10F);
            this.materialRadioButton1.Location = new System.Drawing.Point(160, 271);
            this.materialRadioButton1.Margin = new System.Windows.Forms.Padding(0);
            this.materialRadioButton1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRadioButton1.Name = "materialRadioButton1";
            this.materialRadioButton1.Ripple = true;
            this.materialRadioButton1.Size = new System.Drawing.Size(41, 30);
            this.materialRadioButton1.TabIndex = 58;
            this.materialRadioButton1.TabStop = true;
            this.materialRadioButton1.Text = "M";
            this.materialRadioButton1.UseVisualStyleBackColor = true;
            // 
            // RePwd_txt
            // 
            this.RePwd_txt.Depth = 0;
            this.RePwd_txt.Hint = "";
            this.RePwd_txt.Location = new System.Drawing.Point(149, 190);
            this.RePwd_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.RePwd_txt.Name = "RePwd_txt";
            this.RePwd_txt.PasswordChar = '*';
            this.RePwd_txt.SelectedText = "";
            this.RePwd_txt.SelectionLength = 0;
            this.RePwd_txt.SelectionStart = 0;
            this.RePwd_txt.Size = new System.Drawing.Size(160, 23);
            this.RePwd_txt.TabIndex = 57;
            this.RePwd_txt.UseSystemPasswordChar = false;
            // 
            // Pwd_txt
            // 
            this.Pwd_txt.Depth = 0;
            this.Pwd_txt.Hint = "";
            this.Pwd_txt.Location = new System.Drawing.Point(148, 156);
            this.Pwd_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Pwd_txt.Name = "Pwd_txt";
            this.Pwd_txt.PasswordChar = '\0';
            this.Pwd_txt.SelectedText = "";
            this.Pwd_txt.SelectionLength = 0;
            this.Pwd_txt.SelectionStart = 0;
            this.Pwd_txt.Size = new System.Drawing.Size(160, 23);
            this.Pwd_txt.TabIndex = 56;
            this.Pwd_txt.UseSystemPasswordChar = false;
            // 
            // Email_txt
            // 
            this.Email_txt.Depth = 0;
            this.Email_txt.Hint = "";
            this.Email_txt.Location = new System.Drawing.Point(149, 116);
            this.Email_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.PasswordChar = '\0';
            this.Email_txt.SelectedText = "";
            this.Email_txt.SelectionLength = 0;
            this.Email_txt.SelectionStart = 0;
            this.Email_txt.Size = new System.Drawing.Size(457, 23);
            this.Email_txt.TabIndex = 55;
            this.Email_txt.UseSystemPasswordChar = false;
            // 
            // LName_txt
            // 
            this.LName_txt.Depth = 0;
            this.LName_txt.Hint = "";
            this.LName_txt.Location = new System.Drawing.Point(428, 73);
            this.LName_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.LName_txt.Name = "LName_txt";
            this.LName_txt.PasswordChar = '\0';
            this.LName_txt.SelectedText = "";
            this.LName_txt.SelectionLength = 0;
            this.LName_txt.SelectionStart = 0;
            this.LName_txt.Size = new System.Drawing.Size(160, 23);
            this.LName_txt.TabIndex = 54;
            this.LName_txt.UseSystemPasswordChar = false;
            // 
            // FName_txt
            // 
            this.FName_txt.Depth = 0;
            this.FName_txt.Hint = "";
            this.FName_txt.Location = new System.Drawing.Point(149, 73);
            this.FName_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.FName_txt.Name = "FName_txt";
            this.FName_txt.PasswordChar = '\0';
            this.FName_txt.SelectedText = "";
            this.FName_txt.SelectionLength = 0;
            this.FName_txt.SelectionStart = 0;
            this.FName_txt.Size = new System.Drawing.Size(160, 23);
            this.FName_txt.TabIndex = 53;
            this.FName_txt.UseSystemPasswordChar = false;
            // 
            // ContryType_com
            // 
            this.ContryType_com.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContryType_com.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ContryType_com.FormattingEnabled = true;
            this.ContryType_com.ItemHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ContryType_com.Location = new System.Drawing.Point(413, 236);
            this.ContryType_com.Name = "ContryType_com";
            this.ContryType_com.Size = new System.Drawing.Size(121, 23);
            this.ContryType_com.TabIndex = 75;
            this.ContryType_com.WaterText = "";
            this.ContryType_com.SelectedIndexChanged += new System.EventHandler(this.ContryType_com_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(341, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 18);
            this.label10.TabIndex = 76;
            this.label10.Text = "Country";
            // 
            // Camera_btn
            // 
            this.Camera_btn.Activecolor = System.Drawing.Color.Transparent;
            this.Camera_btn.BackColor = System.Drawing.Color.Transparent;
            this.Camera_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Camera_btn.BorderRadius = 0;
            this.Camera_btn.ButtonText = "Take your Photo";
            this.Camera_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Camera_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Camera_btn.Iconimage = null;
            this.Camera_btn.Iconimage_right = null;
            this.Camera_btn.Iconimage_right_Selected = null;
            this.Camera_btn.Iconimage_Selected = null;
            this.Camera_btn.IconZoom = 90D;
            this.Camera_btn.IsTab = false;
            this.Camera_btn.Location = new System.Drawing.Point(631, 250);
            this.Camera_btn.Name = "Camera_btn";
            this.Camera_btn.Normalcolor = System.Drawing.Color.Transparent;
            this.Camera_btn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Camera_btn.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.Camera_btn.selected = false;
            this.Camera_btn.Size = new System.Drawing.Size(176, 44);
            this.Camera_btn.TabIndex = 77;
            this.Camera_btn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Camera_btn.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera_btn.Click += new System.EventHandler(this.Camera_btn_Click);
            // 
            // RegiserU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 442);
            this.Controls.Add(this.Camera_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ContryType_com);
            this.Controls.Add(this.ShowPwd_CkB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HKID_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Birth);
            this.Controls.Add(this.Create_btn);
            this.Controls.Add(this.Selet_btn);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.materialRadioButton2);
            this.Controls.Add(this.materialRadioButton1);
            this.Controls.Add(this.RePwd_txt);
            this.Controls.Add(this.Pwd_txt);
            this.Controls.Add(this.Email_txt);
            this.Controls.Add(this.LName_txt);
            this.Controls.Add(this.FName_txt);
            this.Name = "RegiserU";
            this.Text = "RegiserU";
            this.Load += new System.EventHandler(this.RegiserU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckBox ShowPwd_CkB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialSingleLineTextField HKID_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCalendar Birth;
        private WindowsFormsControlLibrary1.BunifuThinButton Create_btn;
        private WindowsFormsControlLibrary1.BunifuThinButton Selet_btn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton2;
        private MaterialSkin.Controls.MaterialRadioButton materialRadioButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField RePwd_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Pwd_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField Email_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField LName_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField FName_txt;
        private CCWin.SkinControl.SkinComboBox ContryType_com;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuFlatButton Camera_btn;
    }
}