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
    public class PRO97_ServiTecController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO97_ServiTec
        public ActionResult Index()
        {
            var pRO97_ServiTec = db.PRO97_ServiTec.Include(p => p.PRO1_Productos);
            return View(pRO97_ServiTec.ToList());
        }

        // GET: PRO97_ServiTec/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO97_ServiTec pRO97_ServiTec = db.PRO97_ServiTec.Find(id);
            if (pRO97_ServiTec == null)
            {
                return HttpNotFound();
            }
            return View(pRO97_ServiTec);
        }

        // GET: PRO97_ServiTec/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO97_ServiTec/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO97_ServiTec pRO97_ServiTec)
        {
            if (ModelState.IsValid)
            {
                db.PRO97_ServiTec.Add(pRO97_ServiTec);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO97_ServiTec.Cod_PRO);
            return View(pRO97_ServiTec);
        }

        // GET: PRO97_ServiTec/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO97_ServiTec pRO97_ServiTec = db.PRO97_ServiTec.Find(id);
            if (pRO97_ServiTec == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO97_ServiTec.Cod_PRO);
            return View(pRO97_ServiTec);
        }

        // POST: PRO97_ServiTec/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO97_ServiTec pRO97_ServiTec)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO97_ServiTec).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO97_ServiTec.Cod_PRO);
            return View(pRO97_ServiTec);
        }

        // GET: PRO97_ServiTec/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO97_ServiTec pRO97_ServiTec = db.PRO97_ServiTec.Find(id);
            if (pRO97_ServiTec == null)
            {
                return HttpNotFound();
            }
            return View(pRO97_ServiTec);
        }

        // POST: PRO97_ServiTec/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO97_ServiTec pRO97_ServiTec = db.PRO97_ServiTec.Find(id);
            db.PRO97_ServiTec.Remove(pRO97_ServiTec);
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
