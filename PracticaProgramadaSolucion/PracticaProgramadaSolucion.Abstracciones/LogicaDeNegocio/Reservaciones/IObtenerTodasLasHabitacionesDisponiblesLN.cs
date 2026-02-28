using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Reservaciones
{
    public interface IObtenerTodasLasHabitacionesDisponiblesLN
    {
        List<HabitacionesDto> ObtenerHabitacionesDisponibles();
    }
}
