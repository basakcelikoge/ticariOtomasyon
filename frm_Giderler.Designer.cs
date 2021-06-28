
namespace Ticari_Otomasyon1
{
    partial class frm_Giderler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Giderler));
            this.txt_not = new System.Windows.Forms.RichTextBox();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_yıl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_ay = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_ekstra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.btn_guncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sil = new DevExpress.XtraEditors.SimpleButton();
            this.btn_kaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_dogalgaz = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_internet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_maaslar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_giderlerID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_giderler = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_su = new DevExpress.XtraEditors.TextEdit();
            this.txt_elektrik = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_yıl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ekstra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dogalgaz.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_internet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maaslar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giderlerID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_giderler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_su.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_elektrik.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_not
            // 
            this.txt_not.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_not.Location = new System.Drawing.Point(83, 323);
            this.txt_not.Name = "txt_not";
            this.txt_not.Size = new System.Drawing.Size(115, 96);
            this.txt_not.TabIndex = 10;
            this.txt_not.Text = "";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(52, 321);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(24, 16);
            this.labelControl11.TabIndex = 32;
            this.labelControl11.Text = "Not:";
            // 
            // cmb_yıl
            // 
            this.cmb_yıl.Location = new System.Drawing.Point(83, 95);
            this.cmb_yıl.Name = "cmb_yıl";
            this.cmb_yıl.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_yıl.Properties.Appearance.Options.UseFont = true;
            this.cmb_yıl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_yıl.Properties.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.cmb_yıl.Size = new System.Drawing.Size(115, 22);
            this.cmb_yıl.TabIndex = 3;
            // 
            // cmb_ay
            // 
            this.cmb_ay.Location = new System.Drawing.Point(83, 67);
            this.cmb_ay.Name = "cmb_ay";
            this.cmb_ay.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.cmb_ay.Properties.Appearance.Options.UseFont = true;
            this.cmb_ay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_ay.Properties.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.cmb_ay.Size = new System.Drawing.Size(115, 22);
            this.cmb_ay.TabIndex = 2;
            // 
            // txt_ekstra
            // 
            this.txt_ekstra.Location = new System.Drawing.Point(83, 284);
            this.txt_ekstra.Name = "txt_ekstra";
            this.txt_ekstra.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_ekstra.Properties.Appearance.Options.UseFont = true;
            this.txt_ekstra.Size = new System.Drawing.Size(115, 22);
            this.txt_ekstra.TabIndex = 9;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(36, 290);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(40, 16);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "Ekstra:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(26, 259);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 16);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "Maaşlar:";
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_guncelle.Appearance.Options.UseFont = true;
            this.btn_guncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_guncelle.ImageOptions.SvgImage")));
            this.btn_guncelle.Location = new System.Drawing.Point(83, 513);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(115, 38);
            this.btn_guncelle.TabIndex = 13;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_sil.Appearance.Options.UseFont = true;
            this.btn_sil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sil.ImageOptions.SvgImage")));
            this.btn_sil.Location = new System.Drawing.Point(83, 469);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(115, 38);
            this.btn_sil.TabIndex = 12;
            this.btn_sil.Text = "SİL";
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.btn_kaydet.Appearance.Options.UseFont = true;
            this.btn_kaydet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_kaydet.ImageOptions.SvgImage")));
            this.btn_kaydet.Location = new System.Drawing.Point(83, 425);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(115, 38);
            this.btn_kaydet.TabIndex = 11;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 228);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(50, 16);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "İnternet:";
            // 
            // txt_dogalgaz
            // 
            this.txt_dogalgaz.Location = new System.Drawing.Point(83, 194);
            this.txt_dogalgaz.Name = "txt_dogalgaz";
            this.txt_dogalgaz.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_dogalgaz.Properties.Appearance.Options.UseFont = true;
            this.txt_dogalgaz.Size = new System.Drawing.Size(115, 22);
            this.txt_dogalgaz.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(19, 197);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(57, 16);
            this.labelControl8.TabIndex = 13;
            this.labelControl8.Text = "Doğalgaz:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(56, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 16);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Su:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(30, 135);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Elektrik:";
            // 
            // txt_internet
            // 
            this.txt_internet.Location = new System.Drawing.Point(83, 219);
            this.txt_internet.Name = "txt_internet";
            this.txt_internet.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_internet.Properties.Appearance.Options.UseFont = true;
            this.txt_internet.Size = new System.Drawing.Size(115, 22);
            this.txt_internet.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(58, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(18, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Yıl:";
            // 
            // txt_maaslar
            // 
            this.txt_maaslar.Location = new System.Drawing.Point(83, 253);
            this.txt_maaslar.Name = "txt_maaslar";
            this.txt_maaslar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_maaslar.Properties.Appearance.Options.UseFont = true;
            this.txt_maaslar.Size = new System.Drawing.Size(115, 22);
            this.txt_maaslar.TabIndex = 8;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(57, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(19, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Ay:";
            // 
            // txt_giderlerID
            // 
            this.txt_giderlerID.Enabled = false;
            this.txt_giderlerID.Location = new System.Drawing.Point(83, 36);
            this.txt_giderlerID.Name = "txt_giderlerID";
            this.txt_giderlerID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_giderlerID.Properties.Appearance.Options.UseFont = true;
            this.txt_giderlerID.Size = new System.Drawing.Size(115, 22);
            this.txt_giderlerID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(59, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl_giderler;
            this.gridView1.GroupPanelText = "D";
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl_giderler
            // 
            this.gridControl_giderler.Location = new System.Drawing.Point(9, -1);
            this.gridControl_giderler.MainView = this.gridView1;
            this.gridControl_giderler.Name = "gridControl_giderler";
            this.gridControl_giderler.Size = new System.Drawing.Size(1083, 638);
            this.gridControl_giderler.TabIndex = 6;
            this.gridControl_giderler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_su);
            this.groupControl1.Controls.Add(this.txt_elektrik);
            this.groupControl1.Controls.Add(this.txt_not);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.cmb_yıl);
            this.groupControl1.Controls.Add(this.cmb_ay);
            this.groupControl1.Controls.Add(this.txt_ekstra);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.btn_guncelle);
            this.groupControl1.Controls.Add(this.btn_sil);
            this.groupControl1.Controls.Add(this.btn_kaydet);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_dogalgaz);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txt_internet);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txt_maaslar);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txt_giderlerID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1098, -1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(273, 638);
            this.groupControl1.TabIndex = 7;
            // 
            // txt_su
            // 
            this.txt_su.Location = new System.Drawing.Point(83, 160);
            this.txt_su.Name = "txt_su";
            this.txt_su.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_su.Properties.Appearance.Options.UseFont = true;
            this.txt_su.Size = new System.Drawing.Size(115, 22);
            this.txt_su.TabIndex = 5;
            // 
            // txt_elektrik
            // 
            this.txt_elektrik.Location = new System.Drawing.Point(83, 129);
            this.txt_elektrik.Name = "txt_elektrik";
            this.txt_elektrik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.txt_elektrik.Properties.Appearance.Options.UseFont = true;
            this.txt_elektrik.Size = new System.Drawing.Size(115, 22);
            this.txt_elektrik.TabIndex = 4;
            // 
            // frm_Giderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 636);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl_giderler);
            this.Name = "frm_Giderler";
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.frm_Giderler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmb_yıl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_ay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ekstra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_dogalgaz.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_internet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_maaslar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_giderlerID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_giderler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_su.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_elektrik.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_not;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_yıl;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_ay;
        private DevExpress.XtraEditors.TextEdit txt_ekstra;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btn_guncelle;
        private DevExpress.XtraEditors.SimpleButton btn_sil;
        private DevExpress.XtraEditors.SimpleButton btn_kaydet;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_dogalgaz;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_internet;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_maaslar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_giderlerID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl_giderler;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_su;
        private DevExpress.XtraEditors.TextEdit txt_elektrik;
    }
}