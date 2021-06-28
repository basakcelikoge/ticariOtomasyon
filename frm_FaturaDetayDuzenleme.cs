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
    public partial class frm_FaturaDetayDuzenleme : Form
    {
        public frm_FaturaDetayDuzenleme()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        private void txt_tutar_EditValueChanged(object sender, EventArgs e)
        {
            txt_tutar.Text = (Convert.ToDouble(txt_miktar.Text) * Convert.ToDouble(txt_fiyat.Text)).ToString();
        }
        public string urunID;
        private void frm_FaturaDetayDuzenleme_Load(object sender, EventArgs e)
        {
            txt_urunID.Text = urunID;
            SqlCommand komut = new SqlCommand("select * from TBL_FATURADETAY WHERE ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", urunID);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {

                txt_urunAd.Text = reader[1].ToString();
                txt_miktar.Text = reader[2].ToString();
                txt_fiyat.Text = reader[3].ToString();
                txt_tutar.Text = reader[4].ToString();
                bgl.baglanti().Close();

            }


        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURADETAY SET URUNAD=@URUNAD, MIKTAR=@MIKTAR, FIYAT=@FIYAT, TUTAR=@TUTAR WHERE ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_urunID.Text);
            komut.Parameters.AddWithValue("@URUNAD", txt_urunAd.Text);
            komut.Parameters.AddWithValue("@MIKTAR", txt_miktar.Text);
            komut.Parameters.AddWithValue("@FIYAT", txt_miktar.Text);
            komut.Parameters.AddWithValue("@TUTAR", txt_tutar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura detay değişikliği yapıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);





        }
        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FATURADETAY WHERE ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_urunID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Fatura detay silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
