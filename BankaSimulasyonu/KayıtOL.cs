using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BankaSimulasyonu
{
    public partial class KayıtOL : Form
    {
        public KayıtOL()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KIMUOA0\SQLEXPRESS;Initial Catalog=DbBankamatik;Integrated Security=True");

            
        private void buttonKAYDET_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblKisiler (AD,SOYAD,TC,TELEFON,HESAPNO,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);


            komut.Parameters.AddWithValue("@p1", textBoxAD.Text);
            komut.Parameters.AddWithValue("@p2", textBoxSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBoxTC.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBoxTEL.Text);
            komut.Parameters.AddWithValue("@p5",maskedTextBoxhesapno.Text);
            komut.Parameters.AddWithValue("@p6", textBoxsifre.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonHESAPNO_Click(object sender, EventArgs e)
        {
            Random rastgele=new Random();
            int sayi = rastgele.Next(100000, 1000000);
            maskedTextBoxhesapno.Text=sayi.ToString();
        }
    }
}
