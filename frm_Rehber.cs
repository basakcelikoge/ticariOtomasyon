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
    public partial class frm_Rehber : Form
    {
        public frm_Rehber()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        void MusteriBilgileri()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter("Select ID, AD, SOYAD, TELEFON, TELEFON2,MAIL from TBL_MUSTERILER", bgl.baglanti());
            sqlData.Fill(dataTable);
            gridControl_musteri.DataSource = dataTable;
        }
        void FirmaBilgileri()
        {
            DataTable data= new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select ID, AD, YETKILIADSOYAD,TELEFON1, TELEFON2, TELEFON3, MAIL, FAX from TBL_FIRMALAR", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_firma.DataSource = data;
        }

        private void frm_Rehber_Load(object sender, EventArgs e)
        {
            MusteriBilgileri();
            FirmaBilgileri();


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frm_mail mail = new frm_mail();
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row!= null)
            {
                mail.mail = row["MAIL"].ToString();
            }
            mail.Show();
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frm_mail mail = new frm_mail();
            DataRow row = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (row != null)
            {
                mail.mail = row["MAIL"].ToString();
            }
            mail.Show();
        }
    }
}
