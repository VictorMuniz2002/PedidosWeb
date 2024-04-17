
using System.Net.Mail;

namespace PedidosWeb.Components.Services
{
    public static class MailService
    {
        public static string SendMail()
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress("asfhalt.cho8@gmail.com");
                    mail.To.Add("vmunizvesteiro@gmail.com");
                    mail.Subject = "Mail enviado";
                    mail.Body = "<h1>Cuerpo del email</h1>";
                    mail.IsBodyHtml = true;

                    string attachment = $"{Directory.GetCurrentDirectory()}{@"\wwwroot\img\Captura.PNG"}";

                    mail.Attachments.Add(new Attachment(attachment));

                    using SmtpClient smtp = new("smtp.mundo-r.com", 25);
                    smtp.Send(mail);
                    return "Email enviado";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
