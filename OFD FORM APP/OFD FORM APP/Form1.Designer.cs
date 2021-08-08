namespace OFD_FORM_APP
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
            this.btnofd = new System.Windows.Forms.Button();
            this.txtboxpath = new System.Windows.Forms.TextBox();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnofd
            // 
            this.btnofd.Location = new System.Drawing.Point(151, 38);
            this.btnofd.Name = "btnofd";
            this.btnofd.Size = new System.Drawing.Size(97, 70);
            this.btnofd.TabIndex = 0;
            this.btnofd.Text = "Dosya yolu seç";
            this.btnofd.UseVisualStyleBackColor = true;
            this.btnofd.Click += new System.EventHandler(this.btnofd_Click);
            // 
            // txtboxpath
            // 
            this.txtboxpath.Location = new System.Drawing.Point(12, 12);
            this.txtboxpath.Name = "txtboxpath";
            this.txtboxpath.Size = new System.Drawing.Size(377, 20);
            this.txtboxpath.TabIndex = 1;
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 115);
            this.Controls.Add(this.txtboxpath);
            this.Controls.Add(this.btnofd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnofd;
        private System.Windows.Forms.TextBox txtboxpath;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}

