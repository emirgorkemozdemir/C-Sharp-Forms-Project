namespace Folder_Operations_Form
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
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btncreation = new System.Windows.Forms.Button();
            this.btnlastaccess = new System.Windows.Forms.Button();
            this.btnCurrent = new System.Windows.Forms.Button();
            this.txtboxPath = new System.Windows.Forms.TextBox();
            this.txtboxnewname = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxName
            // 
            this.txtboxName.Location = new System.Drawing.Point(12, 12);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(376, 20);
            this.txtboxName.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 136);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(104, 47);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Klasör Oluştur";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(147, 136);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Klasörü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btncreation
            // 
            this.btncreation.Location = new System.Drawing.Point(284, 136);
            this.btncreation.Name = "btncreation";
            this.btncreation.Size = new System.Drawing.Size(104, 47);
            this.btncreation.TabIndex = 3;
            this.btncreation.Text = "Oluşturulma Tarihi";
            this.btncreation.UseVisualStyleBackColor = true;
            this.btncreation.Click += new System.EventHandler(this.btncreation_Click);
            // 
            // btnlastaccess
            // 
            this.btnlastaccess.Location = new System.Drawing.Point(147, 224);
            this.btnlastaccess.Name = "btnlastaccess";
            this.btnlastaccess.Size = new System.Drawing.Size(104, 47);
            this.btnlastaccess.TabIndex = 5;
            this.btnlastaccess.Text = "Klasöre Son Erişim";
            this.btnlastaccess.UseVisualStyleBackColor = true;
            this.btnlastaccess.Click += new System.EventHandler(this.btnlastaccess_Click);
            // 
            // btnCurrent
            // 
            this.btnCurrent.Location = new System.Drawing.Point(12, 224);
            this.btnCurrent.Name = "btnCurrent";
            this.btnCurrent.Size = new System.Drawing.Size(104, 47);
            this.btnCurrent.TabIndex = 4;
            this.btnCurrent.Text = "Uygulamanın Konumunu Göster";
            this.btnCurrent.UseVisualStyleBackColor = true;
            this.btnCurrent.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // txtboxPath
            // 
            this.txtboxPath.Location = new System.Drawing.Point(12, 47);
            this.txtboxPath.Name = "txtboxPath";
            this.txtboxPath.Size = new System.Drawing.Size(376, 20);
            this.txtboxPath.TabIndex = 7;
            // 
            // txtboxnewname
            // 
            this.txtboxnewname.Location = new System.Drawing.Point(12, 87);
            this.txtboxnewname.Name = "txtboxnewname";
            this.txtboxnewname.Size = new System.Drawing.Size(376, 20);
            this.txtboxnewname.TabIndex = 8;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(284, 224);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(104, 47);
            this.btnRename.TabIndex = 9;
            this.btnRename.Text = "Klasör İsmini Değiştir";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 283);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.txtboxnewname);
            this.Controls.Add(this.txtboxPath);
            this.Controls.Add(this.btnlastaccess);
            this.Controls.Add(this.btnCurrent);
            this.Controls.Add(this.btncreation);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtboxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btncreation;
        private System.Windows.Forms.Button btnlastaccess;
        private System.Windows.Forms.Button btnCurrent;
        private System.Windows.Forms.TextBox txtboxPath;
        private System.Windows.Forms.TextBox txtboxnewname;
        private System.Windows.Forms.Button btnRename;
    }
}

