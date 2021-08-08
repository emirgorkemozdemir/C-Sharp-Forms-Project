namespace Enum_App_Form
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
            this.txtboxnum = new System.Windows.Forms.TextBox();
            this.lblmonth = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxnum
            // 
            this.txtboxnum.Location = new System.Drawing.Point(12, 35);
            this.txtboxnum.Name = "txtboxnum";
            this.txtboxnum.Size = new System.Drawing.Size(280, 20);
            this.txtboxnum.TabIndex = 0;
            // 
            // lblmonth
            // 
            this.lblmonth.AutoSize = true;
            this.lblmonth.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmonth.Location = new System.Drawing.Point(122, 99);
            this.lblmonth.Name = "lblmonth";
            this.lblmonth.Size = new System.Drawing.Size(0, 23);
            this.lblmonth.TabIndex = 1;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(95, 155);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(102, 68);
            this.btnshow.TabIndex = 2;
            this.btnshow.Text = "Ayı Göster";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 254);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lblmonth);
            this.Controls.Add(this.txtboxnum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxnum;
        private System.Windows.Forms.Label lblmonth;
        private System.Windows.Forms.Button btnshow;
    }
}

