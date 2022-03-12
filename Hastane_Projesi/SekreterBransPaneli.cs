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
    public partial class SekreterBransPaneli : Form
    {
        public SekreterBransPaneli()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();

        private void SekreterBransPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new();
            SqlDataAdapter da = new SqlDataAdapter("Select * From tbl_branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("insert into tbl_branslar (BransId,bransad) values (@d1,@d2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", txtId.Text.ToString());
            komut2.Parameters.AddWithValue("@d2", txtAd.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Yeni Branş Kaydedildi !");
        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_branslar where BransId= @p1 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi !");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_branslar set BransAd=@d2 where BransId=@d1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", txtId.Text);
            komut2.Parameters.AddWithValue("@d2", txtAd.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi !");
        }
    }
}
