using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon1
{
    class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-AGR5HLU\SQLEXPRESS;Initial Catalog=Ticari_Otomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
