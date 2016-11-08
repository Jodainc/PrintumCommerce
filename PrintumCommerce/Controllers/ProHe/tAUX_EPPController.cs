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
    public class tAUX_EPPController : Controller
    {
        private Model1 db = new Model1();

        // GET: tAUX_EPP
        public ActionResult Index()
        {
            return View(db.tAUX_EPP.ToList());
        }

        // GET: tAUX_EPP/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tAUX_EPP tAUX_EPP = db.tAUX_EPP.Find(id);
            if (tAUX_EPP == null)
            {
                return HttpNotFound();
            }
            return View(tAUX_EPP);
        }

        // GET: tAUX_EPP/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tAUX_EPP/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nO,pOP,nOMBREhS,tPROTECCCION,dETALLEePP,iNFOa,nORMAT,uSO,cUIDADOSE,cONxrEMPLA,aLMACENAMIENTO,lIMPIEZA,oBLIGApARA,rEVISION,IEPP")] tAUX_EPP tAUX_EPP)
        {
            if (ModelState.IsValid)
            {
                db.tAUX_EPP.Add(tAUX_EPP);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tAUX_EPP);
        }

        // GET: tAUX_EPP/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tAUX_EPP tAUX_EPP = db.tAUX_EPP.Find(id);
            if (tAUX_EPP == null)
            {
                return HttpNotFound();
            }
            return View(tAUX_EPP);
        }

        // POST: tAUX_EPP/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nO,pOP,nOMBREhS,tPROTECCCION,dETALLEePP,iNFOa,nORMAT,uSO,cUIDADOSE,cONxrEMPLA,aLMACENAMIENTO,lIMPIEZA,oBLIGApARA,rEVISION,IEPP")] tAUX_EPP tAUX_EPP)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAUX_EPP).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tAUX_EPP);
        }

        // GET: tAUX_EPP/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tAUX_EPP tAUX_EPP = db.tAUX_EPP.Find(id);
            if (tAUX_EPP == null)
            {
                return HttpNotFound();
            }
            return View(tAUX_EPP);
        }

        // POST: tAUX_EPP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tAUX_EPP tAUX_EPP = db.tAUX_EPP.Find(id);
            db.tAUX_EPP.Remove(tAUX_EPP);
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
