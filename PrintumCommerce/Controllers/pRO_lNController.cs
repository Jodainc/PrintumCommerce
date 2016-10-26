using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;

namespace PrintumCommerce.Controllers
{
    public class pRO_lNController : Controller
    {
        private Model1 db = new Model1();

        public ActionResult Index()
        {
            return View(db.pRO_lN.ToList());
        }

        public ActionResult Details(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_lN pRO_lN = db.pRO_lN.Find(id);
            if (pRO_lN == null)
            {
                return HttpNotFound();
            }
            return View(pRO_lN);
        }

        public ActionResult Create()
        {
            return View();
        }

   [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LN,Linea_Negocio")] pRO_lN pRO_lN)
        {
            if (ModelState.IsValid)
            {
                db.pRO_lN.Add(pRO_lN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRO_lN);
        }


        public ActionResult Edit(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_lN pRO_lN = db.pRO_lN.Find(id);
            if (pRO_lN == null)
            {
                return HttpNotFound();
            }
            return View(pRO_lN);
        }

[HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LN,Linea_Negocio")] pRO_lN pRO_lN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO_lN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRO_lN);
        }


        public ActionResult Delete(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_lN pRO_lN = db.pRO_lN.Find(id);
            if (pRO_lN == null)
            {
                return HttpNotFound();
            }
            return View(pRO_lN);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(double id)
        {
            pRO_lN pRO_lN = db.pRO_lN.Find(id);
            db.pRO_lN.Remove(pRO_lN);
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
