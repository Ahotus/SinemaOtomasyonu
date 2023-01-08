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
    public partial class SalonEkle : Form
    {
        SqlConnection baglan = new SqlConnection("Data Source = DESKTOP-S8DVTVD; Initial Catalog = SinemaOtomasyonu; Integrated Security = True");
        
        public SalonEkle()
        {
            InitializeComponent();
        }

        private void SalonEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sinemaOtomasyonuDataSet1.Salonbilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.salonbilgiTableAdapter.Fill(this.sinemaOtomasyonuDataSet1.Salonbilgi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan.Open();  
            SqlCommand ekle = new SqlCommand("insert into Salonbilgi (SalonAd) values (@salonno)",baglan);
            ekle.Parameters.AddWithValue("@salonno", salonAd.Text);
            ekle.ExecuteNonQuery();
            baglan.Close();
        }

        private void SilBT_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("delete from Salonbilgi where SalonId = @salonno", baglan);
            sil.Parameters.AddWithValue("@salonno", salonAd.Text);
            sil.ExecuteNonQuery();

        }

        private void VeriGetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataada = new SqlDataAdapter("Select * from Salonbilgi", baglan);
            DataSet dataset = new DataSet();
            dataada.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void islemGecBT_Click(object sender, EventArgs e)
        {
            SalonEkleKayit salonkayit = new SalonEkleKayit();
            salonkayit.Show();
        }
    }
}
