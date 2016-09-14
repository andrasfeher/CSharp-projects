using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Mail;

namespace SendMail
{
    class Program
    {
        static void Main(string[] args)
        {
            SmtpClient  mySmtpClient    = new SmtpClient();
            MailMessage myMailMessage   = new MailMessage();
            MailAddress fromMailAddress = new MailAddress("feher_a@freemail.hu");
            MailAddress toMailAddress   = new MailAddress("feher@biofeedback.hu");

            myMailMessage.From = fromMailAddress;
            myMailMessage.To.Add(toMailAddress);
            myMailMessage.Subject = "C# mail teszt";
            myMailMessage.Body    = "Ez egy teszt üzenet";

            mySmtpClient.Host = "mail.menthanet.hu";
            mySmtpClient.Port = 25;
            mySmtpClient.Send(myMailMessage);
        }
    }
}
