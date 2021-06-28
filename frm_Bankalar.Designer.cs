
namespace Ticari_Otomasyon1
{
    partial class frm_Bankalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Bankalar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_bankalar = new DevExpress.XtraGrid.GridControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_il = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msktext_iban = new System.Windows.Forms.MaskedTextBox();
            this.txt_yetkili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.msk_tarih = new System.Windows.Forms.MaskedTextBox();
            this.txt_hesapturu = new DevExpress.XtraEditors.TextEdit();
            this.msk_Telefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_hesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_sube = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_BankaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_bankaID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bankalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yetkili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hesapturu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sube.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BankaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bankaID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl_bankalar;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl_bankalar
            // 
            this.gridControl_bankalar.Location = new System.Drawing.Point(9, 4);
            this.gridControl_bankalar.MainView = this.gridView1;
            this.gridControl_bankalar.Name = "gridControl_bankalar";
            this.gridControl_bankalar.Size = new System.Drawing.Size(1083, 628);
            this.gridControl_bankalar.TabIndex = 4;
            this.gridControl_bankalar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(64, 293);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(35, 16);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "Tarih:";
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.Location = new System.Drawing.Point(105, 103);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_ilce.Properties.Appearance.Options.UseFont = true;
            this.cmb_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ilce.Size = new System.Drawing.Size(106, 22);
            this.cmb_ilce.TabIndex = 31;
            // 
            // cmb_il
            // 
            this.cmb_il.Location = new System.Drawing.Point(105, 75);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_il.Properties.Appearance.Options.UseFont = true;
            this.cmb_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_il.Size = new System.Drawing.Size(106, 22);
            this.cmb_il.TabIndex = 30;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged_1);
            // 
            // msktext_iban
            // 
            this.msktext_iban.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msktext_iban.Location = new System.Drawing.Point(105, 154);
            this.msktext_iban.Mask = "TR00000000000";
            this.msktext_iban.Name = "msktext_iban";
            this.msktext_iban.Size = new System.Drawing.Size(106, 23);
            this.msktext_iban.TabIndex = 29;
            this.msktext_iban.ValidatingType = typeof(int);
            // 
            // txt_yetkili
            // 
            this.txt_yetkili.Location = new System.Drawing.Point(104, 233);
            this.txt_yetkili.Name = "txt_yetkili";
            this.txt_yetkili.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_yetkili.Properties.Appearance.Options.UseFont = true;
            this.txt_yetkili.Size = new System.Drawing.Size(106, 22);
            this.txt_yetkili.TabIndex = 25;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(61, 239);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Yetkili:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(74, 109);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(25, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(38, 319);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 16);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Firma Adı:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.msk_tarih);
            this.groupControl1.Controls.Add(this.txt_hesapturu);
            this.groupControl1.Controls.Add(this.msk_Telefon);
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.cmb_ilce);
            this.groupControl1.Controls.Add(this.cmb_il);
            this.groupControl1.Controls.Add(this.msktext_iban);
            this.groupControl1.Controls.Add(this.txt_yetkili);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_hesapNo);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_sube);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_BankaAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_bankaID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1097, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 628);
            this.groupControl1.TabIndex = 5;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(104, 313);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(106, 22);
            this.lookUpEdit1.TabIndex = 38;
            // 
            // msk_tarih
            // 
            this.msk_tarih.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msk_tarih.Location = new System.Drawing.Point(104, 286);
            this.msk_tarih.Mask = "00/00/0000";
            this.msk_tarih.Name = "msk_tarih";
            this.msk_tarih.Size = new System.Drawing.Size(106, 23);
            this.msk_tarih.TabIndex = 37;
            this.msk_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // txt_hesapturu
            // 
            this.txt_hesapturu.Location = new System.Drawing.Point(104, 207);
            this.txt_hesapturu.Name = "txt_hesapturu";
            this.txt_hesapturu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_hesapturu.Properties.Appearance.Options.UseFont = true;
            this.txt_hesapturu.Size = new System.Drawing.Size(106, 22);
            this.txt_hesapturu.TabIndex = 36;
            // 
            // msk_Telefon
            // 
            this.msk_Telefon.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msk_Telefon.Location = new System.Drawing.Point(104, 259);
            this.msk_Telefon.Mask = "(999) 000-0000";
            this.msk_Telefon.Name = "msk_Telefon";
            this.msk_Telefon.Size = new System.Drawing.Size(106, 23);
            this.msk_Telefon.TabIndex = 35;
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(51, 266);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 16);
            this.labelControl12.TabIndex = 34;
            this.labelControl12.Text = "Telefon:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_guncelle.ImageOptions.SvgImage")));
            this.btn_guncelle.Location = new System.Drawing.Point(104, 439);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(106, 33);
            this.btn_guncelle.TabIndex = 19;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sil.ImageOptions.SvgImage")));
            this.btn_sil.Location = new System.Drawing.Point(104, 395);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(106, 33);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kaydet.ImageOptions.SvgImage")));
            this.btn_kaydet.Location = new System.Drawing.Point(104, 351);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(106, 33);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(87, 83);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(12, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "İl:";
            // 
            // txt_hesapNo
            // 
            this.txt_hesapNo.Location = new System.Drawing.Point(105, 181);
            this.txt_hesapNo.Name = "txt_hesapNo";
            this.txt_hesapNo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_hesapNo.Properties.Appearance.Options.UseFont = true;
            this.txt_hesapNo.Size = new System.Drawing.Size(106, 22);
            this.txt_hesapNo.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(40, 187);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Hesap No:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(69, 161);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(30, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Iban:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 213);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = " Hesap Türü:";
            // 
            // txt_sube
            // 
            this.txt_sube.Location = new System.Drawing.Point(105, 128);
            this.txt_sube.Name = "txt_sube";
            this.txt_sube.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_sube.Properties.Appearance.Options.UseFont = true;
            this.txt_sube.Size = new System.Drawing.Size(106, 22);
            this.txt_sube.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(65, 134);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Şube:";
            // 
            // txt_BankaAd
            // 
            this.txt_BankaAd.Location = new System.Drawing.Point(105, 51);
            this.txt_BankaAd.Name = "txt_BankaAd";
            this.txt_BankaAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_BankaAd.Properties.Appearance.Options.UseFont = true;
            this.txt_BankaAd.Size = new System.Drawing.Size(106, 22);
            this.txt_BankaAd.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(41, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Banka Ad:";
            // 
            // txt_bankaID
            // 
            this.txt_bankaID.Enabled = false;
            this.txt_bankaID.Location = new System.Drawing.Point(105, 26);
            this.txt_bankaID.Name = "txt_bankaID";
            this.txt_bankaID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_bankaID.Properties.Appearance.Options.UseFont = true;
            this.txt_bankaID.Size = new System.Drawing.Size(106, 22);
            this.txt_bankaID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(82, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frm_Bankalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl_bankalar);
            this.Name = "frm_Bankalar";
            this.Text = "Bankalar";
            this.Load += new System.EventHandler(this.frm_Bankalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_bankalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_yetkili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hesapturu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sube.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_BankaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_bankaID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl_bankalar;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_il;
        private System.Windows.Forms.MaskedTextBox msktext_iban;
        private DevExpress.XtraEditors.TextEdit txt_yetkili;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.MaskedTextBox msk_tarih;
        private DevExpress.XtraEditors.TextEdit txt_hesapturu;
        private System.Windows.Forms.MaskedTextBox msk_Telefon;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_hesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_sube;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_BankaAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_bankaID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}