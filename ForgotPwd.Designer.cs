namespace WindowsFormsApplication1
{
    partial class ForgotPwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPwd));
            this.Confirm_btn = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.Email_Txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FirstName_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LastName_txt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Confirm_btn
            // 
            this.Confirm_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Confirm_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Confirm_btn.BackgroundImage")));
            this.Confirm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirm_btn.ButtonText = "Get new password";
            this.Confirm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_btn.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Confirm_btn.ForeColorHoverState = System.Drawing.SystemColors.Menu;
            this.Confirm_btn.Iconimage = null;
            this.Confirm_btn.IconVisible = true;
            this.Confirm_btn.IconZoom = 90D;
            this.Confirm_btn.ImageIconOverlay = false;
            this.Confirm_btn.Location = new System.Drawing.Point(269, 189);
            this.Confirm_btn.Name = "Confirm_btn";
            this.Confirm_btn.Size = new System.Drawing.Size(156, 42);
            this.Confirm_btn.TabIndex = 13;
            this.Confirm_btn.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // Email_Txt
            // 
            this.Email_Txt.Depth = 0;
            this.Email_Txt.Hint = "Email";
            this.Email_Txt.Location = new System.Drawing.Point(127, 132);
            this.Email_Txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Email_Txt.Name = "Email_Txt";
            this.Email_Txt.PasswordChar = '\0';
            this.Email_Txt.SelectedText = "";
            this.Email_Txt.SelectionLength = 0;
            this.Email_Txt.SelectionStart = 0;
            this.Email_Txt.Size = new System.Drawing.Size(265, 23);
            this.Email_Txt.TabIndex = 12;
            this.Email_Txt.UseSystemPasswordChar = false;
            this.Email_Txt.Click += new System.EventHandler(this.ID_Txt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Depth = 0;
            this.FirstName_txt.Hint = "FirstName";
            this.FirstName_txt.Location = new System.Drawing.Point(127, 81);
            this.FirstName_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.PasswordChar = '\0';
            this.FirstName_txt.SelectedText = "";
            this.FirstName_txt.SelectionLength = 0;
            this.FirstName_txt.SelectionStart = 0;
            this.FirstName_txt.Size = new System.Drawing.Size(120, 23);
            this.FirstName_txt.TabIndex = 19;
            this.FirstName_txt.UseSystemPasswordChar = false;
            // 
            // LastName_txt
            // 
            this.LastName_txt.Depth = 0;
            this.LastName_txt.Hint = "LastName";
            this.LastName_txt.Location = new System.Drawing.Point(278, 81);
            this.LastName_txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.PasswordChar = '\0';
            this.LastName_txt.SelectedText = "";
            this.LastName_txt.SelectionLength = 0;
            this.LastName_txt.SelectionStart = 0;
            this.LastName_txt.Size = new System.Drawing.Size(124, 23);
            this.LastName_txt.TabIndex = 20;
            this.LastName_txt.UseSystemPasswordChar = false;
            // 
            // ForgotPwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 292);
            this.Controls.Add(this.LastName_txt);
            this.Controls.Add(this.FirstName_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Confirm_btn);
            this.Controls.Add(this.Email_Txt);
            this.Name = "ForgotPwd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ForgotPwd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WindowsFormsControlLibrary1.BunifuThinButton Confirm_btn;
        private MaterialSkin.Controls.MaterialSingleLineTextField Email_Txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField FirstName_txt;
        private MaterialSkin.Controls.MaterialSingleLineTextField LastName_txt;
    }
}