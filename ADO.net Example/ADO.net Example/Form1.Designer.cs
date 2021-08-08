namespace ADO.net_Example
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
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtboxad = new System.Windows.Forms.TextBox();
            this.txtboxsoyad = new System.Windows.Forms.TextBox();
            this.txtboxon = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtboxuon = new System.Windows.Forms.TextBox();
            this.txtboxusoyad = new System.Windows.Forms.TextBox();
            this.txtboxuad = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(12, 12);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(663, 235);
            this.dg.TabIndex = 0;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // txtboxad
            // 
            this.txtboxad.Location = new System.Drawing.Point(12, 265);
            this.txtboxad.Name = "txtboxad";
            this.txtboxad.Size = new System.Drawing.Size(132, 20);
            this.txtboxad.TabIndex = 1;
            // 
            // txtboxsoyad
            // 
            this.txtboxsoyad.Location = new System.Drawing.Point(12, 301);
            this.txtboxsoyad.Name = "txtboxsoyad";
            this.txtboxsoyad.Size = new System.Drawing.Size(132, 20);
            this.txtboxsoyad.TabIndex = 2;
            // 
            // txtboxon
            // 
            this.txtboxon.Location = new System.Drawing.Point(12, 336);
            this.txtboxon.Name = "txtboxon";
            this.txtboxon.Size = new System.Drawing.Size(132, 20);
            this.txtboxon.TabIndex = 3;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(35, 362);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(81, 45);
            this.btnekle.TabIndex = 4;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(222, 362);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(81, 45);
            this.btnupdate.TabIndex = 8;
            this.btnupdate.Text = "Düzenle";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtboxuon
            // 
            this.txtboxuon.Location = new System.Drawing.Point(199, 336);
            this.txtboxuon.Name = "txtboxuon";
            this.txtboxuon.Size = new System.Drawing.Size(132, 20);
            this.txtboxuon.TabIndex = 7;
            // 
            // txtboxusoyad
            // 
            this.txtboxusoyad.Location = new System.Drawing.Point(199, 301);
            this.txtboxusoyad.Name = "txtboxusoyad";
            this.txtboxusoyad.Size = new System.Drawing.Size(132, 20);
            this.txtboxusoyad.TabIndex = 6;
            // 
            // txtboxuad
            // 
            this.txtboxuad.Location = new System.Drawing.Point(199, 265);
            this.txtboxuad.Name = "txtboxuad";
            this.txtboxuad.Size = new System.Drawing.Size(132, 20);
            this.txtboxuad.TabIndex = 5;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(393, 288);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(81, 45);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Sil";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 419);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtboxuon);
            this.Controls.Add(this.txtboxusoyad);
            this.Controls.Add(this.txtboxuad);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtboxon);
            this.Controls.Add(this.txtboxsoyad);
            this.Controls.Add(this.txtboxad);
            this.Controls.Add(this.dg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtboxad;
        private System.Windows.Forms.TextBox txtboxsoyad;
        private System.Windows.Forms.TextBox txtboxon;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtboxuon;
        private System.Windows.Forms.TextBox txtboxusoyad;
        private System.Windows.Forms.TextBox txtboxuad;
        private System.Windows.Forms.Button btndelete;
    }
}

