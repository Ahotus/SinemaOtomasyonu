namespace SinemaOtomasyonu
{
    partial class SeansEkleKayit
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
            this.sinemaOtomasyonuDataSet4 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet4();
            this.seansBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansBilgiTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet4TableAdapters.SeansBilgiTableAdapter();
            this.sinemaOtomasyonuDataSet1 = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1();
            this.seansbilgiTrigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansbilgiTrigTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSet1TableAdapters.SeansbilgiTrigTableAdapter();
            this.islemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansbilgiTrigBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansbilgiTrigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansbilgiTrigBindingSource1)).BeginInit();
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
            this.dataGridView1.DataSource = this.seansbilgiTrigBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 328);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // sinemaOtomasyonuDataSet1
            // 
            this.sinemaOtomasyonuDataSet1.DataSetName = "SinemaOtomasyonuDataSet1";
            this.sinemaOtomasyonuDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // seansbilgiTrigBindingSource
            // 
            this.seansbilgiTrigBindingSource.DataMember = "SeansbilgiTrig";
            this.seansbilgiTrigBindingSource.DataSource = this.sinemaOtomasyonuDataSet1;
            // 
            // seansbilgiTrigTableAdapter
            // 
            this.seansbilgiTrigTableAdapter.ClearBeforeFill = true;
            // 
            // islemidDataGridViewTextBoxColumn
            // 
            this.islemidDataGridViewTextBoxColumn.DataPropertyName = "islemid";
            this.islemidDataGridViewTextBoxColumn.HeaderText = "islemid";
            this.islemidDataGridViewTextBoxColumn.Name = "islemidDataGridViewTextBoxColumn";
            this.islemidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // seansbilgiTrigBindingSource1
            // 
            this.seansbilgiTrigBindingSource1.DataMember = "SeansbilgiTrig";
            this.seansbilgiTrigBindingSource1.DataSource = this.sinemaOtomasyonuDataSet1;
            // 
            // SeansEkleKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 315);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SeansEkleKayit";
            this.Text = "SeansEkleKayit";
            this.Load += new System.EventHandler(this.SeansEkleKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansbilgiTrigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansbilgiTrigBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SinemaOtomasyonuDataSet4 sinemaOtomasyonuDataSet4;
        private System.Windows.Forms.BindingSource seansBilgiBindingSource;
        private SinemaOtomasyonuDataSet4TableAdapters.SeansBilgiTableAdapter seansBilgiTableAdapter;
        private SinemaOtomasyonuDataSet1 sinemaOtomasyonuDataSet1;
        private System.Windows.Forms.BindingSource seansbilgiTrigBindingSource;
        private SinemaOtomasyonuDataSet1TableAdapters.SeansbilgiTrigTableAdapter seansbilgiTrigTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seansbilgiTrigBindingSource1;
    }
}