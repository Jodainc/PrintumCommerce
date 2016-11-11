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
    public class pRO_hsEG_ePPController : Controller
    {
        private Model1 db = new Model1();

        // GET: pRO_hsEG_ePP
        public ActionResult Index()
        {
            var pRO_hsEG_ePP = db.pRO_hsEG_ePP.Include(p => p.pRO_hsEG);
            return View(pRO_hsEG_ePP.ToList());
        }

        // GET: pRO_hsEG_ePP/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_ePP pRO_hsEG_ePP = db.pRO_hsEG_ePP.Find(id);
            if (pRO_hsEG_ePP == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG_ePP);
        }

        // GET: pRO_hsEG_ePP/Create
        public ActionResult Create()
        {
            ViewBag.C8Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE");
            return View();
        }

        // POST: pRO_hsEG_ePP/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,C8Codigo,C8pROTECCION,C8ePP,C8mASiNFO,pro_hsEG_Codigo")] pRO_hsEG_ePP pRO_hsEG_ePP)
        {
            if (ModelState.IsValid)
            {
                db.pRO_hsEG_ePP.Add(pRO_hsEG_ePP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.C8Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE", pRO_hsEG_ePP.C8Codigo);
            return View(pRO_hsEG_ePP);
        }

        // GET: pRO_hsEG_ePP/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_ePP pRO_hsEG_ePP = db.pRO_hsEG_ePP.Find(id);
            if (pRO_hsEG_ePP == null)
            {
                return HttpNotFound();
            }
            ViewBag.C8Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE", pRO_hsEG_ePP.C8Codigo);
            return View(pRO_hsEG_ePP);
        }

        // POST: pRO_hsEG_ePP/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,C8Codigo,C8pROTECCION,C8ePP,C8mASiNFO,pro_hsEG_Codigo")] pRO_hsEG_ePP pRO_hsEG_ePP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO_hsEG_ePP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.C8Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE", pRO_hsEG_ePP.C8Codigo);
            return View(pRO_hsEG_ePP);
        }

        // GET: pRO_hsEG_ePP/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_ePP pRO_hsEG_ePP = db.pRO_hsEG_ePP.Find(id);
            if (pRO_hsEG_ePP == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG_ePP);
        }

        // POST: pRO_hsEG_ePP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pRO_hsEG_ePP pRO_hsEG_ePP = db.pRO_hsEG_ePP.Find(id);
            db.pRO_hsEG_ePP.Remove(pRO_hsEG_ePP);
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
