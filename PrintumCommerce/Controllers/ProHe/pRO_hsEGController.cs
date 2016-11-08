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

namespace PrintumCommerce.Controllers.ProHe
{
    public class pRO_hsEGController : Controller
    {
        private Model1 db = new Model1();

        // GET: pRO_hsEG
        public ActionResult Index()
        {
            var pRO_hsEG = db.pRO_hsEG.Include(p => p.Producto);
            return View(pRO_hsEG.ToList());
        }

        // GET: pRO_hsEG/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG pRO_hsEG = db.pRO_hsEG.Find(id);
            if (pRO_hsEG == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG);
        }

        public ActionResult PDF(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var pRO_hsEG = db.pRO_hsEG.Include(p => p.Producto).Where(p => p.Codigo == id);
            var pRO_hsEG_cOMPO = db.pRO_hsEG_cOMPO.Where(p => p.C2Codigo == id);
            var pRO_hsEG_ePP1 = db.pRO_hsEG_ePP.Where(p => p.C8Codigo == id);
            var q = from r in db.pRO_hsEG_ePP
                    where r.C8Codigo == id
                    select new
                    {
                        C8Codigo = r.C8Codigo,
                        c8epp = r.c8ePP,
                        c8mASiNFO = r.c8mASiNFO,
                        C8pROTECCION = r.C8pROTECCION
                    };
            List<pRO_hsEG_ePP> list10 = null;

            foreach (var item1 in q)
            {
                if (!(item1.Equals(null)) || (string.IsNullOrEmpty(item1.c8epp)) || (string.IsNullOrEmpty(item1.C8Codigo)) || !(string.IsNullOrEmpty(item1.c8epp)))
                {

                int catgry = 0;
                int a10 = 0;
                string[] words = { };
                char[] delimiterChars = { ' ', ';', '\t' };
                words = item1.c8epp.Split(delimiterChars);
                foreach (string s in words)
                {
                    if (!(String.IsNullOrEmpty(words[a10])))
                    {
                        catgry = Convert.ToInt32(words[a10]);
                    } else
                    {
                        break;
                    }

                }
                var q10 = from r in db.tAUX_EPP
                          where r.nO == catgry
                          select new
                          {

                              c8epp = r.nOMBREhS

                          };
               
                var hj2 = from r in db.tAUX_EPP where r.nO == catgry select new { c8epp = r.nOMBREhS };
                hj2.ToList();
                list10 = q.AsEnumerable()
                    .Select(o => new pRO_hsEG_ePP
                    {
                        C8Codigo = o.C8Codigo,
                        c8ePP  =hj2.ToString(),
                        c8mASiNFO = o.c8mASiNFO,
                        C8pROTECCION = o.C8pROTECCION,
                    }).ToList();

        
                a10++;
                }
                else { break; }
            }
            var allModels = new Tuple<List<pRO_hsEG>, List<pRO_hsEG_cOMPO>, List<pRO_hsEG_ePP>, List<pRO_hsEG_ePP>>(pRO_hsEG.ToList(), pRO_hsEG_cOMPO.ToList(), list10, list10) { };
            if (pRO_hsEG == null || pRO_hsEG_cOMPO == null)
            {
                return HttpNotFound();
            }
            return new PdfResult(allModels, "PDF");
        }

        // GET: pRO_hsEG/Create
        public ActionResult Create()
        {
            ViewBag.Codigo = new SelectList(db.Productos, "Código", "Descripción");
            return View();
        }

        // POST: pRO_hsEG/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Codigo,C1nOMBRE,C1sINONIMOS,C1fXqUIMICA,C1nOUN,C1iDpROVEE,C3rIESTOsALUD,C3iNHALACION,C3iNGESTION,C3cONTACpIEL,C3cONTACoJOS,C4iNHALACION,C4iNGESTION,C4cONTACpIEL,C4cONTACoJOS,C5piNFLAMACION,C5tEMaUTOiGNICION,C5lIMITiNFLAMA,C5pELIiNCENeXPLO,C5mEDIeXTINCION,C5pROcOMBUSTION,C5pRECAUCIONES,C5iNTRUCcONTRAfIRE,C6mEDIvERDITO,C7mANEJO,C7aLMACENAMIENTO,C8cONTROLiNG,C9aPARIENCIA,C9vALOR,C9eSTADOfISICO,C9gRAVEDAD,C9pUNTOeBULLI,C9pUNTOfUSION,C9dENSIDAD,C9vISCOSIDAD,C9pH,C9sOLUBILIDAD,C10eSTABILIquIMICA,C10aeVITAR,C10iNCOMPATIBILIDAD,C10pRPpELIxdESCOM,C10pOLIMERIZACION,C11iNFOtOXICOLOGICA,C12iNFOeCOLOGICA,C13dISPOSICION,C14iNFOtRANSPORTE,C15iNFOrEGLAMENTA,C16nFPA,C16pICT1,C16pICT2")] pRO_hsEG pRO_hsEG)
        {
            if (ModelState.IsValid)
            {
                db.pRO_hsEG.Add(pRO_hsEG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Codigo = new SelectList(db.Productos, "Código", "Descripción", pRO_hsEG.Codigo);
            return View(pRO_hsEG);
        }

        // GET: pRO_hsEG/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG pRO_hsEG = db.pRO_hsEG.Find(id);
            if (pRO_hsEG == null)
            {
                return HttpNotFound();
            }
            ViewBag.Codigo = new SelectList(db.Productos, "Código", "Descripción", pRO_hsEG.Codigo);
            return View(pRO_hsEG);
        }

        // POST: pRO_hsEG/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Codigo,C1nOMBRE,C1sINONIMOS,C1fXqUIMICA,C1nOUN,C1iDpROVEE,C3rIESTOsALUD,C3iNHALACION,C3iNGESTION,C3cONTACpIEL,C3cONTACoJOS,C4iNHALACION,C4iNGESTION,C4cONTACpIEL,C4cONTACoJOS,C5piNFLAMACION,C5tEMaUTOiGNICION,C5lIMITiNFLAMA,C5pELIiNCENeXPLO,C5mEDIeXTINCION,C5pROcOMBUSTION,C5pRECAUCIONES,C5iNTRUCcONTRAfIRE,C6mEDIvERDITO,C7mANEJO,C7aLMACENAMIENTO,C8cONTROLiNG,C9aPARIENCIA,C9vALOR,C9eSTADOfISICO,C9gRAVEDAD,C9pUNTOeBULLI,C9pUNTOfUSION,C9dENSIDAD,C9vISCOSIDAD,C9pH,C9sOLUBILIDAD,C10eSTABILIquIMICA,C10aeVITAR,C10iNCOMPATIBILIDAD,C10pRPpELIxdESCOM,C10pOLIMERIZACION,C11iNFOtOXICOLOGICA,C12iNFOeCOLOGICA,C13dISPOSICION,C14iNFOtRANSPORTE,C15iNFOrEGLAMENTA,C16nFPA,C16pICT1,C16pICT2")] pRO_hsEG pRO_hsEG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRO_hsEG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Codigo = new SelectList(db.Productos, "Código", "Descripción", pRO_hsEG.Codigo);
            return View(pRO_hsEG);
        }

        // GET: pRO_hsEG/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pRO_hsEG pRO_hsEG = db.pRO_hsEG.Find(id);
            if (pRO_hsEG == null)
            {
                return HttpNotFound();
            }
            return View(pRO_hsEG);
        }

        // POST: pRO_hsEG/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            pRO_hsEG pRO_hsEG = db.pRO_hsEG.Find(id);
            db.pRO_hsEG.Remove(pRO_hsEG);
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
