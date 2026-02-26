using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.EditarHabitaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerTodasLasHabitaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.RegistrarHabitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaProgramadaSolucion.UI.Controllers
{
    public class HabitacionesController : Controller
    {
        IObtenerTodasLasHabitacionesLN _obtenerTodasLasHabitaciones;
        IRegistrarHabitacionesLN _registrarHabitaciones;
        IEditarHabitacionesLN _editarHabitaciones;

        public HabitacionesController()
        {
            _obtenerTodasLasHabitaciones = new ObtenerTodasLasHabitacionesLN();
            _registrarHabitaciones = new RegistrarHabitacionesLN();
            _editarHabitaciones = new EditarHabitacionesLN();
        }

        // GET: Habitaciones
        public ActionResult ObtenerTodasLasHabitaciones()
        {
            List<HabitacionesDto> listaHabitaciones = _obtenerTodasLasHabitaciones.Obtener();

            return View(listaHabitaciones);
        }


        // GET: Habitaciones/Create
        public ActionResult RegistrarHabitaciones()
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }

        // POST: Habitaciones/Create
        [HttpPost]
        public ActionResult RegistrarHabitaciones(HabitacionesDto laHabitacionARegistrar)
        {
            try
            {
                bool seRegistro = _registrarHabitaciones.Agregar(laHabitacionARegistrar);

                if (seRegistro)
                {
                    return RedirectToAction("ObtenerTodasLasHabitaciones");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Habitaciones/Edit/5
        public ActionResult EditarHabitaciones(int id)
        {
            try
            {
                return View();
            }
            catch
            {
                return View();
            }
        }

        // POST: Habitaciones/Edit/5
        [HttpPost]
        public ActionResult EditarHabitaciones(HabitacionesDto laHabitacionAEditar)
        {
            try
            {
                bool seEdito = _editarHabitaciones.Editar(laHabitacionAEditar);

                if (seEdito)
                {
                    return RedirectToAction("ObtenerTodasLasHabitaciones");
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View();
            }
        }
    }
}
