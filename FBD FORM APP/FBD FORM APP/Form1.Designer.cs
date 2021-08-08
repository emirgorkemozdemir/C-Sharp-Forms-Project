namespace FBD_FORM_APP
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
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnyolseç = new System.Windows.Forms.Button();
            this.txtboxisim = new System.Windows.Forms.TextBox();
            this.txtboxpath = new System.Windows.Forms.TextBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(470, 106);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(324, 183);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(165, 26);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "Dosyaya Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnyolseç
            // 
            this.btnyolseç.Location = new System.Drawing.Point(324, 144);
            this.btnyolseç.Name = "btnyolseç";
            this.btnyolseç.Size = new System.Drawing.Size(165, 26);
            this.btnyolseç.TabIndex = 2;
            this.btnyolseç.Text = "Kaydedilecek yeri seç";
            this.btnyolseç.UseVisualStyleBackColor = true;
            this.btnyolseç.Click += new System.EventHandler(this.btnyolseç_Click);
            // 
            // txtboxisim
            // 
            this.txtboxisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxisim.Location = new System.Drawing.Point(12, 183);
            this.txtboxisim.Name = "txtboxisim";
            this.txtboxisim.Size = new System.Drawing.Size(306, 26);
            this.txtboxisim.TabIndex = 3;
            // 
            // txtboxpath
            // 
            this.txtboxpath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxpath.Location = new System.Drawing.Point(12, 144);
            this.txtboxpath.Name = "txtboxpath";
            this.txtboxpath.Size = new System.Drawing.Size(306, 26);
            this.txtboxpath.TabIndex = 4;
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
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(494, 226);
            this.Controls.Add(this.txtboxpath);
            this.Controls.Add(this.txtboxisim);
            this.Controls.Add(this.btnyolseç);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnyolseç;
        private System.Windows.Forms.TextBox txtboxisim;
        private System.Windows.Forms.TextBox txtboxpath;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

