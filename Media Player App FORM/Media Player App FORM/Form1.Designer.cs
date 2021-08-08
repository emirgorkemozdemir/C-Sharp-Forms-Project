namespace Media_Player_App_FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.lboxad = new System.Windows.Forms.ListBox();
            this.lboxyol = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnçal = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnup = new System.Windows.Forms.Button();
            this.btndown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(547, 70);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // lboxad
            // 
            this.lboxad.FormattingEnabled = true;
            this.lboxad.Location = new System.Drawing.Point(12, 88);
            this.lboxad.Name = "lboxad";
            this.lboxad.Size = new System.Drawing.Size(263, 186);
            this.lboxad.TabIndex = 1;
            this.lboxad.SelectedIndexChanged += new System.EventHandler(this.lboxad_SelectedIndexChanged);
            // 
            // lboxyol
            // 
            this.lboxyol.FormattingEnabled = true;
            this.lboxyol.Location = new System.Drawing.Point(296, 88);
            this.lboxyol.Name = "lboxyol";
            this.lboxyol.Size = new System.Drawing.Size(263, 186);
            this.lboxyol.TabIndex = 2;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(12, 293);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(97, 48);
            this.btnekle.TabIndex = 3;
            this.btnekle.Text = "Müzik Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnçal
            // 
            this.btnçal.Location = new System.Drawing.Point(218, 293);
            this.btnçal.Name = "btnçal";
            this.btnçal.Size = new System.Drawing.Size(97, 48);
            this.btnçal.TabIndex = 4;
            this.btnçal.Text = "Çal";
            this.btnçal.UseVisualStyleBackColor = true;
            this.btnçal.Click += new System.EventHandler(this.btnçal_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(115, 293);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(97, 48);
            this.btnsil.TabIndex = 5;
            this.btnsil.Text = "Müzikleri Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(321, 293);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(97, 48);
            this.btnstop.TabIndex = 6;
            this.btnstop.Text = "Durdur";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnup
            // 
            this.btnup.Location = new System.Drawing.Point(424, 293);
            this.btnup.Name = "btnup";
            this.btnup.Size = new System.Drawing.Size(63, 48);
            this.btnup.TabIndex = 7;
            this.btnup.Text = "+";
            this.btnup.UseVisualStyleBackColor = true;
            this.btnup.Click += new System.EventHandler(this.btnup_Click);
            // 
            // btndown
            // 
            this.btndown.Location = new System.Drawing.Point(496, 293);
            this.btndown.Name = "btndown";
            this.btndown.Size = new System.Drawing.Size(63, 48);
            this.btndown.TabIndex = 8;
            this.btndown.Text = "-";
            this.btndown.UseVisualStyleBackColor = true;
            this.btndown.Click += new System.EventHandler(this.btndown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(571, 402);
            this.Controls.Add(this.btndown);
            this.Controls.Add(this.btnup);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnçal);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lboxyol);
            this.Controls.Add(this.lboxad);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox lboxad;
        private System.Windows.Forms.ListBox lboxyol;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnçal;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnup;
        private System.Windows.Forms.Button btndown;
    }
}

