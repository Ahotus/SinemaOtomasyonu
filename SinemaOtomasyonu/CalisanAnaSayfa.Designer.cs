namespace SinemaOtomasyonu
{
    partial class CalisanAnaSayfa
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
            this.sinemaOtomasyonuDataSet = new SinemaOtomasyonu.SinemaOtomasyonuDataSet();
            this.filmBİlgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmBİlgiTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSetTableAdapters.FilmBİlgiTableAdapter();
            this.seansBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seansBilgiTableAdapter = new SinemaOtomasyonu.SinemaOtomasyonuDataSetTableAdapters.SeansBilgiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.seansIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seansIdTX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.salonAdTX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyADTX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.adTX = new System.Windows.Forms.TextBox();
            this.Telefon = new System.Windows.Forms.Label();
            this.telefonTX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.listeleBT = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.siraTX = new System.Windows.Forms.TextBox();
            this.biletSatBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sinemaOtomasyonuDataSet
            // 
            this.sinemaOtomasyonuDataSet.DataSetName = "SinemaOtomasyonuDataSet";
            this.sinemaOtomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBİlgiBindingSource
            // 
            this.filmBİlgiBindingSource.DataMember = "FilmBİlgi";
            this.filmBİlgiBindingSource.DataSource = this.sinemaOtomasyonuDataSet;
            // 
            // filmBİlgiTableAdapter
            // 
            this.filmBİlgiTableAdapter.ClearBeforeFill = true;
            // 
            // seansBilgiBindingSource
            // 
            this.seansBilgiBindingSource.DataMember = "SeansBilgi";
            this.seansBilgiBindingSource.DataSource = this.sinemaOtomasyonuDataSet;
            // 
            // seansBilgiTableAdapter
            // 
            this.seansBilgiTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 142);
            this.dataGridView1.TabIndex = 5;
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
            // seansIdTX
            // 
            this.seansIdTX.Location = new System.Drawing.Point(60, 169);
            this.seansIdTX.Name = "seansIdTX";
            this.seansIdTX.Size = new System.Drawing.Size(100, 20);
            this.seansIdTX.TabIndex = 6;
            this.seansIdTX.TextChanged += new System.EventHandler(this.seansIdTX_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seans Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Salon Ad";
            // 
            // salonAdTX
            // 
            this.salonAdTX.Location = new System.Drawing.Point(60, 195);
            this.salonAdTX.Name = "salonAdTX";
            this.salonAdTX.Size = new System.Drawing.Size(100, 20);
            this.salonAdTX.TabIndex = 8;
            this.salonAdTX.TextChanged += new System.EventHandler(this.salonAdTX_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Soy Ad";
            // 
            // soyADTX
            // 
            this.soyADTX.Location = new System.Drawing.Point(300, 198);
            this.soyADTX.Name = "soyADTX";
            this.soyADTX.Size = new System.Drawing.Size(100, 20);
            this.soyADTX.TabIndex = 12;
            this.soyADTX.TextChanged += new System.EventHandler(this.soyADTX_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ad";
            // 
            // adTX
            // 
            this.adTX.Location = new System.Drawing.Point(300, 172);
            this.adTX.Name = "adTX";
            this.adTX.Size = new System.Drawing.Size(100, 20);
            this.adTX.TabIndex = 10;
            this.adTX.TextChanged += new System.EventHandler(this.adTX_TextChanged);
            // 
            // Telefon
            // 
            this.Telefon.AutoSize = true;
            this.Telefon.Location = new System.Drawing.Point(253, 227);
            this.Telefon.Name = "Telefon";
            this.Telefon.Size = new System.Drawing.Size(43, 13);
            this.Telefon.TabIndex = 15;
            this.Telefon.Text = "Telefon";
            // 
            // telefonTX
            // 
            this.telefonTX.Location = new System.Drawing.Point(300, 224);
            this.telefonTX.Name = "telefonTX";
            this.telefonTX.Size = new System.Drawing.Size(100, 20);
            this.telefonTX.TabIndex = 14;
            this.telefonTX.TextChanged += new System.EventHandler(this.telefonTX_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(124, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, 274);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 45);
            this.button3.TabIndex = 18;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 45);
            this.button4.TabIndex = 19;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(388, 274);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 45);
            this.button5.TabIndex = 20;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(476, 274);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 45);
            this.button6.TabIndex = 21;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(36, 325);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 45);
            this.button7.TabIndex = 22;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(124, 325);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 45);
            this.button8.TabIndex = 23;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(210, 325);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 45);
            this.button9.TabIndex = 24;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(298, 325);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 45);
            this.button10.TabIndex = 25;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(386, 325);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 45);
            this.button11.TabIndex = 26;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(474, 325);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(82, 45);
            this.button12.TabIndex = 27;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(36, 376);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(82, 45);
            this.button13.TabIndex = 28;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(124, 376);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(82, 45);
            this.button14.TabIndex = 29;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(210, 376);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(82, 45);
            this.button15.TabIndex = 30;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(298, 376);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(82, 45);
            this.button16.TabIndex = 31;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(388, 376);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(82, 45);
            this.button17.TabIndex = 32;
            this.button17.Text = "17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(474, 376);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(82, 45);
            this.button18.TabIndex = 33;
            this.button18.Text = "18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // listeleBT
            // 
            this.listeleBT.Location = new System.Drawing.Point(43, 227);
            this.listeleBT.Name = "listeleBT";
            this.listeleBT.Size = new System.Drawing.Size(75, 23);
            this.listeleBT.TabIndex = 34;
            this.listeleBT.Text = "listele";
            this.listeleBT.UseVisualStyleBackColor = true;
            this.listeleBT.Click += new System.EventHandler(this.listeleBT_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Sıra";
            // 
            // siraTX
            // 
            this.siraTX.Location = new System.Drawing.Point(476, 172);
            this.siraTX.Name = "siraTX";
            this.siraTX.Size = new System.Drawing.Size(100, 20);
            this.siraTX.TabIndex = 35;
            this.siraTX.TextChanged += new System.EventHandler(this.siraTX_TextChanged);
            // 
            // biletSatBT
            // 
            this.biletSatBT.Location = new System.Drawing.Point(474, 227);
            this.biletSatBT.Name = "biletSatBT";
            this.biletSatBT.Size = new System.Drawing.Size(75, 23);
            this.biletSatBT.TabIndex = 37;
            this.biletSatBT.Text = "Bilet Sat";
            this.biletSatBT.UseVisualStyleBackColor = true;
            this.biletSatBT.Click += new System.EventHandler(this.biletSatBT_Click);
            // 
            // CalisanAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 451);
            this.Controls.Add(this.biletSatBT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.siraTX);
            this.Controls.Add(this.listeleBT);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Telefon);
            this.Controls.Add(this.telefonTX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyADTX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adTX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salonAdTX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.seansIdTX);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CalisanAnaSayfa";
            this.Text = "CalisanAnaSayfa";
            this.Load += new System.EventHandler(this.CalisanAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sinemaOtomasyonuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBİlgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seansBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SinemaOtomasyonuDataSet sinemaOtomasyonuDataSet;
        private System.Windows.Forms.BindingSource filmBİlgiBindingSource;
        private SinemaOtomasyonuDataSetTableAdapters.FilmBİlgiTableAdapter filmBİlgiTableAdapter;
        private System.Windows.Forms.BindingSource seansBilgiBindingSource;
        private SinemaOtomasyonuDataSetTableAdapters.SeansBilgiTableAdapter seansBilgiTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seansIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saatDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox seansIdTX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salonAdTX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox soyADTX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adTX;
        private System.Windows.Forms.Label Telefon;
        private System.Windows.Forms.TextBox telefonTX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button listeleBT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox siraTX;
        private System.Windows.Forms.Button biletSatBT;
    }
}