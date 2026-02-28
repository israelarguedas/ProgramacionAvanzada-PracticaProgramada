using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.EditarHabitaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerHabitacionesPorID;
using PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerHistorialDeReservas;
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
        IObtenerHabitacionesPorIDLN _obtenerHabitacionesPorID;
        IObtenerHistorialDeReservasLN _obtenerHistorialDeReservas;

        public HabitacionesController()
        {
            _obtenerTodasLasHabitaciones = new ObtenerTodasLasHabitacionesLN();
            _registrarHabitaciones = new RegistrarHabitacionesLN();
            _editarHabitaciones = new EditarHabitacionesLN();
            _obtenerHabitacionesPorID = new ObtenerHabitacionesPorIDLN();
            _obtenerHistorialDeReservas = new ObtenerHistorialDeReservasLN();
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
                bool seRegistro = _registrarHabitaciones.Registrar(laHabitacionARegistrar);

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
            HabitacionesDto laHabitacionAEditar = _obtenerHabitacionesPorID.Obtener(id);
            return View(laHabitacionAEditar);
        }

        // POST: Habitaciones/Edit/5
        [HttpPost]
        public ActionResult EditarHabitaciones(int id, HabitacionesDto laHabitacionAEditar)
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

        // GET: ReservaAdministrativa
        public ActionResult ObtenerHistorialDeReservas(int id)
        {
            List<ReservacionesDto> listaReservaciones = _obtenerHistorialDeReservas.Obtener(id);
            return View(listaReservaciones);
        }
    }
}
