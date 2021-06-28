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
    public partial class frm_Urunler : Form
    {
        public frm_Urunler()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM TBL_URUNLER",bgl.baglanti());
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;

        }
        public void Temizle(Control control)
        {
            foreach(Control item in control.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is RichTextBox)
                {
                    ((RichTextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                
                if (item.Controls.Count>0)
                {
                    Temizle(item);
                }
            }
        }
        //void TamEkran()
        //{
        //    int w = Screen.PrimaryScreen.Bounds.Width;
        //    int h = Screen.PrimaryScreen.Bounds.Height;
        //    this.Location = new Point(0, 0);
        //    this.Size = new Size(w, h);
        //}

        private void frm_Urunler_Load(object sender, EventArgs e)
        {
            listele();
            //TamEkran();
            Temizle(this);

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_URUNLER ( URUNAD, MARKA, MODEL, YIL, ADET, ALISFIYAT, SATISFIYAT, DETAY) VALUES ( @URUNAD, @MARKA, @MODEL, @YIL, @ADET, @ALISFIYAT, @SATISFIYAT, @DETAY)",bgl.baglanti());
            komut.Parameters.AddWithValue("@URUNAD",txt_ad.Text);
            komut.Parameters.AddWithValue("@MARKA", txt_marka.Text);
            komut.Parameters.AddWithValue("@MODEL", txt_model.Text);
            komut.Parameters.AddWithValue("@YIL", msktxt_yıl.Text);
            komut.Parameters.AddWithValue("@ADET", int.Parse((nud_adet.Value).ToString()));
            komut.Parameters.AddWithValue("@ALISFIYAT", decimal.Parse(txt_alisfiyat.Text).ToString());
            komut.Parameters.AddWithValue("@SATISFIYAT", decimal.Parse(txt_satisfiyat.Text).ToString());
            komut.Parameters.AddWithValue("@DETAY", rtxt_detay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
            Temizle(this);

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_URUNLER where ID=@ID",bgl.baglanti() );
            komut.Parameters.AddWithValue("@ID",txt_ID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
            Temizle(this);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txt_ID.Text = row["ID"].ToString();
            txt_ad.Text = row["URUNAD"].ToString();
            txt_marka.Text = row["MARKA"].ToString();
            txt_model.Text = row["MODEL"].ToString();
            msktxt_yıl.Text = row["YIL"].ToString();
            nud_adet.Value =int.Parse( row["ADET"].ToString());
            txt_alisfiyat.Text = row["ALISFIYAT"].ToString();
            txt_satisfiyat.Text = row["SATISFIYAT"].ToString();
            rtxt_detay.Text = row["DETAY"].ToString();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_URUNLER SET URUNAD=@URUNAD, MARKA=@MARKA, MODEL=@MODEL, YIL=@YIL, ADET=@ADET, ALISFIYAT=@ALISFIYAT, SATISFIYAT=@SATISFIYAT, DETAY=@DETAY WHERE ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID",txt_ID.Text);
            komut.Parameters.AddWithValue("@URUNAD", txt_ad.Text);
            komut.Parameters.AddWithValue("@MARKA", txt_marka.Text);
            komut.Parameters.AddWithValue("@MODEL", txt_model.Text);
            komut.Parameters.AddWithValue("@YIL", msktxt_yıl.Text);
            komut.Parameters.AddWithValue("@ADET", int.Parse((nud_adet.Value).ToString()));
            komut.Parameters.AddWithValue("@ALISFIYAT", decimal.Parse(txt_alisfiyat.Text));
            komut.Parameters.AddWithValue("@SATISFIYAT", decimal.Parse(txt_satisfiyat.Text));
            komut.Parameters.AddWithValue("@DETAY",rtxt_detay.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            Temizle(this);
        }
    }
}
