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
using System.Xml;

namespace Ticari_Otomasyon1
{
    public partial class frm_Anasayfa : Form
    {
        public frm_Anasayfa()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        sqlBaglanti bgl = new sqlBaglanti();
        void Stoklar()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select URUNAD, SUM(ADET) as Adet from TBL_URUNLER group by URUNAD having sum(ADET)<=20 ORDER BY SUM(ADET)", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_Stoklar.DataSource = data;
        }
        void Ajanda()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select TARIH,SAAT,BASLIK from TBL_NOTLAR", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_ajanda.DataSource = data;
        }
        void firmaHareket()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXEC Hareket", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_Hareket.DataSource = data;
        }

     
        private void frm_Anasayfa_Load(object sender, EventArgs e)
        {
          
            Stoklar();
            Ajanda();
            firmaHareket();

            webBrowser1.Navigate("https://www.tcmb.gov.tr/kurlar/today.xml");
            webBrowser2.Navigate("https://webrazzi.com/");



        }
    }
}
