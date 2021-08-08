using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Mail_App_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendmail()
        {
            MailMessage message = new MailMessage();

            SmtpClient sender = new SmtpClient();

            sender.Credentials = new  System.Net.NetworkCredential("lastsaha2752@gmail.com", "Aynur123456789");

            sender.Port = 587;

            sender.EnableSsl = true;

            sender.Host = "smtp.gmail.com";

            message.To.Add($"{txtboxreciever.Text.Trim()}");

            message.From = new MailAddress("lastsaha2752@gmail.com");

            message.Subject="Mail Dersi c#";

            message.Body = $"{txtboxtext.Text}";

            sender.Send(message);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sendmail();
        }
    }
}
