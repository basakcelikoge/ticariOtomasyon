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
    public partial class frm_NotDetay : Form
    {
        public frm_NotDetay()
        {
            InitializeComponent();
        }
        public string metin;
        private void frm_NotDetay_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = metin;
        }
    }
}
