namespace WindowsFormsApplication1
{
    partial class sendEmail
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
            MetroSuite.MetroTextBox.MainColorScheme mainColorScheme1 = new MetroSuite.MetroTextBox.MainColorScheme();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendEmail));
            MetroSuite.MetroTextBox.MainColorScheme mainColorScheme2 = new MetroSuite.MetroTextBox.MainColorScheme();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.txtattachment = new MetroSuite.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnsend = new WindowsFormsControlLibrary1.BunifuThinButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsubject = new MetroSuite.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtreciever = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsender = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnattach = new Bunifu.Framework.UI.BunifuImageButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.btnattach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbody
            // 
            this.txtbody.Location = new System.Drawing.Point(137, 307);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(383, 104);
            this.txtbody.TabIndex = 73;
            // 
            // txtattachment
            // 
            mainColorScheme1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            mainColorScheme1.BorderColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme1.MainColor = System.Drawing.Color.White;
            this.txtattachment.ColorScheme = mainColorScheme1;
            this.txtattachment.Enabled = false;
            this.txtattachment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtattachment.Location = new System.Drawing.Point(147, 214);
            this.txtattachment.MaxLength = 1024;
            this.txtattachment.Multiline = false;
            this.txtattachment.Name = "txtattachment";
            this.txtattachment.ReadOnly = false;
            this.txtattachment.Size = new System.Drawing.Size(367, 23);
            this.txtattachment.Style = MetroSuite.Style.Light;
            this.txtattachment.TabIndex = 72;
            this.txtattachment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtattachment.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(49, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 71;
            this.label6.Text = "Attachment";
            // 
            // btnsend
            // 
            this.btnsend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsend.BackgroundImage")));
            this.btnsend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsend.ButtonText = "Send Email";
            this.btnsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsend.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnsend.ForeColorHoverState = System.Drawing.Color.White;
            this.btnsend.Iconimage = null;
            this.btnsend.IconVisible = true;
            this.btnsend.IconZoom = 90D;
            this.btnsend.ImageIconOverlay = false;
            this.btnsend.Location = new System.Drawing.Point(204, 427);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(236, 33);
            this.btnsend.TabIndex = 70;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(87, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "Body";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(71, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 68;
            this.label3.Text = "Subject";
            // 
            // txtsubject
            // 
            mainColorScheme2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(240)))));
            mainColorScheme2.BorderColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            mainColorScheme2.MainColor = System.Drawing.Color.White;
            this.txtsubject.ColorScheme = mainColorScheme2;
            this.txtsubject.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsubject.Location = new System.Drawing.Point(147, 261);
            this.txtsubject.MaxLength = 1024;
            this.txtsubject.Multiline = false;
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.ReadOnly = false;
            this.txtsubject.Size = new System.Drawing.Size(373, 23);
            this.txtsubject.Style = MetroSuite.Style.Light;
            this.txtsubject.TabIndex = 67;
            this.txtsubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsubject.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(49, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 66;
            this.label2.Text = "Recive Email";
            // 
            // txtreciever
            // 
            this.txtreciever.Depth = 0;
            this.txtreciever.Hint = "";
            this.txtreciever.Location = new System.Drawing.Point(154, 167);
            this.txtreciever.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtreciever.Name = "txtreciever";
            this.txtreciever.PasswordChar = '\0';
            this.txtreciever.SelectedText = "";
            this.txtreciever.SelectionLength = 0;
            this.txtreciever.SelectionStart = 0;
            this.txtreciever.Size = new System.Drawing.Size(360, 23);
            this.txtreciever.TabIndex = 65;
            this.txtreciever.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 64;
            this.label1.Text = "Your Password";
            // 
            // txtpass
            // 
            this.txtpass.Depth = 0;
            this.txtpass.Hint = "";
            this.txtpass.Location = new System.Drawing.Point(154, 122);
            this.txtpass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionLength = 0;
            this.txtpass.SelectionStart = 0;
            this.txtpass.Size = new System.Drawing.Size(360, 23);
            this.txtpass.TabIndex = 63;
            this.txtpass.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(61, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Your Email";
            // 
            // txtsender
            // 
            this.txtsender.Depth = 0;
            this.txtsender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtsender.Hint = "";
            this.txtsender.Location = new System.Drawing.Point(154, 76);
            this.txtsender.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsender.Name = "txtsender";
            this.txtsender.PasswordChar = '\0';
            this.txtsender.SelectedText = "";
            this.txtsender.SelectionLength = 0;
            this.txtsender.SelectionStart = 0;
            this.txtsender.Size = new System.Drawing.Size(360, 23);
            this.txtsender.TabIndex = 61;
            this.txtsender.UseSystemPasswordChar = false;
            // 
            // btnattach
            // 
            this.btnattach.BackColor = System.Drawing.Color.SeaGreen;
            this.btnattach.Image = ((System.Drawing.Image)(resources.GetObject("btnattach.Image")));
            this.btnattach.ImageActive = null;
            this.btnattach.Location = new System.Drawing.Point(534, 206);
            this.btnattach.Name = "btnattach";
            this.btnattach.Size = new System.Drawing.Size(35, 31);
            this.btnattach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnattach.TabIndex = 74;
            this.btnattach.TabStop = false;
            this.btnattach.Zoom = 10;
            this.btnattach.Click += new System.EventHandler(this.btnattach_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // sendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 489);
            this.Controls.Add(this.btnattach);
            this.Controls.Add(this.txtbody);
            this.Controls.Add(this.txtattachment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtreciever);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsender);
            this.Name = "sendEmail";
            this.Text = "Contact us";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.btnattach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbody;
        private MetroSuite.MetroTextBox txtattachment;
        private System.Windows.Forms.Label label6;
        private WindowsFormsControlLibrary1.BunifuThinButton btnsend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroSuite.MetroTextBox txtsubject;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtreciever;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpass;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtsender;
        private Bunifu.Framework.UI.BunifuImageButton btnattach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}