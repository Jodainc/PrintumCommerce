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
    public class PRO95_VentajasController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO95_Ventajas
        public ActionResult Index()
        {
            var pRO95_Ventajas = db.PRO95_Ventajas.Include(p => p.PRO1_Productos);
            return View(pRO95_Ventajas.ToList());
        }

        // GET: PRO95_Ventajas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO95_Ventajas pRO95_Ventajas = db.PRO95_Ventajas.Find(id);
            if (pRO95_Ventajas == null)
            {
                return HttpNotFound();
            }
            return View(pRO95_Ventajas);
        }

        // GET: PRO95_Ventajas/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO95_Ventajas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO95_Ventajas pRO95_Ventajas)
        {
            if (ModelState.IsValid)
            {
                db.PRO95_Ventajas.Add(pRO95_Ventajas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO95_Ventajas.Cod_PRO);
            return View(pRO95_Ventajas);
        }

        // GET: PRO95_Ventajas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO95_Ventajas pRO95_Ventajas = db.PRO95_Ventajas.Find(id);
            if (pRO95_Ventajas == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO95_Ventajas.Cod_PRO);
            return View(pRO95_Ventajas);
        }

        // POST: PRO95_Ventajas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO95_Ventajas pRO95_Ventajas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO95_Ventajas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO95_Ventajas.Cod_PRO);
            return View(pRO95_Ventajas);
        }

        // GET: PRO95_Ventajas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO95_Ventajas pRO95_Ventajas = db.PRO95_Ventajas.Find(id);
            if (pRO95_Ventajas == null)
            {
                return HttpNotFound();
            }
            return View(pRO95_Ventajas);
        }

        // POST: PRO95_Ventajas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO95_Ventajas pRO95_Ventajas = db.PRO95_Ventajas.Find(id);
            db.PRO95_Ventajas.Remove(pRO95_Ventajas);
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
