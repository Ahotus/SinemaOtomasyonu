namespace SinemaOtomasyonu
{
    partial class SeansEkle
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.saatsecimi = new System.Windows.Forms.ComboBox();
            this.verileriGosterBT = new System.Windows.Forms.Button();
            this.seansSilBT = new System.Windows.Forms.Button();
            this.seansEkleBT = new System.Windows.Forms.Button();
            this.islemgecmisi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.filmBİlgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sinemaOtomasyonuDataSet3 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1();
            this.filmBİlgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBİlgiTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1TableAdapters.FilmBİlgiTableAdapter();
            this.sinemaOtomasyonuDataSet4 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet4();
            this.seansBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansBilgiTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet4TableAdapters.SeansBilgiTableAdapter();
            this.seansIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filmBİlgiBindingSource1, "FilmAd", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fİlm Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salon Adı";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filmBİlgiBindingSource1, "FilmAd", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(50, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tarih";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 131);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(50, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Saat";
            // 
            // saatsecimi
            // 
            this.saatsecimi.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filmBİlgiBindingSource1, "FilmAd", true));
            this.saatsecimi.FormattingEnabled = true;
            this.saatsecimi.Items.AddRange(new object[] {
            "11:00",
            "13:00",
            "15:00",
            "17:00",
            "19:00"});
            this.saatsecimi.Location = new System.Drawing.Point(126, 157);
            this.saatsecimi.Name = "saatsecimi";
            this.saatsecimi.Size = new System.Drawing.Size(121, 21);
            this.saatsecimi.TabIndex = 7;
            this.saatsecimi.SelectedIndexChanged += new System.EventHandler(this.saatsecimi_SelectedIndexChanged);
            // 
            // verileriGosterBT
            // 
            this.verileriGosterBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verileriGosterBT.Location = new System.Drawing.Point(387, 22);
            this.verileriGosterBT.Name = "verileriGosterBT";
            this.verileriGosterBT.Size = new System.Drawing.Size(99, 34);
            this.verileriGosterBT.TabIndex = 8;
            this.verileriGosterBT.Text = "Verileri göster";
            this.verileriGosterBT.UseVisualStyleBackColor = true;
            this.verileriGosterBT.Click += new System.EventHandler(this.verileriGosterBT_Click);
            // 
            // seansSilBT
            // 
            this.seansSilBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seansSilBT.Location = new System.Drawing.Point(387, 104);
            this.seansSilBT.Name = "seansSilBT";
            this.seansSilBT.Size = new System.Drawing.Size(99, 34);
            this.seansSilBT.TabIndex = 9;
            this.seansSilBT.Text = "Sil";
            this.seansSilBT.UseVisualStyleBackColor = true;
            this.seansSilBT.Click += new System.EventHandler(this.seansSilBT_Click);
            // 
            // seansEkleBT
            // 
            this.seansEkleBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seansEkleBT.Location = new System.Drawing.Point(387, 64);
            this.seansEkleBT.Name = "seansEkleBT";
            this.seansEkleBT.Size = new System.Drawing.Size(99, 34);
            this.seansEkleBT.TabIndex = 10;
            this.seansEkleBT.Text = "Ekle";
            this.seansEkleBT.UseVisualStyleBackColor = true;
            this.seansEkleBT.Click += new System.EventHandler(this.seansEkleBT_Click);
            // 
            // islemgecmisi
            // 
            this.islemgecmisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.islemgecmisi.Location = new System.Drawing.Point(387, 144);
            this.islemgecmisi.Name = "islemgecmisi";
            this.islemgecmisi.Size = new System.Drawing.Size(99, 34);
            this.islemgecmisi.TabIndex = 11;
            this.islemgecmisi.Text = "İşlem geçmişi";
            this.islemgecmisi.UseVisualStyleBackColor = true;
            this.islemgecmisi.Click += new System.EventHandler(this.islemgecmisi_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seansIdDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.salonAdDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.saatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.seansBilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(560, 123);
            this.dataGridView1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Id (sadece silme işlemlerinde kullanılır)";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(260, 32);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 15;
            // 
            // filmBİlgiBindingSource1
            // 
            this.filmBİlgiBindingSource1.DataMember = "FilmBİlgi";
            this.filmBİlgiBindingSource1.DataSource = this.sinemaOtomasyonuDataSet3;
            // 
            // sinemaOtomasyonuDataSet3
            // 
            this.sinemaOtomasyonuDataSet3.DataSetName = "SinemaOtomasyonuDataSet3";
            this.sinemaOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBİlgiBindingSource
            // 
            this.filmBİlgiBindingSource.DataMember = "FilmBİlgi";
            this.filmBİlgiBindingSource.DataSource = this.sinemaOtomasyonuDataSet3;
            // 
            // filmBİlgiTableAdapter
            // 
            this.filmBİlgiTableAdapter.ClearBeforeFill = true;
            // 
            // sinemaOtomasyonuDataSet4
            // 
            this.sinemaOtomasyonuDataSet4.DataSetName = "SinemaOtomasyonuDataSet4";
            this.sinemaOtomasyonuDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seansBilgiBindingSource
            // 
            this.seansBilgiBindingSource.DataMember = "SeansBilgi";
            this.seansBilgiBindingSource.DataSource = this.sinemaOtomasyonuDataSet4;
            // 
            // seansBilgiTableAdapter
            // 
            this.seansBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // seansIdDataGridViewTextBoxColumn
            // 
            this.seansIdDataGridViewTextBoxColumn.DataPropertyName = "SeansId";
            this.seansIdDataGridViewTextBoxColumn.HeaderText = "SeansId";
            this.seansIdDataGridViewTextBoxColumn.Name = "seansIdDataGridViewTextBoxColumn";
            this.seansIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            // 
            // salonAdDataGridViewTextBoxColumn
            // 
            this.salonAdDataGridViewTextBoxColumn.DataPropertyName = "SalonAd";
            this.salonAdDataGridViewTextBoxColumn.HeaderText = "SalonAd";
            this.salonAdDataGridViewTextBoxColumn.Name = "salonAdDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // saatDataGridViewTextBoxColumn
            // 
            this.saatDataGridViewTextBoxColumn.DataPropertyName = "saat";
            this.saatDataGridViewTextBoxColumn.HeaderText = "saat";
            this.saatDataGridViewTextBoxColumn.Name = "saatDataGridViewTextBoxColumn";
            // 
            // SeansEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 301);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.islemgecmisi);
            this.Controls.Add(this.seansEkleBT);
            this.Controls.Add(this.seansSilBT);
            this.Controls.Add(this.verileriGosterBT);
            this.Controls.Add(this.saatsecimi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "SeansEkle";
            this.Text = "SeansEkle";
            this.Load += new System.EventHandler(this.SeansEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private SinemaOtomasyonuDataSet1 sinemaOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource filmBİlgiBindingSource;
        private SinemaOtomasyonuDataSet1TableAdapters.FilmBİlgiTableAdapter filmBİlgiTableAdapter;
        private System.Windows.Forms.BindingSource filmBİlgiBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox saatsecimi;
        private System.Windows.Forms.Button verileriGosterBT;
        private System.Windows.Forms.Button seansSilBT;
        private System.Windows.Forms.Button seansEkleBT;
        private System.Windows.Forms.Button islemgecmisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private SinemaOtomasyonuDataSet4 sinemaOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource seansBilgiBindingSource;
        private SinemaOtomasyonuDataSet4TableAdapters.SeansBilgiTableAdapter seansBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
    }
}