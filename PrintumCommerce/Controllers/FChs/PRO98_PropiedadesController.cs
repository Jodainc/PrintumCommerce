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
    public class PRO98_PropiedadesController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO98_Propiedades
        public ActionResult Index()
        {
            var pRO98_Propiedades = db.PRO98_Propiedades.Include(p => p.PRO1_Productos);
            return View(pRO98_Propiedades.ToList());
        }

        // GET: PRO98_Propiedades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO98_Propiedades pRO98_Propiedades = db.PRO98_Propiedades.Find(id);
            if (pRO98_Propiedades == null)
            {
                return HttpNotFound();
            }
            return View(pRO98_Propiedades);
        }

        // GET: PRO98_Propiedades/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO98_Propiedades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO98_Propiedades pRO98_Propiedades)
        {
            if (ModelState.IsValid)
            {
                db.PRO98_Propiedades.Add(pRO98_Propiedades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO98_Propiedades.Cod_PRO);
            return View(pRO98_Propiedades);
        }

        // GET: PRO98_Propiedades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO98_Propiedades pRO98_Propiedades = db.PRO98_Propiedades.Find(id);
            if (pRO98_Propiedades == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO98_Propiedades.Cod_PRO);
            return View(pRO98_Propiedades);
        }

        // POST: PRO98_Propiedades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO98_Propiedades pRO98_Propiedades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO98_Propiedades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO98_Propiedades.Cod_PRO);
            return View(pRO98_Propiedades);
        }

        // GET: PRO98_Propiedades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO98_Propiedades pRO98_Propiedades = db.PRO98_Propiedades.Find(id);
            if (pRO98_Propiedades == null)
            {
                return HttpNotFound();
            }
            return View(pRO98_Propiedades);
        }

        // POST: PRO98_Propiedades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO98_Propiedades pRO98_Propiedades = db.PRO98_Propiedades.Find(id);
            db.PRO98_Propiedades.Remove(pRO98_Propiedades);
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
