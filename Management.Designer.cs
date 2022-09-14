namespace WindowsFormsApplication1
{
    partial class Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Management));
            this.Runner_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Vo_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.Charity_btn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Type = new System.Windows.Forms.Label();
            this.voluteer1 = new WindowsFormsApplication1.Voluteer();
            this.SuspendLayout();
            // 
            // Runner_btn
            // 
            this.Runner_btn.BackColor = System.Drawing.Color.Blue;
            this.Runner_btn.color = System.Drawing.Color.Blue;
            this.Runner_btn.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Runner_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Runner_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Runner_btn.ForeColor = System.Drawing.Color.White;
            this.Runner_btn.Image = ((System.Drawing.Image)(resources.GetObject("Runner_btn.Image")));
            this.Runner_btn.ImagePosition = 18;
            this.Runner_btn.ImageZoom = 50;
            this.Runner_btn.LabelPosition = 36;
            this.Runner_btn.LabelText = "Runner";
            this.Runner_btn.Location = new System.Drawing.Point(194, 102);
            this.Runner_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Runner_btn.Name = "Runner_btn";
            this.Runner_btn.Size = new System.Drawing.Size(93, 95);
            this.Runner_btn.TabIndex = 0;
            // 
            // Vo_btn
            // 
            this.Vo_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.Vo_btn.color = System.Drawing.Color.SeaGreen;
            this.Vo_btn.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.Vo_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Vo_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vo_btn.ForeColor = System.Drawing.Color.White;
            this.Vo_btn.Image = ((System.Drawing.Image)(resources.GetObject("Vo_btn.Image")));
            this.Vo_btn.ImagePosition = 18;
            this.Vo_btn.ImageZoom = 50;
            this.Vo_btn.LabelPosition = 36;
            this.Vo_btn.LabelText = "Volunteer";
            this.Vo_btn.Location = new System.Drawing.Point(372, 102);
            this.Vo_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Vo_btn.Name = "Vo_btn";
            this.Vo_btn.Size = new System.Drawing.Size(93, 95);
            this.Vo_btn.TabIndex = 1;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 18;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 36;
            this.bunifuTileButton3.LabelText = "Tile 1";
            this.bunifuTileButton3.Location = new System.Drawing.Point(194, 207);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(93, 95);
            this.bunifuTileButton3.TabIndex = 2;
            // 
            // Charity_btn
            // 
            this.Charity_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Charity_btn.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Charity_btn.colorActive = System.Drawing.Color.Red;
            this.Charity_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Charity_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Charity_btn.ForeColor = System.Drawing.Color.White;
            this.Charity_btn.Image = ((System.Drawing.Image)(resources.GetObject("Charity_btn.Image")));
            this.Charity_btn.ImagePosition = 18;
            this.Charity_btn.ImageZoom = 50;
            this.Charity_btn.LabelPosition = 36;
            this.Charity_btn.LabelText = "Charity";
            this.Charity_btn.Location = new System.Drawing.Point(372, 207);
            this.Charity_btn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Charity_btn.Name = "Charity_btn";
            this.Charity_btn.Size = new System.Drawing.Size(93, 95);
            this.Charity_btn.TabIndex = 3;
            // 
            // Type
            // 
            this.Type.AutoSize = true;
            this.Type.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.Location = new System.Drawing.Point(247, 37);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(165, 32);
            this.Type.TabIndex = 21;
            this.Type.Text = "Management";
            // 
            // voluteer1
            // 
            this.voluteer1.BackColor = System.Drawing.Color.White;
            this.voluteer1.Location = new System.Drawing.Point(-8, 0);
            this.voluteer1.Name = "voluteer1";
            this.voluteer1.Size = new System.Drawing.Size(697, 383);
            this.voluteer1.TabIndex = 22;
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.voluteer1);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Charity_btn);
            this.Controls.Add(this.bunifuTileButton3);
            this.Controls.Add(this.Vo_btn);
            this.Controls.Add(this.Runner_btn);
            this.Name = "Management";
            this.Size = new System.Drawing.Size(689, 386);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton Runner_btn;
        private Bunifu.Framework.UI.BunifuTileButton Vo_btn;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton Charity_btn;
        private System.Windows.Forms.Label Type;
        private Voluteer voluteer1;
    }
}
