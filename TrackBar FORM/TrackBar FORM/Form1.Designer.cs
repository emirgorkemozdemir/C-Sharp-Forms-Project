namespace TrackBar_FORM
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
            this.lblletter = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lblsize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblletter
            // 
            this.lblletter.AutoSize = true;
            this.lblletter.Location = new System.Drawing.Point(186, 65);
            this.lblletter.Name = "lblletter";
            this.lblletter.Size = new System.Drawing.Size(14, 13);
            this.lblletter.TabIndex = 0;
            this.lblletter.Text = "A";
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(92, 12);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(277, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lblsize
            // 
            this.lblsize.AutoSize = true;
            this.lblsize.Location = new System.Drawing.Point(40, 21);
            this.lblsize.Name = "lblsize";
            this.lblsize.Size = new System.Drawing.Size(13, 13);
            this.lblsize.TabIndex = 2;
            this.lblsize.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 141);
            this.Controls.Add(this.lblsize);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblletter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblletter;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblsize;
    }
}

