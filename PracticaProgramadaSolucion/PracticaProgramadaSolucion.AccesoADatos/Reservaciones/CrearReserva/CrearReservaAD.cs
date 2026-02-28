using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using PracticaProgramadaSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Reservaciones.CrearReserva
{
    public class CrearReservaAD : ICrearReservaAD
    {
        Contexto _elContexto;
        public CrearReservaAD()
        {
            _elContexto = new Contexto();
        }

        public HabitacionesDto obtenerHabitacion(int ID)
        {
            HabitacionesDto laHabitacionEnBD = (from laHabitacion in _elContexto.Habitaciones
                                                where laHabitacion.Id == ID
                                                select new HabitacionesDto
                                                {
                                                    Id = laHabitacion.Id,
                                                    CostoDeLimpieza = laHabitacion.CostoDeLimpieza,
                                                    CostoDeReserva = laHabitacion.CostoDeReserva,
                                                    Estado = laHabitacion.Estado
                                                }).FirstOrDefault();
            return laHabitacionEnBD;
        }
        public int CrearReserva(int ID, ReservacionesDto nuevaReserva) { 
            ReservacionesEntidad reservaAGuardar = ConvertirDTOaEntidad(ID, nuevaReserva);
            _elContexto.Reservaciones.Add(reservaAGuardar);
            int cantidadDeRegistrosAlmacenados = _elContexto.SaveChanges();

            if (cantidadDeRegistrosAlmacenados > 0)
            {
                HabitacionesEntidad habitacionAActualizar = _elContexto.Habitaciones.FirstOrDefault(habitacion => habitacion.Id == ID);
                if (habitacionAActualizar != null)
                {
                    habitacionAActualizar.Estado = false;
                    _elContexto.SaveChanges();
                }
            }

            return cantidadDeRegistrosAlmacenados;
        }

        private ReservacionesEntidad ConvertirDTOaEntidad(int ID, ReservacionesDto reserva)
        {
            HabitacionesDto Habitacion = obtenerHabitacion(ID);
            decimal TotalReservacion = (Habitacion.CostoDeReserva * (decimal)(reserva.FechaFinReserva - reserva.FechaInicioReserva).TotalDays) + Habitacion.CostoDeLimpieza;

            return new ReservacionesEntidad
            {
                NombreDeLaPersona = reserva.NombreDeLaPersona,
                Identificacion = reserva.Identificacion,
                Telefono = reserva.Telefono,
                Correo = reserva.Correo,
                FechaNacimiento = reserva.FechaNacimiento,
                Direccion = reserva.Direccion,
                MontoTotal = TotalReservacion,
                FechaInicioReserva = reserva.FechaInicioReserva,
                FechaFinReserva = reserva.FechaFinReserva,
                FechaDeRegistro = reserva.FechaDeRegistro,
                IdHabitacion = ID
            };
        }
    }
}
