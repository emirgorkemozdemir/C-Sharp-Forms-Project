namespace FontDialog_FORM
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
            this.fd1 = new System.Windows.Forms.FontDialog();
            this.txtboxnote = new System.Windows.Forms.RichTextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxnote
            // 
            this.txtboxnote.Location = new System.Drawing.Point(2, 2);
            this.txtboxnote.Name = "txtboxnote";
            this.txtboxnote.Size = new System.Drawing.Size(257, 208);
            this.txtboxnote.TabIndex = 0;
            this.txtboxnote.Text = "";
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnedit.Location = new System.Drawing.Point(265, 2);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(118, 208);
            this.btnedit.TabIndex = 1;
            this.btnedit.Text = "Yazı Düzenle";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(395, 214);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtboxnote);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fd1;
        private System.Windows.Forms.RichTextBox txtboxnote;
        private System.Windows.Forms.Button btnedit;
    }
}

