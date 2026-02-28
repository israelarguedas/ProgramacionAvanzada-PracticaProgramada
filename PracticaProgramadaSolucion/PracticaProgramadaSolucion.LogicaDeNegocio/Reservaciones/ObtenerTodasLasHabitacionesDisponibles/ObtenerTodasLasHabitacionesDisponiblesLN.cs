using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.AccesoADatos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Reservaciones.ObtenerTodasLasHabitacionesDisponibles
{
    public class ObtenerTodasLasHabitacionesDisponiblesLN : IObtenerTodasLasHabitacionesDisponiblesLN
    {
        IObtenerTodasLasHabitacionesDisponiblesAD _obtenerTodasLasHabitacionesDisponiblesAD;

        public ObtenerTodasLasHabitacionesDisponiblesLN()
        {
            _obtenerTodasLasHabitacionesDisponiblesAD = new ObtenerTodasLasHabitacionesDisponiblesAD();
        }

        public List<HabitacionesDto> ObtenerHabitacionesDisponibles()
        {

            List<HabitacionesDto> listaHabitacionesDisponibles = _obtenerTodasLasHabitacionesDisponiblesAD.ObtenerHabitacionesDisponibles();

            return listaHabitacionesDisponibles;
        }
    }
}
