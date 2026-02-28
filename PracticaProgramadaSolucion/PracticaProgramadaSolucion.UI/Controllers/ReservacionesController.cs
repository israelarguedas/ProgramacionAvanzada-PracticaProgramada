using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerHabitacionesPorID;
using PracticaProgramadaSolucion.LogicaDeNegocio.Reservaciones.BuscarReserva;
using PracticaProgramadaSolucion.LogicaDeNegocio.Reservaciones.CrearReserva;
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
        ICrearReservaLN _crearReserva;

        public ReservacionesController()
        {
            _obtenerTodasLasHabitacionesDisponiblesLN = new ObtenerTodasLasHabitacionesDisponiblesLN();
            _buscarReserva = new BuscarReservaLN();
            _obtenerHabitacionesPorID = new ObtenerHabitacionesPorIDLN();
            _crearReserva = new CrearReservaLN();
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

        // GET: Reservaciones/CrearReserva/5
        public ActionResult CrearReserva(int id)
        {
            // Create and pass a ReservacionesDto because the CrearReserva view is strongly typed to ReservacionesDto
            var nuevaReserva = new ReservacionesDto
            {
                IdHabitacion = id,
                FechaDeRegistro = DateTime.Now
                // set other defaults if desired
            };
            return View(nuevaReserva);
        }

        // POST: Reservaciones/CrearReserva
        [HttpPost]
        public ActionResult CrearReserva(int id, ReservacionesDto nuevaReserva)
        {
            try
            {
                bool seRegistro = _crearReserva.CrearReserva(id, nuevaReserva);

                if (seRegistro)
                {
                    return RedirectToAction("ObtenerTodasLasHabitacionesDisponibles");
                }
                else
                {
                    return View(nuevaReserva);
                }
            }
            catch
            {
                return View(nuevaReserva);
            }
        }
    }
}
