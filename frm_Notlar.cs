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
    public partial class frm_Notlar : Form
    {
        public frm_Notlar()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        myFunction myFunction = new myFunction();

        void Listele()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("select ID,TARIH, SAAT, BASLIK AS KONU, NOTDETAY as AÇIKLAMA, NOTOLUSTURAN AS OLUŞTURAN, NOTHITAP AS İLGİLİ_KİŞİLER from TBL_NOTLAR", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_notlar.DataSource = data;
        }
        private void frm_Notlar_Load(object sender, EventArgs e)
        {
            Listele();
            myFunction.Temizle(this);
            txt_ID.Text = "";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
          
            if (txt_ID.Text == "")
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_NOTLAR (TARIH, SAAT, BASLIK, NOTDETAY, NOTOLUSTURAN, NOTHITAP) VALUES (@TARIH, @SAAT, @BASLIK, @NOTDETAY, @NOTOLUSTURAN, @NOTHITAP)", bgl.baglanti());
                komut.Parameters.AddWithValue("@TARIH", DateTime.Parse(msk_tarih.Text));
                komut.Parameters.AddWithValue("@SAAT", DateTime.Parse(msk_saat.Text));
                komut.Parameters.AddWithValue("@BASLIK", txt_baslik.Text);
                komut.Parameters.AddWithValue("@NOTDETAY", txt_detay.Text);
                komut.Parameters.AddWithValue("@NOTOLUSTURAN", txt_olusturan.Text);
                komut.Parameters.AddWithValue("@NOTHITAP", txt_hitap.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("UPDATE TBL_NOTLAR SET TARIH=@TARIH, SAAT=@SAAT, BASLIK=@BASLIK, NOTDETAY=@NOTDETAY, NOTOLUSTURAN=@NOTOLUSTURAN, NOTHITAP=@NOTHITAP WHERE ID=@ID", bgl.baglanti());
                komut2.Parameters.AddWithValue("@ID", txt_ID.Text);
                komut2.Parameters.AddWithValue("@TARIH", DateTime.Parse(msk_tarih.Text));
                komut2.Parameters.AddWithValue("@SAAT", DateTime.Parse(msk_saat.Text));
                komut2.Parameters.AddWithValue("@BASLIK", txt_baslik.Text);
                komut2.Parameters.AddWithValue("@NOTDETAY", txt_detay.Text);
                komut2.Parameters.AddWithValue("@NOTOLUSTURAN", txt_olusturan.Text);
                komut2.Parameters.AddWithValue("@NOTHITAP", txt_hitap.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Not güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }

         
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                txt_ID.Text = row[0].ToString();
                msk_tarih.Text = row[1].ToString();
                msk_saat.Text = row[2].ToString();
                txt_baslik.Text = row[3].ToString();
                txt_detay.Text = row[4].ToString();
                txt_olusturan.Text = row[5].ToString();
                txt_hitap.Text = row[6].ToString();
            }

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_NOTLAR WHERE ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Not silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            myFunction.Temizle(this);
            txt_ID.Text = "";
        }

        private void link_temizle_Click(object sender, EventArgs e)
        {
            myFunction.Temizle(this);
            txt_ID.Text = "";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frm_NotDetay fr =  new frm_NotDetay();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr !=null)
            {
                fr.metin = dr[4].ToString();
                fr.Show();
            }
        }
    }
}
