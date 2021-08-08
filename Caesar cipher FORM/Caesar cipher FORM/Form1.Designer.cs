namespace Caesar_cipher_FORM
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
            this.txtboxresult = new System.Windows.Forms.TextBox();
            this.txtinput = new System.Windows.Forms.TextBox();
            this.btnencrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxresult
            // 
            this.txtboxresult.Location = new System.Drawing.Point(12, 63);
            this.txtboxresult.Name = "txtboxresult";
            this.txtboxresult.Size = new System.Drawing.Size(291, 20);
            this.txtboxresult.TabIndex = 1;
            // 
            // txtinput
            // 
            this.txtinput.Location = new System.Drawing.Point(12, 12);
            this.txtinput.Name = "txtinput";
            this.txtinput.Size = new System.Drawing.Size(291, 20);
            this.txtinput.TabIndex = 2;
            // 
            // btnencrypt
            // 
            this.btnencrypt.Location = new System.Drawing.Point(98, 104);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(124, 50);
            this.btnencrypt.TabIndex = 3;
            this.btnencrypt.Text = "Şifrele";
            this.btnencrypt.UseVisualStyleBackColor = true;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 176);
            this.Controls.Add(this.btnencrypt);
            this.Controls.Add(this.txtinput);
            this.Controls.Add(this.txtboxresult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxresult;
        private System.Windows.Forms.TextBox txtinput;
        private System.Windows.Forms.Button btnencrypt;
    }
}

