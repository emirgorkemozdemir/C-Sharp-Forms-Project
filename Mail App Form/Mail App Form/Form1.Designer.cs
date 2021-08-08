namespace Mail_App_Form
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
            this.txtboxreciever = new System.Windows.Forms.TextBox();
            this.txtboxtext = new System.Windows.Forms.RichTextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxreciever
            // 
            this.txtboxreciever.Location = new System.Drawing.Point(12, 32);
            this.txtboxreciever.Name = "txtboxreciever";
            this.txtboxreciever.Size = new System.Drawing.Size(455, 20);
            this.txtboxreciever.TabIndex = 0;
            // 
            // txtboxtext
            // 
            this.txtboxtext.Location = new System.Drawing.Point(12, 73);
            this.txtboxtext.Name = "txtboxtext";
            this.txtboxtext.Size = new System.Drawing.Size(455, 213);
            this.txtboxtext.TabIndex = 1;
            this.txtboxtext.Text = "";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(164, 299);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(139, 50);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Maili Yolla";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(479, 361);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtboxtext);
            this.Controls.Add(this.txtboxreciever);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxreciever;
        private System.Windows.Forms.RichTextBox txtboxtext;
        private System.Windows.Forms.Button btnSend;
    }
}

