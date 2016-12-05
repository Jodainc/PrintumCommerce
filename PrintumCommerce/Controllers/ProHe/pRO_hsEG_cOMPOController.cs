using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;

namespace PrintumCommerce.Controllers.ProHe
{
    public class pRO_hsEG_cOMPOController : Controller
    {
        private Model1 db = new Model1();

        public ActionResult Index()
        {
            return View(db.pRO_hsEG_cOMPO.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_cOMPO pRO_hsEG_cOMPO = db.pRO_hsEG_cOMPO.Find(id);
            if (pRO_hsEG_cOMPO == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG_cOMPO);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,C2Codigo,C2cOMPONENTE,C2pORCEN,C2nOcAS,pro_hsEG_Codigo")] pRO_hsEG_cOMPO pRO_hsEG_cOMPO)
        {
            if (ModelState.IsValid)
            {
                db.pRO_hsEG_cOMPO.Add(pRO_hsEG_cOMPO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRO_hsEG_cOMPO);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_cOMPO pRO_hsEG_cOMPO = db.pRO_hsEG_cOMPO.Find(id);
            if (pRO_hsEG_cOMPO == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG_cOMPO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,C2Codigo,C2cOMPONENTE,C2pORCEN,C2nOcAS,pro_hsEG_Codigo")] pRO_hsEG_cOMPO pRO_hsEG_cOMPO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO_hsEG_cOMPO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRO_hsEG_cOMPO);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_cOMPO pRO_hsEG_cOMPO = db.pRO_hsEG_cOMPO.Find(id);
            if (pRO_hsEG_cOMPO == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG_cOMPO);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pRO_hsEG_cOMPO pRO_hsEG_cOMPO = db.pRO_hsEG_cOMPO.Find(id);
            db.pRO_hsEG_cOMPO.Remove(pRO_hsEG_cOMPO);
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
