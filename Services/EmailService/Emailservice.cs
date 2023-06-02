using login4.Models;
using MailKit.Net.Smtp;
using MimeKit;

namespace login4.Services.EmailService
{
    public class Emailservice : IEmailService
    {
        private readonly IConfiguration _config;
        public Emailservice(IConfiguration config) 
        {
            _config = config;
        }
        public void SendEmail(EmailDto request)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailSettings")["EmailUserName"]));
            email.To.Add(MailboxAddress.Parse(request.To));
            email.Subject = request.Subject;
            email.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = request.Body };

            using var smtp = new SmtpClient();
            smtp.Connect(_config.GetSection("EmailSettings")["EmailHost"], int.Parse(_config.GetSection("EmailSettings")["Port"]), MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate(_config.GetSection("EmailSettings")["EmailUserName"], _config.GetSection("EmailSettings")["EmailPassword"]);
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
