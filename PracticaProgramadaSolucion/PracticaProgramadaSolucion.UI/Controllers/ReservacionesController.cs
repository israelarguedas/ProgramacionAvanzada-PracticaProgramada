using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerHabitacionesPorID;
using PracticaProgramadaSolucion.LogicaDeNegocio.Reservaciones.BuscarReserva;
using PracticaProgramadaSolucion.LogicaDeNegocio.Reservaciones.ObtenerTodasLasHabitacionesDisponibles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticaProgramadaSolucion.UI.Controllers
{
    public class ReservacionesController : Controller
    {
        IObtenerTodasLasHabitacionesDisponiblesLN _obtenerTodasLasHabitacionesDisponiblesLN;
        IBuscarReservaLN _buscarReserva;
        IObtenerHabitacionesPorIDLN _obtenerHabitacionesPorID;

        public ReservacionesController()
        {
            _obtenerTodasLasHabitacionesDisponiblesLN = new ObtenerTodasLasHabitacionesDisponiblesLN();
            _buscarReserva = new BuscarReservaLN();
            _obtenerHabitacionesPorID = new ObtenerHabitacionesPorIDLN();
        }


        // GET: Reservaciones/ObtenerTodasLasHabitacionesDisponibles
        public ActionResult ObtenerTodasLasHabitacionesDisponibles()
        {
            List<HabitacionesDto> listaHabitacionesDisponibles = _obtenerTodasLasHabitacionesDisponiblesLN.ObtenerHabitacionesDisponibles();

            return View(listaHabitacionesDisponibles);
        }

        // GET: Reservaciones/BuscarReserva/5
        public ActionResult BuscarReserva(int id)
        {
            ReservacionesDto ReservaExistente = _buscarReserva.BuscarReserva(id);
            return View(ReservaExistente);
        }

        // GET: Reservaciones/CrearReserva
        public ActionResult CrearReserva(int id)
        {
            HabitacionesDto laHabitacionAReservar = _obtenerHabitacionesPorID.Obtener(id);
            return View(laHabitacionAReservar);
        }

        // POST: Reservaciones/CrearReserva
        [HttpPost]
        public ActionResult CrearReserva(int id, ReservacionesDto nuevaReserva)
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
    }
}
