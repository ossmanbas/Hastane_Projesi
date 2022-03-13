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
    public partial class RandevuListesi : Form
    {
        public RandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new();
        private void RandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_randevular",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public int secilen;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           secilen = dataGridView1.SelectedCells[0].RowIndex;

        }
    }
}
