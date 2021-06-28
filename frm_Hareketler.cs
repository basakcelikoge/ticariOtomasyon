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
    public partial class frm_Hareketler : Form
    {
        public frm_Hareketler()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        void firmaHareket()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXEC FIRMA_HAREKET",bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_firma.DataSource=data;
        }
        void musteriHareket()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXEC MUSTERI_HAREKET", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_musteri.DataSource = data;
        }
        private void frm_Hareketler_Load(object sender, EventArgs e)
        {
            firmaHareket();
            musteriHareket();
        }
    }
}
