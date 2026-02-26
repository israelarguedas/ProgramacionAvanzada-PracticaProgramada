using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.AccesoADatos.Habitaciones.ObtenerTodasLasHabitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerTodasLasHabitaciones
{
    public class ObtenerTodasLasHabitacionesLN : IObtenerTodasLasHabitacionesLN
    {
        IObtenerTodasLasHabitacionesAD _obtenerTodasLasHabitaciones;
        public ObtenerTodasLasHabitacionesLN()
        {
            _obtenerTodasLasHabitaciones = new ObtenerTodasLasHabitacionesAD();
        }
        public List<HabitacionesDto> Obtener() {

            List<HabitacionesDto> listaHabitaciones = _obtenerTodasLasHabitaciones.Obtener();
            listaHabitaciones = listaHabitaciones.OrderBy(habitacion => habitacion.NombreDeHabitacion).ToList();

            return listaHabitaciones;
        }
    }
}
