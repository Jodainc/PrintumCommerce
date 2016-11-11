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
    public class PRO4_Propiedades_de_AplicaciónController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO4_Propiedades_de_Aplicación
        public ActionResult Index()
        {
            var pRO4_Propiedades_de_Aplicación = db.PRO4_Propiedades_de_Aplicación.Include(p => p.PRO1_Productos);
            return View(pRO4_Propiedades_de_Aplicación.ToList());
        }

        // GET: PRO4_Propiedades_de_Aplicación/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO4_Propiedades_de_Aplicación pRO4_Propiedades_de_Aplicación = db.PRO4_Propiedades_de_Aplicación.Find(id);
            if (pRO4_Propiedades_de_Aplicación == null)
            {
                return HttpNotFound();
            }
            return View(pRO4_Propiedades_de_Aplicación);
        }

        // GET: PRO4_Propiedades_de_Aplicación/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO4_Propiedades_de_Aplicación/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Proceso_de_Impresión,Naturaleza,Viscosidad,Sustrato_Recomendado,LPI1,LPI2,LPI3,G_M2___BCM1,G_M2___BCM2,G_M2___BCM3,Velocidad_de_Secado_____m_min,Productos_Impresos")] PRO4_Propiedades_de_Aplicación pRO4_Propiedades_de_Aplicación)
        {
            if (ModelState.IsValid)
            {
                db.PRO4_Propiedades_de_Aplicación.Add(pRO4_Propiedades_de_Aplicación);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO4_Propiedades_de_Aplicación.Cod_PRO);
            return View(pRO4_Propiedades_de_Aplicación);
        }

        // GET: PRO4_Propiedades_de_Aplicación/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO4_Propiedades_de_Aplicación pRO4_Propiedades_de_Aplicación = db.PRO4_Propiedades_de_Aplicación.Find(id);
            if (pRO4_Propiedades_de_Aplicación == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO4_Propiedades_de_Aplicación.Cod_PRO);
            return View(pRO4_Propiedades_de_Aplicación);
        }

        // POST: PRO4_Propiedades_de_Aplicación/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Proceso_de_Impresión,Naturaleza,Viscosidad,Sustrato_Recomendado,LPI1,LPI2,LPI3,G_M2___BCM1,G_M2___BCM2,G_M2___BCM3,Velocidad_de_Secado_____m_min,Productos_Impresos")] PRO4_Propiedades_de_Aplicación pRO4_Propiedades_de_Aplicación)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO4_Propiedades_de_Aplicación).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO4_Propiedades_de_Aplicación.Cod_PRO);
            return View(pRO4_Propiedades_de_Aplicación);
        }

        // GET: PRO4_Propiedades_de_Aplicación/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO4_Propiedades_de_Aplicación pRO4_Propiedades_de_Aplicación = db.PRO4_Propiedades_de_Aplicación.Find(id);
            if (pRO4_Propiedades_de_Aplicación == null)
            {
                return HttpNotFound();
            }
            return View(pRO4_Propiedades_de_Aplicación);
        }

        // POST: PRO4_Propiedades_de_Aplicación/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO4_Propiedades_de_Aplicación pRO4_Propiedades_de_Aplicación = db.PRO4_Propiedades_de_Aplicación.Find(id);
            db.PRO4_Propiedades_de_Aplicación.Remove(pRO4_Propiedades_de_Aplicación);
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
