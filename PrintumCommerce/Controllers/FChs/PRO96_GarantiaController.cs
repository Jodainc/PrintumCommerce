using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;

namespace PrintumCommerce.Controllers.FChs
{
    public class PRO96_GarantiaController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO96_Garantia
        public ActionResult Index()
        {
            var pRO96_Garantia = db.PRO96_Garantia.Include(p => p.PRO1_Productos);
            return View(pRO96_Garantia.ToList());
        }

        // GET: PRO96_Garantia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO96_Garantia pRO96_Garantia = db.PRO96_Garantia.Find(id);
            if (pRO96_Garantia == null)
            {
                return HttpNotFound();
            }
            return View(pRO96_Garantia);
        }

        // GET: PRO96_Garantia/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO96_Garantia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO96_Garantia pRO96_Garantia)
        {
            if (ModelState.IsValid)
            {
                db.PRO96_Garantia.Add(pRO96_Garantia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO96_Garantia.Cod_PRO);
            return View(pRO96_Garantia);
        }

        // GET: PRO96_Garantia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO96_Garantia pRO96_Garantia = db.PRO96_Garantia.Find(id);
            if (pRO96_Garantia == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO96_Garantia.Cod_PRO);
            return View(pRO96_Garantia);
        }

        // POST: PRO96_Garantia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO96_Garantia pRO96_Garantia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO96_Garantia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO96_Garantia.Cod_PRO);
            return View(pRO96_Garantia);
        }

        // GET: PRO96_Garantia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO96_Garantia pRO96_Garantia = db.PRO96_Garantia.Find(id);
            if (pRO96_Garantia == null)
            {
                return HttpNotFound();
            }
            return View(pRO96_Garantia);
        }

        // POST: PRO96_Garantia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO96_Garantia pRO96_Garantia = db.PRO96_Garantia.Find(id);
            db.PRO96_Garantia.Remove(pRO96_Garantia);
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
