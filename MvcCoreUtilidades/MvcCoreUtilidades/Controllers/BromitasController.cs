using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MvcCoreUtilidades.Providers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MvcCoreUtilidades.Controllers
{
    public class BromitasController : Controller
    {

        private PathProvider pathProvider;
        private IConfiguration Configuration;

        public BromitasController(PathProvider pathProvider, IConfiguration Configuration)
        {
            this.pathProvider = pathProvider;
            this.Configuration = Configuration;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string accion,string destinatario, string asunto, string mensaje, IFormFile fichero)
        { 
            if (accion == "empezar")
            {
                int n = 0;
                int contador = 0;
                while (n == 0)
                {
                    contador++;
                    MailMessage mail = new MailMessage();
                    string user = this.Configuration.GetValue<string>("MailSettings:user");
                    mail.From = new MailAddress(user);
                    mail.To.Add(new MailAddress(destinatario));
                    mail.Subject = asunto+""+contador;
                    mail.Body = mensaje;
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.Normal;

                    if (fichero != null)
                    {
                        string fileName = fichero.FileName;
                        string path = this.pathProvider.MapPath(fileName, Folders.Temp);
                        using (Stream stream = new FileStream(path, FileMode.Create))
                        {
                            await fichero.CopyToAsync(stream);
                        }
                        Attachment attachment = new Attachment(path);
                        mail.Attachments.Add(attachment);
                    }
                    string host = this.Configuration.GetValue<string>("MailSettings:Host");
                    string password = this.Configuration.GetValue<string>("MailSettings:Password");
                    SmtpClient client = new SmtpClient();
                    client.Host = host;
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    NetworkCredential credentials = new NetworkCredential(user, password);
                    client.Credentials = credentials;
                    client.Send(mail);
                }
                    
                
            }
            
            
            
           
            return View();
        }


    }
}
