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
    public partial class FilmEkleKayit : Form
    {
        public FilmEkleKayit()
        {
            InitializeComponent();
        }

        private void FilmEkleKayit_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet3.FilmBilgi_Trig' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmBilgi_TrigTableAdapter.Fill(this.sinemaOtomasyonuDataSet3.FilmBilgi_Trig);

        }
    }
}
