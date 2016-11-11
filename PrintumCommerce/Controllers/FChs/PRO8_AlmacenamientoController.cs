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
    public class PRO8_AlmacenamientoController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO8_Almacenamiento
        public ActionResult Index()
        {
            var pRO8_Almacenamiento = db.PRO8_Almacenamiento.Include(p => p.PRO1_Productos);
            return View(pRO8_Almacenamiento.ToList());
        }

        // GET: PRO8_Almacenamiento/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO8_Almacenamiento pRO8_Almacenamiento = db.PRO8_Almacenamiento.Find(id);
            if (pRO8_Almacenamiento == null)
            {
                return HttpNotFound();
            }
            return View(pRO8_Almacenamiento);
        }

        // GET: PRO8_Almacenamiento/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO8_Almacenamiento/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO8_Almacenamiento pRO8_Almacenamiento)
        {
            if (ModelState.IsValid)
            {
                db.PRO8_Almacenamiento.Add(pRO8_Almacenamiento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO8_Almacenamiento.Cod_PRO);
            return View(pRO8_Almacenamiento);
        }

        // GET: PRO8_Almacenamiento/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO8_Almacenamiento pRO8_Almacenamiento = db.PRO8_Almacenamiento.Find(id);
            if (pRO8_Almacenamiento == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO8_Almacenamiento.Cod_PRO);
            return View(pRO8_Almacenamiento);
        }

        // POST: PRO8_Almacenamiento/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO8_Almacenamiento pRO8_Almacenamiento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO8_Almacenamiento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO8_Almacenamiento.Cod_PRO);
            return View(pRO8_Almacenamiento);
        }

        // GET: PRO8_Almacenamiento/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO8_Almacenamiento pRO8_Almacenamiento = db.PRO8_Almacenamiento.Find(id);
            if (pRO8_Almacenamiento == null)
            {
                return HttpNotFound();
            }
            return View(pRO8_Almacenamiento);
        }

        // POST: PRO8_Almacenamiento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO8_Almacenamiento pRO8_Almacenamiento = db.PRO8_Almacenamiento.Find(id);
            db.PRO8_Almacenamiento.Remove(pRO8_Almacenamiento);
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
