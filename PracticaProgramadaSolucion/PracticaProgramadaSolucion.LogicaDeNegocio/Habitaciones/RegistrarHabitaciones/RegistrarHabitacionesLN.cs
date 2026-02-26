using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.General.Fechas;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.AccesoADatos.Habitaciones.RegistrarHabitaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.General.Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.RegistrarHabitaciones
{
    public class RegistrarHabitacionesLN : IRegistrarHabitacionesLN
    {
        IRegistrarHabitacionesAD _registrarHabitaciones;
        IFechasLN _fechas;

        public RegistrarHabitacionesLN()
        {
            _registrarHabitaciones = new RegistrarHabitacionesAD();
            _fechas = new FechasLN();
        }
        public bool Registrar(HabitacionesDto laHabitacionARegistrar) {
            laHabitacionARegistrar.Estado = true;
            laHabitacionARegistrar.FechaDeRegistro = _fechas.ObtenerFechaActual();
            int cantidadDeHabitacionesReservadas = _registrarHabitaciones.Registrar(laHabitacionARegistrar);
            return cantidadDeHabitacionesReservadas > 0;
        }
    }
}
