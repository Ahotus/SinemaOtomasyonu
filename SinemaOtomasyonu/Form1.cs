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
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        private void adminGitBT_Click(object sender, EventArgs e)
        {
            AdminGİrisYap admin = new AdminGİrisYap();
            
            admin.Show();
            this.Hide();
        }

        private void calisanGirisBT_Click(object sender, EventArgs e)
        {
            CalisanGiris calisangiris = new CalisanGiris();
            calisangiris.Show();
            this.Hide();
        }

        private void musteriGirisBT_Click(object sender, EventArgs e)
        {
            MusteriGİris musterigiris = new MusteriGİris();
            musterigiris.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
