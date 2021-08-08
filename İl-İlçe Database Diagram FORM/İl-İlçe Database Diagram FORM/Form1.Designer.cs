namespace İl_İlçe_Database_Diagram_FORM
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
            this.cmbboxil = new System.Windows.Forms.ComboBox();
            this.cmbboxilçe = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbboxil
            // 
            this.cmbboxil.FormattingEnabled = true;
            this.cmbboxil.Location = new System.Drawing.Point(12, 12);
            this.cmbboxil.Name = "cmbboxil";
            this.cmbboxil.Size = new System.Drawing.Size(121, 21);
            this.cmbboxil.TabIndex = 1;
            this.cmbboxil.SelectionChangeCommitted += new System.EventHandler(this.cmbboxil_SelectionChangeCommitted);
            // 
            // cmbboxilçe
            // 
            this.cmbboxilçe.FormattingEnabled = true;
            this.cmbboxilçe.Location = new System.Drawing.Point(202, 12);
            this.cmbboxilçe.Name = "cmbboxilçe";
            this.cmbboxilçe.Size = new System.Drawing.Size(121, 21);
            this.cmbboxilçe.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 53);
            this.Controls.Add(this.cmbboxilçe);
            this.Controls.Add(this.cmbboxil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbboxil;
        private System.Windows.Forms.ComboBox cmbboxilçe;
    }
}

