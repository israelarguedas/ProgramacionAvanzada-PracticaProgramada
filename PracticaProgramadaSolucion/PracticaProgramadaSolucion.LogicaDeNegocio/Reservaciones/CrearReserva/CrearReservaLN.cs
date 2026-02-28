using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.General.Fechas;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using PracticaProgramadaSolucion.AccesoADatos.Reservaciones.CrearReserva;
using PracticaProgramadaSolucion.LogicaDeNegocio.General.Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Reservaciones.CrearReserva
{
    public class CrearReservaLN : ICrearReservaLN
    {
        ICrearReservaAD _crearReservaAD;
        IFechasLN _fechasLN;

        public CrearReservaLN()
        {
            _crearReservaAD = new CrearReservaAD();
            _fechasLN = new FechasLN();
        }
        public bool CrearReserva(int ID, ReservacionesDto reserva) 
        {
            reserva.FechaDeRegistro = _fechasLN.ObtenerFechaActual();
            int cantidadDeHabitacionesReservadas = _crearReservaAD.CrearReserva(ID, reserva);
            return cantidadDeHabitacionesReservadas > 0;
        }
    }
}
