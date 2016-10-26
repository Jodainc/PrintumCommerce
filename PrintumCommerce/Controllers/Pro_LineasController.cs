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
    public class Pro_LineasController : Controller
    {
        private Model1 db = new Model1();

        // GET: Pro_Lineas
        public ActionResult Index()
        {
            var pro_Lineas = db.Pro_Lineas.Include(p => p.pRO_lN);
            return View(pro_Lineas.ToList());
        }

        // GET: Pro_Lineas/Details/5
        public ActionResult Details(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Lineas pro_Lineas = db.Pro_Lineas.Find(id);
            if (pro_Lineas == null)
            {
                return HttpNotFound();
            }
            return View(pro_Lineas);
        }

        // GET: Pro_Lineas/Create
        public ActionResult Create()
        {
            ViewBag.LN = new SelectList(db.pRO_lN, "LN", "Linea_Negocio");
            return View();
        }

        // POST: Pro_Lineas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Linea,LN,Descripcion")] Pro_Lineas pro_Lineas)
        {
            if (ModelState.IsValid)
            {
                db.Pro_Lineas.Add(pro_Lineas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LN = new SelectList(db.pRO_lN, "LN", "Linea_Negocio", pro_Lineas.LN);
            return View(pro_Lineas);
        }

        // GET: Pro_Lineas/Edit/5
        public ActionResult Edit(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Lineas pro_Lineas = db.Pro_Lineas.Find(id);
            if (pro_Lineas == null)
            {
                return HttpNotFound();
            }
            ViewBag.LN = new SelectList(db.pRO_lN, "LN", "Linea_Negocio", pro_Lineas.LN);
            return View(pro_Lineas);
        }

        // POST: Pro_Lineas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Linea,LN,Descripcion")] Pro_Lineas pro_Lineas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pro_Lineas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LN = new SelectList(db.pRO_lN, "LN", "Linea_Negocio", pro_Lineas.LN);
            return View(pro_Lineas);
        }

        // GET: Pro_Lineas/Delete/5
        public ActionResult Delete(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pro_Lineas pro_Lineas = db.Pro_Lineas.Find(id);
            if (pro_Lineas == null)
            {
                return HttpNotFound();
            }
            return View(pro_Lineas);
        }

        // POST: Pro_Lineas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(double id)
        {
            Pro_Lineas pro_Lineas = db.Pro_Lineas.Find(id);
            db.Pro_Lineas.Remove(pro_Lineas);
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
