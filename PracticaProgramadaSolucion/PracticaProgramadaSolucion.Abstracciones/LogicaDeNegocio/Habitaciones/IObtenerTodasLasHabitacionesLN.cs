using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones
{
    public interface IObtenerTodasLasHabitacionesLN
    {
        List<HabitacionesDto> Obtener();
    }
}
