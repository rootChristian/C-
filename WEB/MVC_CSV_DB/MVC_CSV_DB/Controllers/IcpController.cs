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
    public class IcpController : Controller
    {
        private AnagraficaIcpContext db = new AnagraficaIcpContext();

        // GET: Icp
        public ActionResult Index()
        {
            return View(db.icp.ToList());
        }

        // GET: Icp/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Icp icp = db.icp.Find(id);
            if (icp == null)
            {
                return HttpNotFound();
            }
            return View(icp);
        }

        // GET: Icp/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Icp/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,IndirizzoRes,Tipologia,Ubicazione,Descrizione,DataInizioValidita,DataFineValidita,Esposizione,OrdLum,Categoria,Suolo,UnitaDiMisura,Lunghezza,Larghezza,Qta,Elementi,Facce,QtaTass,DataVariazione,OraVariazione,Utente,Tributo")] Icp icp)
        {
            if (ModelState.IsValid)
            {
                db.icp.Add(icp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(icp);
        }

        // GET: Icp/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Icp icp = db.icp.Find(id);
            if (icp == null)
            {
                return HttpNotFound();
            }
            return View(icp);
        }

        // POST: Icp/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,IndirizzoRes,Tipologia,Ubicazione,Descrizione,DataInizioValidita,DataFineValidita,Esposizione,OrdLum,Categoria,Suolo,UnitaDiMisura,Lunghezza,Larghezza,Qta,Elementi,Facce,QtaTass,DataVariazione,OraVariazione,Utente,Tributo")] Icp icp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(icp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(icp);
        }

        // GET: Icp/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Icp icp = db.icp.Find(id);
            if (icp == null)
            {
                return HttpNotFound();
            }
            return View(icp);
        }

        // POST: Icp/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Icp icp = db.icp.Find(id);
            db.icp.Remove(icp);
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
