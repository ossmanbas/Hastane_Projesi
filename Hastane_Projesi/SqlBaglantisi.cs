using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Hastane_Projesi
{
    class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-R3A8UBN;Initial Catalog=Hospital_Project;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
