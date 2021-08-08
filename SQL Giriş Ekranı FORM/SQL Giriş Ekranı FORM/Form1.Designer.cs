namespace SQL_Giriş_Ekranı_FORM
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtboxNick = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.InfoLabel1 = new System.Windows.Forms.Label();
            this.InfoLabel2 = new System.Windows.Forms.Label();
            this.txtboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txtboxNick
            // 
            this.txtboxNick.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtboxNick.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtboxNick.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtboxNick.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxNick.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxNick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxNick.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxNick.HintText = "";
            this.txtboxNick.isPassword = false;
            this.txtboxNick.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxNick.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxNick.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxNick.LineThickness = 4;
            this.txtboxNick.Location = new System.Drawing.Point(37, 70);
            this.txtboxNick.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtboxNick.MaxLength = 32767;
            this.txtboxNick.Name = "txtboxNick";
            this.txtboxNick.Size = new System.Drawing.Size(280, 46);
            this.txtboxNick.TabIndex = 0;
            this.txtboxNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // InfoLabel1
            // 
            this.InfoLabel1.AutoSize = true;
            this.InfoLabel1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel1.Location = new System.Drawing.Point(102, 20);
            this.InfoLabel1.Name = "InfoLabel1";
            this.InfoLabel1.Size = new System.Drawing.Size(146, 33);
            this.InfoLabel1.TabIndex = 2;
            this.InfoLabel1.Text = "Kullanıcı Adı";
            // 
            // InfoLabel2
            // 
            this.InfoLabel2.AutoSize = true;
            this.InfoLabel2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.InfoLabel2.Location = new System.Drawing.Point(140, 176);
            this.InfoLabel2.Name = "InfoLabel2";
            this.InfoLabel2.Size = new System.Drawing.Size(66, 33);
            this.InfoLabel2.TabIndex = 4;
            this.InfoLabel2.Text = "Şifre";
            // 
            // txtboxPassword
            // 
            this.txtboxPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtboxPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtboxPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtboxPassword.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtboxPassword.HintText = "";
            this.txtboxPassword.isPassword = true;
            this.txtboxPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtboxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtboxPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtboxPassword.LineThickness = 4;
            this.txtboxPassword.Location = new System.Drawing.Point(37, 231);
            this.txtboxPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtboxPassword.MaxLength = 32767;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.Size = new System.Drawing.Size(280, 47);
            this.txtboxPassword.TabIndex = 3;
            this.txtboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(108, 303);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(140, 56);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(359, 394);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.InfoLabel2);
            this.Controls.Add(this.txtboxPassword);
            this.Controls.Add(this.InfoLabel1);
            this.Controls.Add(this.txtboxNick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label InfoLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxPassword;
        private System.Windows.Forms.Label InfoLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtboxNick;
    }
}

