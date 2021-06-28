using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace Ticari_Otomasyon1
{
    public partial class frm_mail : Form
    {
        public frm_mail()
        {
            InitializeComponent();
        }
        public string mail;
        private void frm_mail_Load(object sender, EventArgs e)
        {
            txt_mailAdres.Text = mail;


        }

        private void btn_gonder_Click(object sender, EventArgs e)
        {
            //MailMessage message = new MailMessage();
            //SmtpClient client = new SmtpClient();
            //client.Credentials = new System.Net.NetworkCredential("basakoge2020@gmail.com","bbcc1407");
            //client.Port = 587;
            //client.Host = "smtp.gmail.com";
            //client.EnableSsl = true;
            //message.To.Add(txt_mailAdres.Text);
            //message.From = new MailAddress("basakoge2020@gmail.com");
            //message.Subject = txt_konu.Text;
            //message.Body = txt_mesaj.Text;
            //client.Send(message);

            //SmtpClient Client = new SmtpClient("smtp.gmail.com", 587);
            //Client.EnableSsl = false;
            //Client.UseDefaultCredentials = true;
            //Client.Credentials = new System.Net.NetworkCredential("basakoge2020@gmail.com", "bbcc1407");
            //MailMessage msg = new MailMessage("fmkinsaatservis@gmail.com", txt_mailAdres.Text, txt_konu.Text, txt_mesaj.Text);
            //Client.Send(msg);
            //txt_konu.Text = string.Empty;
            //txt_mailAdres.Text = string.Empty;
            //txt_mesaj.Text = string.Empty;


            //SmtpClient smtpClient = new SmtpClient("basakoge2020@gmail.com", 587);
            //smtpClient.UseDefaultCredentials = false;
            //smtpClient.Credentials = new System.Net.NetworkCredential("basakoge2020@gmail.com", "bbcc1407");
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.EnableSsl = true;

            //MailMessage mail = new MailMessage();

            //mail.From = new MailAddress("basakoge2020@gmail.com", "User");
            //mail.To.Add(new MailAddress("celikbsk@live.com"));
            ////ServicePointManager.ServerCertificateValidationCallback = delegate (object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) { return true; };
            //mail.Body = txt_mesaj.Text;
            //smtpClient.Send(mail);


        }
    }
}
