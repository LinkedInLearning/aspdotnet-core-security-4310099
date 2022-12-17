using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace SecurityApp.MVC.Services
{
    public class EmailSender : IEmailSender
    {
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var apiKey = "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";

            var client = new SendGridClient(apiKey);

            var msg = new SendGridMessage()
            {
                From = new EmailAddress("ervistrupja@gmail.com", "Ervis Trupja - Password Recovery"),
                Subject = subject,
                PlainTextContent = htmlMessage,
                HtmlContent = htmlMessage
            };
            msg.AddTo(email);

            msg.SetClickTracking(false, false);

            var response = await client.SendEmailAsync(msg);
        }
    }
}
