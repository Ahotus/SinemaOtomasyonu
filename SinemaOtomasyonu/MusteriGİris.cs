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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SinemaOtomasyonu
{
    public partial class MusteriGİris : Form

    {
        SqlConnection baglan;
        SqlDataReader oku;
        SqlCommand cmd;
        public MusteriGİris()
        {

            InitializeComponent();
        }

        private void girisBT_Click(object sender, EventArgs e)
        {
            String kAdi = kAdiText.Text;
            String sifre = sifreText.Text;
            baglan = new SqlConnection("Data Source = DESKTOP-S8DVTVD; Initial Catalog=SinemaOtomasyonu; Integrated Security = True");
            cmd = new SqlCommand();
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "Select * from Musteribilgi where MusterikAdi ='" + kAdi + "'And MusteriSifre='" + sifre + "'";
            oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                MusteriAnaSayfa musteriAnaSayfa = new MusteriAnaSayfa();
                musteriAnaSayfa.Show();
                this.Hide();
            }
            else
            {
                yanlisGirisLabel.ForeColor = Color.Red;
                yanlisGirisLabel.Text = "Kullanıcı Adı/Şifre hatalı";
            }
            baglan.Close();
        }

        private void sifreyigoster_CheckedChanged(object sender, EventArgs e)
        {
            if (sifreyigoster.Checked)
            {
                sifreText.PasswordChar = '\0';
            }
            else
            {
                sifreText.PasswordChar = '*';
            }
        }

        private void MusteriGİris_Load(object sender, EventArgs e)
        {

        }
    }
}
