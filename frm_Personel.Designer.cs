
namespace Ticari_Otomasyon1
{
    partial class frm_Personel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Personel));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_personel = new DevExpress.XtraGrid.GridControl();
            this.rtxtbox_adres = new System.Windows.Forms.RichTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_ilce = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_il = new DevExpress.XtraEditors.ComboBoxEdit();
            this.msktext_tc = new System.Windows.Forms.MaskedTextBox();
            this.msktext_tel1 = new System.Windows.Forms.MaskedTextBox();
            this.txt_gorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
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
            this.txt_PersonlID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_personel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PersonlID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl_personel;
            this.gridView1.GroupPanelText = "D";
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl_personel
            // 
            this.gridControl_personel.Location = new System.Drawing.Point(1, -4);
            this.gridControl_personel.MainView = this.gridView1;
            this.gridControl_personel.Name = "gridControl_personel";
            this.gridControl_personel.Size = new System.Drawing.Size(1083, 638);
            this.gridControl_personel.TabIndex = 4;
            this.gridControl_personel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // rtxtbox_adres
            // 
            this.rtxtbox_adres.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.rtxtbox_adres.Location = new System.Drawing.Point(93, 273);
            this.rtxtbox_adres.Name = "rtxtbox_adres";
            this.rtxtbox_adres.Size = new System.Drawing.Size(111, 96);
            this.rtxtbox_adres.TabIndex = 10;
            this.rtxtbox_adres.Text = "";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(53, 273);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(38, 16);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "Adres:";
            // 
            // cmb_ilce
            // 
            this.cmb_ilce.Location = new System.Drawing.Point(93, 220);
            this.cmb_ilce.Name = "cmb_ilce";
            this.cmb_ilce.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_ilce.Properties.Appearance.Options.UseFont = true;
            this.cmb_ilce.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ilce.Size = new System.Drawing.Size(111, 22);
            this.cmb_ilce.TabIndex = 8;
            // 
            // cmb_il
            // 
            this.cmb_il.Location = new System.Drawing.Point(93, 194);
            this.cmb_il.Name = "cmb_il";
            this.cmb_il.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_il.Properties.Appearance.Options.UseFont = true;
            this.cmb_il.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_il.Size = new System.Drawing.Size(111, 22);
            this.cmb_il.TabIndex = 7;
            this.cmb_il.SelectedIndexChanged += new System.EventHandler(this.cmb_il_SelectedIndexChanged);
            // 
            // msktext_tc
            // 
            this.msktext_tc.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msktext_tc.Location = new System.Drawing.Point(93, 141);
            this.msktext_tc.Mask = "00000000000";
            this.msktext_tc.Name = "msktext_tc";
            this.msktext_tc.Size = new System.Drawing.Size(111, 23);
            this.msktext_tc.TabIndex = 5;
            this.msktext_tc.ValidatingType = typeof(int);
            // 
            // msktext_tel1
            // 
            this.msktext_tel1.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.msktext_tel1.Location = new System.Drawing.Point(93, 114);
            this.msktext_tel1.Mask = "(999) 000-0000";
            this.msktext_tel1.Name = "msktext_tel1";
            this.msktext_tel1.Size = new System.Drawing.Size(111, 23);
            this.msktext_tel1.TabIndex = 4;
            // 
            // txt_gorev
            // 
            this.txt_gorev.Location = new System.Drawing.Point(93, 246);
            this.txt_gorev.Name = "txt_gorev";
            this.txt_gorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_gorev.Properties.Appearance.Options.UseFont = true;
            this.txt_gorev.Size = new System.Drawing.Size(111, 22);
            this.txt_gorev.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(53, 252);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(38, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Görev:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(66, 226);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(25, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "İlçe:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.rtxtbox_adres);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.cmb_ilce);
            this.groupControl1.Controls.Add(this.cmb_il);
            this.groupControl1.Controls.Add(this.msktext_tc);
            this.groupControl1.Controls.Add(this.msktext_tel1);
            this.groupControl1.Controls.Add(this.txt_gorev);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
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
            this.groupControl1.Controls.Add(this.txt_PersonlID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1090, -4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 638);
            this.groupControl1.TabIndex = 5;
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_guncelle.ImageOptions.SvgImage")));
            this.btn_guncelle.Location = new System.Drawing.Point(93, 474);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(111, 38);
            this.btn_guncelle.TabIndex = 19;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sil.ImageOptions.SvgImage")));
            this.btn_sil.Location = new System.Drawing.Point(93, 430);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(111, 38);
            this.btn_sil.TabIndex = 18;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kaydet.ImageOptions.SvgImage")));
            this.btn_kaydet.Location = new System.Drawing.Point(93, 386);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(111, 38);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(79, 200);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(12, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "İl:";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(93, 168);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_mail.Properties.Appearance.Options.UseFont = true;
            this.txt_mail.Size = new System.Drawing.Size(111, 22);
            this.txt_mail.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(63, 174);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(28, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Mail:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(51, 148);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "TC No:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(36, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(55, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Telefon1:";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(93, 88);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_soyad.Properties.Appearance.Options.UseFont = true;
            this.txt_soyad.Size = new System.Drawing.Size(111, 22);
            this.txt_soyad.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(51, 94);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(40, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Soyad:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(93, 62);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_Ad.Properties.Appearance.Options.UseFont = true;
            this.txt_Ad.Size = new System.Drawing.Size(111, 22);
            this.txt_Ad.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(71, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ad:";
            // 
            // txt_PersonlID
            // 
            this.txt_PersonlID.Enabled = false;
            this.txt_PersonlID.Location = new System.Drawing.Point(93, 36);
            this.txt_PersonlID.Name = "txt_PersonlID";
            this.txt_PersonlID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_PersonlID.Properties.Appearance.Options.UseFont = true;
            this.txt_PersonlID.Size = new System.Drawing.Size(111, 22);
            this.txt_PersonlID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(74, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // frm_Personel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl_personel);
            this.Name = "frm_Personel";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.frm_Personel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_personel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ilce.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_il.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_gorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_soyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PersonlID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl_personel;
        private System.Windows.Forms.RichTextBox rtxtbox_adres;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private System.Windows.Forms.MaskedTextBox msktext_tc;
        private System.Windows.Forms.MaskedTextBox msktext_tel1;
        private DevExpress.XtraEditors.TextEdit txt_gorev;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl1;
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
        private DevExpress.XtraEditors.TextEdit txt_PersonlID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_ilce;
        public DevExpress.XtraEditors.ComboBoxEdit cmb_il;
    }
}