namespace Hamburger_app_form
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxadsoyad = new System.Windows.Forms.TextBox();
            this.adsoyadlbl = new System.Windows.Forms.Label();
            this.Telefonlbl = new System.Windows.Forms.Label();
            this.txtboxtelefon = new System.Windows.Forms.TextBox();
            this.adreslbl = new System.Windows.Forms.Label();
            this.txtboxadres = new System.Windows.Forms.TextBox();
            this.cmbboxboy = new System.Windows.Forms.ComboBox();
            this.lblboy = new System.Windows.Forms.Label();
            this.chboxket = new System.Windows.Forms.CheckBox();
            this.chboxmay = new System.Windows.Forms.CheckBox();
            this.chboxhar = new System.Windows.Forms.CheckBox();
            this.chboxso = new System.Windows.Forms.CheckBox();
            this.chboxtuz = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lbltuz = new System.Windows.Forms.Label();
            this.lblso = new System.Windows.Forms.Label();
            this.lblhar = new System.Windows.Forms.Label();
            this.lblmay = new System.Windows.Forms.Label();
            this.lblket = new System.Windows.Forms.Label();
            this.lblmenü = new System.Windows.Forms.Label();
            this.teltekrarlbl = new System.Windows.Forms.Label();
            this.adtekrarlbl = new System.Windows.Forms.Label();
            this.btnreg = new System.Windows.Forms.Button();
            this.lstboxadsoyad = new System.Windows.Forms.ListBox();
            this.lstboxtel = new System.Windows.Forms.ListBox();
            this.lstboxadres = new System.Windows.Forms.ListBox();
            this.lstboxboy = new System.Windows.Forms.ListBox();
            this.lstboxextras = new System.Windows.Forms.ListBox();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hambugrer Sipariş Sayfası";
            // 
            // txtboxadsoyad
            // 
            this.txtboxadsoyad.Location = new System.Drawing.Point(108, 63);
            this.txtboxadsoyad.Name = "txtboxadsoyad";
            this.txtboxadsoyad.Size = new System.Drawing.Size(150, 20);
            this.txtboxadsoyad.TabIndex = 2;
            // 
            // adsoyadlbl
            // 
            this.adsoyadlbl.AutoSize = true;
            this.adsoyadlbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.adsoyadlbl.Location = new System.Drawing.Point(3, 64);
            this.adsoyadlbl.Name = "adsoyadlbl";
            this.adsoyadlbl.Size = new System.Drawing.Size(99, 19);
            this.adsoyadlbl.TabIndex = 3;
            this.adsoyadlbl.Text = "Ad Soyad :";
            // 
            // Telefonlbl
            // 
            this.Telefonlbl.AutoSize = true;
            this.Telefonlbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.Telefonlbl.Location = new System.Drawing.Point(3, 106);
            this.Telefonlbl.Name = "Telefonlbl";
            this.Telefonlbl.Size = new System.Drawing.Size(99, 19);
            this.Telefonlbl.TabIndex = 5;
            this.Telefonlbl.Text = "Tel No   :";
            // 
            // txtboxtelefon
            // 
            this.txtboxtelefon.Location = new System.Drawing.Point(108, 107);
            this.txtboxtelefon.Name = "txtboxtelefon";
            this.txtboxtelefon.Size = new System.Drawing.Size(150, 20);
            this.txtboxtelefon.TabIndex = 4;
            // 
            // adreslbl
            // 
            this.adreslbl.AutoSize = true;
            this.adreslbl.Font = new System.Drawing.Font("Consolas", 12F);
            this.adreslbl.Location = new System.Drawing.Point(3, 139);
            this.adreslbl.Name = "adreslbl";
            this.adreslbl.Size = new System.Drawing.Size(99, 19);
            this.adreslbl.TabIndex = 7;
            this.adreslbl.Text = "Adres    :";
            // 
            // txtboxadres
            // 
            this.txtboxadres.Location = new System.Drawing.Point(108, 140);
            this.txtboxadres.Multiline = true;
            this.txtboxadres.Name = "txtboxadres";
            this.txtboxadres.Size = new System.Drawing.Size(150, 92);
            this.txtboxadres.TabIndex = 6;
            // 
            // cmbboxboy
            // 
            this.cmbboxboy.FormattingEnabled = true;
            this.cmbboxboy.Items.AddRange(new object[] {
            "Küçük",
            "Orta",
            "Büyük"});
            this.cmbboxboy.Location = new System.Drawing.Point(108, 258);
            this.cmbboxboy.Name = "cmbboxboy";
            this.cmbboxboy.Size = new System.Drawing.Size(150, 21);
            this.cmbboxboy.TabIndex = 8;
            // 
            // lblboy
            // 
            this.lblboy.AutoSize = true;
            this.lblboy.Font = new System.Drawing.Font("Consolas", 12F);
            this.lblboy.Location = new System.Drawing.Point(3, 257);
            this.lblboy.Name = "lblboy";
            this.lblboy.Size = new System.Drawing.Size(99, 19);
            this.lblboy.TabIndex = 10;
            this.lblboy.Text = "Menü Boyu:";
            // 
            // chboxket
            // 
            this.chboxket.AutoSize = true;
            this.chboxket.Font = new System.Drawing.Font("Consolas", 10F);
            this.chboxket.Location = new System.Drawing.Point(303, 63);
            this.chboxket.Name = "chboxket";
            this.chboxket.Size = new System.Drawing.Size(75, 21);
            this.chboxket.TabIndex = 11;
            this.chboxket.Text = "Ketçap";
            this.chboxket.UseVisualStyleBackColor = true;
            this.chboxket.CheckedChanged += new System.EventHandler(this.chboxket_CheckedChanged);
            // 
            // chboxmay
            // 
            this.chboxmay.AutoSize = true;
            this.chboxmay.Font = new System.Drawing.Font("Consolas", 10F);
            this.chboxmay.Location = new System.Drawing.Point(303, 104);
            this.chboxmay.Name = "chboxmay";
            this.chboxmay.Size = new System.Drawing.Size(83, 21);
            this.chboxmay.TabIndex = 12;
            this.chboxmay.Text = "Mayonez";
            this.chboxmay.UseVisualStyleBackColor = true;
            this.chboxmay.CheckedChanged += new System.EventHandler(this.chboxmay_CheckedChanged);
            // 
            // chboxhar
            // 
            this.chboxhar.AutoSize = true;
            this.chboxhar.Font = new System.Drawing.Font("Consolas", 10F);
            this.chboxhar.Location = new System.Drawing.Point(303, 140);
            this.chboxhar.Name = "chboxhar";
            this.chboxhar.Size = new System.Drawing.Size(75, 21);
            this.chboxhar.TabIndex = 13;
            this.chboxhar.Text = "Hardal";
            this.chboxhar.UseVisualStyleBackColor = true;
            this.chboxhar.CheckedChanged += new System.EventHandler(this.chboxhar_CheckedChanged);
            // 
            // chboxso
            // 
            this.chboxso.AutoSize = true;
            this.chboxso.Font = new System.Drawing.Font("Consolas", 10F);
            this.chboxso.Location = new System.Drawing.Point(303, 184);
            this.chboxso.Name = "chboxso";
            this.chboxso.Size = new System.Drawing.Size(67, 21);
            this.chboxso.TabIndex = 14;
            this.chboxso.Text = "Soğan";
            this.chboxso.UseVisualStyleBackColor = true;
            this.chboxso.CheckedChanged += new System.EventHandler(this.chboxso_CheckedChanged);
            // 
            // chboxtuz
            // 
            this.chboxtuz.AutoSize = true;
            this.chboxtuz.Font = new System.Drawing.Font("Consolas", 10F);
            this.chboxtuz.Location = new System.Drawing.Point(303, 221);
            this.chboxtuz.Name = "chboxtuz";
            this.chboxtuz.Size = new System.Drawing.Size(99, 21);
            this.chboxtuz.TabIndex = 15;
            this.chboxtuz.Text = "Extra Tuz";
            this.chboxtuz.UseVisualStyleBackColor = true;
            this.chboxtuz.CheckedChanged += new System.EventHandler(this.chboxtuz_CheckedChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lbltuz);
            this.groupBox.Controls.Add(this.lblso);
            this.groupBox.Controls.Add(this.lblhar);
            this.groupBox.Controls.Add(this.lblmay);
            this.groupBox.Controls.Add(this.lblket);
            this.groupBox.Controls.Add(this.lblmenü);
            this.groupBox.Controls.Add(this.teltekrarlbl);
            this.groupBox.Controls.Add(this.adtekrarlbl);
            this.groupBox.Location = new System.Drawing.Point(573, 49);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 219);
            this.groupBox.TabIndex = 16;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Siparişiniz";
           
            // 
            // lbltuz
            // 
            this.lbltuz.AutoSize = true;
            this.lbltuz.Font = new System.Drawing.Font("Consolas", 10F);
            this.lbltuz.Location = new System.Drawing.Point(6, 193);
            this.lbltuz.Name = "lbltuz";
            this.lbltuz.Size = new System.Drawing.Size(0, 17);
            this.lbltuz.TabIndex = 23;
            this.lbltuz.Visible = false;
            // 
            // lblso
            // 
            this.lblso.AutoSize = true;
            this.lblso.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblso.Location = new System.Drawing.Point(6, 176);
            this.lblso.Name = "lblso";
            this.lblso.Size = new System.Drawing.Size(0, 17);
            this.lblso.TabIndex = 22;
            this.lblso.Visible = false;
            // 
            // lblhar
            // 
            this.lblhar.AutoSize = true;
            this.lblhar.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblhar.Location = new System.Drawing.Point(6, 158);
            this.lblhar.Name = "lblhar";
            this.lblhar.Size = new System.Drawing.Size(0, 17);
            this.lblhar.TabIndex = 21;
            this.lblhar.Visible = false;
            // 
            // lblmay
            // 
            this.lblmay.AutoSize = true;
            this.lblmay.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblmay.Location = new System.Drawing.Point(6, 141);
            this.lblmay.Name = "lblmay";
            this.lblmay.Size = new System.Drawing.Size(0, 17);
            this.lblmay.TabIndex = 20;
            this.lblmay.Visible = false;
            // 
            // lblket
            // 
            this.lblket.AutoSize = true;
            this.lblket.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblket.Location = new System.Drawing.Point(6, 124);
            this.lblket.Name = "lblket";
            this.lblket.Size = new System.Drawing.Size(0, 17);
            this.lblket.TabIndex = 18;
            this.lblket.Visible = false;
            // 
            // lblmenü
            // 
            this.lblmenü.AutoSize = true;
            this.lblmenü.Font = new System.Drawing.Font("Consolas", 10F);
            this.lblmenü.Location = new System.Drawing.Point(6, 90);
            this.lblmenü.Name = "lblmenü";
            this.lblmenü.Size = new System.Drawing.Size(80, 17);
            this.lblmenü.TabIndex = 19;
            this.lblmenü.Text = "Menü Boyu";
            // 
            // teltekrarlbl
            // 
            this.teltekrarlbl.AutoSize = true;
            this.teltekrarlbl.Font = new System.Drawing.Font("Consolas", 10F);
            this.teltekrarlbl.Location = new System.Drawing.Point(6, 55);
            this.teltekrarlbl.Name = "teltekrarlbl";
            this.teltekrarlbl.Size = new System.Drawing.Size(56, 17);
            this.teltekrarlbl.TabIndex = 18;
            this.teltekrarlbl.Text = "Tel No";
            // 
            // adtekrarlbl
            // 
            this.adtekrarlbl.AutoSize = true;
            this.adtekrarlbl.Font = new System.Drawing.Font("Consolas", 10F);
            this.adtekrarlbl.Location = new System.Drawing.Point(6, 22);
            this.adtekrarlbl.Name = "adtekrarlbl";
            this.adtekrarlbl.Size = new System.Drawing.Size(72, 17);
            this.adtekrarlbl.TabIndex = 17;
            this.adtekrarlbl.Text = "Ad Soyad";
            // 
            // btnreg
            // 
            this.btnreg.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.btnreg.Location = new System.Drawing.Point(108, 298);
            this.btnreg.Name = "btnreg";
            this.btnreg.Size = new System.Drawing.Size(150, 23);
            this.btnreg.TabIndex = 17;
            this.btnreg.Text = "Bilgileri Kaydet";
            this.btnreg.UseVisualStyleBackColor = true;
            this.btnreg.Click += new System.EventHandler(this.btnreg_Click);
            // 
            // lstboxadsoyad
            // 
            this.lstboxadsoyad.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lstboxadsoyad.FormattingEnabled = true;
            this.lstboxadsoyad.Location = new System.Drawing.Point(20, 345);
            this.lstboxadsoyad.Name = "lstboxadsoyad";
            this.lstboxadsoyad.Size = new System.Drawing.Size(140, 95);
            this.lstboxadsoyad.TabIndex = 18;
            // 
            // lstboxtel
            // 
            this.lstboxtel.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lstboxtel.FormattingEnabled = true;
            this.lstboxtel.Location = new System.Drawing.Point(194, 345);
            this.lstboxtel.Name = "lstboxtel";
            this.lstboxtel.Size = new System.Drawing.Size(140, 95);
            this.lstboxtel.TabIndex = 19;
            // 
            // lstboxadres
            // 
            this.lstboxadres.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lstboxadres.FormattingEnabled = true;
            this.lstboxadres.Location = new System.Drawing.Point(369, 345);
            this.lstboxadres.Name = "lstboxadres";
            this.lstboxadres.Size = new System.Drawing.Size(140, 95);
            this.lstboxadres.TabIndex = 20;
            // 
            // lstboxboy
            // 
            this.lstboxboy.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lstboxboy.FormattingEnabled = true;
            this.lstboxboy.Location = new System.Drawing.Point(539, 345);
            this.lstboxboy.Name = "lstboxboy";
            this.lstboxboy.Size = new System.Drawing.Size(140, 95);
            this.lstboxboy.TabIndex = 21;
            // 
            // lstboxextras
            // 
            this.lstboxextras.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.lstboxextras.FormattingEnabled = true;
            this.lstboxextras.Location = new System.Drawing.Point(700, 345);
            this.lstboxextras.Name = "lstboxextras";
            this.lstboxextras.Size = new System.Drawing.Size(140, 95);
            this.lstboxextras.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(852, 464);
            this.Controls.Add(this.lstboxextras);
            this.Controls.Add(this.lstboxboy);
            this.Controls.Add(this.lstboxadres);
            this.Controls.Add(this.lstboxtel);
            this.Controls.Add(this.lstboxadsoyad);
            this.Controls.Add(this.btnreg);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.chboxtuz);
            this.Controls.Add(this.chboxso);
            this.Controls.Add(this.chboxhar);
            this.Controls.Add(this.chboxmay);
            this.Controls.Add(this.chboxket);
            this.Controls.Add(this.lblboy);
            this.Controls.Add(this.cmbboxboy);
            this.Controls.Add(this.adreslbl);
            this.Controls.Add(this.txtboxadres);
            this.Controls.Add(this.Telefonlbl);
            this.Controls.Add(this.txtboxtelefon);
            this.Controls.Add(this.adsoyadlbl);
            this.Controls.Add(this.txtboxadsoyad);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Hamburger App";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxadsoyad;
        private System.Windows.Forms.Label adsoyadlbl;
        private System.Windows.Forms.Label Telefonlbl;
        private System.Windows.Forms.TextBox txtboxtelefon;
        private System.Windows.Forms.Label adreslbl;
        private System.Windows.Forms.TextBox txtboxadres;
        private System.Windows.Forms.ComboBox cmbboxboy;
        private System.Windows.Forms.Label lblboy;
        private System.Windows.Forms.CheckBox chboxket;
        private System.Windows.Forms.CheckBox chboxmay;
        private System.Windows.Forms.CheckBox chboxhar;
        private System.Windows.Forms.CheckBox chboxso;
        private System.Windows.Forms.CheckBox chboxtuz;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblso;
        private System.Windows.Forms.Label lblhar;
        private System.Windows.Forms.Label lblmay;
        private System.Windows.Forms.Label lblket;
        private System.Windows.Forms.Label lblmenü;
        private System.Windows.Forms.Label teltekrarlbl;
        private System.Windows.Forms.Label adtekrarlbl;
        private System.Windows.Forms.Label lbltuz;
        private System.Windows.Forms.Button btnreg;
        private System.Windows.Forms.ListBox lstboxadsoyad;
        private System.Windows.Forms.ListBox lstboxtel;
        private System.Windows.Forms.ListBox lstboxadres;
        private System.Windows.Forms.ListBox lstboxboy;
        private System.Windows.Forms.ListBox lstboxextras;
    }
}

