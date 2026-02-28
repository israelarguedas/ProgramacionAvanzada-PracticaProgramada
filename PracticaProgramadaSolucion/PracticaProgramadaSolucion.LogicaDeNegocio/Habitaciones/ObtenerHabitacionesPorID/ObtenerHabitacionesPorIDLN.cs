using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.AccesoADatos.Habitaciones.ObtenerHabitacionesPorID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerHabitacionesPorID
{
    public class ObtenerHabitacionesPorIDLN : IObtenerHabitacionesPorIDLN
    {
        IObtenerHabitacionesPorIDAD _obtenerRepuestoPorIdAD;

        public ObtenerHabitacionesPorIDLN() {             
            _obtenerRepuestoPorIdAD = new ObtenerHabitacionesPorIDAD();
        }
        public HabitacionesDto Obtener(int id)
        {
            HabitacionesDto laHabitacion = _obtenerRepuestoPorIdAD.Obtener(id);
            return laHabitacion;
        }
    }
}
