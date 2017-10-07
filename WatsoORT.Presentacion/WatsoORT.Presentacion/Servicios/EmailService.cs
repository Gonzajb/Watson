using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace WatsonORT.Presentacion.Servicios
{
    public class EmailService
    {
        private string emailAuthentication;
        private string passwordAuthentication;
        private string nameAuthentication;
        private string host = "smtp.gmail.com";
        private int port = 587;
        /// <summary>
        /// Recibe el Email y la Contraseña de autenticación al mail. Por defecto, la autenticación utilizada será a través de GMAIL.
        /// </summary>
        /// <param name="emailAuthentication"></param>
        /// <param name="passwordAuthentication"></param>
        /// <param name="nameAuthentication"></param>
        public EmailService(string emailAuthentication, string passwordAuthentication, string nameAuthentication) {
            this.emailAuthentication = emailAuthentication;
            this.passwordAuthentication = passwordAuthentication;
            this.nameAuthentication = nameAuthentication;
        }
        public EmailService(string emailAuthentication, string passwordAuthentication, string nameAuthentication, string host, int port) {
            this.host = host;
            this.port = port;
        }
        public void SendEmail(string subject, string body, List<string> toAddresses) {
            var fromAddress = new MailAddress(this.emailAuthentication, this.nameAuthentication);
            string fromPassword = this.passwordAuthentication;

            var smtp = new SmtpClient
            {
                Host = this.host,
                Port = this.port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            var message = new MailMessage()
            {
                From = fromAddress,
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            };
            foreach (var item in toAddresses)
            {
                var toAddress = new MailAddress(item);
                message.To.Add(toAddress);
            }
            using (message)
            {
                smtp.Send(message);
            }
        }
    }
}