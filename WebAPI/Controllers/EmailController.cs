
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Net.Mail;
//using System.Threading.Tasks;

//namespace WebAPI.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class EmailController : ControllerBase
//    {


//        [HttpPost]

//        public IActionResult SendEmail(string email)
//        {
//            var ePosta = new MailMessage();
//            ePosta.From = new MailAddress("ouzozztech@yandex.com", "Oguzcan");
//            ePosta.To.Add("ouzozztech@yandex.com");
//            ePosta.Subject = "Test Email";
//            ePosta.Body = "deneme mailidir";

//            SmtpClient smtp = new SmtpClient();

//            smtp.Credentials = new System.Net.NetworkCredential("ouzozztech@yandex.com", "ouzozztech1!");
//            smtp.Port = 465;
//            smtp.Host = "smtp.yandex.com";
//            smtp.EnableSsl = true;

//            smtp.Send(ePosta);
//            smtp.Timeout = 10;
//            object userState = ePosta;
//            bool control = true;


//            return Ok();
//        }
//    }
//}
