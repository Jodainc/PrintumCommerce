using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;

namespace PrintumCommerce.Controllers.Pro_Presantation
{
    public class Pro_PresentacionController : Controller
    {
        private Model1 db = new Model1();

        // GET: Pro_Presentacion
        public ActionResult Index()
        {
            var pro_Presentacion = db.Pro_Presentacion.Include(p => p.Pro_Tiempo).Include(p => p.Producto);
            return View(pro_Presentacion.ToList());
        }

        // GET: Pro_Presentacion/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Presentacion pro_Presentacion = db.Pro_Presentacion.Find(id);
            if (pro_Presentacion == null)
            {
                return HttpNotFound();
            }
            return View(pro_Presentacion);
        }

        // GET: Pro_Presentacion/Create
        public ActionResult Create()
        {
            ViewBag.Cod_Producto = new SelectList(db.Pro_Tiempo, "Cod_Producto", "cod");
            ViewBag.CODIGO = new SelectList(db.Productos, "Código", "Descripción");
            return View();
        }

        // POST: Pro_Presentacion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cod_Producto,CODIGO,COD_PROVEEDOR,Descripcion,D1,D2,Presentacion_Kg,Unidad_Medida,Precio_KG,cOSTOpRO,cOSiMP,Maxi,Mini,Presentacion_Pro,Unidad_Medida_Pro,Presentacion_Kg_pri,cLSiNV,R_NFPA1,R_NFPA2,R_NFPA3,R_NFPA4")] Pro_Presentacion pro_Presentacion)
        {
            if (ModelState.IsValid)
            {
                db.Pro_Presentacion.Add(pro_Presentacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_Producto = new SelectList(db.Pro_Tiempo, "Cod_Producto", "cod", pro_Presentacion.Cod_Producto);
            ViewBag.CODIGO = new SelectList(db.Productos, "Código", "Descripción", pro_Presentacion.CODIGO);
            return View(pro_Presentacion);
        }

        // GET: Pro_Presentacion/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Presentacion pro_Presentacion = db.Pro_Presentacion.Find(id);
            if (pro_Presentacion == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_Producto = new SelectList(db.Pro_Tiempo, "Cod_Producto", "cod", pro_Presentacion.Cod_Producto);
            ViewBag.CODIGO = new SelectList(db.Productos, "Código", "Descripción", pro_Presentacion.CODIGO);
            return View(pro_Presentacion);
        }

        // POST: Pro_Presentacion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cod_Producto,CODIGO,COD_PROVEEDOR,Descripcion,D1,D2,Presentacion_Kg,Unidad_Medida,Precio_KG,cOSTOpRO,cOSiMP,Maxi,Mini,Presentacion_Pro,Unidad_Medida_Pro,Presentacion_Kg_pri,cLSiNV,R_NFPA1,R_NFPA2,R_NFPA3,R_NFPA4")] Pro_Presentacion pro_Presentacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pro_Presentacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_Producto = new SelectList(db.Pro_Tiempo, "Cod_Producto", "cod", pro_Presentacion.Cod_Producto);
            ViewBag.CODIGO = new SelectList(db.Productos, "Código", "Descripción", pro_Presentacion.CODIGO);
            return View(pro_Presentacion);
        }

        // GET: Pro_Presentacion/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Presentacion pro_Presentacion = db.Pro_Presentacion.Find(id);
            if (pro_Presentacion == null)
            {
                return HttpNotFound();
            }
            return View(pro_Presentacion);
        }

        // POST: Pro_Presentacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Pro_Presentacion pro_Presentacion = db.Pro_Presentacion.Find(id);
            db.Pro_Presentacion.Remove(pro_Presentacion);
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
