namespace SinemaOtomasyonu
{
    partial class GirisSayfasi
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
            this.adminGitBT = new System.Windows.Forms.Button();
            this.calisanGirisBT = new System.Windows.Forms.Button();
            this.musteriGirisBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(272, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giriş Sayfası";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminGitBT
            // 
            this.adminGitBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adminGitBT.Location = new System.Drawing.Point(35, 174);
            this.adminGitBT.Name = "adminGitBT";
            this.adminGitBT.Size = new System.Drawing.Size(210, 125);
            this.adminGitBT.TabIndex = 1;
            this.adminGitBT.Text = "Admin";
            this.adminGitBT.UseVisualStyleBackColor = true;
            this.adminGitBT.Click += new System.EventHandler(this.adminGitBT_Click);
            // 
            // calisanGirisBT
            // 
            this.calisanGirisBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calisanGirisBT.Location = new System.Drawing.Point(251, 174);
            this.calisanGirisBT.Name = "calisanGirisBT";
            this.calisanGirisBT.Size = new System.Drawing.Size(201, 125);
            this.calisanGirisBT.TabIndex = 2;
            this.calisanGirisBT.Text = "Çalışan";
            this.calisanGirisBT.UseVisualStyleBackColor = true;
            this.calisanGirisBT.Click += new System.EventHandler(this.calisanGirisBT_Click);
            // 
            // musteriGirisBT
            // 
            this.musteriGirisBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteriGirisBT.Location = new System.Drawing.Point(458, 174);
            this.musteriGirisBT.Name = "musteriGirisBT";
            this.musteriGirisBT.Size = new System.Drawing.Size(201, 125);
            this.musteriGirisBT.TabIndex = 3;
            this.musteriGirisBT.Text = "Müşteri";
            this.musteriGirisBT.UseVisualStyleBackColor = true;
            this.musteriGirisBT.Click += new System.EventHandler(this.musteriGirisBT_Click);
            // 
            // GirisSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.musteriGirisBT);
            this.Controls.Add(this.calisanGirisBT);
            this.Controls.Add(this.adminGitBT);
            this.Controls.Add(this.label1);
            this.Name = "GirisSayfasi";
            this.Text = "Giriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminGitBT;
        private System.Windows.Forms.Button calisanGirisBT;
        private System.Windows.Forms.Button musteriGirisBT;
    }
}

