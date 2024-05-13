using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql_kullanımı_1120
{
    public partial class FormFilmElestiri : Form
    {
        string baglantiMetin = "Server=localhost;Database=film_arsiv;Uid=root;Pwd=";
        public FormFilmElestiri()
        {
            InitializeComponent();
        }

        private void FormFilmElestiri_Load(object sender, EventArgs e)
        {
            baglan.Open(); //veritabanı bağlantısı aç
            string sorgu = "SELECT filmler.film_id, filmler.film_id, filmler.tur, elestiriler.elestiri_metin, elestiriler.elestirmen FROM filmler\r\nJOIN elestiriler ON filmler.film_id = elestiriler.film_id;"; //sorgumuz
            MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }
    }
    }
}
