using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestaoDeSalas.Models.Autenticacao.AutenticacaoPlataforma;
using GestaoDeSalas.Models.BancoDeDados;
using GestaoDeSalas.Models.Sala;

namespace GestaoDeSalas.Controllers.Plataforma
{
    [AuthorizeFuncionario]
    public class SalasAgendadasController : Controller
    {
        private BancoDBContext db = new BancoDBContext();

        // GET: SalasAgendadas
        public ActionResult Index()
        {
            var salasAgendadas = db.SalasAgendadas.Include(s => s.Salas);
            return View(salasAgendadas.ToList());
        }

        // GET: SalasAgendadas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalasAgendadas salasAgendadas = db.SalasAgendadas.Find(id);
            if (salasAgendadas == null)
            {
                return HttpNotFound();
            }
            return View(salasAgendadas);
        }

        // GET: SalasAgendadas/Create
        public ActionResult Create()
        {
            ViewBag.SalasId = new SelectList(db.Salas, "SalasId", "NomeSala");
            return View();
        }

        // POST: SalasAgendadas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SalasAgendadasId,SalasId,Titulo,DataInicio,DataFim")] SalasAgendadas salasAgendadas)
        {
            if (ModelState.IsValid)
            {
                db.SalasAgendadas.Add(salasAgendadas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SalasId = new SelectList(db.Salas, "SalasId", "NomeSala", salasAgendadas.SalasId);
            return View(salasAgendadas);
        }

        // GET: SalasAgendadas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalasAgendadas salasAgendadas = db.SalasAgendadas.Find(id);
            if (salasAgendadas == null)
            {
                return HttpNotFound();
            }
            ViewBag.SalasId = new SelectList(db.Salas, "SalasId", "NomeSala", salasAgendadas.SalasId);
            return View(salasAgendadas);
        }

        // POST: SalasAgendadas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SalasAgendadasId,SalasId,Titulo,DataInicio,DataFim")] SalasAgendadas salasAgendadas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salasAgendadas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SalasId = new SelectList(db.Salas, "SalasId", "NomeSala", salasAgendadas.SalasId);
            return View(salasAgendadas);
        }

        // GET: SalasAgendadas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SalasAgendadas salasAgendadas = db.SalasAgendadas.Find(id);
            if (salasAgendadas == null)
            {
                return HttpNotFound();
            }
            return View(salasAgendadas);
        }

        // POST: SalasAgendadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SalasAgendadas salasAgendadas = db.SalasAgendadas.Find(id);
            db.SalasAgendadas.Remove(salasAgendadas);
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
