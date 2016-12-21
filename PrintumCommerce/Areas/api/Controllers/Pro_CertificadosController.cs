using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PrintumCommerce.Areas.api.Models;

namespace PrintumCommerce.Areas.api.Controllers
{
    public class Pro_CertificadosController : ApiController
    {
        private Model1 db = new Model1();
        [System.Web.Http.Authorize]
        public IQueryable<Pro_Certificados> GetPro_Certificados()
        {
            return db.Pro_Certificados;
        }

        [System.Web.Http.Authorize]
        [ResponseType(typeof(Pro_Certificados))]
        [Route("api/Pro_Certificados/{id}/{dateTime}")]
        public IHttpActionResult GetPro_Certificados(string id, string dateTime)
        {
            try
            {
                DateTime dt = Convert.ToDateTime(dateTime);


                if (dateTime != null)
                {
                    var q = from r in db.Pro_Certificados
                            where (r.Cod_producto == id && r.Fecha.Value.Day == dt.Day && r.Fecha.Value.Year == dt.Year && r.Fecha.Value.Month == dt.Month)
                            select new
                            {
                                C8Codigo = r.Cod_producto,
                                c8epp = r.Presentacion,
                                c8mASiNFO = r.Espectro,
                                C8pROTECCION = r.cERTIdRIVE
                            };
                    if (q == null)
                    {
                        return NotFound();
                    }

                    return Ok(q);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                if (ex.InnerException != null && ex.InnerException.InnerException != null && ex.InnerException.Message.Contains("Index"))
                {
                    ModelState.AddModelError(string.Empty, "La casilla {0} ya existe en la tabla");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                return NotFound();
            }
        }

        [System.Web.Http.Authorize]
        [ResponseType(typeof(Pro_Certificados))]
        public IHttpActionResult GetPro_Certificados(string id)
        {
            var q = from r in db.Pro_Certificados
                    where (r.Presentacion == id)
                    select new
                    {
                        C8Codigo = r.Cod_producto,
                        c8epp = r.Presentacion,
                        c8mASiNFO = r.Espectro,
                        C8pROTECCION = r.cERTIdRIVE
                    };
            if (q == null)
            {
                return NotFound();
            }

            return Ok(q);
        }

        [System.Web.Http.Authorize]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPro_Certificados(double id, Pro_Certificados pro_Certificados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pro_Certificados.No)
            {
                return BadRequest();
            }

            db.Entry(pro_Certificados).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Pro_CertificadosExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        [System.Web.Http.Authorize]
        [ResponseType(typeof(Pro_Certificados))]
        public IHttpActionResult PostPro_Certificados(Pro_Certificados pro_Certificados)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pro_Certificados.Add(pro_Certificados);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Pro_CertificadosExists(pro_Certificados.No))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = pro_Certificados.No }, pro_Certificados);
        }


        [System.Web.Http.Authorize]
        [ResponseType(typeof(Pro_Certificados))]
        public IHttpActionResult DeletePro_Certificados(double id)
        {
            Pro_Certificados pro_Certificados = db.Pro_Certificados.Find(id);
            if (pro_Certificados == null)
            {
                return NotFound();
            }

            db.Pro_Certificados.Remove(pro_Certificados);
            db.SaveChanges();

            return Ok(pro_Certificados);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Pro_CertificadosExists(double id)
        {
            return db.Pro_Certificados.Count(e => e.No == id) > 0;
        }
    }
}