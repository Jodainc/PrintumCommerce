using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;

namespace PrintumCommerce.Controllers.ProCertificos
{
    public class Pro_CertificadosController : Controller
    {
        private Model1 db = new Model1();


        public ActionResult Index()
        {
            var pro_Certificados = db.Pro_Certificados.Include(p => p.Productos);
            return View(pro_Certificados.ToList());
        }


        public ActionResult Details(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Certificados pro_Certificados = db.Pro_Certificados.Find(id);
            if (pro_Certificados == null)
            {
                return HttpNotFound();
            }
            return View(pro_Certificados);
        }



        public ActionResult Create()
        {
            ViewBag.Cod_producto = new SelectList(db.Productos, "Código", "Descripción");
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "No,Fecha,Cod_producto,Presentacion,Espectro,cERTIdRIVE")] Pro_Certificados pro_Certificados)
        {
            if (ModelState.IsValid)
            {
                db.Pro_Certificados.Add(pro_Certificados);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_producto = new SelectList(db.Productos, "Código", "Descripción", pro_Certificados.Cod_producto);
            return View(pro_Certificados);
        }


        public ActionResult Edit(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Certificados pro_Certificados = db.Pro_Certificados.Find(id);
            if (pro_Certificados == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_producto = new SelectList(db.Productos, "Código", "Descripción", pro_Certificados.Cod_producto);
            return View(pro_Certificados);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "No,Fecha,Cod_producto,Presentacion,Espectro,cERTIdRIVE")] Pro_Certificados pro_Certificados)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pro_Certificados).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_producto = new SelectList(db.Productos, "Código", "Descripción", pro_Certificados.Cod_producto);
            return View(pro_Certificados);
        }


        public ActionResult Delete(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Certificados pro_Certificados = db.Pro_Certificados.Find(id);
            if (pro_Certificados == null)
            {
                return HttpNotFound();
            }
            return View(pro_Certificados);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(double id)
        {
            Pro_Certificados pro_Certificados = db.Pro_Certificados.Find(id);
            db.Pro_Certificados.Remove(pro_Certificados);
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
