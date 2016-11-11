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
    public class PRO5_Referencias_ExistentesController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO5_Referencias_Existentes
        public ActionResult Index()
        {
            var pRO5_Referencias_Existentes = db.PRO5_Referencias_Existentes.Include(p => p.PRO1_Productos);
            return View(pRO5_Referencias_Existentes.ToList());
        }

        // GET: PRO5_Referencias_Existentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO5_Referencias_Existentes pRO5_Referencias_Existentes = db.PRO5_Referencias_Existentes.Find(id);
            if (pRO5_Referencias_Existentes == null)
            {
                return HttpNotFound();
            }
            return View(pRO5_Referencias_Existentes);
        }

        // GET: PRO5_Referencias_Existentes/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO5_Referencias_Existentes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Descripcion,Off_Tipogra_UV,Off_Tipogra_Aceite,Flx_UV,Flx_AGUA,Flx_SOVENTE,SRC_UV,SRC_AGUA")] PRO5_Referencias_Existentes pRO5_Referencias_Existentes)
        {
            if (ModelState.IsValid)
            {
                db.PRO5_Referencias_Existentes.Add(pRO5_Referencias_Existentes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO5_Referencias_Existentes.Cod_PRO);
            return View(pRO5_Referencias_Existentes);
        }

        // GET: PRO5_Referencias_Existentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO5_Referencias_Existentes pRO5_Referencias_Existentes = db.PRO5_Referencias_Existentes.Find(id);
            if (pRO5_Referencias_Existentes == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO5_Referencias_Existentes.Cod_PRO);
            return View(pRO5_Referencias_Existentes);
        }

        // POST: PRO5_Referencias_Existentes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Descripcion,Off_Tipogra_UV,Off_Tipogra_Aceite,Flx_UV,Flx_AGUA,Flx_SOVENTE,SRC_UV,SRC_AGUA")] PRO5_Referencias_Existentes pRO5_Referencias_Existentes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO5_Referencias_Existentes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO5_Referencias_Existentes.Cod_PRO);
            return View(pRO5_Referencias_Existentes);
        }

        // GET: PRO5_Referencias_Existentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO5_Referencias_Existentes pRO5_Referencias_Existentes = db.PRO5_Referencias_Existentes.Find(id);
            if (pRO5_Referencias_Existentes == null)
            {
                return HttpNotFound();
            }
            return View(pRO5_Referencias_Existentes);
        }

        // POST: PRO5_Referencias_Existentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO5_Referencias_Existentes pRO5_Referencias_Existentes = db.PRO5_Referencias_Existentes.Find(id);
            db.PRO5_Referencias_Existentes.Remove(pRO5_Referencias_Existentes);
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
