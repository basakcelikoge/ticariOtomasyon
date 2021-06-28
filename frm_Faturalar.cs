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
    public partial class frm_Faturalar : Form
    {
        public frm_Faturalar()
        {
            InitializeComponent();
        }
        sqlBaglanti BGL = new sqlBaglanti();
        myFunction myFunction = new myFunction();

        void Listele()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TBL_FATURABILGI", BGL.baglanti());
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            gridControl_faturalar.DataSource = dataTable;
        }
        private void frm_Faturalar_Load(object sender, EventArgs e)
        {
            Listele();
            myFunction.Temizle(this);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (txt_faturaID.Text == "")
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_FATURABILGI (SERI, SIRANO, TARIH, SAAT, VERGIDAIRE, ALICI, TESLIMEDEN, TESLIMALAN) VALUES(@SERI, @SIRANO, @TARIH, @SAAT, @VERGIDAIRE, @ALICI, @TESLIMEDEN, @TESLIMALAN)", BGL.baglanti());
                komut.Parameters.AddWithValue("@SERI", txt_seriNo.Text);
                komut.Parameters.AddWithValue("@SIRANO", txt_siraNo.Text);
                komut.Parameters.AddWithValue("@TARIH", DateTime.Parse(msk_tarih.Text));
                komut.Parameters.AddWithValue("@SAAT", DateTime.Parse(msk_saat.Text));
                komut.Parameters.AddWithValue("@VERGIDAIRE", txt_vergiDairesi.Text);
                komut.Parameters.AddWithValue("@ALICI", txt_alici.Text);
                komut.Parameters.AddWithValue("@TESLIMEDEN", txt_teslimEDEN.Text);
                komut.Parameters.AddWithValue("@TESLIMALAN", txt_teslimALAN.Text);
                komut.ExecuteNonQuery();
                BGL.baglanti().Close();
                MessageBox.Show("Fatura bilgisi kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                myFunction.Temizle(this);
            }
            if (txt_faturaID.Text != null)
            {
                Double miktar, tutar, fiyat;
                fiyat = Convert.ToDouble(txt_fiyat.Text);
                miktar = Convert.ToDouble(txt_miktar.Text);
                tutar = miktar * fiyat;
                txt_tutar.Text = tutar.ToString();
                SqlCommand komut2 = new SqlCommand("INSERT INTO TBL_FATURADETAY (URUNAD, MIKTAR, FIYAT, TUTAR, FATURABILGIID) VALUES (@URUNAD, @MIKTAR, @FIYAT, @TUTAR,@FATURABILGIID)", BGL.baglanti());
                komut2.Parameters.AddWithValue("@URUNAD", txt_urunAd.Text);
                komut2.Parameters.AddWithValue("@MIKTAR", miktar);
                komut2.Parameters.AddWithValue("@FIYAT", fiyat);
                komut2.Parameters.AddWithValue("@TUTAR", tutar);
                komut2.Parameters.AddWithValue("@FATURABILGIID", txt_faturaID.Text);
                komut2.ExecuteNonQuery();
                BGL.baglanti().Close();
                MessageBox.Show("Fatura detayı kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
                myFunction.Temizle(this);
            }

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                txt_ID.Text = row[0].ToString();
                txt_seriNo.Text = row[1].ToString();
                txt_siraNo.Text = row[2].ToString();
                msk_tarih.Text = row[3].ToString();
                msk_saat.Text = row[4].ToString();
                txt_vergiDairesi.Text = row[5].ToString();
                txt_alici.Text = row[6].ToString();
                txt_teslimEDEN.Text = row[7].ToString();
                txt_teslimALAN.Text = row[8].ToString();
            }

        }

        private void txt_tutar_EditValueChanged(object sender, EventArgs e)
        {
            txt_tutar.Text = (Convert.ToDouble(txt_miktar.Text) * Convert.ToDouble(txt_fiyat.Text)).ToString();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FATURABILGI where ID=@ID", BGL.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_ID.Text);
            komut.ExecuteNonQuery();
            BGL.baglanti().Close();
            MessageBox.Show("Fatura silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Listele();
            myFunction.Temizle(this);

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update TBL_FATURABILGI SET SERI=@SERI, SIRANO=@SIRANO, TARIH=@TARIH, SAAT=@SAAT, VERGIDAIRE=@VERGIDAIRE, ALICI=@ALICI, TESLIMEDEN=@TESLIMEDEN, TESLIMALAN=@TESLIMALAN where ID=@ID", BGL.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_ID.Text);
            komut.Parameters.AddWithValue("@SERI", txt_seriNo.Text);
            komut.Parameters.AddWithValue("@SIRANO", txt_siraNo.Text);
            komut.Parameters.AddWithValue("@TARIH", DateTime.Parse(msk_tarih.Text));
            komut.Parameters.AddWithValue("@SAAT", DateTime.Parse(msk_saat.Text));
            komut.Parameters.AddWithValue("@VERGIDAIRE", txt_vergiDairesi.Text);
            komut.Parameters.AddWithValue("@ALICI", txt_alici.Text);
            komut.Parameters.AddWithValue("@TESLIMEDEN", txt_teslimEDEN.Text);
            komut.Parameters.AddWithValue("@TESLIMALAN", txt_teslimALAN.Text);
            komut.ExecuteNonQuery();
            BGL.baglanti().Close();
            MessageBox.Show("Fatura bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            myFunction.Temizle(this);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frm_FaturaDetay frm_FaturaDetay = new frm_FaturaDetay();
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (data!= null)
            {
                frm_FaturaDetay.ID = data[0].ToString();

            }
            frm_FaturaDetay.Show();
        }
    }
}
