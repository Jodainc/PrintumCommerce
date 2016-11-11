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
    public class PRO93_lAP_Propiedades_ElectricasController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO93_lAP_Propiedades_Electricas
        public ActionResult Index()
        {
            var pRO93_lAP_Propiedades_Electricas = db.PRO93_lAP_Propiedades_Electricas.Include(p => p.PRO1_Productos);
            return View(pRO93_lAP_Propiedades_Electricas.ToList());
        }

        // GET: PRO93_lAP_Propiedades_Electricas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO93_lAP_Propiedades_Electricas pRO93_lAP_Propiedades_Electricas = db.PRO93_lAP_Propiedades_Electricas.Find(id);
            if (pRO93_lAP_Propiedades_Electricas == null)
            {
                return HttpNotFound();
            }
            return View(pRO93_lAP_Propiedades_Electricas);
        }

        // GET: PRO93_lAP_Propiedades_Electricas/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO93_lAP_Propiedades_Electricas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Info,Medicion")] PRO93_lAP_Propiedades_Electricas pRO93_lAP_Propiedades_Electricas)
        {
            if (ModelState.IsValid)
            {
                db.PRO93_lAP_Propiedades_Electricas.Add(pRO93_lAP_Propiedades_Electricas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO93_lAP_Propiedades_Electricas.Cod_PRO);
            return View(pRO93_lAP_Propiedades_Electricas);
        }

        // GET: PRO93_lAP_Propiedades_Electricas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO93_lAP_Propiedades_Electricas pRO93_lAP_Propiedades_Electricas = db.PRO93_lAP_Propiedades_Electricas.Find(id);
            if (pRO93_lAP_Propiedades_Electricas == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO93_lAP_Propiedades_Electricas.Cod_PRO);
            return View(pRO93_lAP_Propiedades_Electricas);
        }

        // POST: PRO93_lAP_Propiedades_Electricas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Info,Medicion")] PRO93_lAP_Propiedades_Electricas pRO93_lAP_Propiedades_Electricas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO93_lAP_Propiedades_Electricas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO93_lAP_Propiedades_Electricas.Cod_PRO);
            return View(pRO93_lAP_Propiedades_Electricas);
        }

        // GET: PRO93_lAP_Propiedades_Electricas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO93_lAP_Propiedades_Electricas pRO93_lAP_Propiedades_Electricas = db.PRO93_lAP_Propiedades_Electricas.Find(id);
            if (pRO93_lAP_Propiedades_Electricas == null)
            {
                return HttpNotFound();
            }
            return View(pRO93_lAP_Propiedades_Electricas);
        }

        // POST: PRO93_lAP_Propiedades_Electricas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO93_lAP_Propiedades_Electricas pRO93_lAP_Propiedades_Electricas = db.PRO93_lAP_Propiedades_Electricas.Find(id);
            db.PRO93_lAP_Propiedades_Electricas.Remove(pRO93_lAP_Propiedades_Electricas);
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
