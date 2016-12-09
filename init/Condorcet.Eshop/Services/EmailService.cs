using System;
using Condorcet.Eshop.Interfaces;
using System.Net.Mail;
using System.Net;

namespace Condorcet.Eshop.Services
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string email)
        {
            var client = new SmtpClient("relay.skynet.be", 587)
            {
                Credentials = new NetworkCredential("adrien.clerbois@skynet.be", "xxxxx"),
                EnableSsl = true
            };

            MailMessage mail = new MailMessage("adrien.clerbois@skynet.be", email)
            {
                Subject = "[Condorcet eShop] Santa message",
                IsBodyHtml = true,
                Body = "<a href=\"http://www.wallpaperup.com/uploads/wallpapers/2013/10/20/163130/big_thumb_d8ab0c28f1f6c285057d8ba75837ba98.jpg\" />Message for you from Santa Claus</a>"
            };
            client.Send(mail);
        }
    }
}