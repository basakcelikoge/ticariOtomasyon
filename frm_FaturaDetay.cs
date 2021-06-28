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
    public partial class frm_FaturaDetay : Form
    {
        public frm_FaturaDetay()
        {
            InitializeComponent();
        }
        public string ID;
        sqlBaglanti bgl = new sqlBaglanti();
        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_FATURADETAY where FATURABILGIID='" + ID+"'",bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void frm_FaturaDetay_Load(object sender, EventArgs e)
        {
            labelControl1.Text = ID;
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frm_FaturaDetayDuzenleme fr = new frm_FaturaDetayDuzenleme();
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (data!= null)
            {
                fr.urunID = data[0].ToString();
            }fr.Show();
        }
    }
}
