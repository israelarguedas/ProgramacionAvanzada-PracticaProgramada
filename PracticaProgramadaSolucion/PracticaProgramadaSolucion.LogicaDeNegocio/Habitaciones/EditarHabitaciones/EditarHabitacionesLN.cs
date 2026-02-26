using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.General.Fechas;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.AccesoADatos.Habitaciones.EditarHabitaciones;
using PracticaProgramadaSolucion.LogicaDeNegocio.General.Fechas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.EditarHabitaciones
{
    public class EditarHabitacionesLN : IEditarHabitacionesLN
    {
        IEditarHabitacionesAD _editarHabitaciones;
        IFechasLN _fechasLN;

        public EditarHabitacionesLN()
        {
            _editarHabitaciones = new EditarHabitacionesAD();
            _fechasLN = new FechasLN();
        }
        public bool Editar(HabitacionesDto HabitacionAEditar) {
            HabitacionAEditar.FechaDeModificacion = _fechasLN.ObtenerFechaActual();
            int cantidadDeRegistrosAfectados = _editarHabitaciones.Editar(HabitacionAEditar);
            return cantidadDeRegistrosAfectados > 0;
        }
    }
}
