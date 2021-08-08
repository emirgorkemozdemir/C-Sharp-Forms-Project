namespace Plane_Tickets_App_Form_WebBrowser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnenuygun = new System.Windows.Forms.Button();
            this.btnbiletbayisi = new System.Windows.Forms.Button();
            this.btnucuzabilet = new System.Windows.Forms.Button();
            this.btnwego = new System.Windows.Forms.Button();
            this.btnobilet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(265, 33);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(649, 603);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnenuygun
            // 
            this.btnenuygun.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnenuygun.Location = new System.Drawing.Point(44, 87);
            this.btnenuygun.Name = "btnenuygun";
            this.btnenuygun.Size = new System.Drawing.Size(165, 40);
            this.btnenuygun.TabIndex = 1;
            this.btnenuygun.Text = "Pegasus";
            this.btnenuygun.UseVisualStyleBackColor = true;
            this.btnenuygun.Click += new System.EventHandler(this.btnenuygun_Click);
            // 
            // btnbiletbayisi
            // 
            this.btnbiletbayisi.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnbiletbayisi.Location = new System.Drawing.Point(44, 154);
            this.btnbiletbayisi.Name = "btnbiletbayisi";
            this.btnbiletbayisi.Size = new System.Drawing.Size(165, 40);
            this.btnbiletbayisi.TabIndex = 2;
            this.btnbiletbayisi.Text = "BiletBayisi.com";
            this.btnbiletbayisi.UseVisualStyleBackColor = true;
            this.btnbiletbayisi.Click += new System.EventHandler(this.btnbiletbayisi_Click);
            // 
            // btnucuzabilet
            // 
            this.btnucuzabilet.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnucuzabilet.Location = new System.Drawing.Point(44, 222);
            this.btnucuzabilet.Name = "btnucuzabilet";
            this.btnucuzabilet.Size = new System.Drawing.Size(165, 40);
            this.btnucuzabilet.TabIndex = 3;
            this.btnucuzabilet.Text = "UcuzaBilet.com";
            this.btnucuzabilet.UseVisualStyleBackColor = true;
            this.btnucuzabilet.Click += new System.EventHandler(this.btnucuzabilet_Click);
            // 
            // btnwego
            // 
            this.btnwego.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnwego.Location = new System.Drawing.Point(44, 289);
            this.btnwego.Name = "btnwego";
            this.btnwego.Size = new System.Drawing.Size(165, 40);
            this.btnwego.TabIndex = 4;
            this.btnwego.Text = "Wego.com";
            this.btnwego.UseVisualStyleBackColor = true;
            this.btnwego.Click += new System.EventHandler(this.btnwego_Click);
            // 
            // btnobilet
            // 
            this.btnobilet.Font = new System.Drawing.Font("Lucida Console", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnobilet.Location = new System.Drawing.Point(44, 358);
            this.btnobilet.Name = "btnobilet";
            this.btnobilet.Size = new System.Drawing.Size(165, 40);
            this.btnobilet.TabIndex = 5;
            this.btnobilet.Text = "OBilet.com";
            this.btnobilet.UseVisualStyleBackColor = true;
            this.btnobilet.Click += new System.EventHandler(this.btnobilet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(934, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnobilet);
            this.Controls.Add(this.btnwego);
            this.Controls.Add(this.btnucuzabilet);
            this.Controls.Add(this.btnbiletbayisi);
            this.Controls.Add(this.btnenuygun);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Uçak Biletleri";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnenuygun;
        private System.Windows.Forms.Button btnbiletbayisi;
        private System.Windows.Forms.Button btnucuzabilet;
        private System.Windows.Forms.Button btnwego;
        private System.Windows.Forms.Button btnobilet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

