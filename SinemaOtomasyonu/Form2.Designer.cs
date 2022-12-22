namespace SinemaOtomasyonu
{
    partial class AdminGİrisYap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yanlisGirisLabel = new System.Windows.Forms.Label();
            this.kAdiText = new System.Windows.Forms.TextBox();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sifreyigoster = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // yanlisGirisLabel
            // 
            this.yanlisGirisLabel.AutoSize = true;
            this.yanlisGirisLabel.Location = new System.Drawing.Point(311, 195);
            this.yanlisGirisLabel.Name = "yanlisGirisLabel";
            this.yanlisGirisLabel.Size = new System.Drawing.Size(0, 13);
            this.yanlisGirisLabel.TabIndex = 2;
            this.yanlisGirisLabel.Click += new System.EventHandler(this.yanlisGirisLabel_Click);
            // 
            // kAdiText
            // 
            this.kAdiText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kAdiText.Location = new System.Drawing.Point(238, 68);
            this.kAdiText.Name = "kAdiText";
            this.kAdiText.Size = new System.Drawing.Size(137, 26);
            this.kAdiText.TabIndex = 3;
            // 
            // sifreText
            // 
            this.sifreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreText.Location = new System.Drawing.Point(238, 126);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(137, 26);
            this.sifreText.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(413, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sifreyigoster
            // 
            this.sifreyigoster.AutoSize = true;
            this.sifreyigoster.Checked = true;
            this.sifreyigoster.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sifreyigoster.Location = new System.Drawing.Point(238, 158);
            this.sifreyigoster.Name = "sifreyigoster";
            this.sifreyigoster.Size = new System.Drawing.Size(88, 17);
            this.sifreyigoster.TabIndex = 19;
            this.sifreyigoster.Text = "Şifreyi Göster";
            this.sifreyigoster.UseVisualStyleBackColor = true;
            this.sifreyigoster.CheckedChanged += new System.EventHandler(this.sifreyigoster_CheckedChanged);
            // 
            // AdminGİrisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 240);
            this.Controls.Add(this.sifreyigoster);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.kAdiText);
            this.Controls.Add(this.yanlisGirisLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminGİrisYap";
            this.Text = "Admin Gİriş Sayfası";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label yanlisGirisLabel;
        private System.Windows.Forms.TextBox kAdiText;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox sifreyigoster;
    }
}