using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SinemaOtomasyonu
{
    public partial class FilmEkle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-S8DVTVD; Initial Catalog = SinemaOtomasyonu; Integrated Security = True");

        public FilmEkle()
        {
            InitializeComponent();
        }

        private void FilmEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet2.FilmBİlgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmBİlgiTableAdapter.Fill(this.sinemaOtomasyonuDataSet2.FilmBİlgi);

        }

        private void filmEkleBT_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into FilmBilgi (FilmAd,FilmTur,Tarih) values (@filmad,@filmtur,@tarih)", baglan);
            ekle.Parameters.AddWithValue("filmad", filmAdıTB.Text);
            ekle.Parameters.AddWithValue("filmtur", filmTuruTB.Text);
            ekle.Parameters.AddWithValue("tarih", tarihTB.Text);
            ekle.ExecuteNonQuery();
            baglan.Close();
        }

        private void VerileriGoster_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataada = new SqlDataAdapter("Select * from FİlmBilgi", baglan);
            DataSet dataset = new DataSet();
            dataada.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void filmSilBT_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("delete from FilmBilgi where FilmAd=@filmad", baglan);
            sil.Parameters.AddWithValue("filmad", filmAdıTB.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
        }

        private void filmGuncelleBT_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand guncelle = new SqlCommand("update FilmBilgi set FilmAd=@filmad, FilmTur=@filmtur, Tarih=@tarih where FilmAd=@eskifilmad", baglan);
            guncelle.Parameters.AddWithValue("filmad", filmAdıTB.Text);
            guncelle.Parameters.AddWithValue("filmtur", filmTuruTB.Text);
            guncelle.Parameters.AddWithValue("tarih", tarihTB.Text);
            guncelle.Parameters.AddWithValue("eskifilmad", eskiFİlmAdıTB.Text);
            guncelle.ExecuteNonQuery();
            baglan.Close();
        }

        private void eskiFİlmAdıTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilmEkleKayit FilmEkleKayit = new FilmEkleKayit();
            FilmEkleKayit.Show();
            
        }
    }
}
