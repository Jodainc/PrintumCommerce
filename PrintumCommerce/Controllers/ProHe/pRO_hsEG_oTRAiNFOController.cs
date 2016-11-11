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
    public class pRO_hsEG_oTRAiNFOController : Controller
    {
        private Model1 db = new Model1();

        // GET: pRO_hsEG_oTRAiNFO
        public ActionResult Index()
        {
            var pRO_hsEG_oTRAiNFO = db.pRO_hsEG_oTRAiNFO.Include(p => p.pRO_hsEG);
            return View(pRO_hsEG_oTRAiNFO.ToList());
        }

        // GET: pRO_hsEG_oTRAiNFO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_oTRAiNFO pRO_hsEG_oTRAiNFO = db.pRO_hsEG_oTRAiNFO.Find(id);
            if (pRO_hsEG_oTRAiNFO == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG_oTRAiNFO);
        }

        // GET: pRO_hsEG_oTRAiNFO/Create
        public ActionResult Create()
        {
            ViewBag.C16Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE");
            return View();
        }

        // POST: pRO_hsEG_oTRAiNFO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,C16Codigo,C16iNFO")] pRO_hsEG_oTRAiNFO pRO_hsEG_oTRAiNFO)
        {
            if (ModelState.IsValid)
            {
                db.pRO_hsEG_oTRAiNFO.Add(pRO_hsEG_oTRAiNFO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.C16Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE", pRO_hsEG_oTRAiNFO.C16Codigo);
            return View(pRO_hsEG_oTRAiNFO);
        }

        // GET: pRO_hsEG_oTRAiNFO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_oTRAiNFO pRO_hsEG_oTRAiNFO = db.pRO_hsEG_oTRAiNFO.Find(id);
            if (pRO_hsEG_oTRAiNFO == null)
            {
                return HttpNotFound();
            }
            ViewBag.C16Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE", pRO_hsEG_oTRAiNFO.C16Codigo);
            return View(pRO_hsEG_oTRAiNFO);
        }

        // POST: pRO_hsEG_oTRAiNFO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,C16Codigo,C16iNFO")] pRO_hsEG_oTRAiNFO pRO_hsEG_oTRAiNFO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO_hsEG_oTRAiNFO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.C16Codigo = new SelectList(db.pRO_hsEG, "Codigo", "C1nOMBRE", pRO_hsEG_oTRAiNFO.C16Codigo);
            return View(pRO_hsEG_oTRAiNFO);
        }

        // GET: pRO_hsEG_oTRAiNFO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG_oTRAiNFO pRO_hsEG_oTRAiNFO = db.pRO_hsEG_oTRAiNFO.Find(id);
            if (pRO_hsEG_oTRAiNFO == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG_oTRAiNFO);
        }

        // POST: pRO_hsEG_oTRAiNFO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pRO_hsEG_oTRAiNFO pRO_hsEG_oTRAiNFO = db.pRO_hsEG_oTRAiNFO.Find(id);
            db.pRO_hsEG_oTRAiNFO.Remove(pRO_hsEG_oTRAiNFO);
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
