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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }
        public string TCNO;
        SqlBaglantisi bgl = new();
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCNO;

            //Ad Soyad
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreter where SekreterTC = @p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TCNO);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();


            //Branşları Aktarma
            DataTable dt = new();
            SqlDataAdapter da = new SqlDataAdapter("Select BransAd From tbl_branslar", bgl.baglanti());
            da.Fill(dt);
            dgvBrans.DataSource = dt;

            //Doktorları Listeye Aktarma
            DataTable dt2 = new();
            SqlDataAdapter daa = new SqlDataAdapter("Select Doktorad,Doktorsoyad,DoktorBrans From tbl_doktor", bgl.baglanti());
            daa.Fill(dt2);
            dgvDoktor.DataSource = dt2;

            //branşı combobox a aktarma
            SqlCommand komut3 = new SqlCommand("Select BransAd From tbl_Branslar ",bgl.baglanti());
            SqlDataReader dt3 = komut3.ExecuteReader();
            while (dt3.Read())
            {
                cmbPoliklinik.Items.Add(dt3[0]);
            }
            bgl.baglanti().Close();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into tbl_randevular (RandevuTarih,RandevuSaat,Randevubrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@r1", mskTarih.Text);
            komut2.Parameters.AddWithValue("@r2", mskSaat.Text);
            komut2.Parameters.AddWithValue("@r3", cmbPoliklinik);
            komut2.Parameters.AddWithValue("@r4", cmbDoktor);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu !");
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut4 = new SqlCommand("Select DoktorAd,DoktorSoyad From tbl_Doktor where doktorbrans=@p1", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", cmbPoliklinik.Text);
            SqlDataReader dataReader = komut4.ExecuteReader();
            while (dataReader.Read())
            {
                cmbDoktor.Text = dataReader[0]+" "+dataReader[1];
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into  Tbl_Duyurular (duyuru) values (@d1)",bgl.baglanti());
            sqlCommand.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            sqlCommand.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu ! ");
        }

        private void btnDokPaneli_Click(object sender, EventArgs e)
        {
            SekreterDoktorPaneli fr = new();
            fr.Show();
           
        }
    }
}
