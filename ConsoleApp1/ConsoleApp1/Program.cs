using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;



class Program
{
    static void Main()
    {
        MailAddress from = new MailAddress("tnik8080@gmail.com", "Nik");
        MailAddress to = new MailAddress("golumvicerlid35@gmail.com");
        MailMessage m = new MailMessage(from, to);
        m.Subject = "Тест";
        m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
        m.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.Credentials = new NetworkCredential("tnik8080@gmail.com", "DD123123");
        smtp.EnableSsl = true;
        smtp.Send(m);
        Console.Read();
    }
}