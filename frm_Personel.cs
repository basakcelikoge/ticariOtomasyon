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
    public partial class frm_Personel : Form
    {
        public frm_Personel()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        //public void Temizle(Control control)
        //{
        //    foreach (Control item in control.Controls)
        //    {
        //        if (item is TextBox)
        //        {
        //            ((TextBox)item).Clear();
        //        }
        //        if (item is RichTextBox)
        //        {
        //            ((RichTextBox)item).Clear();
        //        }
        //        if (item is MaskedTextBox)
        //        {
        //            ((MaskedTextBox)item).Clear();
        //        }

        //        if (item.Controls.Count > 0)
        //        {
        //            Temizle(item);
        //        }
        //    }
        //}
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
        void PersonelListele()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TBL_PERSONELLER", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            gridControl_personel.DataSource = dataTable;
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
        myFunction myFunction = new myFunction();
        private void frm_Personel_Load(object sender, EventArgs e)
        {
         
            sehirListele();
            PersonelListele();
    
            myFunction.Temizle(this);
           
           

        }
     
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_PERSONELLER (AD, SOYAD, TELEFON, TC, MAIL, IL, ILCE, ADRES, GOREV)values (@AD, @SOYAD, @TELEFON, @TC, @MAIL, @IL,@ILCE,@ADRES,@GOREV)", bgl.baglanti());
            komut.Parameters.AddWithValue("@AD", txt_Ad.Text);
            komut.Parameters.AddWithValue("@SOYAD", txt_soyad.Text);
            komut.Parameters.AddWithValue("@TELEFON", msktext_tel1.Text);
            komut.Parameters.AddWithValue("@TC", msktext_tc.Text);
            komut.Parameters.AddWithValue("@MAIL", txt_mail.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@ADRES", rtxtbox_adres.Text);
            komut.Parameters.AddWithValue("@GOREV", txt_gorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            PersonelListele();
            myFunction.Temizle(this);


        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (row != null)
            {
                txt_PersonlID.Text = row[0].ToString();
                txt_Ad.Text = row[1].ToString();
                txt_soyad.Text = row[2].ToString();
                msktext_tel1.Text = row[3].ToString();
                msktext_tc.Text = row[4].ToString();
                txt_mail.Text = row[5].ToString();
                cmb_il.Text = row[6].ToString();
                cmb_ilce.Text = row[7].ToString();
                rtxtbox_adres.Text = row[8].ToString();
                txt_gorev.Text = row[9].ToString();

            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from TBL_PERSONELLER where ID=@ID",bgl.baglanti());
            komut.Parameters.AddWithValue("@ID",txt_PersonlID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel silindi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            PersonelListele();
            myFunction.Temizle(this);

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE TBL_PERSONELLER SET AD=@AD, SOYAD=@SOYAD, TELEFON=@TELEFON, TC=@TC, MAIL=@MAIL, IL=@IL, ILCE=@ILCE, ADRES=@ADRES, GOREV=@GOREV WHERE ID=@ID",bgl.baglanti());
            komut.Parameters.AddWithValue("@ID", txt_PersonlID.Text);
            komut.Parameters.AddWithValue("@AD", txt_Ad.Text);
            komut.Parameters.AddWithValue("@SOYAD", txt_soyad.Text);
            komut.Parameters.AddWithValue("@TELEFON", msktext_tel1.Text);
            komut.Parameters.AddWithValue("@TC", msktext_tc.Text);
            komut.Parameters.AddWithValue("@MAIL", txt_mail.Text);
            komut.Parameters.AddWithValue("@IL", cmb_il.Text);
            komut.Parameters.AddWithValue("@ILCE", cmb_ilce.Text);
            komut.Parameters.AddWithValue("@ADRES", rtxtbox_adres.Text);
            komut.Parameters.AddWithValue("@GOREV", txt_gorev.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PersonelListele();
            myFunction.Temizle(this);
        }
    }
}
