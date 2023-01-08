namespace SinemaOtomasyonu
{
    partial class MusteriAnaSayfa
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
            this.biletId = new System.Windows.Forms.TextBox();
            this.Sorgula = new System.Windows.Forms.Button();
            this.gosterL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilet Numarası";
            // 
            // biletId
            // 
            this.biletId.Location = new System.Drawing.Point(126, 28);
            this.biletId.Name = "biletId";
            this.biletId.Size = new System.Drawing.Size(100, 20);
            this.biletId.TabIndex = 1;
            // 
            // Sorgula
            // 
            this.Sorgula.Location = new System.Drawing.Point(86, 73);
            this.Sorgula.Name = "Sorgula";
            this.Sorgula.Size = new System.Drawing.Size(75, 23);
            this.Sorgula.TabIndex = 2;
            this.Sorgula.Text = "Sorgula";
            this.Sorgula.UseVisualStyleBackColor = true;
            this.Sorgula.Click += new System.EventHandler(this.Sorgula_Click);
            // 
            // gosterL
            // 
            this.gosterL.AutoSize = true;
            this.gosterL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gosterL.Location = new System.Drawing.Point(361, 47);
            this.gosterL.Name = "gosterL";
            this.gosterL.Size = new System.Drawing.Size(0, 20);
            this.gosterL.TabIndex = 3;
            // 
            // MusteriAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 333);
            this.Controls.Add(this.gosterL);
            this.Controls.Add(this.Sorgula);
            this.Controls.Add(this.biletId);
            this.Controls.Add(this.label1);
            this.Name = "MusteriAnaSayfa";
            this.Text = "MusteriAnaSayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox biletId;
        private System.Windows.Forms.Button Sorgula;
        private System.Windows.Forms.Label gosterL;
    }
}