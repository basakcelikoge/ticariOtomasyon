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
    public partial class frm_Ayarlar : Form
    {
        public frm_Ayarlar()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        myFunction my = new myFunction();
        void Listele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TBL_ADMIN", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
        }
        private void frm_Ayarlar_Load(object sender, EventArgs e)
        {
            Listele();
            my.Temizle(this);
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (txt_kullaniciAd.Text != R_ad)
            {
                SqlCommand komut = new SqlCommand("INSERT INTO TBL_ADMIN (KullaniciAd, Sifre) VALUES (@KullaniciAd, @Sifre)", bgl.baglanti());
                komut.Parameters.AddWithValue("@KullaniciAd", txt_kullaniciAd.Text);
                komut.Parameters.AddWithValue("@Sifre", txt_sifre.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                Listele();
                MessageBox.Show("Yeni kullanıcı kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                my.Temizle(this);

            }
            else
            {
                SqlCommand komut2 = new SqlCommand("update TBL_ADMIN SET KullaniciAd=@KullaniciAd, Sifre=@Sifre WHERE ID=@ID", bgl.baglanti());
                komut2.Parameters.AddWithValue("@ID", R);
                komut2.Parameters.AddWithValue("@KullaniciAd", txt_kullaniciAd.Text);
                komut2.Parameters.AddWithValue("@Sifre", txt_sifre.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                Listele();
                MessageBox.Show("Kullanıcı güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                my.Temizle(this);
            }
            


        }

        private void gridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {

        }
        string R;
        string R_ad;

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                R = row[0].ToString(); 
                R_ad = row[1].ToString();
                txt_kullaniciAd.Text = row[1].ToString();
                txt_sifre.Text = row[2].ToString();
            }

        }

        
    }
}
