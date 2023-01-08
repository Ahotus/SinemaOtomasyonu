namespace SinemaOtomasyonu
{
    partial class SalonEkleKayit
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
            this.sinemaOtomasyonuDataSet2 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1();
            this.salonbilgiTrigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salonbilgi_TrigTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1TableAdapters.Salonbilgi_TrigTableAdapter();
            this.islemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgiTrigBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemidDataGridViewTextBoxColumn,
            this.islemturuDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salonbilgiTrigBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // sinemaOtomasyonuDataSet2
            // 
            this.sinemaOtomasyonuDataSet2.DataSetName = "SinemaOtomasyonuDataSet2";
            this.sinemaOtomasyonuDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salonbilgiTrigBindingSource
            // 
            this.salonbilgiTrigBindingSource.DataMember = "Salonbilgi_Trig";
            this.salonbilgiTrigBindingSource.DataSource = this.sinemaOtomasyonuDataSet2;
            // 
            // salonbilgi_TrigTableAdapter
            // 
            this.salonbilgi_TrigTableAdapter.ClearBeforeFill = true;
            // 
            // islemidDataGridViewTextBoxColumn
            // 
            this.islemidDataGridViewTextBoxColumn.DataPropertyName = "islemid";
            this.islemidDataGridViewTextBoxColumn.HeaderText = "islemid";
            this.islemidDataGridViewTextBoxColumn.Name = "islemidDataGridViewTextBoxColumn";
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
            // SalonEkleKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 246);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SalonEkleKayit";
            this.Text = "SalonEkleKayit";
            this.Load += new System.EventHandler(this.SalonEkleKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonbilgiTrigBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaOtomasyonuDataSet1 sinemaOtomasyonuDataSet2;
        private System.Windows.Forms.BindingSource salonbilgiTrigBindingSource;
        private SinemaOtomasyonuDataSet1TableAdapters.Salonbilgi_TrigTableAdapter salonbilgi_TrigTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
    }
}