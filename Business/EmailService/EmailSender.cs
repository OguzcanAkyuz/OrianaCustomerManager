using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

using MimeKit;

namespace Business.EmailService
{
    public class EmailSender : IEmailSender

    {
      
        private readonly EmailConfiguration _emailConfig;
        public EmailSender(EmailConfiguration emailConfig)
        {
            _emailConfig = emailConfig;
          
        }

        public void SendEmail(MailMessage emailMessage)
        {
            //var emailMessages = CreateEmailMessage(emailMessage);
            Send(emailMessage);
        }


        //private EmailMessage CreateEmailMessage(EmailMessage emailMessage)
        //{
        //    MailMessage emailMessages = new MailMessage();
        //    emailMessages.From.Add(new MailboxAddress("ouzozztech", "ouzozztech@yandex.com"));
        //    emailMessages.To.AddRange(emailMessage.To);
        //    emailMessages.Subject = emailMessage.Subject;
        //    emailMessages.Body = emailMessages.Body;
            

        //    return emailMessages;



        //}

        private void Send(MailMessage emailMessage)
        {
           // MimeMessage emailMessages = new MimeMessage();
           
            var basicCredential = new NetworkCredential("ouzozztech@yandex.com", "ouzozztech1!");
            using (var smtp = new SmtpClient())
            {
                
                try
                {
                    smtp.Credentials = basicCredential;
                    smtp.Port = 465;
                    smtp.UseDefaultCredentials = false;
                    smtp.Host = "smtp.yandex.com";
                    smtp.EnableSsl = true;
                    smtp.Timeout = int.MaxValue;
                    object userState = emailMessage;
                    bool control = true;

                    smtp.Send(emailMessage);

                }
                catch
                {
                    throw;
                }
                finally
                {
                    smtp.Dispose();
                }
            }
        }
    }
}
