using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Sakany.Services
{
    public class EmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public async Task SendEmailWithAttachmentAsync(
            string toEmail,
            string toName,
            string subject,
            string htmlBody,
            byte[] attachmentBytes,
            string attachmentFileName)
        {
            var settings = _config.GetSection("EmailSettings");

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(settings["FromName"], settings["Username"]));
            message.To.Add(new MailboxAddress(toName, toEmail));
            message.Subject = subject;

            var builder = new BodyBuilder { HtmlBody = htmlBody };
            builder.Attachments.Add(
                attachmentFileName,
                attachmentBytes,
                ContentType.Parse("application/pdf"));

            message.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(
                settings["Host"],
                int.Parse(settings["Port"]!),
                SecureSocketOptions.StartTls);

            await smtp.AuthenticateAsync(settings["Username"], settings["Password"]);
            await smtp.SendAsync(message);
            await smtp.DisconnectAsync(true);
        }
    }
}