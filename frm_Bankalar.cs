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
    public partial class frm_Bankalar : Form
    {
        public frm_Bankalar()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        myFunction myFunction = new myFunction();
        void sehirListele()
        {
            SqlCommand komut = new SqlCommand("Select sehir FROM TBL_ILLER", bgl.baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_il.Properties.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
        }
        void Firmalar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select ID,AD FROM TBL_FIRMALAR", bgl.baglanti());
            da.Fill(dt);
            lookUpEdit1.Properties.NullText = "Lütfen bir firma seçiniz";
            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "AD";
            lookUpEdit1.Properties.DataSource = dt;
            bgl.baglanti().Close();
        }

        void BankaListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXEC BankaBilgileri", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl_bankalar.DataSource = dataTable;

        }
        private void frm_Bankalar_Load(object sender, EventArgs e)
        {
          
            BankaListele();
            sehirListele();
            Firmalar();
            myFunction.Temizle(this);



        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_BANKALAR (BANKAADI, IL, ILCE, SUBE, IBAN, HESAPNO, YETKILI, TELEFON, TARIH, HESAPTURU, FIRMAID)" +
                "VALUES(@BANKAADI, @IL, @ILCE, @SUBE, @IBAN, @HESAPNO, @YETKILI, @TELEFON, @TARIH, @HESAPTURU, @FIRMAID)", bgl.baglanti());
            komut.Parameters.AddWithValue("@BANKAADI", txt_BankaAd.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@SUBE", txt_sube.Text);
            komut.Parameters.AddWithValue("@IBAN", msktext_iban.Text);
            komut.Parameters.AddWithValue("@HESAPNO", txt_hesapNo.Text);
            komut.Parameters.AddWithValue("@YETKILI", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@TELEFON", msk_Telefon.Text);
            komut.Parameters.AddWithValue("@TARIH", msk_tarih.Text);
            komut.Parameters.AddWithValue("@HESAPTURU", txt_hesapturu.Text);
            komut.Parameters.AddWithValue("@FIRMAID", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BankaListele();
            myFunction.Temizle(this);
        }

        private void cmb_il_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmb_ilce.Properties.Items.Clear();
            SqlCommand komut = new SqlCommand("SELECT ilce from TBL_ILCELER where sehir=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@P1", cmb_il.SelectedIndex + 1);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmb_ilce.Properties.Items.Add(dataReader[0]);
            }
            bgl.baglanti().Close();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                txt_bankaID.Text = row[0].ToString();
                txt_BankaAd.Text = row[1].ToString();
                cmb_il.Text = row[2].ToString();
                cmb_ilce.Text = row[3].ToString();
                txt_sube.Text = row[4].ToString();
                msktext_iban.Text = row[5].ToString();
                txt_hesapNo.Text = row[6].ToString();
                txt_yetkili.Text = row[7].ToString();
                msk_Telefon.Text = row[8].ToString();
                msk_tarih.Text = row[9].ToString();
                txt_hesapturu.Text = row[10].ToString();
               // lookUpEdit1.Properties.DisplayMember= row[11].ToString();
               
               
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete TBL_BANKALAR where ID=@ID",bgl.baglanti());
            komut.Parameters.AddWithValue("@ID",txt_bankaID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            BankaListele();
            myFunction.Temizle(this);

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_BANKALAR SET BANKAADI=@BANKAADI, IL=@IL, ILCE=@ILCE, SUBE=@SUBE, IBAN=@IBAN, HESAPNO=@HESAPNO, YETKILI=@YETKILI, TELEFON=@TELEFON, TARIH=@TARIH, HESAPTURU=@HESAPTURU, FIRMAID=@FIRMAID WHERE ID=@ID",bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_bankaID.Text);
            komut.Parameters.AddWithValue("@BANKAADI", txt_BankaAd.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@SUBE", txt_sube.Text);
            komut.Parameters.AddWithValue("@IBAN", msktext_iban.Text);
            komut.Parameters.AddWithValue("@HESAPNO", txt_hesapNo.Text);
            komut.Parameters.AddWithValue("@YETKILI", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@TELEFON", msk_Telefon.Text);
            komut.Parameters.AddWithValue("@TARIH", msk_tarih.Text);
            komut.Parameters.AddWithValue("@HESAPTURU", txt_hesapturu.Text);
            komut.Parameters.AddWithValue("@FIRMAID", lookUpEdit1.EditValue);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Banka Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BankaListele();
            myFunction.Temizle(this);

        }
    }
}
