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


namespace Hastane_Projesi
{
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void HastaDetay_Load(object sender, EventArgs e)
        {
            //Ad Soyad Çekme
            lblTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi Çekme
            DataTable dt = new();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular Where HastaTC="+tc,bgl.baglanti());
            da.Fill(dt);
            dgvGecmis.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktor Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable Dt = new();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans='"+cmbBrans.Text+"'",bgl.baglanti());
            da.Fill(Dt);
            dgvAktif.DataSource = Dt;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgileriDuzenle bd = new();
            bd.tcNo = lblTC.Text;
            bd.Show();
            
        }
    }
}
