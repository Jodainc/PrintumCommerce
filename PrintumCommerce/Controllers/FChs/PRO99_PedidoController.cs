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
    public class PRO99_PedidoController : Controller
    {
        private Model1 db = new Model1();

        // GET: PRO99_Pedido
        public ActionResult Index()
        {
            var pRO99_Pedido = db.PRO99_Pedido.Include(p => p.PRO1_Productos);
            return View(pRO99_Pedido.ToList());
        }

        // GET: PRO99_Pedido/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO99_Pedido pRO99_Pedido = db.PRO99_Pedido.Find(id);
            if (pRO99_Pedido == null)
            {
                return HttpNotFound();
            }
            return View(pRO99_Pedido);
        }

        // GET: PRO99_Pedido/Create
        public ActionResult Create()
        {
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO");
            return View();
        }

        // POST: PRO99_Pedido/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO99_Pedido pRO99_Pedido)
        {
            if (ModelState.IsValid)
            {
                db.PRO99_Pedido.Add(pRO99_Pedido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO99_Pedido.Cod_PRO);
            return View(pRO99_Pedido);
        }

        // GET: PRO99_Pedido/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO99_Pedido pRO99_Pedido = db.PRO99_Pedido.Find(id);
            if (pRO99_Pedido == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO99_Pedido.Cod_PRO);
            return View(pRO99_Pedido);
        }

        // POST: PRO99_Pedido/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idCode,Cod_PRO,Informacion")] PRO99_Pedido pRO99_Pedido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO99_Pedido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cod_PRO = new SelectList(db.PRO1_Productos, "Cod_pro", "COD_PRODUCTO", pRO99_Pedido.Cod_PRO);
            return View(pRO99_Pedido);
        }

        // GET: PRO99_Pedido/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO99_Pedido pRO99_Pedido = db.PRO99_Pedido.Find(id);
            if (pRO99_Pedido == null)
            {
                return HttpNotFound();
            }
            return View(pRO99_Pedido);
        }

        // POST: PRO99_Pedido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PRO99_Pedido pRO99_Pedido = db.PRO99_Pedido.Find(id);
            db.PRO99_Pedido.Remove(pRO99_Pedido);
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
