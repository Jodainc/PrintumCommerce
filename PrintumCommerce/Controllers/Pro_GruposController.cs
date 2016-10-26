using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;

namespace PrintumCommerce.Controllers
{
    public class Pro_GruposController : Controller
    {
        private Model1 db = new Model1();
        public ActionResult Index()
        {
            var pro_Grupos = db.Pro_Grupos.Include(p => p.Pro_Lineas).Include(p => p.VT_Vlr_Liq);
            return View(pro_Grupos.ToList());
        }

        public ActionResult Details(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Grupos pro_Grupos = db.Pro_Grupos.Find(id);
            if (pro_Grupos == null)
            {
                return HttpNotFound();
            }
            return View(pro_Grupos);
        }

        public ActionResult Create()
        {
            ViewBag.Linea = new SelectList(db.Pro_Lineas, "Linea", "Descripcion");
            ViewBag.tIPO = new SelectList(db.VT_Vlr_Liq, "Tipo", "Tipo");
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Grupo,Linea,Descripcion,tIPO")] Pro_Grupos pro_Grupos)
        {
            if (ModelState.IsValid)
            {
                db.Pro_Grupos.Add(pro_Grupos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Linea = new SelectList(db.Pro_Lineas, "Linea", "Descripcion", pro_Grupos.Linea);
            ViewBag.tIPO = new SelectList(db.VT_Vlr_Liq, "Tipo", "Tipo", pro_Grupos.tIPO);
            return View(pro_Grupos);
        }

        public ActionResult Edit(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Grupos pro_Grupos = db.Pro_Grupos.Find(id);
            if (pro_Grupos == null)
            {
                return HttpNotFound();
            }
            ViewBag.Linea = new SelectList(db.Pro_Lineas, "Linea", "Descripcion", pro_Grupos.Linea);
            ViewBag.tIPO = new SelectList(db.VT_Vlr_Liq, "Tipo", "Tipo", pro_Grupos.tIPO);
            return View(pro_Grupos);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Grupo,Linea,Descripcion,tIPO")] Pro_Grupos pro_Grupos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pro_Grupos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Linea = new SelectList(db.Pro_Lineas, "Linea", "Descripcion", pro_Grupos.Linea);
            ViewBag.tIPO = new SelectList(db.VT_Vlr_Liq, "Tipo", "Tipo", pro_Grupos.tIPO);
            return View(pro_Grupos);
        }

        public ActionResult Delete(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Grupos pro_Grupos = db.Pro_Grupos.Find(id);
            if (pro_Grupos == null)
            {
                return HttpNotFound();
            }
            return View(pro_Grupos);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(double id)
        {
            Pro_Grupos pro_Grupos = db.Pro_Grupos.Find(id);
            db.Pro_Grupos.Remove(pro_Grupos);
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
