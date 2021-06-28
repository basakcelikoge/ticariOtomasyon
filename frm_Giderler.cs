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
    public partial class frm_Giderler : Form
    {
        public frm_Giderler()
        {
            InitializeComponent();
        }
        myFunction myFunction = new myFunction();
        sqlBaglanti bgl = new sqlBaglanti();

        void giderListesi()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TBL_GIDERLER", bgl.baglanti());
            da.Fill(dataTable);
            gridControl_giderler.DataSource = dataTable;
        }

        private void frm_Giderler_Load(object sender, EventArgs e)
        {
            myFunction.Temizle(this);
            giderListesi();

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("INSERT INTO TBL_GIDERLER (AY, YIL, ELEKTIRK, SU, DOGALGAZ, INTERNET, MAASLAR, EKSTRA, NOTLAR) VALUES (@AY, @YIL, @ELEKTIRK, @SU, @DOGALGAZ, @INTERNET, @MAASLAR, @EKSTRA, @NOTLAR)", bgl.baglanti());
            sql.Parameters.AddWithValue("@AY", cmb_ay.Text);
            sql.Parameters.AddWithValue("@YIL", cmb_yıl.Text);
            sql.Parameters.AddWithValue("@ELEKTIRK", decimal.Parse(txt_elektrik.Text));
            sql.Parameters.AddWithValue("@SU", decimal.Parse(txt_su.Text));
            sql.Parameters.AddWithValue("@DOGALGAZ", decimal.Parse(txt_dogalgaz.Text));
            sql.Parameters.AddWithValue("@INTERNET", decimal.Parse(txt_internet.Text));
            sql.Parameters.AddWithValue("@MAASLAR", decimal.Parse(txt_maaslar.Text));
            sql.Parameters.AddWithValue("@EKSTRA", decimal.Parse(txt_ekstra.Text));
            sql.Parameters.AddWithValue("@NOTLAR", txt_not.Text);
            sql.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            myFunction.Temizle(this);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                txt_giderlerID.Text = row[0].ToString();
                cmb_ay.Text = row[1].ToString();
                cmb_yıl.Text = row[2].ToString();
                txt_elektrik.Text = row[3].ToString();
                txt_su.Text = row[4].ToString();
                txt_dogalgaz.Text = row[5].ToString();
                txt_internet.Text = row[6].ToString();
                txt_maaslar.Text = row[7].ToString();
                txt_ekstra.Text = row[8].ToString();
                txt_not.Text = row[9].ToString();


            } 

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_GIDERLER where ID=@ID",bgl.baglanti());
            komut.Parameters.AddWithValue("@ID",txt_giderlerID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            giderListesi();
            myFunction.Temizle(this);

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_GIDERLER SET AY=@AY, YIL=@YIL, ELEKTIRK=@ELEKTIRK, SU=@SU, DOGALGAZ=@DOGALGAZ, INTERNET=@INTERNET, MAASLAR=@MAASLAR, EKSTRA=@EKSTRA, NOTLAR=@NOTLAR WHERE ID=@ID",bgl.baglanti());
                        
            komut.Parameters.AddWithValue("@ID", txt_giderlerID.Text);
            komut.Parameters.AddWithValue("@AY", cmb_ay.Text);
            komut.Parameters.AddWithValue("@YIL", cmb_yıl.Text);
            komut.Parameters.AddWithValue("@ELEKTIRK", decimal.Parse(txt_elektrik.Text));
            komut.Parameters.AddWithValue("@SU", decimal.Parse(txt_su.Text));
            komut.Parameters.AddWithValue("@DOGALGAZ", decimal.Parse(txt_dogalgaz.Text));
            komut.Parameters.AddWithValue("@INTERNET", decimal.Parse(txt_internet.Text));
            komut.Parameters.AddWithValue("@MAASLAR", decimal.Parse(txt_maaslar.Text));
            komut.Parameters.AddWithValue("@EKSTRA", decimal.Parse(txt_ekstra.Text));
            komut.Parameters.AddWithValue("@NOTLAR", txt_not.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            giderListesi();
            myFunction.Temizle(this);
        }
    }
}
