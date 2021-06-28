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
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
       

        private void txt_sifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlCommand komut = new SqlCommand("select * from TBL_ADMIN where KullaniciAd=@p1 and Sifre=@p2", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", txt_kullaniciAd.Text);
                komut.Parameters.AddWithValue("@p2", txt_sifre.Text);
                SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                {
                    frm_Anamodul fr = new frm_Anamodul();
                    fr.kullanici = txt_kullaniciAd.Text;                
                    fr.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                bgl.baglanti().Close();
            }

        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
