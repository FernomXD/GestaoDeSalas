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
    public class SalasAgendadasController : ApiController
    {
        private BancoDBContext db = new BancoDBContext();

        // GET: api/SalasAgendadas
        public IQueryable<SalasAgendadas> GetSalasAgendadas()
        {
            return db.SalasAgendadas.OrderBy(i => i.DataInicio).ThenBy(i => i.Salas.NomeSala);
        }

        // GET: api/SalasAgendadas/5
        [ResponseType(typeof(SalasAgendadas))]
        public IHttpActionResult GetSalasAgendadas(int id)
        {
            SalasAgendadas salasAgendadas = db.SalasAgendadas.Find(id);
            if (salasAgendadas == null)
            {
                return NotFound();
            }

            return Ok(salasAgendadas);
        }

        // PUT: api/SalasAgendadas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSalasAgendadas(int id, SalasAgendadas salasAgendadas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != salasAgendadas.SalasAgendadasId)
            {
                return BadRequest();
            }

            db.Entry(salasAgendadas).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalasAgendadasExists(id))
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

        // POST: api/SalasAgendadas
        [ResponseType(typeof(SalasAgendadas))]
        public IHttpActionResult PostSalasAgendadas(SalasAgendadas salasAgendadas)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if(salasAgendadas.DataInicio > salasAgendadas.DataFim)
                return Content(HttpStatusCode.BadRequest, "Ocorreu um erro ao reservar sua sala. O horário final deve ser maior que o inicial.");

            if (salasAgendadas.VerificaDisponibilidade())
            {
                db.SalasAgendadas.Add(salasAgendadas);
                db.SaveChanges();

                salasAgendadas.Salas = db.Salas.Find(salasAgendadas.SalasId);

                return CreatedAtRoute("DefaultApi", new { id = salasAgendadas.SalasAgendadasId }, salasAgendadas);
            }
            else
                return Content(HttpStatusCode.BadRequest, "Ocorreu um erro ao reservar sua sala. Já existe um agendamento para essa sala neste horários.");
        }

        // DELETE: api/SalasAgendadas/5
        [ResponseType(typeof(SalasAgendadas))]
        public IHttpActionResult DeleteSalasAgendadas(int id)
        {
            SalasAgendadas salasAgendadas = db.SalasAgendadas.Find(id);
            if (salasAgendadas == null)
            {
                return NotFound();
            }

            db.SalasAgendadas.Remove(salasAgendadas);
            db.SaveChanges();

            return Ok(salasAgendadas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SalasAgendadasExists(int id)
        {
            return db.SalasAgendadas.Count(e => e.SalasAgendadasId == id) > 0;
        }
    }
}