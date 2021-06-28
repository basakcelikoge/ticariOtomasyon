
namespace Ticari_Otomasyon1
{
    partial class frm_Notlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Notlar));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_notlar = new DevExpress.XtraGrid.GridControl();
            this.msk_tarih = new System.Windows.Forms.MaskedTextBox();
            this.msk_saat = new System.Windows.Forms.MaskedTextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_detay = new System.Windows.Forms.RichTextBox();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_olusturan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_baslik = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_hitap = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.link_temizle = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_notlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_olusturan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_baslik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hitap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl_notlar;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // gridControl_notlar
            // 
            this.gridControl_notlar.Location = new System.Drawing.Point(3, 4);
            this.gridControl_notlar.MainView = this.gridView1;
            this.gridControl_notlar.Name = "gridControl_notlar";
            this.gridControl_notlar.Size = new System.Drawing.Size(1089, 628);
            this.gridControl_notlar.TabIndex = 4;
            this.gridControl_notlar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // msk_tarih
            // 
            this.msk_tarih.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msk_tarih.Location = new System.Drawing.Point(79, 65);
            this.msk_tarih.Mask = "00/00/0000";
            this.msk_tarih.Name = "msk_tarih";
            this.msk_tarih.Size = new System.Drawing.Size(149, 23);
            this.msk_tarih.TabIndex = 2;
            this.msk_tarih.ValidatingType = typeof(System.DateTime);
            // 
            // msk_saat
            // 
            this.msk_saat.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msk_saat.Location = new System.Drawing.Point(79, 94);
            this.msk_saat.Mask = "00:00";
            this.msk_saat.Name = "msk_saat";
            this.msk_saat.Size = new System.Drawing.Size(149, 23);
            this.msk_saat.TabIndex = 3;
            this.msk_saat.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(36, 207);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(37, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Detay:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.link_temizle);
            this.groupControl1.Controls.Add(this.txt_detay);
            this.groupControl1.Controls.Add(this.msk_tarih);
            this.groupControl1.Controls.Add(this.msk_saat);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.txt_olusturan);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_baslik);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_hitap);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1098, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 628);
            this.groupControl1.TabIndex = 5;
            // 
            // txt_detay
            // 
            this.txt_detay.Location = new System.Drawing.Point(79, 207);
            this.txt_detay.Name = "txt_detay";
            this.txt_detay.Size = new System.Drawing.Size(149, 125);
            this.txt_detay.TabIndex = 7;
            this.txt_detay.Text = "";
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sil.ImageOptions.SvgImage")));
            this.btn_sil.Location = new System.Drawing.Point(94, 415);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(109, 38);
            this.btn_sil.TabIndex = 9;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kaydet.ImageOptions.SvgImage")));
            this.btn_kaydet.Location = new System.Drawing.Point(94, 371);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(109, 38);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // txt_olusturan
            // 
            this.txt_olusturan.Location = new System.Drawing.Point(79, 151);
            this.txt_olusturan.Name = "txt_olusturan";
            this.txt_olusturan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_olusturan.Properties.Appearance.Options.UseFont = true;
            this.txt_olusturan.Size = new System.Drawing.Size(149, 22);
            this.txt_olusturan.TabIndex = 5;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(39, 185);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(34, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Hitap:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 157);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Oluşturan:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 129);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Başlık:";
            // 
            // txt_baslik
            // 
            this.txt_baslik.Location = new System.Drawing.Point(79, 123);
            this.txt_baslik.Name = "txt_baslik";
            this.txt_baslik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_baslik.Properties.Appearance.Options.UseFont = true;
            this.txt_baslik.Size = new System.Drawing.Size(149, 22);
            this.txt_baslik.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(42, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Saat:";
            // 
            // txt_hitap
            // 
            this.txt_hitap.Location = new System.Drawing.Point(79, 179);
            this.txt_hitap.Name = "txt_hitap";
            this.txt_hitap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_hitap.Properties.Appearance.Options.UseFont = true;
            this.txt_hitap.Size = new System.Drawing.Size(149, 22);
            this.txt_hitap.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(38, 72);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tarih:";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(79, 37);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_ID.Properties.Appearance.Options.UseFont = true;
            this.txt_ID.Size = new System.Drawing.Size(149, 22);
            this.txt_ID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // link_temizle
            // 
            this.link_temizle.Location = new System.Drawing.Point(115, 336);
            this.link_temizle.Name = "link_temizle";
            this.link_temizle.Size = new System.Drawing.Size(61, 13);
            this.link_temizle.TabIndex = 27;
            this.link_temizle.Text = "Formu Yenile";
            this.link_temizle.Click += new System.EventHandler(this.link_temizle_Click);
            // 
            // frm_Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl_notlar);
            this.Name = "frm_Notlar";
            this.Text = "Notlar";
            this.Load += new System.EventHandler(this.frm_Notlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_notlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_olusturan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_baslik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_hitap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl_notlar;
        private System.Windows.Forms.MaskedTextBox msk_tarih;
        private System.Windows.Forms.MaskedTextBox msk_saat;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox txt_detay;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.TextEdit txt_olusturan;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_baslik;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_hitap;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.HyperlinkLabelControl link_temizle;
    }
}