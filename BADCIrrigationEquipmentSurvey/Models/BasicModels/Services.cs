using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BADCIrrigationEquipmentSurvey.Models.Services
{
    public class EmailSender : IEmailSender
    {

        // Our private configuration variables
        private int port;
        private string host;
        private readonly bool enableSSL;
        private string userName;
        private string password;

        // Get our parameterized configuration
        public EmailSender(string host, int port, bool enableSsl, string userName, string password)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSsl;
            this.userName = userName;
            this.password = password;
        }

        // Use our configuration to send the email by using SmtpClient
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(host, port)
            {
                Credentials = new NetworkCredential(userName, password),
                EnableSsl = enableSSL
            };
            return client.SendMailAsync(
                new MailMessage(userName, email, subject, htmlMessage) { IsBodyHtml = true }
            );
        }
    }
}