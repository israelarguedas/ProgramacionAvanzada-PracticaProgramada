using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaProgramadaSolucion.UI.Controllers
{
    public class HabitacionesController : Controller
    {
        
        // GET: Habitaciones
        public ActionResult ObtenerTodasLasHabitaciones()
        {
            List<HabitacionesDto> listaHabitaciones = new List<HabitacionesDto>();
            listaHabitaciones.Add(new HabitacionesDto
            {
                Id = 1,
                CodigoDeHabitacion = "HAB001",
                NombreDeHabitacion = "Habitación Deluxe",
                CantidadDeHuespedesPermitidos = 2,
                CantidadDeCamas = 1,
                CantidadDeBanos = 1,
                Ubicacion = "Piso 3",
                EncargadoDeLimpieza = "Juan Pérez",
                TipoDeHabitacion = 1,
                CostoDeLimpieza = 50.00m,
                CostoDeReserva = 200.00m,
                FechaDeRegistro = DateTime.Now,
                Estado = true
            }); 

            return View(listaHabitaciones);
        }


        // GET: Habitaciones/Create
        public ActionResult RegistrarHabitaciones()
        {
            return View();
        }

        // POST: Habitaciones/Create
        [HttpPost]
        public ActionResult RegistrarHabitaciones(FormCollection collection)
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

        // GET: Habitaciones/Edit/5
        public ActionResult EditarHabitaciones(int id)
        {
            return View();
        }

        // POST: Habitaciones/Edit/5
        [HttpPost]
        public ActionResult EditarHabitaciones(int id, FormCollection collection)
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
    }
}
