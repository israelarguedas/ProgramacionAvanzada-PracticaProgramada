using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using PracticaProgramadaSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Habitaciones.RegistrarHabitaciones
{
    public class RegistrarHabitacionesAD : IRegistrarHabitacionesAD
    {
        Contexto _elContexto;

        public RegistrarHabitacionesAD()
        {
            _elContexto = new Contexto();
        }

        public int Registrar(HabitacionesDto habitacion)
        {
            HabitacionesEntidad habitacionAGuardar = ConvertirDTOaEntidad(habitacion);
            _elContexto.Habitaciones.Add(habitacionAGuardar);
            int cantidadDeRegistrosAlmacenados = _elContexto.SaveChanges();

            return cantidadDeRegistrosAlmacenados;
        }

        private HabitacionesEntidad ConvertirDTOaEntidad(HabitacionesDto habitacion)
        {
            return new HabitacionesEntidad
            {
                Id = habitacion.Id,
                CodigoDeHabitacion = habitacion.CodigoDeHabitacion,
                NombreDeHabitacion = habitacion.NombreDeHabitacion,
                CantidadDeHuespedesPermitidos = habitacion.CantidadDeHuespedesPermitidos,
                CantidadDeCamas = habitacion.CantidadDeCamas,
                CantidadDeBanos = habitacion.CantidadDeBanos,
                Ubicacion = habitacion.Ubicacion,
                EncargadoDeLimpieza = habitacion.EncargadoDeLimpieza,
                TipoDeHabitacion = habitacion.TipoDeHabitacion,
                CostoDeLimpieza = habitacion.CostoDeLimpieza,
                CostoDeReserva = habitacion.CostoDeReserva,
                FechaDeRegistro = habitacion.FechaDeRegistro,
                FechaDeModificacion = habitacion.FechaDeModificacion,
                Estado = habitacion.Estado
            };
        }
    }
}
