using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace User_Managment.Services
{
    public class EmailSender : IEmailSender
    {
        public  async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var fromMail = "enter your mail";
            var fromMailPassword = "enter password";
            var message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(email);
            message.Body = $"<html><body></body{htmlMessage}></html>";
            message.IsBodyHtml = true;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromMail, fromMailPassword)
            };
            smtp.Send(message);
        }
    }
}
