using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;

namespace PrintumCommerce.Controllers.Customer
{
    public class ClientesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Clientes
        public ActionResult Index()
        {
            return View(db.Clientes.ToList());
        }

        // GET: Clientes/Details/5
        public ActionResult Details(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clientes clientes = db.Clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }



        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nombre,TIPO_ID,RepresentanteLegal,IDRP,Ciudad,Sector,Barrio,Zona,Direccion,Telefono,Telefono1,Fax,Celular,IDVENDEDOR,Plazo,Cupo,RUT,Estado,Mail,Contacto,WebSite,Fecha_Creacion,Creado_Por,WO,cONSUMO,rEF_fIN,rEF_cOM,eSPECIAL,h_lUN_vIE,h_sAB,dIAS_cOBRO,nOTAS_cOBRO,F_INI_aCT,PlazoP,CupoP,rEF_cOM1,rEF_cOM2,rEF_cOM3,rEF_cOM4,lEADtIME,sTOCKmAX,HC,CCC")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(clientes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientes);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clientes clientes = db.Clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nombre,TIPO_ID,RepresentanteLegal,IDRP,Ciudad,Sector,Barrio,Zona,Direccion,Telefono,Telefono1,Fax,Celular,IDVENDEDOR,Plazo,Cupo,RUT,Estado,Mail,Contacto,WebSite,Fecha_Creacion,Creado_Por,WO,cONSUMO,rEF_fIN,rEF_cOM,eSPECIAL,h_lUN_vIE,h_sAB,dIAS_cOBRO,nOTAS_cOBRO,F_INI_aCT,PlazoP,CupoP,rEF_cOM1,rEF_cOM2,rEF_cOM3,rEF_cOM4,lEADtIME,sTOCKmAX,HC,CCC")] Clientes clientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientes);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clientes clientes = db.Clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(double id)
        {
            Clientes clientes = db.Clientes.Find(id);
            db.Clientes.Remove(clientes);
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
