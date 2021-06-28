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
    public partial class frm_Musteriler : Form
    {
        public frm_Musteriler()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();
        void listele_musteri()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from TBL_MUSTERILER", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl_musterıler.DataSource = dataTable;
        }
        public void Temizle(Control control)
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


        private void frm_Musteriler_Load(object sender, EventArgs e)
        {
            listele_musteri();
            sehirListele();
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

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("INSERT INTO TBL_MUSTERILER (AD, SOYAD, TELEFON, TELEFON2, TC, MAIL, IL, ILCE, ADRES, VERGIDAIRE) VALUES (@AD, @SOYAD, @TELEFON, @TELEFON2, @TC, @MAIL, @IL, @ILCE, @ADRES, @VERGIDAIRE)", bgl.baglanti());
            komut.Parameters.AddWithValue("@AD", txt_Ad.Text);
            komut.Parameters.AddWithValue("@SOYAD", txt_soyad.Text);
            komut.Parameters.AddWithValue("@TELEFON", msktext_tel1.Text);
            komut.Parameters.AddWithValue("@TELEFON2", msktext_tel2.Text);
            komut.Parameters.AddWithValue("@TC", msktext_tc.Text);
            komut.Parameters.AddWithValue("@MAIL", txt_mail.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@ADRES", rtxtbox_adres.Text);
            komut.Parameters.AddWithValue("@VERGIDAIRE", txt_vergidaire.Text);
            DialogResult result = MessageBox.Show("Ürün Eklensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
            }
            bgl.baglanti().Close();
     
            listele_musteri();
            Temizle(this);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_MUSTERILER where ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_musteriID.Text);
            DialogResult dialog = MessageBox.Show("Müşteri Silinsin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
            }
            
            bgl.baglanti().Close();

            listele_musteri();
            Temizle(this);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                txt_musteriID.Text = row["ID"].ToString();
                txt_Ad.Text = row[1].ToString();
                txt_soyad.Text = row["SOYAD"].ToString();
                msktext_tel1.Text = row["TELEFON"].ToString();
                msktext_tel2.Text = row["TELEFON2"].ToString();
                msktext_tc.Text = row["TC"].ToString();
                txt_mail.Text = row["MAIL"].ToString();
                cmb_il.Text = row["IL"].ToString();
                cmb_ilce.Text = row["ILCE"].ToString();
                rtxtbox_adres.Text = row["ADRES"].ToString();
                txt_vergidaire.Text = row["VERGIDAIRE"].ToString();
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_MUSTERILER SET AD=@AD, SOYAD=@SOYAD, TELEFON=@TELEFON, TELEFON2=@TELEFON2, TC=@TC, MAIL=@MAIL,IL=@IL ,ILCE=@ILCE, ADRES=@ADRES, VERGIDAIRE=@VERGIDAIRE WHERE ID=@ID", bgl.baglanti());
            komut.Parameters.AddWithValue("@ID",txt_musteriID.Text);
            komut.Parameters.AddWithValue("@AD", txt_Ad.Text);
            komut.Parameters.AddWithValue("@SOYAD", txt_soyad.Text);
            komut.Parameters.AddWithValue("@TELEFON", msktext_tel1.Text);
            komut.Parameters.AddWithValue("@TELEFON2", msktext_tel2.Text);
            komut.Parameters.AddWithValue("@TC", msktext_tc.Text);
            komut.Parameters.AddWithValue("@MAIL", txt_mail.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@ADRES", rtxtbox_adres.Text);
            komut.Parameters.AddWithValue("@VERGIDAIRE", txt_vergidaire.Text);
            DialogResult result = MessageBox.Show("Ürün Güncellensin mi?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                komut.ExecuteNonQuery();
            }
          
            bgl.baglanti().Close();
            listele_musteri();
            Temizle(this);
        }
    }
}
