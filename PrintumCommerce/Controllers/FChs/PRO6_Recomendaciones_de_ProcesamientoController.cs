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
    public class PRO6_Recomendaciones_de_ProcesamientoController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO6_Recomendaciones_de_Procesamiento
        public ActionResult Index()
        {
            var pRO6_Recomendaciones_de_Procesamiento = db.PRO6_Recomendaciones_de_Procesamiento.Include(p => p.PRO1_Productos);
            return View(pRO6_Recomendaciones_de_Procesamiento.ToList());
        }

        // GET: PRO6_Recomendaciones_de_Procesamiento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO6_Recomendaciones_de_Procesamiento pRO6_Recomendaciones_de_Procesamiento = db.PRO6_Recomendaciones_de_Procesamiento.Find(id);
            if (pRO6_Recomendaciones_de_Procesamiento == null)
            {
                return HttpNotFound();
            }
            return View(pRO6_Recomendaciones_de_Procesamiento);
        }

        // GET: PRO6_Recomendaciones_de_Procesamiento/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO6_Recomendaciones_de_Procesamiento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO6_Recomendaciones_de_Procesamiento pRO6_Recomendaciones_de_Procesamiento)
        {
            if (ModelState.IsValid)
            {
                db.PRO6_Recomendaciones_de_Procesamiento.Add(pRO6_Recomendaciones_de_Procesamiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO6_Recomendaciones_de_Procesamiento.Cod_PRO);
            return View(pRO6_Recomendaciones_de_Procesamiento);
        }

        // GET: PRO6_Recomendaciones_de_Procesamiento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO6_Recomendaciones_de_Procesamiento pRO6_Recomendaciones_de_Procesamiento = db.PRO6_Recomendaciones_de_Procesamiento.Find(id);
            if (pRO6_Recomendaciones_de_Procesamiento == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO6_Recomendaciones_de_Procesamiento.Cod_PRO);
            return View(pRO6_Recomendaciones_de_Procesamiento);
        }

        // POST: PRO6_Recomendaciones_de_Procesamiento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO6_Recomendaciones_de_Procesamiento pRO6_Recomendaciones_de_Procesamiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO6_Recomendaciones_de_Procesamiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO6_Recomendaciones_de_Procesamiento.Cod_PRO);
            return View(pRO6_Recomendaciones_de_Procesamiento);
        }

        // GET: PRO6_Recomendaciones_de_Procesamiento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO6_Recomendaciones_de_Procesamiento pRO6_Recomendaciones_de_Procesamiento = db.PRO6_Recomendaciones_de_Procesamiento.Find(id);
            if (pRO6_Recomendaciones_de_Procesamiento == null)
            {
                return HttpNotFound();
            }
            return View(pRO6_Recomendaciones_de_Procesamiento);
        }

        // POST: PRO6_Recomendaciones_de_Procesamiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO6_Recomendaciones_de_Procesamiento pRO6_Recomendaciones_de_Procesamiento = db.PRO6_Recomendaciones_de_Procesamiento.Find(id);
            db.PRO6_Recomendaciones_de_Procesamiento.Remove(pRO6_Recomendaciones_de_Procesamiento);
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
