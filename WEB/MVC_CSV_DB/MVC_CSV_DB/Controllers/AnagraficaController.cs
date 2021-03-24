using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_CSV_DB.DAL;
using MVC_CSV_DB.Models;

namespace MVC_CSV_DB.Controllers
{
    public class AnagraficaController : Controller
    {
        private AnagraficaIcpContext db = new AnagraficaIcpContext();

        // GET: Anagrafica
        public ActionResult Index()
        {
            return View(db.anagrafica.ToList());
        }

        // GET: Anagrafica/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.anagrafica.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // GET: Anagrafica/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anagrafica/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CF,PIVA,DENOMINAZIONE,MAIL")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                db.anagrafica.Add(anagrafica);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anagrafica);
        }

        // GET: Anagrafica/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.anagrafica.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // POST: Anagrafica/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CF,PIVA,DENOMINAZIONE,MAIL")] Anagrafica anagrafica)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anagrafica).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anagrafica);
        }

        // GET: Anagrafica/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anagrafica anagrafica = db.anagrafica.Find(id);
            if (anagrafica == null)
            {
                return HttpNotFound();
            }
            return View(anagrafica);
        }

        // POST: Anagrafica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Anagrafica anagrafica = db.anagrafica.Find(id);
            db.anagrafica.Remove(anagrafica);
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
