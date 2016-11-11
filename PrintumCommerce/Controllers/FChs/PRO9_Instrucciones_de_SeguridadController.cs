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
    public class PRO9_Instrucciones_de_SeguridadController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO9_Instrucciones_de_Seguridad
        public ActionResult Index()
        {
            var pRO9_Instrucciones_de_Seguridad = db.PRO9_Instrucciones_de_Seguridad.Include(p => p.PRO1_Productos);
            return View(pRO9_Instrucciones_de_Seguridad.ToList());
        }

        // GET: PRO9_Instrucciones_de_Seguridad/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO9_Instrucciones_de_Seguridad pRO9_Instrucciones_de_Seguridad = db.PRO9_Instrucciones_de_Seguridad.Find(id);
            if (pRO9_Instrucciones_de_Seguridad == null)
            {
                return HttpNotFound();
            }
            return View(pRO9_Instrucciones_de_Seguridad);
        }

        // GET: PRO9_Instrucciones_de_Seguridad/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO9_Instrucciones_de_Seguridad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO9_Instrucciones_de_Seguridad pRO9_Instrucciones_de_Seguridad)
        {
            if (ModelState.IsValid)
            {
                db.PRO9_Instrucciones_de_Seguridad.Add(pRO9_Instrucciones_de_Seguridad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO9_Instrucciones_de_Seguridad.Cod_PRO);
            return View(pRO9_Instrucciones_de_Seguridad);
        }

        // GET: PRO9_Instrucciones_de_Seguridad/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO9_Instrucciones_de_Seguridad pRO9_Instrucciones_de_Seguridad = db.PRO9_Instrucciones_de_Seguridad.Find(id);
            if (pRO9_Instrucciones_de_Seguridad == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO9_Instrucciones_de_Seguridad.Cod_PRO);
            return View(pRO9_Instrucciones_de_Seguridad);
        }

        // POST: PRO9_Instrucciones_de_Seguridad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO9_Instrucciones_de_Seguridad pRO9_Instrucciones_de_Seguridad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO9_Instrucciones_de_Seguridad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO9_Instrucciones_de_Seguridad.Cod_PRO);
            return View(pRO9_Instrucciones_de_Seguridad);
        }

        // GET: PRO9_Instrucciones_de_Seguridad/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO9_Instrucciones_de_Seguridad pRO9_Instrucciones_de_Seguridad = db.PRO9_Instrucciones_de_Seguridad.Find(id);
            if (pRO9_Instrucciones_de_Seguridad == null)
            {
                return HttpNotFound();
            }
            return View(pRO9_Instrucciones_de_Seguridad);
        }

        // POST: PRO9_Instrucciones_de_Seguridad/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO9_Instrucciones_de_Seguridad pRO9_Instrucciones_de_Seguridad = db.PRO9_Instrucciones_de_Seguridad.Find(id);
            db.PRO9_Instrucciones_de_Seguridad.Remove(pRO9_Instrucciones_de_Seguridad);
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
