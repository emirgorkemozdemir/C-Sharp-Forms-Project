namespace Kütüphane_Uygulaması_Form
{
    partial class KitapRezerve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapRezerve));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.TxtAra = new System.Windows.Forms.TextBox();
            this.BtnAl = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoLabel3.Location = new System.Drawing.Point(21, 9);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(203, 58);
            this.InfoLabel3.TabIndex = 8;
            this.InfoLabel3.Text = "Almak istediğiniz kitabı\r\n       aşağıya giriniz";
            // 
            // TxtAra
            // 
            this.TxtAra.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAra.Location = new System.Drawing.Point(70, 80);
            this.TxtAra.Name = "TxtAra";
            this.TxtAra.Size = new System.Drawing.Size(100, 21);
            this.TxtAra.TabIndex = 9;
            // 
            // BtnAl
            // 
            this.BtnAl.BackColor = System.Drawing.Color.Plum;
            this.BtnAl.FlatAppearance.BorderSize = 0;
            this.BtnAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAl.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnAl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAl.Location = new System.Drawing.Point(60, 116);
            this.BtnAl.Name = "BtnAl";
            this.BtnAl.Size = new System.Drawing.Size(121, 42);
            this.BtnAl.TabIndex = 12;
            this.BtnAl.Text = "Kitabı al";
            this.BtnAl.UseVisualStyleBackColor = false;
            this.BtnAl.Click += new System.EventHandler(this.BtnAl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(230, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // KitapRezerve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(254, 221);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAl);
            this.Controls.Add(this.TxtAra);
            this.Controls.Add(this.InfoLabel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KitapRezerve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitapRezerve";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label InfoLabel3;
        private System.Windows.Forms.TextBox TxtAra;
        private System.Windows.Forms.Button BtnAl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}