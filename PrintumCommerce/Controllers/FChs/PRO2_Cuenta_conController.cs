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
    public class PRO2_Cuenta_conController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO2_Cuenta_con
        public ActionResult Index()
        {
            var pRO2_Cuenta_con = db.PRO2_Cuenta_con.Include(p => p.PRO1_Productos);
            return View(pRO2_Cuenta_con.ToList());
        }

        // GET: PRO2_Cuenta_con/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO2_Cuenta_con pRO2_Cuenta_con = db.PRO2_Cuenta_con.Find(id);
            if (pRO2_Cuenta_con == null)
            {
                return HttpNotFound();
            }
            return View(pRO2_Cuenta_con);
        }

        // GET: PRO2_Cuenta_con/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO2_Cuenta_con/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO2_Cuenta_con pRO2_Cuenta_con)
        {
            if (ModelState.IsValid)
            {
                db.PRO2_Cuenta_con.Add(pRO2_Cuenta_con);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO2_Cuenta_con.Cod_PRO);
            return View(pRO2_Cuenta_con);
        }

        // GET: PRO2_Cuenta_con/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO2_Cuenta_con pRO2_Cuenta_con = db.PRO2_Cuenta_con.Find(id);
            if (pRO2_Cuenta_con == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO2_Cuenta_con.Cod_PRO);
            return View(pRO2_Cuenta_con);
        }

        // POST: PRO2_Cuenta_con/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO2_Cuenta_con pRO2_Cuenta_con)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO2_Cuenta_con).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO2_Cuenta_con.Cod_PRO);
            return View(pRO2_Cuenta_con);
        }

        // GET: PRO2_Cuenta_con/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO2_Cuenta_con pRO2_Cuenta_con = db.PRO2_Cuenta_con.Find(id);
            if (pRO2_Cuenta_con == null)
            {
                return HttpNotFound();
            }
            return View(pRO2_Cuenta_con);
        }

        // POST: PRO2_Cuenta_con/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO2_Cuenta_con pRO2_Cuenta_con = db.PRO2_Cuenta_con.Find(id);
            db.PRO2_Cuenta_con.Remove(pRO2_Cuenta_con);
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
