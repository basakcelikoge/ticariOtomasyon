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
using DevExpress.Charts;

namespace Ticari_Otomasyon1
{
    public partial class frm_Kasa : Form
    {
        public frm_Kasa()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        myFunction myFunction = new myFunction();

        void MusteriHareket()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXECUTE MUSTERI_HAREKET", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_musteri.DataSource = data;
        }
        void FirmaHareket()
        {
            DataTable data = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("EXECUTE FIRMA_HAREKET", bgl.baglanti());
            dataAdapter.Fill(data);
            gridControl_frima.DataSource = data;
        }
        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {
     
        }
        public string ad;
        private void frm_Kasa_Load(object sender, EventArgs e)
        {
            MusteriHareket();
            FirmaHareket();
            lbl_aktifKullanici.Text = ad;


            //TOPLAM TUTAR
            SqlCommand komut = new SqlCommand("select SUM(TUTAR)FROM TBL_FATURADETAY",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbl_toplamTutar.Text = (dr[0]+" ₺").ToString();
            }bgl.baglanti().Close();

            //SON ÖDEME
            SqlCommand komut2 = new SqlCommand("exec SonOdeme", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbl_odemeler.Text = (dr2[0] + " ₺").ToString();
            }
            bgl.baglanti().Close();

            //SON ÖDENEN MAAŞ

            SqlCommand komut3 = new SqlCommand("SELECT TOP 1 MAASLAR FROM TBL_GIDERLER ORDER BY ID DESC", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lbl_personelMaas.Text = (dr3[0] + " ₺").ToString();
            }
            bgl.baglanti().Close();

            //MÜŞTERİ SAYISI

            SqlCommand komut4 = new SqlCommand("SELECT COUNT(ID) FROM TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lbl_musteriSayisi.Text = dr4[0].ToString();
            }
            bgl.baglanti().Close();


            //FİRMA SAYISI

            SqlCommand komut5 = new SqlCommand("SELECT COUNT(ID) FROM TBL_FIRMALAR", bgl.baglanti());
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbl_firmaSayisi.Text = dr5[0].ToString();
            }
            bgl.baglanti().Close();

            //ŞEHİR SAYISI
            SqlCommand komut6 = new SqlCommand( "Select count (DISTINCT(IL) )FROM TBL_FIRMALAR", bgl.baglanti());
            SqlCommand komut7 = new SqlCommand( "Select COUNT(DISTINCT(IL))  FROM TBL_MUSTERILER", bgl.baglanti());
            SqlDataReader dr6 = komut6.ExecuteReader();
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr6.Read()&& dr7.Read())
            {
                lbl_sehirSayisi.Text = "Firma şehir:" +dr6[0].ToString() + Environment.NewLine + "Müşteri şehir:" + dr7[0].ToString();
                
            }
            bgl.baglanti().Close();

            //PERSONEL SAYISI
            SqlCommand komut8 = new SqlCommand("select count (ID) from TBL_PERSONELLER",bgl.baglanti());
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lbl_personelSayisi.Text = dr8[0].ToString();
            }
            bgl.baglanti().Close();

            //STOK SAYISI
            SqlCommand komut9 = new SqlCommand("SELECT SUM(ADET) FROM TBL_URUNLER", bgl.baglanti());
            SqlDataReader dr9 = komut9.ExecuteReader();
            while (dr9.Read())
            {
                lbl_stokSayisi.Text = dr9[0].ToString();
            }
            bgl.baglanti().Close();

            SqlDataAdapter command = new SqlDataAdapter("select * from TBL_GIDERLER",bgl.baglanti());
            DataTable data = new DataTable();
            command.Fill(data);
            gridControl1.DataSource = data;
            

         
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac>0 && sayac<=5)
            {
                // elektrik faturası son 4 ay
                SqlCommand komut10 = new SqlCommand("SELECT TOP 4 AY,ELEKTIRK FROM TBL_GIDERLER order by ID DESC", bgl.baglanti());
                SqlDataReader dr10 = komut10.ExecuteReader();
                while (dr10.Read())
                {
                    chartControl2.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr10[0], dr10[1]));
                }
                bgl.baglanti().Close();


            }
            if (sayac>5 && sayac<=10)
            {
                chartControl2.Series["Aylar"].Points.Clear();
                //su faturası son 4 ay
                SqlCommand komut11 = new SqlCommand("SELECT TOP 4 AY,SU FROM TBL_GIDERLER order by ID DESC", bgl.baglanti());
                SqlDataReader dr11 = komut11.ExecuteReader();
                while (dr11.Read())
                {
                    chartControl1.Series["Aylar"].Points.Add(new DevExpress.XtraCharts.SeriesPoint(dr11[0], dr11[1]));
                }
                bgl.baglanti().Close();
            }
            if (sayac ==10)
            {
                sayac = 0;
            }
        }
    }
}
