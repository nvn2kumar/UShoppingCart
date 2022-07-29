using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace UShoppingCart.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }
        public async Task Execute(string email, string subject, string Body)
        {
           
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.From = new MailAddress("verifyotp9@gmail.com");
                mail.Subject = subject;
                //string Body = $"Your OTP is <b> {Otp}</b>  <br/>thanks for choosing us.";
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("verifyotp9@gmail.com", "mjwaixbdrmwtxhtl"); // Enter seders User name and password  
                smtp.EnableSsl = true;
                smtp.Send(mail);

        }
    }

}
