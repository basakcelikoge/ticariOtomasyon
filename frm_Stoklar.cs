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

namespace Ticari_Otomasyon1
{
    public partial class frm_Stoklar : Form
    {
        public frm_Stoklar()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        private void frm_Stoklar_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("İzmir", 8);
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 6);
            //chartControl1.Series["Series 1"].Points.AddPoint("Adana", 5);

            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT URUNAD 'Ürün Ad',SUM(ADET)AS 'Miktar' FROM TBL_URUNLER GROUP BY URUNAD",bgl.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;


            SqlCommand komut = new SqlCommand("SELECT URUNAD 'Ürün Ad',SUM(ADET)AS 'Miktar' FROM TBL_URUNLER GROUP BY URUNAD",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint( Convert.ToString(dr[0]) ,Convert.ToInt32(dr[1]) );
            }
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("SELECT IL,COUNT(*)FROM TBL_FIRMALAR GROUP BY IL",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]),int.Parse((dr2[1]).ToString()));
            }
            bgl.baglanti().Close();

        }
    }
}
