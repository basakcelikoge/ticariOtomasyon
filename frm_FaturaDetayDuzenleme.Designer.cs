
namespace Ticari_Otomasyon1
{
    partial class frm_FaturaDetayDuzenleme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FaturaDetayDuzenleme));
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.txt_urunID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txt_urunAd = new DevExpress.XtraEditors.TextEdit();
            this.txt_miktar = new DevExpress.XtraEditors.TextEdit();
            this.txt_tutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_fiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fiyat.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.txt_urunID);
            this.groupControl5.Controls.Add(this.labelControl8);
            this.groupControl5.Controls.Add(this.txt_urunAd);
            this.groupControl5.Controls.Add(this.txt_miktar);
            this.groupControl5.Controls.Add(this.txt_tutar);
            this.groupControl5.Controls.Add(this.labelControl11);
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Controls.Add(this.txt_fiyat);
            this.groupControl5.Controls.Add(this.labelControl10);
            this.groupControl5.Controls.Add(this.labelControl9);
            this.groupControl5.Location = new System.Drawing.Point(12, 12);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.ShowCaption = false;
            this.groupControl5.Size = new System.Drawing.Size(311, 224);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "groupControl5";
            // 
            // txt_urunID
            // 
            this.txt_urunID.Location = new System.Drawing.Point(98, 36);
            this.txt_urunID.Name = "txt_urunID";
            this.txt_urunID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_urunID.Properties.Appearance.Options.UseFont = true;
            this.txt_urunID.Size = new System.Drawing.Size(137, 22);
            this.txt_urunID.TabIndex = 13;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(44, 39);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 16);
            this.labelControl8.TabIndex = 36;
            this.labelControl8.Text = "Ürün ID:";
            // 
            // txt_urunAd
            // 
            this.txt_urunAd.Location = new System.Drawing.Point(98, 64);
            this.txt_urunAd.Name = "txt_urunAd";
            this.txt_urunAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_urunAd.Properties.Appearance.Options.UseFont = true;
            this.txt_urunAd.Size = new System.Drawing.Size(137, 22);
            this.txt_urunAd.TabIndex = 14;
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(98, 92);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_miktar.Properties.Appearance.Options.UseFont = true;
            this.txt_miktar.Properties.Leave += new System.EventHandler(this.txt_tutar_EditValueChanged);
            this.txt_miktar.Size = new System.Drawing.Size(137, 22);
            this.txt_miktar.TabIndex = 15;
            // 
            // txt_tutar
            // 
            this.txt_tutar.Enabled = false;
            this.txt_tutar.Location = new System.Drawing.Point(98, 148);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_tutar.Properties.Appearance.Options.UseFont = true;
            this.txt_tutar.Size = new System.Drawing.Size(137, 22);
            this.txt_tutar.TabIndex = 17;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(56, 154);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 16);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "Tutar:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(38, 70);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Ürün Adı:";
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(98, 120);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_fiyat.Properties.Appearance.Options.UseFont = true;
            this.txt_fiyat.Properties.Leave += new System.EventHandler(this.txt_tutar_EditValueChanged);
            this.txt_fiyat.Size = new System.Drawing.Size(137, 22);
            this.txt_fiyat.TabIndex = 16;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(60, 126);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(32, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Fiyat:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(52, 98);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(40, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Miktar:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_guncelle.ImageOptions.SvgImage")));
            this.btn_guncelle.Location = new System.Drawing.Point(122, 256);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(116, 38);
            this.btn_guncelle.TabIndex = 17;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sil.ImageOptions.SvgImage")));
            this.btn_sil.Location = new System.Drawing.Point(122, 297);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(116, 38);
            this.btn_sil.TabIndex = 16;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // frm_FaturaDetayDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 402);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.groupControl5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_FaturaDetayDuzenleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Detay Duzenleme";
            this.Load += new System.EventHandler(this.frm_FaturaDetayDuzenleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_urunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_tutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_fiyat.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.TextEdit txt_urunID;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txt_urunAd;
        private DevExpress.XtraEditors.TextEdit txt_miktar;
        private DevExpress.XtraEditors.TextEdit txt_tutar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_fiyat;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
    }
}