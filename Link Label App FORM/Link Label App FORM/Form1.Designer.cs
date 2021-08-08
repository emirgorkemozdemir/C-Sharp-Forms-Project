namespace Link_Label_App_FORM
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
            this.llgoogle = new System.Windows.Forms.LinkLabel();
            this.llpaint = new System.Windows.Forms.LinkLabel();
            this.llword = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // llgoogle
            // 
            this.llgoogle.ActiveLinkColor = System.Drawing.Color.Black;
            this.llgoogle.AutoSize = true;
            this.llgoogle.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llgoogle.LinkColor = System.Drawing.Color.Maroon;
            this.llgoogle.Location = new System.Drawing.Point(12, 19);
            this.llgoogle.Name = "llgoogle";
            this.llgoogle.Size = new System.Drawing.Size(80, 35);
            this.llgoogle.TabIndex = 0;
            this.llgoogle.TabStop = true;
            this.llgoogle.Text = "Google";
            this.llgoogle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llgoogle_LinkClicked);
            // 
            // llpaint
            // 
            this.llpaint.ActiveLinkColor = System.Drawing.Color.Black;
            this.llpaint.AutoSize = true;
            this.llpaint.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llpaint.LinkColor = System.Drawing.Color.Maroon;
            this.llpaint.Location = new System.Drawing.Point(167, 19);
            this.llpaint.Name = "llpaint";
            this.llpaint.Size = new System.Drawing.Size(65, 35);
            this.llpaint.TabIndex = 1;
            this.llpaint.TabStop = true;
            this.llpaint.Text = "Paint";
            this.llpaint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llpaint_LinkClicked);
            // 
            // llword
            // 
            this.llword.ActiveLinkColor = System.Drawing.Color.Black;
            this.llword.AutoSize = true;
            this.llword.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llword.LinkColor = System.Drawing.Color.Maroon;
            this.llword.Location = new System.Drawing.Point(307, 19);
            this.llword.Name = "llword";
            this.llword.Size = new System.Drawing.Size(98, 35);
            this.llword.TabIndex = 2;
            this.llword.TabStop = true;
            this.llword.Text = "WordPad";
            this.llword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llword_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(416, 86);
            this.Controls.Add(this.llword);
            this.Controls.Add(this.llpaint);
            this.Controls.Add(this.llgoogle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel llgoogle;
        private System.Windows.Forms.LinkLabel llpaint;
        private System.Windows.Forms.LinkLabel llword;
    }
}

