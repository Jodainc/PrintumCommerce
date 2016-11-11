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
    public class PRO3_Propiedades_de_ImpresiónController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO3_Propiedades_de_Impresión
        public ActionResult Index()
        {
            var pRO3_Propiedades_de_Impresión = db.PRO3_Propiedades_de_Impresión.Include(p => p.PRO1_Productos);
            return View(pRO3_Propiedades_de_Impresión.ToList());
        }

        // GET: PRO3_Propiedades_de_Impresión/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO3_Propiedades_de_Impresión pRO3_Propiedades_de_Impresión = db.PRO3_Propiedades_de_Impresión.Find(id);
            if (pRO3_Propiedades_de_Impresión == null)
            {
                return HttpNotFound();
            }
            return View(pRO3_Propiedades_de_Impresión);
        }

        // GET: PRO3_Propiedades_de_Impresión/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO3_Propiedades_de_Impresión/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,En_máquina_Imprimibilidad,En_máquina_Secado,En_máquina_Limpieza,En_Seco_Brillo,En_Seco_Resistencia_al_Roce_en_Húmedo,En_Seco_Resistencia_al_Roce_en_Seco,En_Seco_Resistencia_a_Químicos,En_Seco_Resistencia_a_la_Luz___Amarillamiento,En_Seco_Resistencia_al_Calor,En_Seco_Nivelación,Procesamiento_Estampado_al_Calor,Procesamiento_Pegabilidad,Procesamiento_Transferencia_Térmica,Procesamiento_Impresión_Láser")] PRO3_Propiedades_de_Impresión pRO3_Propiedades_de_Impresión)
        {
            if (ModelState.IsValid)
            {
                db.PRO3_Propiedades_de_Impresión.Add(pRO3_Propiedades_de_Impresión);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO3_Propiedades_de_Impresión.Cod_PRO);
            return View(pRO3_Propiedades_de_Impresión);
        }

        // GET: PRO3_Propiedades_de_Impresión/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO3_Propiedades_de_Impresión pRO3_Propiedades_de_Impresión = db.PRO3_Propiedades_de_Impresión.Find(id);
            if (pRO3_Propiedades_de_Impresión == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO3_Propiedades_de_Impresión.Cod_PRO);
            return View(pRO3_Propiedades_de_Impresión);
        }

        // POST: PRO3_Propiedades_de_Impresión/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,En_máquina_Imprimibilidad,En_máquina_Secado,En_máquina_Limpieza,En_Seco_Brillo,En_Seco_Resistencia_al_Roce_en_Húmedo,En_Seco_Resistencia_al_Roce_en_Seco,En_Seco_Resistencia_a_Químicos,En_Seco_Resistencia_a_la_Luz___Amarillamiento,En_Seco_Resistencia_al_Calor,En_Seco_Nivelación,Procesamiento_Estampado_al_Calor,Procesamiento_Pegabilidad,Procesamiento_Transferencia_Térmica,Procesamiento_Impresión_Láser")] PRO3_Propiedades_de_Impresión pRO3_Propiedades_de_Impresión)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO3_Propiedades_de_Impresión).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO3_Propiedades_de_Impresión.Cod_PRO);
            return View(pRO3_Propiedades_de_Impresión);
        }

        // GET: PRO3_Propiedades_de_Impresión/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO3_Propiedades_de_Impresión pRO3_Propiedades_de_Impresión = db.PRO3_Propiedades_de_Impresión.Find(id);
            if (pRO3_Propiedades_de_Impresión == null)
            {
                return HttpNotFound();
            }
            return View(pRO3_Propiedades_de_Impresión);
        }

        // POST: PRO3_Propiedades_de_Impresión/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO3_Propiedades_de_Impresión pRO3_Propiedades_de_Impresión = db.PRO3_Propiedades_de_Impresión.Find(id);
            db.PRO3_Propiedades_de_Impresión.Remove(pRO3_Propiedades_de_Impresión);
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
