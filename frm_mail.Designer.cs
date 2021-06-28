
namespace Ticari_Otomasyon1
{
    partial class frm_mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_mail));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mailAdres = new DevExpress.XtraEditors.TextEdit();
            this.txt_konu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_mesaj = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_gonder = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_mailAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_konu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(35, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mail Adresi:";
            // 
            // txt_mailAdres
            // 
            this.txt_mailAdres.Location = new System.Drawing.Point(125, 54);
            this.txt_mailAdres.Name = "txt_mailAdres";
            this.txt_mailAdres.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_mailAdres.Properties.Appearance.Options.UseFont = true;
            this.txt_mailAdres.Size = new System.Drawing.Size(344, 26);
            this.txt_mailAdres.TabIndex = 1;
            // 
            // txt_konu
            // 
            this.txt_konu.Location = new System.Drawing.Point(125, 100);
            this.txt_konu.Name = "txt_konu";
            this.txt_konu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txt_konu.Properties.Appearance.Options.UseFont = true;
            this.txt_konu.Size = new System.Drawing.Size(344, 26);
            this.txt_konu.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(77, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Konu:";
            // 
            // txt_mesaj
            // 
            this.txt_mesaj.Location = new System.Drawing.Point(125, 146);
            this.txt_mesaj.Name = "txt_mesaj";
            this.txt_mesaj.Size = new System.Drawing.Size(344, 349);
            this.txt_mesaj.TabIndex = 3;
            this.txt_mesaj.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(73, 146);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 19);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Mesaj:";
            // 
            // btn_gonder
            // 
            this.btn_gonder.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btn_gonder.Appearance.Options.UseFont = true;
            this.btn_gonder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.btn_gonder.Location = new System.Drawing.Point(236, 530);
            this.btn_gonder.Name = "btn_gonder";
            this.btn_gonder.Size = new System.Drawing.Size(133, 49);
            this.btn_gonder.TabIndex = 4;
            this.btn_gonder.Text = "Gönder";
            this.btn_gonder.Click += new System.EventHandler(this.btn_gonder_Click);
            // 
            // frm_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 655);
            this.Controls.Add(this.btn_gonder);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_mesaj);
            this.Controls.Add(this.txt_konu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_mailAdres);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_mail";
            this.Text = "MAIL";
            this.Load += new System.EventHandler(this.frm_mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_mailAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_konu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_mailAdres;
        private DevExpress.XtraEditors.TextEdit txt_konu;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.RichTextBox txt_mesaj;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_gonder;
    }
}