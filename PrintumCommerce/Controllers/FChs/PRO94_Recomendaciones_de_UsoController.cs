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
    public class PRO94_Recomendaciones_de_UsoController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO94_Recomendaciones_de_Uso
        public ActionResult Index()
        {
            var pRO94_Recomendaciones_de_Uso = db.PRO94_Recomendaciones_de_Uso.Include(p => p.PRO1_Productos);
            return View(pRO94_Recomendaciones_de_Uso.ToList());
        }

        // GET: PRO94_Recomendaciones_de_Uso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO94_Recomendaciones_de_Uso pRO94_Recomendaciones_de_Uso = db.PRO94_Recomendaciones_de_Uso.Find(id);
            if (pRO94_Recomendaciones_de_Uso == null)
            {
                return HttpNotFound();
            }
            return View(pRO94_Recomendaciones_de_Uso);
        }

        // GET: PRO94_Recomendaciones_de_Uso/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO94_Recomendaciones_de_Uso/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO94_Recomendaciones_de_Uso pRO94_Recomendaciones_de_Uso)
        {
            if (ModelState.IsValid)
            {
                db.PRO94_Recomendaciones_de_Uso.Add(pRO94_Recomendaciones_de_Uso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO94_Recomendaciones_de_Uso.Cod_PRO);
            return View(pRO94_Recomendaciones_de_Uso);
        }

        // GET: PRO94_Recomendaciones_de_Uso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO94_Recomendaciones_de_Uso pRO94_Recomendaciones_de_Uso = db.PRO94_Recomendaciones_de_Uso.Find(id);
            if (pRO94_Recomendaciones_de_Uso == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO94_Recomendaciones_de_Uso.Cod_PRO);
            return View(pRO94_Recomendaciones_de_Uso);
        }

        // POST: PRO94_Recomendaciones_de_Uso/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO94_Recomendaciones_de_Uso pRO94_Recomendaciones_de_Uso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO94_Recomendaciones_de_Uso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO94_Recomendaciones_de_Uso.Cod_PRO);
            return View(pRO94_Recomendaciones_de_Uso);
        }

        // GET: PRO94_Recomendaciones_de_Uso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO94_Recomendaciones_de_Uso pRO94_Recomendaciones_de_Uso = db.PRO94_Recomendaciones_de_Uso.Find(id);
            if (pRO94_Recomendaciones_de_Uso == null)
            {
                return HttpNotFound();
            }
            return View(pRO94_Recomendaciones_de_Uso);
        }

        // POST: PRO94_Recomendaciones_de_Uso/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO94_Recomendaciones_de_Uso pRO94_Recomendaciones_de_Uso = db.PRO94_Recomendaciones_de_Uso.Find(id);
            db.PRO94_Recomendaciones_de_Uso.Remove(pRO94_Recomendaciones_de_Uso);
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
