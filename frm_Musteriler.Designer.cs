
namespace Ticari_Otomasyon1
{
    partial class frm_Musteriler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Musteriler));
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_soyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Ad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_musteriID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.rtxtbox_adres = new System.Windows.Forms.RichTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_il = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msktext_tc = new System.Windows.Forms.MaskedTextBox();
            this.msktext_tel2 = new System.Windows.Forms.MaskedTextBox();
            this.msktext_tel1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_vergidaire = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl_musterıler = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteriID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vergidaire.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_musterıler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_guncelle.ImageOptions.SvgImage")));
            this.btn_guncelle.Location = new System.Drawing.Point(95, 497);
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
            this.btn_sil.Location = new System.Drawing.Point(95, 453);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(109, 38);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kaydet.ImageOptions.SvgImage")));
            this.btn_kaydet.Location = new System.Drawing.Point(95, 409);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(109, 38);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(77, 226);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(12, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "İl:";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(95, 194);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_mail.Properties.Appearance.Options.UseFont = true;
            this.txt_mail.Size = new System.Drawing.Size(109, 22);
            this.txt_mail.TabIndex = 7;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(61, 200);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Mail:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(49, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "TC No:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(34, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Telefon1:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(95, 88);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_soyad.Properties.Appearance.Options.UseFont = true;
            this.txt_soyad.Size = new System.Drawing.Size(109, 22);
            this.txt_soyad.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(49, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Soyad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(95, 62);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_Ad.Properties.Appearance.Options.UseFont = true;
            this.txt_Ad.Size = new System.Drawing.Size(109, 22);
            this.txt_Ad.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(69, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad:";
            // 
            // txt_musteriID
            // 
            this.txt_musteriID.Enabled = false;
            this.txt_musteriID.Location = new System.Drawing.Point(95, 36);
            this.txt_musteriID.Name = "txt_musteriID";
            this.txt_musteriID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_musteriID.Properties.Appearance.Options.UseFont = true;
            this.txt_musteriID.Size = new System.Drawing.Size(109, 22);
            this.txt_musteriID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(72, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rtxtbox_adres);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.cmb_ilce);
            this.groupControl1.Controls.Add(this.cmb_il);
            this.groupControl1.Controls.Add(this.msktext_tc);
            this.groupControl1.Controls.Add(this.msktext_tel2);
            this.groupControl1.Controls.Add(this.msktext_tel1);
            this.groupControl1.Controls.Add(this.txt_vergidaire);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_mail);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_soyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_Ad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_musteriID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1095, 6);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 628);
            this.groupControl1.TabIndex = 3;
            // 
            // rtxtbox_adres
            // 
            this.rtxtbox_adres.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.rtxtbox_adres.Location = new System.Drawing.Point(95, 298);
            this.rtxtbox_adres.Name = "rtxtbox_adres";
            this.rtxtbox_adres.Size = new System.Drawing.Size(109, 96);
            this.rtxtbox_adres.TabIndex = 33;
            this.rtxtbox_adres.Text = "";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(51, 298);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(38, 16);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "Adres:";
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.Location = new System.Drawing.Point(95, 246);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_ilce.Properties.Appearance.Options.UseFont = true;
            this.cmb_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ilce.Size = new System.Drawing.Size(109, 22);
            this.cmb_ilce.TabIndex = 31;
            // 
            // cmb_il
            // 
            this.cmb_il.Location = new System.Drawing.Point(95, 220);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_il.Properties.Appearance.Options.UseFont = true;
            this.cmb_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_il.Size = new System.Drawing.Size(109, 22);
            this.cmb_il.TabIndex = 30;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged);
            // 
            // msktext_tc
            // 
            this.msktext_tc.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msktext_tc.Location = new System.Drawing.Point(95, 168);
            this.msktext_tc.Mask = "00000000000";
            this.msktext_tc.Name = "msktext_tc";
            this.msktext_tc.Size = new System.Drawing.Size(109, 23);
            this.msktext_tc.TabIndex = 29;
            this.msktext_tc.ValidatingType = typeof(int);
            // 
            // msktext_tel2
            // 
            this.msktext_tel2.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msktext_tel2.Location = new System.Drawing.Point(95, 141);
            this.msktext_tel2.Mask = "(999) 000-0000";
            this.msktext_tel2.Name = "msktext_tel2";
            this.msktext_tel2.Size = new System.Drawing.Size(109, 23);
            this.msktext_tel2.TabIndex = 28;
            // 
            // msktext_tel1
            // 
            this.msktext_tel1.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msktext_tel1.Location = new System.Drawing.Point(95, 114);
            this.msktext_tel1.Mask = "(999) 000-0000";
            this.msktext_tel1.Name = "msktext_tel1";
            this.msktext_tel1.Size = new System.Drawing.Size(109, 23);
            this.msktext_tel1.TabIndex = 27;
            // 
            // txt_vergidaire
            // 
            this.txt_vergidaire.Location = new System.Drawing.Point(95, 272);
            this.txt_vergidaire.Name = "txt_vergidaire";
            this.txt_vergidaire.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_vergidaire.Properties.Appearance.Options.UseFont = true;
            this.txt_vergidaire.Size = new System.Drawing.Size(109, 22);
            this.txt_vergidaire.TabIndex = 25;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(11, 278);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(78, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Vergi Dairesi:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(64, 252);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(25, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "İlçe:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(34, 148);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(55, 16);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Telefon2:";
            // 
            // gridControl_musterıler
            // 
            this.gridControl_musterıler.Location = new System.Drawing.Point(6, 6);
            this.gridControl_musterıler.MainView = this.gridView1;
            this.gridControl_musterıler.Name = "gridControl_musterıler";
            this.gridControl_musterıler.Size = new System.Drawing.Size(1083, 628);
            this.gridControl_musterıler.TabIndex = 2;
            this.gridControl_musterıler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl_musterıler;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // frm_Musteriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl_musterıler);
            this.Name = "frm_Musteriler";
            this.Text = "Müşteriler";
            this.Load += new System.EventHandler(this.frm_Musteriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_musteriID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_vergidaire.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_musterıler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_mail;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_soyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Ad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_musteriID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_vergidaire;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gridControl_musterıler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.MaskedTextBox msktext_tc;
        private System.Windows.Forms.MaskedTextBox msktext_tel2;
        private System.Windows.Forms.MaskedTextBox msktext_tel1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ilce;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_il;
        private System.Windows.Forms.RichTextBox rtxtbox_adres;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}