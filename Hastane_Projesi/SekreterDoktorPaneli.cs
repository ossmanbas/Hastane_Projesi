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
    
    public partial class SekreterDoktorPaneli : Form
    {
        public SekreterDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void SekreterDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new();
            SqlDataAdapter daa = new SqlDataAdapter("Select * From tbl_doktor", bgl.baglanti());
            daa.Fill(dt2);
            dataGridView1.DataSource = dt2;
            SqlCommand komut3 = new SqlCommand("Select BransAd From tbl_Branslar ", bgl.baglanti());
            SqlDataReader dt3 = komut3.ExecuteReader();
            while (dt3.Read())
            {
                cmbBrans.Items.Add(dt3[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into tbl_doktor (DoktorAd,doktorsoyad,doktorbrans,Doktortc,doktorsifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", txtAd.Text);
            komut2.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut2.Parameters.AddWithValue("@d4",mskTC.Text );
            komut2.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Doktor Oluşturuldu !","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_doktor where doktortc= @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi !");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut2 = new SqlCommand("update tbl_doktor set DoktorAd=@d1,doktorsoyad=@d2,doktorbrans=@d3,doktorsifre=@d5 where Doktortc=@d4", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", txtAd.Text);
            komut2.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@d3", cmbBrans.Text);
            komut2.Parameters.AddWithValue("@d4", mskTC.Text);
            komut2.Parameters.AddWithValue("@d5", txtSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
