using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaOtomasyonu
{
    public partial class SeansEkleKayit : Form
    {
        public SeansEkleKayit()
        {
            InitializeComponent();
        }

        private void SeansEkleKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet1.SeansbilgiTrig' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seansbilgiTrigTableAdapter.Fill(this.sinemaOtomasyonuDataSet1.SeansbilgiTrig);
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet4.SeansBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seansBilgiTableAdapter.Fill(this.sinemaOtomasyonuDataSet4.SeansBilgi);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
