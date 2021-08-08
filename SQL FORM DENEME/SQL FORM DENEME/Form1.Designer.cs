namespace SQL_FORM_DENEME
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnekle = new System.Windows.Forms.Button();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtno = new System.Windows.Forms.TextBox();
            this.btnpekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnpsil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsilme = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtupad = new System.Windows.Forms.TextBox();
            this.txtupsoyad = new System.Windows.Forms.TextBox();
            this.txtupon = new System.Windows.Forms.TextBox();
            this.txtara = new System.Windows.Forms.TextBox();
            this.btnara = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(556, 174);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(12, 203);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(56, 50);
            this.btnKayıt.TabIndex = 1;
            this.btnKayıt.Text = "Tabloyu Aç";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sıra";
            this.columnHeader1.Width = 53;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ad";
            this.columnHeader2.Width = 176;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Soyad";
            this.columnHeader3.Width = 145;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Öğrenci No";
            this.columnHeader4.Width = 172;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 259);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(56, 50);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Normal Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(292, 219);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 3;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(292, 275);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 4;
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(292, 331);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(100, 20);
            this.txtno.TabIndex = 5;
            // 
            // btnpekle
            // 
            this.btnpekle.Location = new System.Drawing.Point(12, 315);
            this.btnpekle.Name = "btnpekle";
            this.btnpekle.Size = new System.Drawing.Size(56, 50);
            this.btnpekle.TabIndex = 6;
            this.btnpekle.Text = "P Ekle";
            this.btnpekle.UseVisualStyleBackColor = true;
            this.btnpekle.Click += new System.EventHandler(this.btnpekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(101, 203);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(56, 50);
            this.btnsil.TabIndex = 7;
            this.btnsil.Text = "Normal Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnpsil
            // 
            this.btnpsil.Location = new System.Drawing.Point(101, 259);
            this.btnpsil.Name = "btnpsil";
            this.btnpsil.Size = new System.Drawing.Size(56, 50);
            this.btnpsil.TabIndex = 8;
            this.btnpsil.Text = "P Sil";
            this.btnpsil.UseVisualStyleBackColor = true;
            this.btnpsil.Click += new System.EventHandler(this.btnpsil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "SİLİNECEK ÖĞRENCİ NO";
            // 
            // txtsilme
            // 
            this.txtsilme.Location = new System.Drawing.Point(439, 219);
            this.txtsilme.Name = "txtsilme";
            this.txtsilme.Size = new System.Drawing.Size(100, 20);
            this.txtsilme.TabIndex = 10;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(101, 315);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(56, 50);
            this.btnupdate.TabIndex = 11;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "UPDATE YERİ";
            // 
            // txtupad
            // 
            this.txtupad.Location = new System.Drawing.Point(439, 275);
            this.txtupad.Name = "txtupad";
            this.txtupad.Size = new System.Drawing.Size(100, 20);
            this.txtupad.TabIndex = 13;
            // 
            // txtupsoyad
            // 
            this.txtupsoyad.Location = new System.Drawing.Point(439, 301);
            this.txtupsoyad.Name = "txtupsoyad";
            this.txtupsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtupsoyad.TabIndex = 14;
            // 
            // txtupon
            // 
            this.txtupon.Location = new System.Drawing.Point(439, 327);
            this.txtupon.Name = "txtupon";
            this.txtupon.Size = new System.Drawing.Size(100, 20);
            this.txtupon.TabIndex = 15;
            // 
            // txtara
            // 
            this.txtara.Location = new System.Drawing.Point(174, 275);
            this.txtara.Name = "txtara";
            this.txtara.Size = new System.Drawing.Size(100, 20);
            this.txtara.TabIndex = 16;
            // 
            // btnara
            // 
            this.btnara.Location = new System.Drawing.Point(199, 310);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(56, 50);
            this.btnara.TabIndex = 17;
            this.btnara.Text = "Ara";
            this.btnara.UseVisualStyleBackColor = true;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "ARAMA YERİ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnara);
            this.Controls.Add(this.txtara);
            this.Controls.Add(this.txtupon);
            this.Controls.Add(this.txtupsoyad);
            this.Controls.Add(this.txtupad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtsilme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnpsil);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnpekle);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SQL FORM DENEME";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Button btnpekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnpsil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsilme;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtupad;
        private System.Windows.Forms.TextBox txtupsoyad;
        private System.Windows.Forms.TextBox txtupon;
        private System.Windows.Forms.TextBox txtara;
        private System.Windows.Forms.Button btnara;
        private System.Windows.Forms.Label label3;
    }
}

