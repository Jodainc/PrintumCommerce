﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models;

namespace PrintumCommerce.Controllers
{
    public class UsersController : Controller
    {
        private DBPrintumContext db = new DBPrintumContext();

        // GET: Users
        public ActionResult Index()
        {
            var users = db.Users.Include(u => u.City).Include(u => u.Company).Include(u => u.DepartmentModel);
            return View(users.ToList());
        }

        // GET: Users/Details/5
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

        // GET: Users/Create
        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CitiesName");
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName");
            ViewBag.DepartmentId = new SelectList(db.DepartmentModels, "DepartmentId", "DepartmentName");
            return View();
        }

        // POST: Users/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserId,UserName,FirstName,LastName,UserPhone,UserAddress,UserPhoto,DepartmentId,CityId,CompanyId")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CitiesName", user.CityId);
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName", user.CompanyId);
            ViewBag.DepartmentId = new SelectList(db.DepartmentModels, "DepartmentId", "DepartmentName", user.DepartmentId);
            return View(user);
        }

        // GET: Users/Edit/5
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
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CitiesName", user.CityId);
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName", user.CompanyId);
            ViewBag.DepartmentId = new SelectList(db.DepartmentModels, "DepartmentId", "DepartmentName", user.DepartmentId);
            return View(user);
        }

        // POST: Users/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserId,UserName,FirstName,LastName,UserPhone,UserAddress,UserPhoto,DepartmentId,CityId,CompanyId")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CitiesName", user.CityId);
            ViewBag.CompanyId = new SelectList(db.Companies, "CompanyId", "CompanyName", user.CompanyId);
            ViewBag.DepartmentId = new SelectList(db.DepartmentModels, "DepartmentId", "DepartmentName", user.DepartmentId);
            return View(user);
        }

        // GET: Users/Delete/5
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

        // POST: Users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
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
    }
}
