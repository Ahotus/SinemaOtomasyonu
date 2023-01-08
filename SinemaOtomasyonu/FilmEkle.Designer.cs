namespace SinemaOtomasyonu
{
    partial class FilmEkle
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filmAdıTB = new System.Windows.Forms.TextBox();
            this.tarihTB = new System.Windows.Forms.TextBox();
            this.filmTuruTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinemaOtomasyonuDataSet2 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1();
            this.filmBİlgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBİlgiTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1TableAdapters.FilmBİlgiTableAdapter();
            this.filmNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmEkleBT = new System.Windows.Forms.Button();
            this.filmSilBT = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.filmGuncelleBT = new System.Windows.Forms.Button();
            this.VerileriGoster = new System.Windows.Forms.Button();
            this.eskiFİlmAdıTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(30, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Film Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(58, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // filmAdıTB
            // 
            this.filmAdıTB.Location = new System.Drawing.Point(153, 57);
            this.filmAdıTB.Name = "filmAdıTB";
            this.filmAdıTB.Size = new System.Drawing.Size(121, 20);
            this.filmAdıTB.TabIndex = 3;
            // 
            // tarihTB
            // 
            this.tarihTB.Location = new System.Drawing.Point(153, 127);
            this.tarihTB.Name = "tarihTB";
            this.tarihTB.Size = new System.Drawing.Size(121, 20);
            this.tarihTB.TabIndex = 5;
            // 
            // filmTuruTB
            // 
            this.filmTuruTB.Location = new System.Drawing.Point(153, 92);
            this.filmTuruTB.Name = "filmTuruTB";
            this.filmTuruTB.Size = new System.Drawing.Size(121, 20);
            this.filmTuruTB.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmNoDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.filmTurDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmBİlgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(2, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 203);
            this.dataGridView1.TabIndex = 7;
            // 
            // sinemaOtomasyonuDataSet2
            // 
            this.sinemaOtomasyonuDataSet2.DataSetName = "SinemaOtomasyonuDataSet2";
            this.sinemaOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBİlgiBindingSource
            // 
            this.filmBİlgiBindingSource.DataMember = "FilmBİlgi";
            this.filmBİlgiBindingSource.DataSource = this.sinemaOtomasyonuDataSet2;
            // 
            // filmBİlgiTableAdapter
            // 
            this.filmBİlgiTableAdapter.ClearBeforeFill = true;
            // 
            // filmNoDataGridViewTextBoxColumn
            // 
            this.filmNoDataGridViewTextBoxColumn.DataPropertyName = "FilmNo";
            this.filmNoDataGridViewTextBoxColumn.HeaderText = "FilmNo";
            this.filmNoDataGridViewTextBoxColumn.Name = "filmNoDataGridViewTextBoxColumn";
            this.filmNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            // 
            // filmTurDataGridViewTextBoxColumn
            // 
            this.filmTurDataGridViewTextBoxColumn.DataPropertyName = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.HeaderText = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.Name = "filmTurDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // filmEkleBT
            // 
            this.filmEkleBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmEkleBT.Location = new System.Drawing.Point(409, 54);
            this.filmEkleBT.Name = "filmEkleBT";
            this.filmEkleBT.Size = new System.Drawing.Size(118, 41);
            this.filmEkleBT.TabIndex = 8;
            this.filmEkleBT.Text = "Ekle";
            this.filmEkleBT.UseVisualStyleBackColor = true;
            this.filmEkleBT.Click += new System.EventHandler(this.filmEkleBT_Click);
            // 
            // filmSilBT
            // 
            this.filmSilBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmSilBT.Location = new System.Drawing.Point(409, 101);
            this.filmSilBT.Name = "filmSilBT";
            this.filmSilBT.Size = new System.Drawing.Size(118, 41);
            this.filmSilBT.TabIndex = 9;
            this.filmSilBT.Text = "Sil";
            this.filmSilBT.UseVisualStyleBackColor = true;
            this.filmSilBT.Click += new System.EventHandler(this.filmSilBT_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(409, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 41);
            this.button3.TabIndex = 10;
            this.button3.Text = "İşlem geçmişi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // filmGuncelleBT
            // 
            this.filmGuncelleBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmGuncelleBT.Location = new System.Drawing.Point(409, 148);
            this.filmGuncelleBT.Name = "filmGuncelleBT";
            this.filmGuncelleBT.Size = new System.Drawing.Size(118, 41);
            this.filmGuncelleBT.TabIndex = 11;
            this.filmGuncelleBT.Text = "Güncelle";
            this.filmGuncelleBT.UseVisualStyleBackColor = true;
            this.filmGuncelleBT.Click += new System.EventHandler(this.filmGuncelleBT_Click);
            // 
            // VerileriGoster
            // 
            this.VerileriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VerileriGoster.Location = new System.Drawing.Point(409, 7);
            this.VerileriGoster.Name = "VerileriGoster";
            this.VerileriGoster.Size = new System.Drawing.Size(118, 41);
            this.VerileriGoster.TabIndex = 12;
            this.VerileriGoster.Text = "Verileri Göster";
            this.VerileriGoster.UseVisualStyleBackColor = true;
            this.VerileriGoster.Click += new System.EventHandler(this.VerileriGoster_Click);
            // 
            // eskiFİlmAdıTB
            // 
            this.eskiFİlmAdıTB.Location = new System.Drawing.Point(153, 162);
            this.eskiFİlmAdıTB.Name = "eskiFİlmAdıTB";
            this.eskiFİlmAdıTB.Size = new System.Drawing.Size(121, 20);
            this.eskiFİlmAdıTB.TabIndex = 13;
            this.eskiFİlmAdıTB.TextChanged += new System.EventHandler(this.eskiFİlmAdıTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "EskiFilmAdı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(14, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "*Güncellemek istediğiniz filmin adını eski Fİlm Adına yazınız";
            // 
            // FilmEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(612, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eskiFİlmAdıTB);
            this.Controls.Add(this.VerileriGoster);
            this.Controls.Add(this.filmGuncelleBT);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.filmSilBT);
            this.Controls.Add(this.filmEkleBT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filmTuruTB);
            this.Controls.Add(this.tarihTB);
            this.Controls.Add(this.filmAdıTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FilmEkle";
            this.Text = "FilmEkle";
            this.Load += new System.EventHandler(this.FilmEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filmAdıTB;
        private System.Windows.Forms.TextBox tarihTB;
        private System.Windows.Forms.TextBox filmTuruTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaOtomasyonuDataSet1 sinemaOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource filmBİlgiBindingSource;
        private SinemaOtomasyonuDataSet1TableAdapters.FilmBİlgiTableAdapter filmBİlgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button filmEkleBT;
        private System.Windows.Forms.Button filmSilBT;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button filmGuncelleBT;
        private System.Windows.Forms.Button VerileriGoster;
        private System.Windows.Forms.TextBox eskiFİlmAdıTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}