using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.RegistrarHabitaciones
{
    public class RegistrarHabitacionesLN : IRegistrarHabitacionesLN
    {
        public bool Agregar(HabitacionesDto laHabitacionARegitrar) { 
            return true;
        }
    }
}
