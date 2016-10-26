using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models;
using PrintumCommerce.ClassHelper;

namespace PrintumCommerce.Controllers
{
    public class UsersController : Controller
    {
        private DBPrintumContext db = new DBPrintumContext();

        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.City).Include(u => u.Company).Include(u => u.DepartmentModel);
            return View(users.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(ComboHelper.getCities(), "CityId", "CitiesName");
            ViewBag.CompanyId = new SelectList(ComboHelper.getCompanies(), "CompanyId", "CompanyName");
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    UsersHelper.CreateUserASP(user.UserName, "User");
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
                if (user.UserPhotoFile != null)
                {
                    var folder = "~/Content/StatePho";
                    var response = FilHelper.UploadPhoto(user.UserPhotoFile, folder, string.Format("{0}.jpg", user.UserId));
                    if (response)
                    {
                        var pic = string.Format("{0}/{1}.jpg", folder, user.UserId);
                        user.UserPhoto = pic;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(ComboHelper.getCities(), "CityId", "CitiesName", user.CityId);
            ViewBag.CompanyId = new SelectList(ComboHelper.getCompanies(), "CompanyId", "CompanyName", user.CompanyId);
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName", user.DepartmentId);
            return View(user);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(ComboHelper.getCities(), "CityId", "CitiesName", user.CityId);
            ViewBag.CompanyId = new SelectList(ComboHelper.getCompanies(), "CompanyId", "CompanyName", user.CompanyId);
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName", user.DepartmentId);
            return View(user);
        }


        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var folder = "~/Content/Golo";
                var pic = string.Empty;

                if (user.UserPhotoFile != null)
                {
                    var response = FilHelper.UploadPhoto(user.UserPhotoFile, folder, string.Format("{0}.jpg", user.UserId));
                    if (response)
                    {
                        pic = string.Format("{0}/{1}.jpg", folder, user.UserId);
                        user.UserPhoto = pic;
                    }

                }
                var db2 = new DBPrintumContext();
                var currentUser = db2.Users.Find(user.UserId);
                if (currentUser.UserName != user.UserName)
                {
                    UsersHelper.UpdateUserName(currentUser.UserName, user.UserName);
                }
                db2.Dispose();
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(ComboHelper.getCities(), "CityId", "CitiesName", user.CityId);
            ViewBag.CompanyId = new SelectList(ComboHelper.getCompanies(), "CompanyId", "CompanyName", user.CompanyId);
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName", user.DepartmentId);
            return View(user);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            UsersHelper.DeleteUser(user.UserName);
            return RedirectToAction("Index");
        }

        public JsonResult GetCities(int departmentId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var municipalities = db.Cities.Where(m => m.DepartmentId == departmentId);
            return Json(municipalities);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
