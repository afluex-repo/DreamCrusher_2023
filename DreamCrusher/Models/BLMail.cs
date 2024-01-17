using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace DreamCrusher.Models
{
    public class BLMail
    {
        
        public static void SendPayPayoutMail(string UserName, string Amount, string TransactionDate, string Subject, string MailId)
        {
            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            string str = string.Empty;
            string MailText = string.Empty;
            message.From = new MailAddress("dreamcrushers2023@gmail.com");
            using (StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/SendPayPayoutMail/PayPayouMail.html")))
            {
                MailText = reader.ReadToEnd();
            }
            MailText = MailText.Replace("[UserName]", UserName);
            MailText = MailText.Replace("[Amount]", Amount);
            MailText = MailText.Replace("[TransactionDate]", TransactionDate);
            message.Subject = Subject;
            message.IsBodyHtml = true; //to make message body as html  
            message.Body = MailText;
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com"; //for gmail host  
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("dreamcrushers2023@gmail.com", "yayp vjni xwas mvni");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;
            message.To.Add(new MailAddress(MailId));
            smtp.Send(message);
        }

        



    }
}