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
    public class PRO92_lAP_Propiedades_medicion_mmController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO92_lAP_Propiedades_medicion_mm
        public ActionResult Index()
        {
            var pRO92_lAP_Propiedades_medicion_mm = db.PRO92_lAP_Propiedades_medicion_mm.Include(p => p.PRO1_Productos);
            return View(pRO92_lAP_Propiedades_medicion_mm.ToList());
        }

        // GET: PRO92_lAP_Propiedades_medicion_mm/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO92_lAP_Propiedades_medicion_mm pRO92_lAP_Propiedades_medicion_mm = db.PRO92_lAP_Propiedades_medicion_mm.Find(id);
            if (pRO92_lAP_Propiedades_medicion_mm == null)
            {
                return HttpNotFound();
            }
            return View(pRO92_lAP_Propiedades_medicion_mm);
        }

        // GET: PRO92_lAP_Propiedades_medicion_mm/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO92_lAP_Propiedades_medicion_mm/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Info,Medicion")] PRO92_lAP_Propiedades_medicion_mm pRO92_lAP_Propiedades_medicion_mm)
        {
            if (ModelState.IsValid)
            {
                db.PRO92_lAP_Propiedades_medicion_mm.Add(pRO92_lAP_Propiedades_medicion_mm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO92_lAP_Propiedades_medicion_mm.Cod_PRO);
            return View(pRO92_lAP_Propiedades_medicion_mm);
        }

        // GET: PRO92_lAP_Propiedades_medicion_mm/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO92_lAP_Propiedades_medicion_mm pRO92_lAP_Propiedades_medicion_mm = db.PRO92_lAP_Propiedades_medicion_mm.Find(id);
            if (pRO92_lAP_Propiedades_medicion_mm == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO92_lAP_Propiedades_medicion_mm.Cod_PRO);
            return View(pRO92_lAP_Propiedades_medicion_mm);
        }

        // POST: PRO92_lAP_Propiedades_medicion_mm/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Info,Medicion")] PRO92_lAP_Propiedades_medicion_mm pRO92_lAP_Propiedades_medicion_mm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO92_lAP_Propiedades_medicion_mm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO92_lAP_Propiedades_medicion_mm.Cod_PRO);
            return View(pRO92_lAP_Propiedades_medicion_mm);
        }

        // GET: PRO92_lAP_Propiedades_medicion_mm/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO92_lAP_Propiedades_medicion_mm pRO92_lAP_Propiedades_medicion_mm = db.PRO92_lAP_Propiedades_medicion_mm.Find(id);
            if (pRO92_lAP_Propiedades_medicion_mm == null)
            {
                return HttpNotFound();
            }
            return View(pRO92_lAP_Propiedades_medicion_mm);
        }

        // POST: PRO92_lAP_Propiedades_medicion_mm/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO92_lAP_Propiedades_medicion_mm pRO92_lAP_Propiedades_medicion_mm = db.PRO92_lAP_Propiedades_medicion_mm.Find(id);
            db.PRO92_lAP_Propiedades_medicion_mm.Remove(pRO92_lAP_Propiedades_medicion_mm);
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
