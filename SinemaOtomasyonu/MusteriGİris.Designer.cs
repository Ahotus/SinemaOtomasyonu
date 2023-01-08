namespace SinemaOtomasyonu
{
    partial class MusteriGİris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.yanlisGirisLabel = new System.Windows.Forms.Label();
            this.girisBT = new System.Windows.Forms.Button();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.kAdiText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreyigoster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // yanlisGirisLabel
            // 
            this.yanlisGirisLabel.AutoSize = true;
            this.yanlisGirisLabel.Location = new System.Drawing.Point(437, 197);
            this.yanlisGirisLabel.Name = "yanlisGirisLabel";
            this.yanlisGirisLabel.Size = new System.Drawing.Size(0, 13);
            this.yanlisGirisLabel.TabIndex = 17;
            // 
            // girisBT
            // 
            this.girisBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisBT.Location = new System.Drawing.Point(462, 116);
            this.girisBT.Name = "girisBT";
            this.girisBT.Size = new System.Drawing.Size(101, 43);
            this.girisBT.TabIndex = 16;
            this.girisBT.Text = "Giriş Yap";
            this.girisBT.UseVisualStyleBackColor = true;
            this.girisBT.Click += new System.EventHandler(this.girisBT_Click);
            // 
            // sifreText
            // 
            this.sifreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreText.Location = new System.Drawing.Point(287, 158);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(137, 26);
            this.sifreText.TabIndex = 15;
            // 
            // kAdiText
            // 
            this.kAdiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdiText.Location = new System.Drawing.Point(287, 100);
            this.kAdiText.Name = "kAdiText";
            this.kAdiText.Size = new System.Drawing.Size(137, 26);
            this.kAdiText.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // sifreyigoster
            // 
            this.sifreyigoster.AutoSize = true;
            this.sifreyigoster.Checked = true;
            this.sifreyigoster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sifreyigoster.Location = new System.Drawing.Point(287, 197);
            this.sifreyigoster.Name = "sifreyigoster";
            this.sifreyigoster.Size = new System.Drawing.Size(88, 17);
            this.sifreyigoster.TabIndex = 18;
            this.sifreyigoster.Text = "Şifreyi Göster";
            this.sifreyigoster.UseVisualStyleBackColor = true;
            this.sifreyigoster.CheckedChanged += new System.EventHandler(this.sifreyigoster_CheckedChanged);
            // 
            // MusteriGİris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(580, 288);
            this.Controls.Add(this.sifreyigoster);
            this.Controls.Add(this.yanlisGirisLabel);
            this.Controls.Add(this.girisBT);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kAdiText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusteriGİris";
            this.Text = "MusteriGİris";
            this.Load += new System.EventHandler(this.MusteriGİris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yanlisGirisLabel;
        private System.Windows.Forms.Button girisBT;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.TextBox kAdiText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sifreyigoster;
    }
}