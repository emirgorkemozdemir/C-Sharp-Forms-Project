namespace Web_Browser_FORM
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
            this.components = new System.ComponentModel.Container();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnobilet = new System.Windows.Forms.Button();
            this.btnbiletall = new System.Windows.Forms.Button();
            this.btnenuygun = new System.Windows.Forms.Button();
            this.btnneredennereye = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, -1);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(964, 451);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnobilet
            // 
            this.btnobilet.Location = new System.Drawing.Point(134, 490);
            this.btnobilet.Name = "btnobilet";
            this.btnobilet.Size = new System.Drawing.Size(188, 54);
            this.btnobilet.TabIndex = 1;
            this.btnobilet.Text = "OBilet.com";
            this.btnobilet.UseVisualStyleBackColor = true;
            this.btnobilet.Click += new System.EventHandler(this.btnobilet_Click);
            // 
            // btnbiletall
            // 
            this.btnbiletall.Location = new System.Drawing.Point(328, 490);
            this.btnbiletall.Name = "btnbiletall";
            this.btnbiletall.Size = new System.Drawing.Size(168, 54);
            this.btnbiletall.TabIndex = 2;
            this.btnbiletall.Text = "Biletall.com";
            this.btnbiletall.UseVisualStyleBackColor = true;
            this.btnbiletall.Click += new System.EventHandler(this.btnbiletall_Click);
            // 
            // btnenuygun
            // 
            this.btnenuygun.Location = new System.Drawing.Point(502, 490);
            this.btnenuygun.Name = "btnenuygun";
            this.btnenuygun.Size = new System.Drawing.Size(168, 54);
            this.btnenuygun.TabIndex = 3;
            this.btnenuygun.Text = "EnUygun.com";
            this.btnenuygun.UseVisualStyleBackColor = true;
            this.btnenuygun.Click += new System.EventHandler(this.btnenuygun_Click);
            // 
            // btnneredennereye
            // 
            this.btnneredennereye.Location = new System.Drawing.Point(676, 490);
            this.btnneredennereye.Name = "btnneredennereye";
            this.btnneredennereye.Size = new System.Drawing.Size(168, 54);
            this.btnneredennereye.TabIndex = 4;
            this.btnneredennereye.Text = "NeredenNereye.com";
            this.btnneredennereye.UseVisualStyleBackColor = true;
            this.btnneredennereye.Click += new System.EventHandler(this.btnneredennereye_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 575);
            this.Controls.Add(this.btnneredennereye);
            this.Controls.Add(this.btnenuygun);
            this.Controls.Add(this.btnbiletall);
            this.Controls.Add(this.btnobilet);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnobilet;
        private System.Windows.Forms.Button btnbiletall;
        private System.Windows.Forms.Button btnenuygun;
        private System.Windows.Forms.Button btnneredennereye;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

