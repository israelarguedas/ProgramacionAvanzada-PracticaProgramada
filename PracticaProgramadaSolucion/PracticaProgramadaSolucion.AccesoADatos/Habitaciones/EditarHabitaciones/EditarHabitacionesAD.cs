using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Habitaciones.EditarHabitaciones
{
    public class EditarHabitacionesAD : IEditarHabitacionesAD
    {
        Contexto _elContexto;
        public EditarHabitacionesAD()
        {
            _elContexto = new Contexto();
        }

        public int Editar(HabitacionesDto habitacionAEditar) 
        {
            HabitacionesEntidad habitacionesEnBD = _elContexto.Habitaciones.Where(habitacionBuscada => 
            habitacionBuscada.Id == habitacionAEditar.Id).FirstOrDefault();

            if (habitacionesEnBD != null) 
            {
                habitacionesEnBD.CantidadDeHuespedesPermitidos = habitacionAEditar.CantidadDeHuespedesPermitidos;
                habitacionesEnBD.CantidadDeCamas = habitacionAEditar.CantidadDeCamas;
                habitacionesEnBD.EncargadoDeLimpieza = habitacionAEditar.EncargadoDeLimpieza;
                habitacionesEnBD.TipoDeHabitacion = habitacionAEditar.TipoDeHabitacion;
                habitacionesEnBD.CostoDeLimpieza = habitacionAEditar.CostoDeLimpieza;
                habitacionesEnBD.CostoDeReserva = habitacionAEditar.CostoDeReserva;
                habitacionesEnBD.FechaDeModificacion = DateTime.Now;
                habitacionesEnBD.Estado = habitacionAEditar.Estado;
                return _elContexto.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}

