using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaProgramadaSolucion.UI.Controllers
{
    public class ReservacionesController : Controller
    {
        // GET: Reservaciones
        public ActionResult Index()
        {
            return View();
        }

        // GET: Reservaciones/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservaciones/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservaciones/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservaciones/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservaciones/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservaciones/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservaciones/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
