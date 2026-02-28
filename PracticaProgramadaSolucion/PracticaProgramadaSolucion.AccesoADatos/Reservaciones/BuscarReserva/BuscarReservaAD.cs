using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Reservaciones.BuscarReserva
{
    public class BuscarReservaAD : IBuscarReservaAD
    {
        Contexto _elContexto;
        public BuscarReservaAD()
        {
            _elContexto = new Contexto();
        }

        public ReservacionesDto BuscarReserva(int Id)
        {
            ReservacionesDto ReservaExistente = (from ReservasEnBD
                                               in _elContexto.Reservaciones
                                                 where ReservasEnBD.Id == Id
                                                 select new ReservacionesDto
                                                 {
                                                     Id = ReservasEnBD.Id,
                                                     NombreDeLaPersona = ReservasEnBD.NombreDeLaPersona,
                                                     Identificacion = ReservasEnBD.Identificacion,
                                                     Telefono = ReservasEnBD.Telefono,
                                                     Correo = ReservasEnBD.Correo,
                                                     FechaNacimiento = ReservasEnBD.FechaNacimiento,
                                                     Direccion = ReservasEnBD.Direccion,
                                                     MontoTotal = ReservasEnBD.MontoTotal,
                                                     FechaInicioReserva = ReservasEnBD.FechaInicioReserva,
                                                     FechaFinReserva = ReservasEnBD.FechaFinReserva,
                                                     FechaDeRegistro = ReservasEnBD.FechaDeRegistro,
                                                     IdHabitacion = ReservasEnBD.IdHabitacion
                                                 }).FirstOrDefault();
            return ReservaExistente;

        }
    }
}
