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
    public partial class AdminAnaSayfa : Form
    {
        public AdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void salonEkleBT_Click(object sender, EventArgs e)
        {
            SalonEkle salonekle = new SalonEkle();
            salonekle.Show();
            this.Hide();
            
        }

        private void filmEkleBT_Click(object sender, EventArgs e)
        {
            FilmEkle film = new FilmEkle();
            film.Show();
            this.Hide();
        }

        private void AdminAnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeansEkle seans = new SeansEkle();
            seans.Show();
            this.Hide();
        }
    }
}
