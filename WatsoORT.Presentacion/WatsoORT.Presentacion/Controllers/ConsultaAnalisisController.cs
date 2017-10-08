using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WatsonORT.Datos;
using WatsonORT.Dominio.Clases;

namespace WatsonORT.Presentacion.Controllers
{
    public class ConsultaAnalisisController : Controller
    {
        private WatsonORTDbContext db = new WatsonORTDbContext();

        // GET: ConsultaAnalisis
        public ActionResult Index()
        {
            return View(db.ConsultasAnalisis.ToList());
        }

        // GET: ConsultaAnalisis/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultaAnalisis consultaAnalisis = db.ConsultasAnalisis.Find(id);
            if (consultaAnalisis == null)
            {
                return HttpNotFound();
            }
            return View(consultaAnalisis);
        }

        // GET: ConsultaAnalisis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsultaAnalisis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Nombre,Texto,CodigoConsulta")] ConsultaAnalisis consultaAnalisis)
        {
            if (ModelState.IsValid)
            {
                db.ConsultasAnalisis.Add(consultaAnalisis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(consultaAnalisis);
        }

        // GET: ConsultaAnalisis/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultaAnalisis consultaAnalisis = db.ConsultasAnalisis.Find(id);
            if (consultaAnalisis == null)
            {
                return HttpNotFound();
            }
            return View(consultaAnalisis);
        }

        // POST: ConsultaAnalisis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Email,Nombre,Texto,CodigoConsulta")] ConsultaAnalisis consultaAnalisis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(consultaAnalisis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(consultaAnalisis);
        }

        // GET: ConsultaAnalisis/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ConsultaAnalisis consultaAnalisis = db.ConsultasAnalisis.Find(id);
            if (consultaAnalisis == null)
            {
                return HttpNotFound();
            }
            return View(consultaAnalisis);
        }

        // POST: ConsultaAnalisis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ConsultaAnalisis consultaAnalisis = db.ConsultasAnalisis.Find(id);
            db.ConsultasAnalisis.Remove(consultaAnalisis);
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
