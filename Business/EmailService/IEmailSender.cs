using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Business.EmailService
{
    public interface IEmailSender
    {
        void SendEmail(MailMessage emailMessage);
    }
}
