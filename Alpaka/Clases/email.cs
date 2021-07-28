using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace Alpaka.Clases
{
    public class email
    {
        public static void EnviarCorreo(string para,string asunto,string body) {
            //enviar mail
            MailMessage mensaje = new MailMessage();
            mensaje.From = new MailAddress("your email");
            mensaje.To.Add(para);
            mensaje.Subject = asunto;
            mensaje.IsBodyHtml = false;
            mensaje.Body = body;
            SmtpClient enviar = new SmtpClient();
            enviar.Host = "smtp.gmail.com";
            System.Net.NetworkCredential credencial = new System.Net.NetworkCredential();
            credencial.UserName = "your email";
            credencial.Password = "password";
            enviar.UseDefaultCredentials = true;
            enviar.Credentials = credencial;
            enviar.Port = 587;
            enviar.EnableSsl = true;
            enviar.Send(mensaje);
        }
    }
}