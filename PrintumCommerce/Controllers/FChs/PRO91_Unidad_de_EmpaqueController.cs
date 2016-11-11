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
    public class PRO91_Unidad_de_EmpaqueController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO91_Unidad_de_Empaque
        public ActionResult Index()
        {
            var pRO91_Unidad_de_Empaque = db.PRO91_Unidad_de_Empaque.Include(p => p.PRO1_Productos);
            return View(pRO91_Unidad_de_Empaque.ToList());
        }

        // GET: PRO91_Unidad_de_Empaque/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO91_Unidad_de_Empaque pRO91_Unidad_de_Empaque = db.PRO91_Unidad_de_Empaque.Find(id);
            if (pRO91_Unidad_de_Empaque == null)
            {
                return HttpNotFound();
            }
            return View(pRO91_Unidad_de_Empaque);
        }

        // GET: PRO91_Unidad_de_Empaque/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO91_Unidad_de_Empaque/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO91_Unidad_de_Empaque pRO91_Unidad_de_Empaque)
        {
            if (ModelState.IsValid)
            {
                db.PRO91_Unidad_de_Empaque.Add(pRO91_Unidad_de_Empaque);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO91_Unidad_de_Empaque.Cod_PRO);
            return View(pRO91_Unidad_de_Empaque);
        }

        // GET: PRO91_Unidad_de_Empaque/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO91_Unidad_de_Empaque pRO91_Unidad_de_Empaque = db.PRO91_Unidad_de_Empaque.Find(id);
            if (pRO91_Unidad_de_Empaque == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO91_Unidad_de_Empaque.Cod_PRO);
            return View(pRO91_Unidad_de_Empaque);
        }

        // POST: PRO91_Unidad_de_Empaque/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO91_Unidad_de_Empaque pRO91_Unidad_de_Empaque)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO91_Unidad_de_Empaque).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO91_Unidad_de_Empaque.Cod_PRO);
            return View(pRO91_Unidad_de_Empaque);
        }

        // GET: PRO91_Unidad_de_Empaque/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO91_Unidad_de_Empaque pRO91_Unidad_de_Empaque = db.PRO91_Unidad_de_Empaque.Find(id);
            if (pRO91_Unidad_de_Empaque == null)
            {
                return HttpNotFound();
            }
            return View(pRO91_Unidad_de_Empaque);
        }

        // POST: PRO91_Unidad_de_Empaque/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO91_Unidad_de_Empaque pRO91_Unidad_de_Empaque = db.PRO91_Unidad_de_Empaque.Find(id);
            db.PRO91_Unidad_de_Empaque.Remove(pRO91_Unidad_de_Empaque);
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
