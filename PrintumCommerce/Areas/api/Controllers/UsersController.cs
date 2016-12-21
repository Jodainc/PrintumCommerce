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
using PrintumCommerce.ClassHelper;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Web.Configuration;

namespace PrintumCommerce.Areas.api.Controllers
{
    public class UsersController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Users
        public IQueryable<User> GetUsers()
        {
            return db.Users;
        }

  
        [System.Web.Http.Route("api/Users/{name}")]
        [ResponseType(typeof(User))]
        public IHttpActionResult GetUsers(string name)
        {
            string a = name + ".com";
            var user = from r in db.Users
                       where r.UserName == a
                       select new
                       {
                           UserName = r.UserName,
                           UserId = r.UserId,
                           cedula = r.cedula,
                           CompanyId = r.CompanyId,
                           DepartmentId = r.DepartmentId,
                           CityId = r.CityId,
                           FirstName = r.FirstName,
                           LastName = r.LastName,
                           nit_Number = r.nit_Number,
                           troll = r.troll,
                           UserAddress = r.UserAddress,
                           UserPhone = r.UserPhone,
                           UserPhoto = r.UserPhoto
                       };
            Models.User result = new User();
            foreach (var r in user)
            {
                result.UserName = r.UserName;
                result.UserId = r.UserId;
                result.cedula = r.cedula;
                result.CompanyId = r.CompanyId;
                result.DepartmentId = r.DepartmentId;
                result.CityId = r.CityId;
                result.FirstName = r.FirstName;
                result.LastName = r.LastName;
                result.nit_Number = r.nit_Number;
                result.troll = r.troll;
                result.UserAddress = r.UserAddress;
                result.UserPhone = r.UserPhone;
                result.UserPhoto = r.UserPhoto;

            }
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        // PUT: api/Users/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUser(int id, User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user.UserId)
            {
                return BadRequest();
            }

            db.Entry(user).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
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
        [System.Web.Http.Authorize]
        public IHttpActionResult GetUsers(int id, string palme)
        {
            User users = db.Users.Find(id);
            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }
        // POST: api/Users
        [ResponseType(typeof(User))]
        public IHttpActionResult PostUser(User user)
        {
            user.DepartmentId = 1;
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                db.Users.Add(user);
                db.SaveChanges();
                UsersHelper.CreateUserASP(user.UserName, "User");
                //await SendMail();
                string s = String.Format("hoy {0}, se registró un usuario con correo {1}. y con nombre {2} y apellido {3}",
                             DateTime.Now, user.UserName, user.FirstName, user.LastName);
                string s1 = String.Format("hoy {0}, se registró un usuario con correo {1}.",
                             DateTime.Now, user.UserName);
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

            return CreatedAtRoute("DefaultApi", new { id = user.UserId }, user);
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
        // DELETE: api/Users/5
        [ResponseType(typeof(User))]
        public IHttpActionResult DeleteUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            db.Users.Remove(user);
            db.SaveChanges();

            return Ok(user);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UserExists(int id)
        {
            return db.Users.Count(e => e.UserId == id) > 0;
        }
    }
}