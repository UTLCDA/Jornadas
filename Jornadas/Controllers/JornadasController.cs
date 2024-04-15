using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Jornadas.Models;

namespace Jornadas.Controllers
{
    public class JornadasController : Controller
    {
        private ApuestasEntities db = new ApuestasEntities();

        // GET: Jornadas
        public ActionResult Index()
        {
            return View(db.Jornada.ToList());
        }

        // GET: Jornadas/Index
        public ActionResult Index(DateTime? startDate, DateTime? endDate)
        {
            // Filtrar las jornadas por fecha si las fechas de inicio y fin están especificadas
            IQueryable<Jornada> jornadasQuery = db.Jornada;

            if (startDate.HasValue && endDate.HasValue)
            {
                jornadasQuery = jornadasQuery.Where(j => j.Fecha >= startDate && j.Fecha <= endDate);
            }

            // Convertir el IQueryable a una lista y pasarla a la vista
            List<Jornada> jornadas = jornadasQuery.ToList();
            return View(jornadas);
        }

        // GET: Jornadas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jornada jornada = db.Jornada.Find(id);
            if (jornada == null)
            {
                return HttpNotFound();
            }
            return View(jornada);
        }

        // GET: Jornadas/Create
        public ActionResult Create()
        {
            var listaDeLigas = db.Liga.ToList();
            ViewBag.Ligas = new SelectList(listaDeLigas, "Id", "Nombre");
            return View();
        }

        // POST: Jornadas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,IdLiga,jornada1,equipoLocal,equipoVisitante,Fecha,Hora,Resultado,Empate,Colocada,LineaDinero,Momio,Ganancia,GananciaTotal")] Jornada jornada)
        {
            if (ModelState.IsValid)
            {
                db.Jornada.Add(jornada);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(jornada);
        }

        // GET: Jornadas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jornada jornada = db.Jornada.Find(id);
            if (jornada == null)
            {
                return HttpNotFound();
            }
            return View(jornada);
        }

        // POST: Jornadas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,IdLiga,jornada1,equipoLocal,equipoVisitante,Fecha,Hora,Resultado,Empate,Colocada,LineaDinero,Momio,Ganancia,GananciaTotal")] Jornada jornada)
        {
            if (ModelState.IsValid)
            {
                db.Entry(jornada).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(jornada);
        }

        // GET: Jornadas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Jornada jornada = db.Jornada.Find(id);
            if (jornada == null)
            {
                return HttpNotFound();
            }
            return View(jornada);
        }

        // POST: Jornadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Jornada jornada = db.Jornada.Find(id);
            db.Jornada.Remove(jornada);
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
