using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PostoDeAssistenciaWeb.Models;
using PostoDeAssistenciaWeb.Models.Context;

namespace PostoDeAssistenciaWeb.Controllers
{
    public class AssistidoController : Controller
    {
        private Contexto db = new Contexto();

        // GET: Assistido
        public ActionResult Index()
        {
            return View(db.Assistidos.ToList());
        }

        // GET: Assistido/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assistido assistido = db.Assistidos.Find(id);
            if (assistido == null)
            {
                return HttpNotFound();
            }
            return View(assistido);
        }

        // GET: Assistido/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assistido/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AssistidoId,NomeCompleto,Sexo,Idade,DataNascimento,GrauParentesco,Telefone1,Telefone2,NumeracaoCalcado,NumeracaoRoupaSuperior,NumeracaoRoupaInferior,Observacao,Principal,DependenteId")] Assistido assistido)
        {
            if (ModelState.IsValid)
            {
                assistido.AssistidoId = Guid.NewGuid();
                db.Assistidos.Add(assistido);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(assistido);
        }

        // GET: Assistido/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assistido assistido = db.Assistidos.Find(id);
            if (assistido == null)
            {
                return HttpNotFound();
            }
            return View(assistido);
        }

        // POST: Assistido/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AssistidoId,NomeCompleto,Sexo,Idade,DataNascimento,GrauParentesco,Telefone1,Telefone2,NumeracaoCalcado,NumeracaoRoupaSuperior,NumeracaoRoupaInferior,Observacao,Principal,DependenteId")] Assistido assistido)
        {
            if (ModelState.IsValid)
            {
                db.Entry(assistido).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(assistido);
        }

        // GET: Assistido/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Assistido assistido = db.Assistidos.Find(id);
            if (assistido == null)
            {
                return HttpNotFound();
            }
            return View(assistido);
        }

        // POST: Assistido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Assistido assistido = db.Assistidos.Find(id);
            db.Assistidos.Remove(assistido);
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
