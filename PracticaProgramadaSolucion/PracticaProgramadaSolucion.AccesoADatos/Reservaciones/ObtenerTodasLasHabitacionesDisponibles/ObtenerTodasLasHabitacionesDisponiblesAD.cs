using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Reservaciones
{
    public class ObtenerTodasLasHabitacionesDisponiblesAD : IObtenerTodasLasHabitacionesDisponiblesAD
    {
        Contexto _elContexto;
        public ObtenerTodasLasHabitacionesDisponiblesAD()
        {
            _elContexto = new Contexto();
        }

        public List<HabitacionesDto> ObtenerHabitacionesDisponibles() {
            List<HabitacionesDto> listaHabitaciones = (from habitacionesEnBD
                                                       in _elContexto.Habitaciones
                                                       where habitacionesEnBD.Estado == true
                                                       select new HabitacionesDto
                                                       {
                                                           Id = habitacionesEnBD.Id,
                                                           NombreDeHabitacion = habitacionesEnBD.NombreDeHabitacion,
                                                           CantidadDeHuespedesPermitidos = habitacionesEnBD.CantidadDeHuespedesPermitidos,
                                                           CantidadDeCamas = habitacionesEnBD.CantidadDeCamas,
                                                           CantidadDeBanos = habitacionesEnBD.CantidadDeBanos,
                                                           Ubicacion = habitacionesEnBD.Ubicacion,
                                                           CostoDeReserva = habitacionesEnBD.CostoDeReserva,
                                                           TipoDeHabitacion = habitacionesEnBD.TipoDeHabitacion,
                                                           Estado = habitacionesEnBD.Estado
                                                       }).ToList();
            return listaHabitaciones;
        }
    }
}
