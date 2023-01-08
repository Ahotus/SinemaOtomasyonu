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
    public partial class SalonEkleKayit : Form
    {
        public SalonEkleKayit()
        {
            InitializeComponent();
        }

        private void SalonEkleKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet2.Salonbilgi_Trig' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonbilgi_TrigTableAdapter.Fill(this.sinemaOtomasyonuDataSet2.Salonbilgi_Trig);

        }
    }
}
