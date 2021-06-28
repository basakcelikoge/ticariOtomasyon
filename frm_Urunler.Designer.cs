
namespace Ticari_Otomasyon1
{
    partial class frm_Urunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Urunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.msktxt_yıl = new System.Windows.Forms.MaskedTextBox();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rtxt_detay = new System.Windows.Forms.RichTextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_satisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_alisfiyat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.nud_adet = new System.Windows.Forms.NumericUpDown();
            this.txt_model = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_marka = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_ID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_satisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alisfiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_marka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1083, 634);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.msktxt_yıl);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.rtxt_detay);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txt_satisfiyat);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_alisfiyat);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.nud_adet);
            this.groupControl1.Controls.Add(this.txt_model);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_marka);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_ad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_ID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1089, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 634);
            this.groupControl1.TabIndex = 1;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_guncelle.ImageOptions.SvgImage")));
            this.btn_guncelle.Location = new System.Drawing.Point(97, 423);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(109, 38);
            this.btn_guncelle.TabIndex = 19;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sil.ImageOptions.SvgImage")));
            this.btn_sil.Location = new System.Drawing.Point(97, 379);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(109, 38);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // msktxt_yıl
            // 
            this.msktxt_yıl.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msktxt_yıl.Location = new System.Drawing.Point(97, 138);
            this.msktxt_yıl.Mask = "0000";
            this.msktxt_yıl.Name = "msktxt_yıl";
            this.msktxt_yıl.Size = new System.Drawing.Size(109, 23);
            this.msktxt_yıl.TabIndex = 5;
            this.msktxt_yıl.ValidatingType = typeof(int);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kaydet.ImageOptions.SvgImage")));
            this.btn_kaydet.Location = new System.Drawing.Point(97, 335);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(109, 38);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // rtxt_detay
            // 
            this.rtxt_detay.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.rtxt_detay.Location = new System.Drawing.Point(97, 244);
            this.rtxt_detay.Name = "rtxt_detay";
            this.rtxt_detay.Size = new System.Drawing.Size(109, 76);
            this.rtxt_detay.TabIndex = 9;
            this.rtxt_detay.Text = "";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(57, 244);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(37, 16);
            this.labelControl9.TabIndex = 17;
            this.labelControl9.Text = "Detay:";
            // 
            // txt_satisfiyat
            // 
            this.txt_satisfiyat.Location = new System.Drawing.Point(97, 218);
            this.txt_satisfiyat.Name = "txt_satisfiyat";
            this.txt_satisfiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_satisfiyat.Properties.Appearance.Options.UseFont = true;
            this.txt_satisfiyat.Size = new System.Drawing.Size(109, 22);
            this.txt_satisfiyat.TabIndex = 8;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(30, 224);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(64, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Satış Fiyat:";
            // 
            // txt_alisfiyat
            // 
            this.txt_alisfiyat.Location = new System.Drawing.Point(97, 192);
            this.txt_alisfiyat.Name = "txt_alisfiyat";
            this.txt_alisfiyat.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_alisfiyat.Properties.Appearance.Options.UseFont = true;
            this.txt_alisfiyat.Size = new System.Drawing.Size(109, 22);
            this.txt_alisfiyat.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(38, 198);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Alış Fiyat:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(76, 145);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(18, 16);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Yıl:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(63, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Adet:";
            // 
            // nud_adet
            // 
            this.nud_adet.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.nud_adet.Location = new System.Drawing.Point(97, 165);
            this.nud_adet.Name = "nud_adet";
            this.nud_adet.Size = new System.Drawing.Size(109, 23);
            this.nud_adet.TabIndex = 6;
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(97, 112);
            this.txt_model.Name = "txt_model";
            this.txt_model.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_model.Properties.Appearance.Options.UseFont = true;
            this.txt_model.Size = new System.Drawing.Size(109, 22);
            this.txt_model.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(55, 118);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(39, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Model:";
            // 
            // txt_marka
            // 
            this.txt_marka.Location = new System.Drawing.Point(97, 86);
            this.txt_marka.Name = "txt_marka";
            this.txt_marka.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_marka.Properties.Appearance.Options.UseFont = true;
            this.txt_marka.Size = new System.Drawing.Size(109, 22);
            this.txt_marka.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(54, 92);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Marka:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(97, 60);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_ad.Properties.Appearance.Options.UseFont = true;
            this.txt_ad.Size = new System.Drawing.Size(109, 22);
            this.txt_ad.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(74, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad:";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(97, 34);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_ID.Properties.Appearance.Options.UseFont = true;
            this.txt_ID.Size = new System.Drawing.Size(109, 22);
            this.txt_ID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(77, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frm_Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_Urunler";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.frm_Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_satisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_alisfiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_model.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_marka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.RichTextBox rtxt_detay;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txt_satisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_alisfiyat;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.NumericUpDown nud_adet;
        private DevExpress.XtraEditors.TextEdit txt_model;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_marka;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_ad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_ID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private System.Windows.Forms.MaskedTextBox msktxt_yıl;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
    }
}