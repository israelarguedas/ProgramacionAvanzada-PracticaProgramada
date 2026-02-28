using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Habitaciones.ObtenerHistorialDeReservas
{
    public class ObtenerHistorialDeReservasAD : IObtenerHistorialDeReservasAD
    {
        Contexto _elContexto;

        public ObtenerHistorialDeReservasAD()
        {
            _elContexto = new Contexto();
        }

        public List<ReservacionesDto> Obtener(int idHabitacion)
        {
            List<ReservacionesDto> listaHistorialDeReservas = (from laReserva in _elContexto.Reservaciones
                                                               where laReserva.IdHabitacion == idHabitacion
                                                               select new ReservacionesDto
                                                               {
                                                                   Id = laReserva.Id,
                                                                   IdHabitacion = laReserva.IdHabitacion,
                                                                   NombreDeLaPersona = laReserva.NombreDeLaPersona,
                                                                   Identificacion = laReserva.Identificacion,
                                                                   Telefono = laReserva.Telefono,
                                                                   Correo = laReserva.Correo,
                                                                   FechaNacimiento = laReserva.FechaNacimiento,
                                                                   Direccion = laReserva.Direccion,
                                                                   MontoTotal = laReserva.MontoTotal,
                                                                   FechaInicioReserva = laReserva.FechaInicioReserva,
                                                                   FechaFinReserva = laReserva.FechaFinReserva,
                                                                   FechaDeRegistro = laReserva.FechaDeRegistro
                                                               }).ToList();
            return listaHistorialDeReservas;
        }
    }
}
