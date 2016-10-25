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
using System.Web.UI.WebControls;

namespace PrintumCommerce.Controllers
{
    public class CompaniesController : Controller
    {
        private DBPrintumContext db = new DBPrintumContext();

        // GET: Companies
        public ActionResult Index()
        {
            var companies = db.Companies.Include(c => c.City).Include(c => c.DepartmentModel);
            return View(companies.ToList());
        }

        // GET: Companies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(ComboHelper.getCities() , "CityId", "CitiesName");
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName");
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(company);
                db.SaveChanges();
      

                if (company.CompanyPhotoFile != null)
                {
      
                    var folder = "~/Content/Golo";
                    var response = FilHelper.UploadPhoto(company.CompanyPhotoFile, folder,string.Format("{0}",company.CompanyId));
                    if (response)
                    {
                        var pic = string.Format("{0}/{1}", folder, company.CompanyId);
                        company.CompanyPhoto = pic;
                        db.Entry(company).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                   
                }
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(ComboHelper.getCities(), "CityId", "CitiesName", company.CityId);
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName", company.DepartmentId);
            return View(company);
        }

        // GET: Companies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(ComboHelper.getCities(), "CityId", "CitiesName", company.CityId);
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName", company.DepartmentId);
            return View(company);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Company company)
        {
            if (ModelState.IsValid)
            {
                var folder = "~/Content/Golo";
                var pic = string.Empty;

                if (company.CompanyPhotoFile != null)
                {
                    var response = FilHelper.UploadPhoto(company.CompanyPhotoFile, folder, string.Format("{0}", company.CompanyId));
                    if (response)
                    {
                       pic  = string.Format("{0}/{1}", folder, company.CompanyId);
                        company.CompanyPhoto = pic;
                    }
                   
                }
              
                db.Entry(company).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(ComboHelper.getCities(), "CityId", "CitiesName", company.CityId);
            ViewBag.DepartmentId = new SelectList(ComboHelper.getDepartment(), "DepartmentId", "DepartmentName", company.DepartmentId);
            return View(company);
        }

        // GET: Companies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return View(company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Company company = db.Companies.Find(id);
            db.Companies.Remove(company);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public JsonResult GetCities(int departmentId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var municipalities = db.Cities.Where(m => m.DepartmentId == departmentId);
            return Json(municipalities);
        }

    }
}
