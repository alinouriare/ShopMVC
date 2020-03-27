using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace MyEshop.Classes
{
    public class SendEmailGmail
    {
        public static void Send(string To, string Subject, string Body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");  // For Gmail

            SmtpClient SmtpServery = new SmtpClient("smtp.mail.yahoo.com"); //  For Yahoo

            mail.From = new MailAddress("alinouriare@gmail.com","علی نوری");
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);
                       SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("alinouriare@gmail.com", "1366315ali");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}
