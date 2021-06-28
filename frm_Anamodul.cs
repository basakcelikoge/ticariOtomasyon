using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon1
{
    public partial class frm_Anamodul : Form
    {
        public frm_Anamodul()
        {
            InitializeComponent();
        }

        frm_Urunler frm_Urunler;
        public string kullanici;
        //int SimdikiWidth = 1366;

        //int SimdikiHeight = 768;

        private void btn_urunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (frm_Urunler == null || frm_Urunler.IsDisposed)
            {
                frm_Urunler = new frm_Urunler();
                frm_Urunler.MdiParent = this;
                frm_Urunler.Show();
            }

        }
        frm_Musteriler frm_Musteriler;
        private void btn_musteri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Musteriler == null || frm_Musteriler.IsDisposed)
            {
                frm_Musteriler = new frm_Musteriler();
                frm_Musteriler.MdiParent = this;
                frm_Musteriler.Show();
            }
        }
        frm_Firmalar frm_Firmalar;

        private void btn_firma_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Firmalar == null || frm_Firmalar.IsDisposed)
            {
                frm_Firmalar = new frm_Firmalar();
                frm_Firmalar.MdiParent = this;
                frm_Firmalar.Show();
            }
        }
        frm_Personel frm_Personel;
        private void btn_personel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Personel == null || frm_Personel.IsDisposed)
            {
                frm_Personel = new frm_Personel();
                frm_Personel.MdiParent = this;
                frm_Personel.Show();
            }
        }
        frm_Rehber frm_Rehber;
        private void btn_rehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Rehber == null || frm_Rehber.IsDisposed)
            {
                frm_Rehber = new frm_Rehber();
                frm_Rehber.MdiParent = this;
                frm_Rehber.Show();
            }
        }
        frm_Giderler frm_Giderler;
        private void btn_giderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Giderler == null || frm_Giderler.IsDisposed)
            {
                frm_Giderler = new frm_Giderler();
                frm_Giderler.MdiParent = this;
                frm_Giderler.Show();
            }
        }
        frm_Bankalar frm_Bankalar;
        private void btn_banka_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Bankalar == null || frm_Bankalar.IsDisposed)
            {
                frm_Bankalar = new frm_Bankalar();
                frm_Bankalar.MdiParent = this;
                frm_Bankalar.Show();
            }
        }
        frm_Faturalar frm_Faturalar;
        private void btn_fatura_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Faturalar == null || frm_Faturalar.IsDisposed)
            {
                frm_Faturalar = new frm_Faturalar();
                frm_Faturalar.MdiParent = this;
                frm_Faturalar.Show();
            }
        }
        frm_Notlar frm_Notlar;

        private void btn_not_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Notlar ==null || frm_Notlar.IsDisposed)
            {
                frm_Notlar = new frm_Notlar();
                frm_Notlar.MdiParent = this;
                frm_Notlar.Show();
            }
        }
        frm_Hareketler frm_Hareketler;
        private void btn_hareketler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Hareketler == null || frm_Hareketler.IsDisposed)
            {
                frm_Hareketler = new frm_Hareketler();
                frm_Hareketler.MdiParent = this;
                frm_Hareketler.Show();
            }
        }
        frm_Raporlar frm_Raporlar;
        private void btn_raporlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Raporlar == null || frm_Raporlar.IsDisposed)
            {
                frm_Raporlar = new frm_Raporlar();
                frm_Raporlar.MdiParent = this;
                frm_Raporlar.Show();
            }
        }
        frm_Stoklar frm_Stoklar;
        private void btn_stok_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Stoklar == null || frm_Stoklar.IsDisposed)
            {
                frm_Stoklar = new frm_Stoklar();
                frm_Stoklar.MdiParent = this;
                frm_Stoklar.Show();
            }
        }
        frm_Ayarlar frm_Ayarlar;
        private void btn_ayarlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Ayarlar == null || frm_Ayarlar.IsDisposed)
            {
                frm_Ayarlar = new frm_Ayarlar();
              
                frm_Ayarlar.Show();
            }
        }
        frm_Kasa frm_Kasa;
        private void btn_kasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Kasa == null || frm_Kasa.IsDisposed)
            {
                frm_Kasa = new frm_Kasa();
                frm_Kasa.ad = kullanici;
                frm_Kasa.MdiParent = this;
                frm_Kasa.Show();
            }
        }
        frm_Anasayfa frm_Anasayfa;
  private void btn_anasayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frm_Anasayfa == null || frm_Anasayfa.IsDisposed)
            {
                frm_Anasayfa = new frm_Anasayfa();
             
                frm_Anasayfa.MdiParent = this;
                frm_Anasayfa.Show();
            }
        }

        private void frm_Anamodul_Load(object sender, EventArgs e)
        {
            //Rectangle ClientCozunurluk = new Rectangle();

            //ClientCozunurluk = Screen.GetBounds(ClientCozunurluk);

            //float OranWidth = ((float)ClientCozunurluk.Width / (float)SimdikiWidth);

            //float OranHeight = ((float)ClientCozunurluk.Height / (float)SimdikiHeight);

            if (frm_Anasayfa == null || frm_Anasayfa.IsDisposed)
            {
                frm_Anasayfa = new frm_Anasayfa();

                frm_Anasayfa.MdiParent = this;
                frm_Anasayfa.Show();
            }

        }

      
    }
}
