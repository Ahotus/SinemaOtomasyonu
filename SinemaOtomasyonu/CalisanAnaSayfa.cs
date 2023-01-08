using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace SinemaOtomasyonu
{
    public partial class CalisanAnaSayfa : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-S8DVTVD; Initial Catalog=SinemaOtomasyonu; Integrated Security = True");
        private void LoadKoltuklar(int seansId)
        {
            // Veritabanı bağlantısı ve sorgu
            string connectionString = "Data Source = DESKTOP-S8DVTVD; Initial Catalog=SinemaOtomasyonu; Integrated Security = True";
            SqlConnection conn = new SqlConnection(connectionString);

            string query = "SELECT * FROM Koltuklar WHERE SeansId = @SeansId";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@seansId", seansId);

            DataTable koltuklar = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(koltuklar);

            // Koltukların arkaplan rengini değiştir
            foreach (DataRow row in koltuklar.Rows)
            {
                int Sira = (int)row["Sira"];
                string durum = row["Durum"].ToString();
                Button koltuk = (Button)Controls["button" + Sira];  
                if (durum == "Dolu")
                    koltuk.BackColor = Color.Red;
                else
                    koltuk.BackColor = Color.Green;
                
            }
            
        }


        public CalisanAnaSayfa()
        {
            InitializeComponent();
        }

        private void CalisanAnaSayfa_Load(object sender, EventArgs e)
        {
            
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet.SeansBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seansBilgiTableAdapter.Fill(this.sinemaOtomasyonuDataSet.SeansBilgi);
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet.FilmBİlgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmBİlgiTableAdapter.Fill(this.sinemaOtomasyonuDataSet.FilmBİlgi);

        }

        private void seansIdTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void listeleBT_Click(object sender, EventArgs e)
        {
            LoadKoltuklar(Convert.ToInt32(seansIdTX.Text));
        }

        private void biletSatBT_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into Biletler (SeansId,KoltukId,Adi,SoyAdi,Telefon) values (@SeansId,@Koltuk,@Ad,@SoyAd,@Telefon)", baglan);
            ekle.Parameters.AddWithValue("SeansId", seansIdTX.Text);
            ekle.Parameters.AddWithValue("Koltuk", siraTX.Text);
            ekle.Parameters.AddWithValue("Ad", adTX.Text);
            ekle.Parameters.AddWithValue("SoyAd", soyADTX.Text);
            ekle.Parameters.AddWithValue("Telefon", telefonTX.Text);
            SqlCommand degis = new SqlCommand("update Koltuklar set durum ='Dolu' where Sira= @sira",baglan);
            degis.Parameters.AddWithValue("sira", siraTX.Text);
            degis.ExecuteNonQuery();
            ekle.ExecuteNonQuery();
            SqlCommand mesaj = new SqlCommand("select BiletId from Biletler where KoltukId = @siraNo", baglan);
            mesaj.Parameters.AddWithValue("siraNo", siraTX.Text);

            int BiletId = (int)mesaj.ExecuteScalar();
            MessageBox.Show("bilet numarası: "+BiletId.ToString());

           

            baglan.Close();
        }

        private void siraTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void adTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void soyADTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void telefonTX_TextChanged(object sender, EventArgs e)
        {

        }

        private void salonAdTX_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
