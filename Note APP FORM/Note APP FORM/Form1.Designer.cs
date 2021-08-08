namespace Note_APP_FORM
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
            this.dp1 = new System.Windows.Forms.DateTimePicker();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtboxnote = new System.Windows.Forms.RichTextBox();
            this.dg1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // dp1
            // 
            this.dp1.CalendarFont = new System.Drawing.Font("Bahnschrift SemiCondensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dp1.Location = new System.Drawing.Point(12, 12);
            this.dp1.Name = "dp1";
            this.dp1.Size = new System.Drawing.Size(200, 20);
            this.dp1.TabIndex = 0;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsave.Location = new System.Drawing.Point(12, 38);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(200, 55);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Notu Kaydet";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtboxnote
            // 
            this.txtboxnote.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxnote.Location = new System.Drawing.Point(218, 12);
            this.txtboxnote.Name = "txtboxnote";
            this.txtboxnote.Size = new System.Drawing.Size(337, 81);
            this.txtboxnote.TabIndex = 2;
            this.txtboxnote.Text = "";
            // 
            // dg1
            // 
            this.dg1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg1.Location = new System.Drawing.Point(12, 108);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(543, 208);
            this.dg1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(567, 328);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.txtboxnote);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dp1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.DateTimePicker dp1;
        private System.Windows.Forms.RichTextBox txtboxnote;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.DataGridView dg1;
    }
}

