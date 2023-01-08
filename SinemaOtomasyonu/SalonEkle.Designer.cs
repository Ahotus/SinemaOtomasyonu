namespace SinemaOtomasyonu
{
    partial class SalonEkle
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
            this.salonAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salonIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonbilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaOtomasyonuDataSet1 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1();
            this.SilBT = new System.Windows.Forms.Button();
            this.salonbilgiTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1TableAdapters.SalonbilgiTableAdapter();
            this.VeriGetir = new System.Windows.Forms.Button();
            this.islemGecBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon No";
            // 
            // salonAd
            // 
            this.salonAd.Location = new System.Drawing.Point(156, 29);
            this.salonAd.Name = "salonAd";
            this.salonAd.Size = new System.Drawing.Size(100, 20);
            this.salonAd.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(328, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salonIdDataGridViewTextBoxColumn,
            this.salonAdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salonbilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // salonIdDataGridViewTextBoxColumn
            // 
            this.salonIdDataGridViewTextBoxColumn.DataPropertyName = "SalonId";
            this.salonIdDataGridViewTextBoxColumn.HeaderText = "SalonId";
            this.salonIdDataGridViewTextBoxColumn.Name = "salonIdDataGridViewTextBoxColumn";
            this.salonIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salonAdDataGridViewTextBoxColumn
            // 
            this.salonAdDataGridViewTextBoxColumn.DataPropertyName = "SalonAd";
            this.salonAdDataGridViewTextBoxColumn.HeaderText = "SalonAd";
            this.salonAdDataGridViewTextBoxColumn.Name = "salonAdDataGridViewTextBoxColumn";
            // 
            // salonbilgiBindingSource
            // 
            this.salonbilgiBindingSource.DataMember = "Salonbilgi";
            this.salonbilgiBindingSource.DataSource = this.sinemaOtomasyonuDataSet1;
            // 
            // sinemaOtomasyonuDataSet1
            // 
            this.sinemaOtomasyonuDataSet1.DataSetName = "SinemaOtomasyonuDataSet1";
            this.sinemaOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SilBT
            // 
            this.SilBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBT.Location = new System.Drawing.Point(328, 61);
            this.SilBT.Name = "SilBT";
            this.SilBT.Size = new System.Drawing.Size(103, 43);
            this.SilBT.TabIndex = 6;
            this.SilBT.Text = "Sil";
            this.SilBT.UseVisualStyleBackColor = true;
            this.SilBT.Click += new System.EventHandler(this.SilBT_Click);
            // 
            // salonbilgiTableAdapter
            // 
            this.salonbilgiTableAdapter.ClearBeforeFill = true;
            // 
            // VeriGetir
            // 
            this.VeriGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.VeriGetir.Location = new System.Drawing.Point(328, 110);
            this.VeriGetir.Name = "VeriGetir";
            this.VeriGetir.Size = new System.Drawing.Size(103, 43);
            this.VeriGetir.TabIndex = 8;
            this.VeriGetir.Text = "Verileri getir";
            this.VeriGetir.UseVisualStyleBackColor = true;
            this.VeriGetir.Click += new System.EventHandler(this.VeriGetir_Click);
            // 
            // islemGecBT
            // 
            this.islemGecBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemGecBT.Location = new System.Drawing.Point(328, 159);
            this.islemGecBT.Name = "islemGecBT";
            this.islemGecBT.Size = new System.Drawing.Size(103, 43);
            this.islemGecBT.TabIndex = 9;
            this.islemGecBT.Text = "İşlem Geçmişi";
            this.islemGecBT.UseVisualStyleBackColor = true;
            this.islemGecBT.Click += new System.EventHandler(this.islemGecBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Salon Silmek İçin Salon no kısmına SalonId yazınız";
            // 
            // SalonEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(462, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.islemGecBT);
            this.Controls.Add(this.VeriGetir);
            this.Controls.Add(this.SilBT);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.salonAd);
            this.Controls.Add(this.label1);
            this.Name = "SalonEkle";
            this.Text = "Salon Ekle/Güncelle";
            this.Load += new System.EventHandler(this.SalonEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salonAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SilBT;
        private SinemaOtomasyonuDataSet1 sinemaOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource salonbilgiBindingSource;
        private SinemaOtomasyonuDataSet1TableAdapters.SalonbilgiTableAdapter salonbilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button VeriGetir;
        private System.Windows.Forms.Button islemGecBT;
        private System.Windows.Forms.Label label2;
    }
}