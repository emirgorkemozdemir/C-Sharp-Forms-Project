namespace DOSYA_KAYDETME_OKUTMA_YÖNTEMLERİ_FORM
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
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtkayıt = new System.Windows.Forms.TextBox();
            this.lbox = new System.Windows.Forms.ListBox();
            this.btnkayıt1 = new System.Windows.Forms.Button();
            this.btnkayıt2 = new System.Windows.Forms.Button();
            this.btnread1 = new System.Windows.Forms.Button();
            this.btnoku2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtkayıt
            // 
            this.txtkayıt.Location = new System.Drawing.Point(12, 11);
            this.txtkayıt.Name = "txtkayıt";
            this.txtkayıt.Size = new System.Drawing.Size(322, 20);
            this.txtkayıt.TabIndex = 0;
            // 
            // lbox
            // 
            this.lbox.FormattingEnabled = true;
            this.lbox.Location = new System.Drawing.Point(12, 49);
            this.lbox.Name = "lbox";
            this.lbox.Size = new System.Drawing.Size(322, 173);
            this.lbox.TabIndex = 1;
            // 
            // btnkayıt1
            // 
            this.btnkayıt1.Location = new System.Drawing.Point(12, 237);
            this.btnkayıt1.Name = "btnkayıt1";
            this.btnkayıt1.Size = new System.Drawing.Size(92, 47);
            this.btnkayıt1.TabIndex = 2;
            this.btnkayıt1.Text = "Kaydet t1";
            this.btnkayıt1.UseVisualStyleBackColor = true;
            this.btnkayıt1.Click += new System.EventHandler(this.btnkayıt1_Click);
            // 
            // btnkayıt2
            // 
            this.btnkayıt2.Location = new System.Drawing.Point(110, 237);
            this.btnkayıt2.Name = "btnkayıt2";
            this.btnkayıt2.Size = new System.Drawing.Size(92, 47);
            this.btnkayıt2.TabIndex = 3;
            this.btnkayıt2.Text = "Kaydet t2";
            this.btnkayıt2.UseVisualStyleBackColor = true;
            this.btnkayıt2.Click += new System.EventHandler(this.btnkayıt2_Click);
            // 
            // btnread1
            // 
            this.btnread1.Location = new System.Drawing.Point(208, 237);
            this.btnread1.Name = "btnread1";
            this.btnread1.Size = new System.Drawing.Size(92, 47);
            this.btnread1.TabIndex = 4;
            this.btnread1.Text = "Oku t1";
            this.btnread1.UseVisualStyleBackColor = true;
            this.btnread1.Click += new System.EventHandler(this.btnread1_Click);
            // 
            // btnoku2
            // 
            this.btnoku2.Location = new System.Drawing.Point(12, 290);
            this.btnoku2.Name = "btnoku2";
            this.btnoku2.Size = new System.Drawing.Size(92, 47);
            this.btnoku2.TabIndex = 5;
            this.btnoku2.Text = "Oku t2";
            this.btnoku2.UseVisualStyleBackColor = true;
            this.btnoku2.Click += new System.EventHandler(this.btnoku2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.btnoku2);
            this.Controls.Add(this.btnread1);
            this.Controls.Add(this.btnkayıt2);
            this.Controls.Add(this.btnkayıt1);
            this.Controls.Add(this.lbox);
            this.Controls.Add(this.txtkayıt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.ListBox lbox;
        private System.Windows.Forms.TextBox txtkayıt;
        private System.Windows.Forms.Button btnkayıt1;
        private System.Windows.Forms.Button btnkayıt2;
        private System.Windows.Forms.Button btnread1;
        private System.Windows.Forms.Button btnoku2;
    }
}

