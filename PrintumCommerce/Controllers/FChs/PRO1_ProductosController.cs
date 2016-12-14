using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrintumCommerce.Models.Access;
using RazorPDF;
using PrintumCommerce.Models.ViewModel;

namespace PrintumCommerce.Controllers.FChs
{
    public class PRO1_ProductosController : Controller
    {
        private Model1 db = new Model1();


        public ActionResult Index()
        {
            var pRO1_Productos = db.PRO1_Productos.Include(p => p.Productos);
            return View(pRO1_Productos.ToList());
        }
        public ActionResult PDF(string id)
        {
            ViewModelDemoVM vm = new ViewModelDemoVM();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var ppRO1_Productos = db.PRO1_Productos.Where(p => p.Cod_pro == id);
            var ppRO1 = db.Pro_Lineas;
            var ppRO2 = db.PRO2_Cuenta_con.Where(p => p.Cod_PRO == id);
            var ppRO3 = db.PRO3_Propiedades_de_Impresión.Where(p => p.Cod_PRO == id);
            var ppRO4 = db.PRO4_Propiedades_de_Aplicación.Where(p => p.Cod_PRO == id);
            var ppRO5 = db.PRO5_Referencias_Existentes.Where(p => p.Cod_PRO == id);
            var ppRO6 = db.PRO6_Recomendaciones_de_Procesamiento.Where(p => p.Cod_PRO == id);
            var ppRO7 = db.PRO7_Limpieza.Where(p => p.Cod_PRO == id);
            var ppRO8 = db.PRO8_Almacenamiento.Where(p => p.Cod_PRO == id);
            var ppRO9 = db.PRO9_Instrucciones_de_Seguridad.Where(p => p.Cod_PRO == id);
            var ppRO91 = db.PRO91_Unidad_de_Empaque.Where(p => p.Cod_PRO == id);
            var ppRO92 = db.PRO92_lAP_Propiedades_medicion_mm.Where(p => p.Cod_PRO == id);
            var ppRO93 = db.PRO93_lAP_Propiedades_Electricas.Where(p => p.Cod_PRO == id);
            var ppRO932 = db.PRO93_lAP_DIAGRAMA.Where(p => p.Cod_PRO == id);
            var ppRO94 = db.PRO94_Recomendaciones_de_Uso.Where(p => p.Cod_PRO == id);
            var ppRO95 = db.PRO95_Ventajas.Where(p => p.Cod_PRO == id);
            var ppRO96 = db.PRO96_Garantia.Where(p => p.Cod_PRO == id);
            var ppRO97 = db.PRO97_ServiTec.Where(p => p.Cod_PRO == id);
            var ppRO98 = db.PRO98_Propiedades.Where(p => p.Cod_PRO == id);
            var ppRO99 = db.PRO99_Pedido.Where(p => p.Cod_PRO == id);
            var ppR0100 = db.Pro_Grupos;
            vm.hojasSerguProductos1 = ppRO1_Productos.ToList();
            vm.hojasSeGurPro2 = ppRO2.ToList();
            vm.hojasSeGurPro3 = ppRO3.ToList();
            vm.hojasSeGurPro4 = ppRO4.ToList();
            vm.hojasSegurPro5 = ppRO5.ToList();
            vm.hojasSergu6 = ppRO6.ToList();
            vm.hojasSergu7 = ppRO7.ToList();
            vm.hojasSergu8 = ppRO8.ToList();
            vm.hojasSergu9 = ppRO9.ToList();
            vm.hojasSergu91 = ppRO91.ToList();
            vm.hojasSergu92= ppRO92.ToList();
            vm.hojasSergu93 = ppRO93.ToList();
            vm.hojasSergu94 = ppRO94.ToList();
            vm.hojasSergu98 = ppRO98.ToList();
            vm.hojasSergu96 = ppRO96.ToList();
            vm.hojasSergu97 = ppRO97.ToList();
            vm.hojasSergu99 = ppRO99.ToList();
            vm.hojasSergu95 = ppRO95.ToList();
            vm.hojasSergu901 = ppRO932.ToList();
            vm.lisneas = ppRO1.ToList();
            vm.hojasSeGuriPGrupos = ppR0100.ToList();
            return new PdfResult(vm, "PDF");
           // return View(vm);
        }


        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO1_Productos pRO1_Productos = db.PRO1_Productos.Find(id);
            if (pRO1_Productos == null)
            {
                return HttpNotFound();
            }
            return View(pRO1_Productos);
        }


        public ActionResult Create()
        {
            ViewBag.COD_PRODUCTO = new SelectList(db.Productos, "Código", "Descripción");
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cod_pro,Cod_Linea,Cod_Grupo,COD_PRODUCTO,Producto,Descripcion,Imagen")] PRO1_Productos pRO1_Productos)
        {
            if (ModelState.IsValid)
            {
                db.PRO1_Productos.Add(pRO1_Productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.COD_PRODUCTO = new SelectList(db.Productos, "Código", "Descripción", pRO1_Productos.COD_PRODUCTO);
            return View(pRO1_Productos);
        }


        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO1_Productos pRO1_Productos = db.PRO1_Productos.Find(id);
            if (pRO1_Productos == null)
            {
                return HttpNotFound();
            }
            ViewBag.COD_PRODUCTO = new SelectList(db.Productos, "Código", "Descripción", pRO1_Productos.COD_PRODUCTO);
            return View(pRO1_Productos);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cod_pro,Cod_Linea,Cod_Grupo,COD_PRODUCTO,Producto,Descripcion,Imagen")] PRO1_Productos pRO1_Productos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO1_Productos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.COD_PRODUCTO = new SelectList(db.Productos, "Código", "Descripción", pRO1_Productos.COD_PRODUCTO);
            return View(pRO1_Productos);
        }


        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRO1_Productos pRO1_Productos = db.PRO1_Productos.Find(id);
            if (pRO1_Productos == null)
            {
                return HttpNotFound();
            }
            return View(pRO1_Productos);
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PRO1_Productos pRO1_Productos = db.PRO1_Productos.Find(id);
            db.PRO1_Productos.Remove(pRO1_Productos);
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
