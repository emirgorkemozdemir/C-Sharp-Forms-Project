namespace SQL_FORM_LİSTVİEW_ÖĞRENCİ_UYG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.infolabel1 = new System.Windows.Forms.Label();
            this.studentPicture = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Sıra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Şifre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtsoyad = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtşifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnaç = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.infolabel1);
            this.panel1.Controls.Add(this.studentPicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 337);
            this.panel1.TabIndex = 0;
            // 
            // infolabel1
            // 
            this.infolabel1.AutoSize = true;
            this.infolabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infolabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.infolabel1.Location = new System.Drawing.Point(47, 107);
            this.infolabel1.Name = "infolabel1";
            this.infolabel1.Size = new System.Drawing.Size(114, 18);
            this.infolabel1.TabIndex = 2;
            this.infolabel1.Text = "Öğrenci Kayıt Sistemi\r\n";
            // 
            // studentPicture
            // 
            this.studentPicture.Image = ((System.Drawing.Image)(resources.GetObject("studentPicture.Image")));
            this.studentPicture.Location = new System.Drawing.Point(50, 12);
            this.studentPicture.Name = "studentPicture";
            this.studentPicture.Size = new System.Drawing.Size(111, 81);
            this.studentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.studentPicture.TabIndex = 2;
            this.studentPicture.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Sıra,
            this.Ad,
            this.Soyad,
            this.Şifre});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(215, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(374, 129);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Sıra
            // 
            this.Sıra.Text = "Sıra";
            // 
            // Ad
            // 
            this.Ad.Text = "Ad";
            // 
            // Soyad
            // 
            this.Soyad.Text = "Soyad";
            // 
            // Şifre
            // 
            this.Şifre.Text = "Şifre";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(595, 60);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(58, 42);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(595, 99);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(58, 42);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.studentPicture;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.infolabel1;
            this.bunifuDragControl3.Vertical = true;
            // 
            // txtad
            // 
            this.txtad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtad.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtad.ForeColor = System.Drawing.Color.SeaShell;
            this.txtad.HintForeColor = System.Drawing.Color.Empty;
            this.txtad.HintText = "";
            this.txtad.isPassword = false;
            this.txtad.LineFocusedColor = System.Drawing.Color.SandyBrown;
            this.txtad.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtad.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.txtad.LineThickness = 3;
            this.txtad.Location = new System.Drawing.Point(215, 166);
            this.txtad.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtad.MaxLength = 32767;
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(71, 29);
            this.txtad.TabIndex = 5;
            this.txtad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtsoyad
            // 
            this.txtsoyad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtsoyad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtsoyad.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtsoyad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsoyad.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsoyad.ForeColor = System.Drawing.Color.SeaShell;
            this.txtsoyad.HintForeColor = System.Drawing.Color.Empty;
            this.txtsoyad.HintText = "";
            this.txtsoyad.isPassword = false;
            this.txtsoyad.LineFocusedColor = System.Drawing.Color.SandyBrown;
            this.txtsoyad.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtsoyad.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.txtsoyad.LineThickness = 3;
            this.txtsoyad.Location = new System.Drawing.Point(308, 169);
            this.txtsoyad.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtsoyad.MaxLength = 32767;
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(71, 26);
            this.txtsoyad.TabIndex = 6;
            this.txtsoyad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtşifre
            // 
            this.txtşifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtşifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtşifre.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtşifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtşifre.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtşifre.ForeColor = System.Drawing.Color.SeaShell;
            this.txtşifre.HintForeColor = System.Drawing.Color.Empty;
            this.txtşifre.HintText = "";
            this.txtşifre.isPassword = true;
            this.txtşifre.LineFocusedColor = System.Drawing.Color.SandyBrown;
            this.txtşifre.LineIdleColor = System.Drawing.Color.SeaShell;
            this.txtşifre.LineMouseHoverColor = System.Drawing.Color.SandyBrown;
            this.txtşifre.LineThickness = 3;
            this.txtşifre.Location = new System.Drawing.Point(396, 169);
            this.txtşifre.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtşifre.MaxLength = 32767;
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(71, 26);
            this.txtşifre.TabIndex = 8;
            this.txtşifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.SeaShell;
            this.btnkaydet.FlatAppearance.BorderSize = 0;
            this.btnkaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkaydet.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkaydet.Location = new System.Drawing.Point(308, 241);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(75, 23);
            this.btnkaydet.TabIndex = 9;
            this.btnkaydet.Text = "Kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(240, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(321, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = " Soyad ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(415, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Şifre";
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.SeaShell;
            this.btngüncelle.FlatAppearance.BorderSize = 0;
            this.btngüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngüncelle.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngüncelle.Location = new System.Drawing.Point(308, 288);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(75, 23);
            this.btngüncelle.TabIndex = 16;
            this.btngüncelle.Text = "Güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.SeaShell;
            this.btnsil.FlatAppearance.BorderSize = 0;
            this.btnsil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsil.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsil.Location = new System.Drawing.Point(215, 241);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(75, 23);
            this.btnsil.TabIndex = 17;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnaç
            // 
            this.btnaç.BackColor = System.Drawing.Color.SeaShell;
            this.btnaç.FlatAppearance.BorderSize = 0;
            this.btnaç.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaç.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnaç.Location = new System.Drawing.Point(215, 288);
            this.btnaç.Name = "btnaç";
            this.btnaç.Size = new System.Drawing.Size(75, 23);
            this.btnaç.TabIndex = 18;
            this.btnaç.Text = "Tabloyu Aç";
            this.btnaç.UseVisualStyleBackColor = false;
            this.btnaç.Click += new System.EventHandler(this.btnaç_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(654, 337);
            this.Controls.Add(this.btnaç);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox studentPicture;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label infolabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsoyad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtad;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtşifre;
        private System.Windows.Forms.Button btnaç;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.ColumnHeader Sıra;
        private System.Windows.Forms.ColumnHeader Ad;
        private System.Windows.Forms.ColumnHeader Soyad;
        private System.Windows.Forms.ColumnHeader Şifre;
    }
}

