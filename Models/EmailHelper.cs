using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Pulp.Models
{
    public class EmailHelper
    {
        public bool SendEmail(string userEmail, string confirmationLink)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("pulpiti41@gmail.com");
            mailMessage.To.Add(new MailAddress(userEmail));

            mailMessage.Subject = "Confirm your email";
            mailMessage.IsBodyHtml = true;
            mailMessage.Body = confirmationLink;

            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("pulpiti41@gmail.com", "iTi_intake41");
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.TargetName = "STARTTLS/smtp.gmail.com";


            try
            {
                client.Send(mailMessage);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);


                if (ex.InnerException != null)
                {
                    Debug.WriteLine($"Inner: { ex.InnerException}");

                }
            }
            return false;
        }
    }
}
