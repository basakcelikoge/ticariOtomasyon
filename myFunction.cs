using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticari_Otomasyon1
{
    public class myFunction
    {
        sqlBaglanti bgl = new sqlBaglanti();
        public void Temizle(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if (item is RichTextBox)
                {
                    ((RichTextBox)item).Clear();
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }

                if (item.Controls.Count > 0)
                {
                    Temizle(item);
                }
            }
        }
      
        



    }
}
