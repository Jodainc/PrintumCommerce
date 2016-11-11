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
    public class PRO7_LimpiezaController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO7_Limpieza
        public ActionResult Index()
        {
            var pRO7_Limpieza = db.PRO7_Limpieza.Include(p => p.PRO1_Productos);
            return View(pRO7_Limpieza.ToList());
        }

        // GET: PRO7_Limpieza/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO7_Limpieza pRO7_Limpieza = db.PRO7_Limpieza.Find(id);
            if (pRO7_Limpieza == null)
            {
                return HttpNotFound();
            }
            return View(pRO7_Limpieza);
        }

        // GET: PRO7_Limpieza/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO7_Limpieza/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO7_Limpieza pRO7_Limpieza)
        {
            if (ModelState.IsValid)
            {
                db.PRO7_Limpieza.Add(pRO7_Limpieza);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO7_Limpieza.Cod_PRO);
            return View(pRO7_Limpieza);
        }

        // GET: PRO7_Limpieza/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO7_Limpieza pRO7_Limpieza = db.PRO7_Limpieza.Find(id);
            if (pRO7_Limpieza == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO7_Limpieza.Cod_PRO);
            return View(pRO7_Limpieza);
        }

        // POST: PRO7_Limpieza/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO7_Limpieza pRO7_Limpieza)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO7_Limpieza).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO7_Limpieza.Cod_PRO);
            return View(pRO7_Limpieza);
        }

        // GET: PRO7_Limpieza/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO7_Limpieza pRO7_Limpieza = db.PRO7_Limpieza.Find(id);
            if (pRO7_Limpieza == null)
            {
                return HttpNotFound();
            }
            return View(pRO7_Limpieza);
        }

        // POST: PRO7_Limpieza/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO7_Limpieza pRO7_Limpieza = db.PRO7_Limpieza.Find(id);
            db.PRO7_Limpieza.Remove(pRO7_Limpieza);
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
