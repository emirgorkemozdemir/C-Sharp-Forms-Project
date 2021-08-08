namespace Calculation_rectangle_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnsqr = new System.Windows.Forms.Button();
            this.btnrect = new System.Windows.Forms.Button();
            this.panelsqr = new System.Windows.Forms.Panel();
            this.txtsqr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsqrcal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblsqrrange = new System.Windows.Forms.Label();
            this.lblsqrper = new System.Windows.Forms.Label();
            this.panelrect = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxshort = new System.Windows.Forms.TextBox();
            this.txtboxlong = new System.Windows.Forms.TextBox();
            this.rectcal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblrectrange = new System.Windows.Forms.Label();
            this.lblrectper = new System.Windows.Forms.Label();
            this.panelsqr.SuspendLayout();
            this.panelrect.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose your shape";
            // 
            // btnsqr
            // 
            this.btnsqr.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnsqr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsqr.Location = new System.Drawing.Point(274, 9);
            this.btnsqr.Name = "btnsqr";
            this.btnsqr.Size = new System.Drawing.Size(86, 23);
            this.btnsqr.TabIndex = 1;
            this.btnsqr.Text = "Square";
            this.btnsqr.UseVisualStyleBackColor = true;
            this.btnsqr.Click += new System.EventHandler(this.btnsqr_Click);
            // 
            // btnrect
            // 
            this.btnrect.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnrect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrect.Location = new System.Drawing.Point(403, 9);
            this.btnrect.Name = "btnrect";
            this.btnrect.Size = new System.Drawing.Size(86, 23);
            this.btnrect.TabIndex = 2;
            this.btnrect.Text = "Rectangle";
            this.btnrect.UseVisualStyleBackColor = true;
            this.btnrect.Click += new System.EventHandler(this.btnrect_Click);
            // 
            // panelsqr
            // 
            this.panelsqr.Controls.Add(this.lblsqrper);
            this.panelsqr.Controls.Add(this.lblsqrrange);
            this.panelsqr.Controls.Add(this.label4);
            this.panelsqr.Controls.Add(this.label3);
            this.panelsqr.Controls.Add(this.btnsqrcal);
            this.panelsqr.Controls.Add(this.label2);
            this.panelsqr.Controls.Add(this.txtsqr);
            this.panelsqr.Location = new System.Drawing.Point(16, 106);
            this.panelsqr.Name = "panelsqr";
            this.panelsqr.Size = new System.Drawing.Size(465, 274);
            this.panelsqr.TabIndex = 3;
            this.panelsqr.Visible = false;
            // 
            // txtsqr
            // 
            this.txtsqr.Location = new System.Drawing.Point(240, 27);
            this.txtsqr.Name = "txtsqr";
            this.txtsqr.Size = new System.Drawing.Size(100, 20);
            this.txtsqr.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your edge :";
            // 
            // btnsqrcal
            // 
            this.btnsqrcal.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.btnsqrcal.Location = new System.Drawing.Point(252, 74);
            this.btnsqrcal.Name = "btnsqrcal";
            this.btnsqrcal.Size = new System.Drawing.Size(79, 60);
            this.btnsqrcal.TabIndex = 5;
            this.btnsqrcal.Text = "Calculate";
            this.btnsqrcal.UseVisualStyleBackColor = true;
            this.btnsqrcal.Click += new System.EventHandler(this.btnsqrcal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(3, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(3, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Perimeter:";
            // 
            // lblsqrrange
            // 
            this.lblsqrrange.AutoSize = true;
            this.lblsqrrange.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsqrrange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsqrrange.Location = new System.Drawing.Point(97, 91);
            this.lblsqrrange.Name = "lblsqrrange";
            this.lblsqrrange.Size = new System.Drawing.Size(0, 23);
            this.lblsqrrange.TabIndex = 8;
            this.lblsqrrange.Visible = false;
            // 
            // lblsqrper
            // 
            this.lblsqrper.AutoSize = true;
            this.lblsqrper.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsqrper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsqrper.Location = new System.Drawing.Point(149, 134);
            this.lblsqrper.Name = "lblsqrper";
            this.lblsqrper.Size = new System.Drawing.Size(0, 23);
            this.lblsqrper.TabIndex = 9;
            this.lblsqrper.Visible = false;
            // 
            // panelrect
            // 
            this.panelrect.Controls.Add(this.lblrectper);
            this.panelrect.Controls.Add(this.lblrectrange);
            this.panelrect.Controls.Add(this.label8);
            this.panelrect.Controls.Add(this.label7);
            this.panelrect.Controls.Add(this.rectcal);
            this.panelrect.Controls.Add(this.txtboxlong);
            this.panelrect.Controls.Add(this.txtboxshort);
            this.panelrect.Controls.Add(this.label6);
            this.panelrect.Controls.Add(this.label5);
            this.panelrect.Location = new System.Drawing.Point(16, 106);
            this.panelrect.Name = "panelrect";
            this.panelrect.Size = new System.Drawing.Size(465, 271);
            this.panelrect.TabIndex = 4;
            this.panelrect.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(309, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter Your Short Edge :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(3, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "Enter Your Long Edge :";
            // 
            // txtboxshort
            // 
            this.txtboxshort.Location = new System.Drawing.Point(318, 27);
            this.txtboxshort.Name = "txtboxshort";
            this.txtboxshort.Size = new System.Drawing.Size(115, 20);
            this.txtboxshort.TabIndex = 5;
            // 
            // txtboxlong
            // 
            this.txtboxlong.Location = new System.Drawing.Point(318, 94);
            this.txtboxlong.Name = "txtboxlong";
            this.txtboxlong.Size = new System.Drawing.Size(115, 20);
            this.txtboxlong.TabIndex = 6;
            // 
            // rectcal
            // 
            this.rectcal.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.rectcal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rectcal.Location = new System.Drawing.Point(332, 136);
            this.rectcal.Name = "rectcal";
            this.rectcal.Size = new System.Drawing.Size(86, 63);
            this.rectcal.TabIndex = 7;
            this.rectcal.Text = "Calculate";
            this.rectcal.UseVisualStyleBackColor = true;
            this.rectcal.Click += new System.EventHandler(this.rectcal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(3, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Range :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(3, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Perimeter :";
            // 
            // lblrectrange
            // 
            this.lblrectrange.AutoSize = true;
            this.lblrectrange.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrectrange.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrectrange.Location = new System.Drawing.Point(110, 154);
            this.lblrectrange.Name = "lblrectrange";
            this.lblrectrange.Size = new System.Drawing.Size(0, 23);
            this.lblrectrange.TabIndex = 10;
            this.lblrectrange.Visible = false;
            // 
            // lblrectper
            // 
            this.lblrectper.AutoSize = true;
            this.lblrectper.Font = new System.Drawing.Font("Courier New", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblrectper.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblrectper.Location = new System.Drawing.Point(162, 191);
            this.lblrectper.Name = "lblrectper";
            this.lblrectper.Size = new System.Drawing.Size(0, 23);
            this.lblrectper.TabIndex = 11;
            this.lblrectper.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelrect);
            this.Controls.Add(this.panelsqr);
            this.Controls.Add(this.btnrect);
            this.Controls.Add(this.btnsqr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Square & Rectangle Calculations";
            this.panelsqr.ResumeLayout(false);
            this.panelsqr.PerformLayout();
            this.panelrect.ResumeLayout(false);
            this.panelrect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsqr;
        private System.Windows.Forms.Button btnrect;
        private System.Windows.Forms.Panel panelsqr;
        private System.Windows.Forms.TextBox txtsqr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblsqrper;
        private System.Windows.Forms.Label lblsqrrange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsqrcal;
        private System.Windows.Forms.Panel panelrect;
        private System.Windows.Forms.Label lblrectper;
        private System.Windows.Forms.Label lblrectrange;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button rectcal;
        private System.Windows.Forms.TextBox txtboxlong;
        private System.Windows.Forms.TextBox txtboxshort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

