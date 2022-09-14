namespace WindowsFormsApplication1
{
    partial class ReadQR
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
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.btnabrir = new System.Windows.Forms.Button();
            this.pbmostrararchivo = new System.Windows.Forms.PictureBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.pbgenerar = new System.Windows.Forms.PictureBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Selection = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.sqr1 = new WindowsFormsApplication1.SQR();
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).BeginInit();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(6, 279);
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.ReadOnly = true;
            this.txtmostrar.Size = new System.Drawing.Size(267, 22);
            this.txtmostrar.TabIndex = 15;
            // 
            // btnabrir
            // 
            this.btnabrir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnabrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnabrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnabrir.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnabrir.Location = new System.Drawing.Point(279, 270);
            this.btnabrir.Name = "btnabrir";
            this.btnabrir.Size = new System.Drawing.Size(195, 31);
            this.btnabrir.TabIndex = 13;
            this.btnabrir.Text = "Import QRCode";
            this.btnabrir.UseVisualStyleBackColor = true;
            this.btnabrir.Click += new System.EventHandler(this.btnabrir_Click);
            // 
            // pbmostrararchivo
            // 
            this.pbmostrararchivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbmostrararchivo.Location = new System.Drawing.Point(6, 6);
            this.pbmostrararchivo.Name = "pbmostrararchivo";
            this.pbmostrararchivo.Size = new System.Drawing.Size(267, 255);
            this.pbmostrararchivo.TabIndex = 12;
            this.pbmostrararchivo.TabStop = false;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnguardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnguardar.Location = new System.Drawing.Point(303, 265);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(85, 34);
            this.btnguardar.TabIndex = 11;
            this.btnguardar.Text = "Save";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // pbgenerar
            // 
            this.pbgenerar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbgenerar.Location = new System.Drawing.Point(16, 6);
            this.pbgenerar.Name = "pbgenerar";
            this.pbgenerar.Size = new System.Drawing.Size(267, 224);
            this.pbgenerar.TabIndex = 10;
            this.pbgenerar.TabStop = false;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(16, 273);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(267, 22);
            this.txtnombre.TabIndex = 9;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "QR Code";
            // 
            // Selection
            // 
            this.Selection.BaseTabControl = this.materialTabControl1;
            this.Selection.Depth = 0;
            this.Selection.Location = new System.Drawing.Point(23, 63);
            this.Selection.MouseState = MaterialSkin.MouseState.HOVER;
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(733, 23);
            this.Selection.TabIndex = 73;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(23, 92);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(733, 374);
            this.materialTabControl1.TabIndex = 74;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbgenerar);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtnombre);
            this.tabPage1.Controls.Add(this.btnguardar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create QR Code";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pbmostrararchivo);
            this.tabPage2.Controls.Add(this.txtmostrar);
            this.tabPage2.Controls.Add(this.btnabrir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Read QR Code";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.sqr1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(725, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Scanner QR Code";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // sqr1
            // 
            this.sqr1.Location = new System.Drawing.Point(3, 0);
            this.sqr1.Name = "sqr1";
            this.sqr1.Size = new System.Drawing.Size(721, 349);
            this.sqr1.TabIndex = 0;
            // 
            // ReadQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 477);
            this.Controls.Add(this.materialTabControl1);
            this.Controls.Add(this.Selection);
            this.Name = "ReadQR";
            this.Text = "QR Code";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.ReadQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbmostrararchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbgenerar)).EndInit();
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.Button btnabrir;
        private System.Windows.Forms.PictureBox pbmostrararchivo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.PictureBox pbgenerar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTabSelector Selection;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private SQR sqr1;
    }
}