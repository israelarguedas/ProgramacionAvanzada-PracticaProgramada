using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones
{
    public interface IObtenerHabitacionesPorIDAD
    {
        HabitacionesDto Obtener(int id);
    }
}
