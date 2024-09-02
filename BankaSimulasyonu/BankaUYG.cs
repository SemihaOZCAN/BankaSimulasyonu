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

namespace BankaSimulasyonu
{
    public partial class BankaUYG : Form
    {
        public BankaUYG()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KIMUOA0\SQLEXPRESS;Initial Catalog=DbBankamatik;Integrated Security=True");

        public string hesap;

        private void BankaUYG_Load(object sender, EventArgs e)
        {
            labelHesapNO.Text = hesap;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblKisiler where HESAPNO=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", hesap);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                labelADSOYAD.Text = dr[1] + " " + dr[2];
                labelTC.Text = dr[3].ToString();
                labelTELEFON.Text = dr[4].ToString();

            }
            baglanti.Close();
        }

        private void buttonGONDER_Click(object sender, EventArgs e)
        {
            try
            {
                // Gönderilen hesaba para artışı
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TblHesap set BAKIYE=BAKIYE+@P1 where HESAPNO=@P2", baglanti);
                komut.Parameters.AddWithValue("@P1", decimal.Parse(textBoxTUTAR.Text));
                komut.Parameters.AddWithValue("@P2", maskedTextBoxhesapno.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                // Gönderen hesabın para azalışı
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TblHesap set BAKIYE=BAKIYE-@k1 where HESAPNO=@k2", baglanti);
                komut2.Parameters.AddWithValue("@k1", decimal.Parse(textBoxTUTAR.Text));
                komut2.Parameters.AddWithValue("@k2", hesap);
                komut2.ExecuteNonQuery();
                baglanti.Close();

                // İşlemi TblHareket tablosuna kaydet
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("insert into TblHareket (GONDEREN, ALICI, TUTAR) values (@g1, @g2, @g3)", baglanti);
                komut3.Parameters.AddWithValue("@g1", hesap);
                komut3.Parameters.AddWithValue("@g2", maskedTextBoxhesapno.Text);
                komut3.Parameters.AddWithValue("@g3", decimal.Parse(textBoxTUTAR.Text));
                komut3.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("İşlem Gerçekleştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void btnHesapHareketi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblHareket where GONDEREN=@p1 or ALICI=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr = komut.ExecuteReader();

            StringBuilder hareketler = new StringBuilder();
            while (dr.Read())
            {
                hareketler.AppendLine($"Gönderen: {dr["GONDEREN"]}, Alıcı: {dr["ALICI"]}, Tutar: {dr["TUTAR"]} TL");
            }
            baglanti.Close();

            MessageBox.Show(hareketler.ToString(), "Hesap Hareketleri", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
