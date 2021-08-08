namespace Kütüphane_Uygulaması_Form
{
    partial class GirişPaneli
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirişPaneli));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoClickable1 = new System.Windows.Forms.Label();
            this.InfoLabel4 = new System.Windows.Forms.Label();
            this.InfoLabel3 = new System.Windows.Forms.Label();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.TxtGirişON = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtGirişŞifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnGiriş = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.InfoClickable1);
            this.panel1.Controls.Add(this.InfoLabel4);
            this.panel1.Controls.Add(this.InfoLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 355);
            this.panel1.TabIndex = 0;
            // 
            // InfoClickable1
            // 
            this.InfoClickable1.AutoSize = true;
            this.InfoClickable1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InfoClickable1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoClickable1.ForeColor = System.Drawing.Color.Black;
            this.InfoClickable1.Location = new System.Drawing.Point(5, 169);
            this.InfoClickable1.Name = "InfoClickable1";
            this.InfoClickable1.Size = new System.Drawing.Size(197, 38);
            this.InfoClickable1.TabIndex = 8;
            this.InfoClickable1.Text = "Hesabınız yoksa bu bağlantıya\r\ntıklayarak hesap oluşturabilirsiniz.";
            this.InfoClickable1.Click += new System.EventHandler(this.label3_Click);
            // 
            // InfoLabel4
            // 
            this.InfoLabel4.AutoSize = true;
            this.InfoLabel4.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel4.ForeColor = System.Drawing.Color.Black;
            this.InfoLabel4.Location = new System.Drawing.Point(5, 102);
            this.InfoLabel4.Name = "InfoLabel4";
            this.InfoLabel4.Size = new System.Drawing.Size(195, 57);
            this.InfoLabel4.TabIndex = 7;
            this.InfoLabel4.Text = "Sisteme kayıtlıysanız,sağ taraftan \r\ngiriş yapabilirsiniz.\r\n\r\n";
            // 
            // InfoLabel3
            // 
            this.InfoLabel3.AutoSize = true;
            this.InfoLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel3.ForeColor = System.Drawing.Color.Black;
            this.InfoLabel3.Location = new System.Drawing.Point(3, 9);
            this.InfoLabel3.Name = "InfoLabel3";
            this.InfoLabel3.Size = new System.Drawing.Size(183, 66);
            this.InfoLabel3.TabIndex = 6;
            this.InfoLabel3.Text = " Toros Üniversitesi\r\nKütüphane Sistemi\r\n";
        
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoLabel1.Location = new System.Drawing.Point(210, 9);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(87, 33);
            this.InfoLabel1.TabIndex = 1;
            this.InfoLabel1.Text = "Okul No ";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InfoLabel2.Location = new System.Drawing.Point(210, 137);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(58, 33);
            this.InfoLabel2.TabIndex = 2;
            this.InfoLabel2.Text = "Şifre";
            // 
            // TxtGirişON
            // 
            this.TxtGirişON.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtGirişON.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtGirişON.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtGirişON.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGirişON.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGirişON.ForeColor = System.Drawing.Color.White;
            this.TxtGirişON.HintForeColor = System.Drawing.Color.Empty;
            this.TxtGirişON.HintText = "";
            this.TxtGirişON.isPassword = false;
            this.TxtGirişON.LineFocusedColor = System.Drawing.Color.Plum;
            this.TxtGirişON.LineIdleColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtGirişON.LineMouseHoverColor = System.Drawing.Color.Plum;
            this.TxtGirişON.LineThickness = 5;
            this.TxtGirişON.Location = new System.Drawing.Point(209, 46);
            this.TxtGirişON.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtGirişON.MaxLength = 32767;
            this.TxtGirişON.Name = "TxtGirişON";
            this.TxtGirişON.Size = new System.Drawing.Size(252, 41);
            this.TxtGirişON.TabIndex = 3;
            this.TxtGirişON.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // TxtGirişŞifre
            // 
            this.TxtGirişŞifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtGirişŞifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtGirişŞifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtGirişŞifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtGirişŞifre.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGirişŞifre.ForeColor = System.Drawing.Color.White;
            this.TxtGirişŞifre.HintForeColor = System.Drawing.Color.Empty;
            this.TxtGirişŞifre.HintText = "";
            this.TxtGirişŞifre.isPassword = true;
            this.TxtGirişŞifre.LineFocusedColor = System.Drawing.Color.Plum;
            this.TxtGirişŞifre.LineIdleColor = System.Drawing.SystemColors.ButtonFace;
            this.TxtGirişŞifre.LineMouseHoverColor = System.Drawing.Color.Plum;
            this.TxtGirişŞifre.LineThickness = 5;
            this.TxtGirişŞifre.Location = new System.Drawing.Point(209, 190);
            this.TxtGirişŞifre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.TxtGirişŞifre.MaxLength = 32767;
            this.TxtGirişŞifre.Name = "TxtGirişŞifre";
            this.TxtGirişŞifre.Size = new System.Drawing.Size(252, 41);
            this.TxtGirişŞifre.TabIndex = 4;
            this.TxtGirişŞifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnGiriş
            // 
            this.BtnGiriş.BackColor = System.Drawing.Color.Plum;
            this.BtnGiriş.FlatAppearance.BorderSize = 0;
            this.BtnGiriş.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGiriş.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGiriş.ForeColor = System.Drawing.Color.Black;
            this.BtnGiriş.Location = new System.Drawing.Point(253, 273);
            this.BtnGiriş.Name = "BtnGiriş";
            this.BtnGiriş.Size = new System.Drawing.Size(142, 54);
            this.BtnGiriş.TabIndex = 5;
            this.BtnGiriş.Text = "Giriş Yap";
            this.BtnGiriş.UseVisualStyleBackColor = false;
            this.BtnGiriş.Click += new System.EventHandler(this.BtnGiriş_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.InfoLabel3;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.InfoLabel4;
            this.bunifuDragControl3.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GirişPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(474, 355);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnGiriş);
            this.Controls.Add(this.TxtGirişŞifre);
            this.Controls.Add(this.TxtGirişON);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.InfoLabel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GirişPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtGirişON;
        private System.Windows.Forms.Label InfoLabel2;
        private System.Windows.Forms.Label InfoLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtGirişŞifre;
        private System.Windows.Forms.Button BtnGiriş;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label InfoLabel3;
        private System.Windows.Forms.Label InfoLabel4;
        private System.Windows.Forms.Label InfoClickable1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

