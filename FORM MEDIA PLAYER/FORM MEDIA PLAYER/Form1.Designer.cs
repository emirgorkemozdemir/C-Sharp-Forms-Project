namespace FORM_MEDIA_PLAYER
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
            this.lboxmusics = new System.Windows.Forms.ListBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnseç = new System.Windows.Forms.Button();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(418, 118);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // lboxmusics
            // 
            this.lboxmusics.FormattingEnabled = true;
            this.lboxmusics.Location = new System.Drawing.Point(12, 136);
            this.lboxmusics.Name = "lboxmusics";
            this.lboxmusics.Size = new System.Drawing.Size(263, 186);
            this.lboxmusics.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.Location = new System.Drawing.Point(281, 136);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(149, 79);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "Müzik Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnseç
            // 
            this.btnseç.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnseç.Location = new System.Drawing.Point(281, 237);
            this.btnseç.Name = "btnseç";
            this.btnseç.Size = new System.Drawing.Size(149, 79);
            this.btnseç.TabIndex = 3;
            this.btnseç.Text = "Müzik Seç";
            this.btnseç.UseVisualStyleBackColor = true;
            this.btnseç.Click += new System.EventHandler(this.btnseç_Click);
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 328);
            this.Controls.Add(this.btnseç);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.lboxmusics);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox lboxmusics;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnseç;
        private System.Windows.Forms.OpenFileDialog ofd1;
    }
}

