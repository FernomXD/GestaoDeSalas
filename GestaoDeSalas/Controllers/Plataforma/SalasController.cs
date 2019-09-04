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
    public class SalasController : Controller
    {
        private BancoDBContext db = new BancoDBContext();

        // GET: Salas
        public ActionResult Index()
        {
            return View(db.Salas.ToList());
        }

        // GET: Salas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return HttpNotFound();
            }
            return View(salas);
        }

        // GET: Salas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salas/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NomeSala,DescricaoSala")] Salas salas)
        {
            if (ModelState.IsValid)
            {
                db.Salas.Add(salas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(salas);
        }

        // GET: Salas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return HttpNotFound();
            }
            return View(salas);
        }

        // POST: Salas/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NomeSala,DescricaoSala")] Salas salas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(salas);
        }

        // GET: Salas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salas salas = db.Salas.Find(id);
            if (salas == null)
            {
                return HttpNotFound();
            }
            return View(salas);
        }

        // POST: Salas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Salas salas = db.Salas.Find(id);
            db.Salas.Remove(salas);
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
