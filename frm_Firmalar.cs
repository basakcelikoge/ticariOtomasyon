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
    public partial class frm_Firmalar : Form
    {
        public frm_Firmalar()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        void firmaListele()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_FIRMALAR",bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_firmalar.DataSource = data;


        }
         void Temizle(Control control)
            {
                foreach (Control item in control.Controls)
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

                    if (item.Controls.Count > 0)
                    {
                        Temizle(item);
                    }
                }
            }

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

        private void frm_Firmalar_Load(object sender, EventArgs e)
        {
            firmaListele();
            sehirListele();
            carikodAciklama();
            Temizle(this);

        }

        void carikodAciklama()
        {
            SqlCommand komut = new SqlCommand("Select FIRMAKOD1 from TBL_KODLAR",bgl.baglanti());
            SqlDataReader DR = komut.ExecuteReader();
            while (DR.Read())
            {
                rtxtbox_ozelkod1.Text = DR[0].ToString();
            }
        }
        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row!= null)
            { //ID, AD, YETKILISTATU, YETKILIADSOYAD, YETKILITC, SEKTOR, TELEFON1, TELEFON2, TELEFON3, MAIL, FAX, IL, ILCE, VERGIDAIRE, ADRES, OZELKOD1, OZELKOD2, OZELKOD3
                txt_firmaID.Text = row[0].ToString();
                txt_Ad.Text = row[1].ToString();
                txt_yetkiligorev.Text = row[2].ToString();
                txt_yetkili.Text = row[3].ToString();
                msktext_yetkilitc.Text = row[4].ToString();
                txt_sektor.Text = row[5].ToString();
                msktext_tel1.Text = row[6].ToString();
                msktext_tel2.Text = row[7].ToString();
                msktext_tel3.Text = row[8].ToString();
                msktext_fax.Text = row[10].ToString();
                txt_mail.Text = row[9].ToString();
                cmb_il.Text = row[11].ToString();
                cmb_ilce.Text = row[12].ToString();
                txt_vergidaire.Text = row[13].ToString();
                rtxtbox_adres.Text = row[14].ToString();
                txt_kod1.Text = row[15].ToString();
                txt_kod2.Text = row[16].ToString();
                txt_kod3.Text = row[17].ToString();
            }


        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand(
                "INSERT INTO TBL_FIRMALAR (AD, YETKILISTATU, YETKILIADSOYAD, YETKILITC, SEKTOR, TELEFON1, TELEFON2, TELEFON3, MAIL, FAX, IL, ILCE, VERGIDAIRE, ADRES, OZELKOD1, OZELKOD2, OZELKOD3)VALUES (@AD, @YETKILISTATU, @YETKILIADSOYAD, @YETKILITC, @SEKTOR, @TELEFON1, @TELEFON2, @TELEFON3, @MAIL, @FAX, @IL, @ILCE, @VERGIDAIRE, @ADRES, @OZELKOD1, @OZELKOD2, @OZELKOD3)",bgl.baglanti());
            
            komut.Parameters.AddWithValue("@AD", txt_Ad.Text);
            komut.Parameters.AddWithValue("@YETKILISTATU", txt_yetkiligorev.Text);
            komut.Parameters.AddWithValue("@YETKILIADSOYAD", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@YETKILITC", msktext_yetkilitc.Text);
            komut.Parameters.AddWithValue("@SEKTOR", txt_sektor.Text);
            komut.Parameters.AddWithValue("@TELEFON1", msktext_tel1.Text);
            komut.Parameters.AddWithValue("@TELEFON2", msktext_tel2.Text);
            komut.Parameters.AddWithValue("@TELEFON3", msktext_tel3.Text);
            komut.Parameters.AddWithValue("@MAIL",txt_mail.Text);
            komut.Parameters.AddWithValue("@FAX", msktext_fax.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@VERGIDAIRE", txt_vergidaire.Text);
            komut.Parameters.AddWithValue("@ADRES", rtxtbox_adres.Text);
            komut.Parameters.AddWithValue("@OZELKOD1", txt_kod1.Text);
            komut.Parameters.AddWithValue("@OZELKOD2", txt_kod2.Text);
            komut.Parameters.AddWithValue("@OZELKOD3", txt_kod3.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Firma eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
            firmaListele();
            Temizle(this);
        }

        private void cmb_il_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from TBL_FIRMALAR where ID=@ID",bgl.baglanti());
            komut.Parameters.AddWithValue("@ID",txt_firmaID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Firma silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
            firmaListele();
            Temizle(this);
            



        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_FIRMALAR SET " +
         "AD=@AD, YETKILISTATU=@YETKILISTATU, YETKILIADSOYAD=@YETKILIADSOYAD, YETKILITC=@YETKILITC, SEKTOR=@SEKTOR, TELEFON1=@TELEFON1, TELEFON2=@TELEFON2, TELEFON3=@TELEFON3, MAIL=@MAIL, FAX=@FAX, IL=@IL, ILCE=@ILCE, VERGIDAIRE=@VERGIDAIRE, ADRES=@ADRES, OZELKOD1=@OZELKOD1, OZELKOD2=@OZELKOD2, OZELKOD3=@OZELKOD3 WHERE ID=@ID",bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_firmaID.Text);
            komut.Parameters.AddWithValue("@AD", txt_Ad.Text);
            komut.Parameters.AddWithValue("@YETKILISTATU", txt_yetkiligorev.Text);
            komut.Parameters.AddWithValue("@YETKILIADSOYAD", txt_yetkili.Text);
            komut.Parameters.AddWithValue("@YETKILITC", msktext_yetkilitc.Text);
            komut.Parameters.AddWithValue("@SEKTOR", txt_sektor.Text);
            komut.Parameters.AddWithValue("@TELEFON1", msktext_tel1.Text);
            komut.Parameters.AddWithValue("@TELEFON2", msktext_tel2.Text);
            komut.Parameters.AddWithValue("@TELEFON3", msktext_tel3.Text);
            komut.Parameters.AddWithValue("@MAIL", txt_mail.Text);
            komut.Parameters.AddWithValue("@FAX", msktext_fax.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@VERGIDAIRE", txt_vergidaire.Text);
            komut.Parameters.AddWithValue("@ADRES", rtxtbox_adres.Text);
            komut.Parameters.AddWithValue("@OZELKOD1", txt_kod1.Text);
            komut.Parameters.AddWithValue("@OZELKOD2", txt_kod2.Text);
            komut.Parameters.AddWithValue("@OZELKOD3", txt_kod3.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Firma güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bgl.baglanti().Close();
            firmaListele();
            Temizle(this);

        }
    }
}
