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
    public partial class AdminGİrisYap : Form
    {
        SqlConnection baglan;
        SqlDataReader oku;
        SqlCommand cmd;
        public AdminGİrisYap()
        {
            InitializeComponent();
        }

        private void yanlisGirisLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String kAdi = kAdiText.Text;
            String sifre = sifreText.Text;
            baglan = new SqlConnection("Data Source = DESKTOP-S8DVTVD; Initial Catalog=SinemaOtomasyonu; Integrated Security = True");
            cmd = new SqlCommand();
            baglan.Open();
            cmd.Connection = baglan;
            cmd.CommandText = "Select * from Adminbilgi where AdminkAdi ='"+ kAdi + "'And AdminSifre='"+ sifre + "'";
            oku = cmd.ExecuteReader();
            if(oku.Read())
            {
                AdminAnaSayfa adminAnaSayfa = new AdminAnaSayfa();
                adminAnaSayfa.Show();
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
    }
}
