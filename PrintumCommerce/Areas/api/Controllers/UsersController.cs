using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PrintumCommerce.Areas.api.Models;
using System.Web.Mvc;
using System.Threading.Tasks;
using PrintumCommerce.Models;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using PrintumCommerce.ClassHelper;
using System.Net.Mail;
using System.Web.Configuration;

namespace PrintumCommerce.Areas.api.Controllers
{
    public class UsersController : ApiController
    {

        private Model1 db = new Model1();
        [System.Web.Http.Authorize]
        public IQueryable<Users> GetUsers()
        {
            return db.Users;
        }

        [ResponseType(typeof(Users))]
        public IHttpActionResult GetUsers(int id)
        {
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }
        [System.Web.Http.Authorize]
        public IHttpActionResult GetUsers(int id,string palme)
        {
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }
        [System.Web.Http.Authorize]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUsers(int id, Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != users.UserId)
            {
                return BadRequest();
            }

            db.Entry(users).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsersExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }
        [ResponseType(typeof(Users))]
        public  IHttpActionResult PostUsers(Users users)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                db.Users.Add(users);
                db.SaveChanges();
                UsersHelper.CreateUserASP(users.UserName, "User");
                //await SendMail();
                string s = String.Format("hoy {0}, se registró un usuario con correo {1}. y con nombre {2} y apellido {3}",
                             DateTime.Now, users.UserName, users.FirstName, users.LastName);
                string s1 = String.Format("hoy {0}, se registró un usuario con correo {1}.",
                             DateTime.Now, users.UserName);
                var task = SendMail("soporte@printum-uv.com", s1, s);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.InnerException != null && ex.InnerException.Message.Contains("Index"))
                {
                    ModelState.AddModelError(string.Empty, "La casilla {0} ya existe en la tabla");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            
            return CreatedAtRoute("DefaultApi", new { id = users.UserId }, users);
        }

        public static async Task SendMail(string to, string subject, string body)
        {
            var message = new MailMessage();
            message.To.Add(new MailAddress(to));
            message.From = new MailAddress(WebConfigurationManager.AppSettings["AdminUser"]);
            message.Subject = subject;
            message.Body = body;
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = WebConfigurationManager.AppSettings["AdminUser"],
                    Password = WebConfigurationManager.AppSettings["AdminPassWord"]
                };

                smtp.Credentials = credential;
                smtp.Host = WebConfigurationManager.AppSettings["SMTPName"];
                smtp.Port = int.Parse(WebConfigurationManager.AppSettings["SMTPPort"]);
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);
            }
        }
        [System.Web.Http.Authorize]
        [ResponseType(typeof(Users))]
        public IHttpActionResult DeleteUsers(int id)
        {
            Users users = db.Users.Find(id);
            if (users == null)
            {
                return NotFound();
            }

            db.Users.Remove(users);
            db.SaveChanges();

            return Ok(users);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UsersExists(int id)
        {
            return db.Users.Count(e => e.UserId == id) > 0;
        }
    }
}