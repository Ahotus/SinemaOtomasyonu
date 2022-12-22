namespace SinemaOtomasyonu
{
    partial class AdminAnaSayfa
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
            this.filmEkleBT = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.salonEkleBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filmEkleBT
            // 
            this.filmEkleBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.filmEkleBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmEkleBT.Location = new System.Drawing.Point(34, 41);
            this.filmEkleBT.Name = "filmEkleBT";
            this.filmEkleBT.Size = new System.Drawing.Size(176, 100);
            this.filmEkleBT.TabIndex = 1;
            this.filmEkleBT.Text = "Film Ekle/Güncelle";
            this.filmEkleBT.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(235, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 100);
            this.button2.TabIndex = 2;
            this.button2.Text = "Seans  Ekle/Güncelle";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // salonEkleBT
            // 
            this.salonEkleBT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.salonEkleBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salonEkleBT.Location = new System.Drawing.Point(428, 41);
            this.salonEkleBT.Name = "salonEkleBT";
            this.salonEkleBT.Size = new System.Drawing.Size(176, 100);
            this.salonEkleBT.TabIndex = 3;
            this.salonEkleBT.Text = "Salon Ekle/Güncelle";
            this.salonEkleBT.UseVisualStyleBackColor = false;
            this.salonEkleBT.Click += new System.EventHandler(this.salonEkleBT_Click);
            // 
            // AdminAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(627, 169);
            this.Controls.Add(this.salonEkleBT);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.filmEkleBT);
            this.Name = "AdminAnaSayfa";
            this.Text = "AdminAnaSayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button filmEkleBT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button salonEkleBT;
    }
}