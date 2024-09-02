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
    public partial class Banka : Form
    {
        public Banka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-KIMUOA0\SQLEXPRESS;Initial Catalog=DbBankamatik;Integrated Security=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayıtOL frm=new KayıtOL();
            frm.ShowDialog();
        }

        private void buttonGIRISYAP_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblKisiler where HESAPNO=@P1 and SIFRE=@P2", baglanti);
            komut.Parameters.AddWithValue("@P1", maskedTextBoxhesapno.Text);
            komut.Parameters.AddWithValue("@P2", textBoxsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                BankaUYG fr = new BankaUYG();
                fr.hesap=maskedTextBoxhesapno.Text;
                fr.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            baglanti.Close();
           
        }

        
    }
}
