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
    public partial class frm_Raporlar : Form
    {
        public frm_Raporlar()
        {
            InitializeComponent();
        }

        private void frm_Raporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'Ticari_OtomasyonDataSetMusteriler.TBL_MUSTERILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_MUSTERILERTableAdapter.Fill(this.Ticari_OtomasyonDataSetMusteriler.TBL_MUSTERILER);
            // TODO: Bu kod satırı 'Ticari_OtomasyonDataSet.TBL_FIRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_FIRMALARTableAdapter.Fill(this.Ticari_OtomasyonDataSet.TBL_FIRMALAR);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
            this.reportViewer5.RefreshReport();
        }
    }
}
