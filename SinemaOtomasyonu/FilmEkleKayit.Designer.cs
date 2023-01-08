namespace SinemaOtomasyonu
{
    partial class FilmEkleKayit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sinemaOtomasyonuDataSet3 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1();
            this.sinemaOtomasyonuDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBilgiTrigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBilgi_TrigTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1TableAdapters.FilmBilgi_TrigTableAdapter();
            this.islemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBilgiTrigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemIdDataGridViewTextBoxColumn,
            this.islemturuDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmBilgiTrigBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // sinemaOtomasyonuDataSet3
            // 
            this.sinemaOtomasyonuDataSet3.DataSetName = "SinemaOtomasyonuDataSet3";
            this.sinemaOtomasyonuDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinemaOtomasyonuDataSet3BindingSource
            // 
            this.sinemaOtomasyonuDataSet3BindingSource.DataSource = this.sinemaOtomasyonuDataSet3;
            this.sinemaOtomasyonuDataSet3BindingSource.Position = 0;
            // 
            // filmBilgiTrigBindingSource
            // 
            this.filmBilgiTrigBindingSource.DataMember = "FilmBilgi_Trig";
            this.filmBilgiTrigBindingSource.DataSource = this.sinemaOtomasyonuDataSet3BindingSource;
            // 
            // filmBilgi_TrigTableAdapter
            // 
            this.filmBilgi_TrigTableAdapter.ClearBeforeFill = true;
            // 
            // islemIdDataGridViewTextBoxColumn
            // 
            this.islemIdDataGridViewTextBoxColumn.DataPropertyName = "islemId";
            this.islemIdDataGridViewTextBoxColumn.HeaderText = "islemId";
            this.islemIdDataGridViewTextBoxColumn.Name = "islemIdDataGridViewTextBoxColumn";
            this.islemIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // islemturuDataGridViewTextBoxColumn
            // 
            this.islemturuDataGridViewTextBoxColumn.DataPropertyName = "islemturu";
            this.islemturuDataGridViewTextBoxColumn.HeaderText = "islemturu";
            this.islemturuDataGridViewTextBoxColumn.Name = "islemturuDataGridViewTextBoxColumn";
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "durum";
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            // 
            // FilmEkleKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 211);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FilmEkleKayit";
            this.Text = "FilmEkleKayit";
            this.Load += new System.EventHandler(this.FilmEkleKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBilgiTrigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource sinemaOtomasyonuDataSet3BindingSource;
        private SinemaOtomasyonuDataSet1 sinemaOtomasyonuDataSet3;
        private System.Windows.Forms.BindingSource filmBilgiTrigBindingSource;
        private SinemaOtomasyonuDataSet1TableAdapters.FilmBilgi_TrigTableAdapter filmBilgi_TrigTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
    }
}