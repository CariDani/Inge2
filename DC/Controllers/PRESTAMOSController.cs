using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DC.Models;

namespace DC.Controllers
{
    public class PRESTAMOSController : Controller
    {
        private Entities db = new Entities();

        // GET: PRESTAMOS
        public ActionResult Index()
        {
            return View(db.PRESTAMOS.ToList());
        }

        // GET: PRESTAMOS/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRESTAMOS pRESTAMOS = db.PRESTAMOS.Find(id);
            if (pRESTAMOS == null)
            {
                return HttpNotFound();
            }
            return View(pRESTAMOS);
        }

        // GET: PRESTAMOS/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PRESTAMOS/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_PRESTAMO,NUMERO_BOLETA,MOTIVO,FECHA_SOLICITUD,FECHA_RETIRO,PERIODO_USO,SOFTWARE_REQUERIDO,OBSERVACIONES_SOLICITANTE,OBSERVACIONES_APROBADO,OBSERVACIONES_RECIBIDO,CEDULA_USUARIO,SIGLA_CURSO")] PRESTAMOS pRESTAMOS)
        {
            if (ModelState.IsValid)
            {
                db.PRESTAMOS.Add(pRESTAMOS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pRESTAMOS);
        }

        // GET: PRESTAMOS/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRESTAMOS pRESTAMOS = db.PRESTAMOS.Find(id);
            if (pRESTAMOS == null)
            {
                return HttpNotFound();
            }
            return View(pRESTAMOS);
        }

        // POST: PRESTAMOS/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID_PRESTAMO,NUMERO_BOLETA,MOTIVO,FECHA_SOLICITUD,FECHA_RETIRO,PERIODO_USO,SOFTWARE_REQUERIDO,OBSERVACIONES_SOLICITANTE,OBSERVACIONES_APROBADO,OBSERVACIONES_RECIBIDO,CEDULA_USUARIO,SIGLA_CURSO")] PRESTAMOS pRESTAMOS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pRESTAMOS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pRESTAMOS);
        }

        // GET: PRESTAMOS/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PRESTAMOS pRESTAMOS = db.PRESTAMOS.Find(id);
            if (pRESTAMOS == null)
            {
                return HttpNotFound();
            }
            return View(pRESTAMOS);
        }

        // POST: PRESTAMOS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PRESTAMOS pRESTAMOS = db.PRESTAMOS.Find(id);
            db.PRESTAMOS.Remove(pRESTAMOS);
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
