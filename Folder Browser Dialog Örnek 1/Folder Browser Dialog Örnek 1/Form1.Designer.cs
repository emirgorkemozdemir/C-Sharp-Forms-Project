namespace Folder_Browser_Dialog_Örnek_1
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyol = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.btnyol = new System.Windows.Forms.Button();
            this.btnkayıt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Belge Yolu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Belge Adı";
            // 
            // txtyol
            // 
            this.txtyol.Location = new System.Drawing.Point(143, 29);
            this.txtyol.Name = "txtyol";
            this.txtyol.Size = new System.Drawing.Size(100, 20);
            this.txtyol.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(143, 95);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 3;
            // 
            // btnyol
            // 
            this.btnyol.Location = new System.Drawing.Point(82, 156);
            this.btnyol.Name = "btnyol";
            this.btnyol.Size = new System.Drawing.Size(67, 37);
            this.btnyol.TabIndex = 4;
            this.btnyol.Text = "Yol Seç";
            this.btnyol.UseVisualStyleBackColor = true;
            this.btnyol.Click += new System.EventHandler(this.btnyol_Click);
            // 
            // btnkayıt
            // 
            this.btnkayıt.Location = new System.Drawing.Point(176, 156);
            this.btnkayıt.Name = "btnkayıt";
            this.btnkayıt.Size = new System.Drawing.Size(67, 37);
            this.btnkayıt.TabIndex = 5;
            this.btnkayıt.Text = "Kaydet";
            this.btnkayıt.UseVisualStyleBackColor = true;
            this.btnkayıt.Click += new System.EventHandler(this.btnkayıt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(343, 250);
            this.Controls.Add(this.btnkayıt);
            this.Controls.Add(this.btnyol);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.txtyol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyol;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Button btnyol;
        private System.Windows.Forms.Button btnkayıt;
    }
}

