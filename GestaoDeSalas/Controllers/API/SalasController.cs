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
using GestaoDeSalas.Models.BancoDeDados;
using GestaoDeSalas.Models.Sala;

namespace GestaoDeSalas.Controllers.API
{
    [Authorize]
    public class SalasController : ApiController
    {
        private BancoDBContext db = new BancoDBContext();

        // GET: api/Salas
        public IQueryable<Salas> GetSalas()
        {
            return db.Salas;
        }

        // GET: api/Salas/5
        [ResponseType(typeof(Salas))]
        public IHttpActionResult GetSalas(int id)
        {
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return NotFound();
            }

            return Ok(salas);
        }

        // PUT: api/Salas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSalas(int id, Salas salas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != salas.SalasId)
            {
                return BadRequest();
            }

            db.Entry(salas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalasExists(id))
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

        // POST: api/Salas
        [ResponseType(typeof(Salas))]
        public IHttpActionResult PostSalas(Salas salas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Salas.Add(salas);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = salas.SalasId }, salas);
        }

        // DELETE: api/Salas/5
        [ResponseType(typeof(Salas))]
        public IHttpActionResult DeleteSalas(int id)
        {
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return NotFound();
            }

            db.Salas.Remove(salas);
            db.SaveChanges();

            return Ok(salas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SalasExists(int id)
        {
            return db.Salas.Count(e => e.SalasId == id) > 0;
        }
    }
}