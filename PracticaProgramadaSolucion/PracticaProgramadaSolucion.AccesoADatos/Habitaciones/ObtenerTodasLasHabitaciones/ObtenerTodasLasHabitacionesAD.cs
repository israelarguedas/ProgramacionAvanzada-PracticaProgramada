using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Habitaciones.ObtenerTodasLasHabitaciones
{
    public class ObtenerTodasLasHabitacionesAD : IObtenerTodasLasHabitacionesAD
    {
        Contexto _elContexto;
        public ObtenerTodasLasHabitacionesAD()
        {
            _elContexto = new Contexto();
        }

        public List<HabitacionesDto> Obtener() 
        { 
            List<HabitacionesDto> listaHabitaciones = (from habitacionesEnBD
                                                       in _elContexto.Habitaciones
                                                       select new HabitacionesDto
                                                       {
                                                           CodigoDeHabitacion = habitacionesEnBD.CodigoDeHabitacion,
                                                           NombreDeHabitacion = habitacionesEnBD.NombreDeHabitacion,
                                                           Ubicacion = habitacionesEnBD.Ubicacion,
                                                           CantidadDeHuespedesPermitidos = habitacionesEnBD.CantidadDeHuespedesPermitidos,
                                                           CantidadDeCamas = habitacionesEnBD.CantidadDeCamas,
                                                           CantidadDeBanos = habitacionesEnBD.CantidadDeBanos,
                                                           EncargadoDeLimpieza = habitacionesEnBD.EncargadoDeLimpieza,
                                                           CostoDeLimpieza = habitacionesEnBD.CostoDeLimpieza,
                                                           CostoDeReserva = habitacionesEnBD.CostoDeReserva,
                                                           TipoDeHabitacion = habitacionesEnBD.TipoDeHabitacion,
                                                           Estado = habitacionesEnBD.Estado
                                                       }).ToList();
            return listaHabitaciones;
        }    
    }
}
