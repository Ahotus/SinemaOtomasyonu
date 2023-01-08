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
    public partial class SeansEkle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-S8DVTVD; Initial Catalog = SinemaOtomasyonu; Integrated Security = True");
        public SeansEkle()
        {
            InitializeComponent();
        }

        private void SeansEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet4.SeansBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.seansBilgiTableAdapter.Fill(this.sinemaOtomasyonuDataSet4.SeansBilgi);
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet3.FilmBİlgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.filmBİlgiTableAdapter.Fill(this.sinemaOtomasyonuDataSet3.FilmBİlgi);


            baglan.Open();


            SqlCommand cmd = new SqlCommand("SELECT FilmAd FROM FilmBilgi", baglan);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox1.Items.Add(reader["FilmAd"]);
            }

            reader.Close();

            SqlCommand cmd2 = new SqlCommand("SELECT SalonAd FROM Salonbilgi", baglan);
            SqlDataReader reader2 = cmd2.ExecuteReader();

            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2["SalonAd"]);
            }

            reader2.Close();
            baglan.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void verileriGosterBT_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataada = new SqlDataAdapter("Select * from SeansBilgi", baglan);
            DataSet dataset = new DataSet();
            dataada.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void seansEkleBT_Click(object sender, EventArgs e)
        {
            
            baglan.Open();
            SqlCommand ekle = new SqlCommand("insert into SeansBilgi (FilmAd,SalonAd,tarih,saat) values (@filmad,@SalonAd,@tarih,@saat)", baglan);
            ekle.Parameters.AddWithValue("FilmAd", comboBox1.Text);
            ekle.Parameters.AddWithValue("SalonAd", comboBox2.Text);
            ekle.Parameters.AddWithValue("tarih", dateTimePicker1.Value);
            ekle.Parameters.AddWithValue("saat", saatsecimi.Text);
            ekle.ExecuteNonQuery();
            
            SqlCommand ara = new SqlCommand("select TOP 1 SeansId from SeansBilgi order by SeansId DESC", baglan);
            
            SqlDataReader reader = ara.ExecuteReader();
            int a = 0;
            if (reader.Read())
            {
                a = reader.GetInt32(0);
            }

            reader.Close();


            for (int i = 1; i <= 18; i++)
            {
               
                string query = "EXEC InsertKoltuklar @SeansId,@salon,@i, 'Boş'";
                SqlCommand cmd = new SqlCommand(query, baglan);
                cmd.Parameters.AddWithValue("@SeansId", a); 
                cmd.Parameters.AddWithValue("salon",comboBox2.Text); 
                cmd.Parameters.AddWithValue("i", i); 
                cmd.Parameters.AddWithValue("@Durum", "Boş"); 

                
                cmd.ExecuteNonQuery();
                
            }
            baglan.Close();


        }

        private void seansSilBT_Click(object sender, EventArgs e)
        {
            baglan.Open();


            string sorgu = "DELETE FROM SeansBilgi WHERE SeansId = @id";
            SqlCommand Sil = new SqlCommand(sorgu, baglan);
            int idDegeri = Convert.ToInt32(id.Text);
            Sil.Parameters.AddWithValue("id", idDegeri);
            Sil.ExecuteNonQuery();
            

           

            SqlCommand SilKoltuk = new SqlCommand("EXEC SilKoltuklar @SeansId", baglan);
            SilKoltuk.Parameters.AddWithValue("@SeansId", idDegeri);
            SilKoltuk.ExecuteNonQuery();

            baglan.Close();


            baglan.Close();
        }
           
        private void saatsecimi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void islemgecmisi_Click(object sender, EventArgs e)
        {
            SeansEkleKayit seansEkleKayit = new SeansEkleKayit();
            seansEkleKayit.Show();
           
        }
    }
}
