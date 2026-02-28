using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Habitaciones.ObtenerHabitacionesPorID
{
    public class ObtenerHabitacionesPorIDAD : IObtenerHabitacionesPorIDAD
    {
        Contexto _elContexto;

        public ObtenerHabitacionesPorIDAD()
        {
            _elContexto = new Contexto();
        }

        public HabitacionesDto Obtener(int id)
        {
            HabitacionesDto laHabitacionEnBD = (from laHabitacion in _elContexto.Habitaciones
                                                where laHabitacion.Id == id
                                                select new HabitacionesDto
                                                {
                                                    Id = laHabitacion.Id,
                                                    CodigoDeHabitacion = laHabitacion.CodigoDeHabitacion,
                                                    NombreDeHabitacion = laHabitacion.NombreDeHabitacion,
                                                    Ubicacion = laHabitacion.Ubicacion,
                                                    CantidadDeHuespedesPermitidos = laHabitacion.CantidadDeHuespedesPermitidos,
                                                    CantidadDeCamas = laHabitacion.CantidadDeCamas,
                                                    CantidadDeBanos = laHabitacion.CantidadDeBanos,
                                                    EncargadoDeLimpieza = laHabitacion.EncargadoDeLimpieza,
                                                    CostoDeLimpieza = laHabitacion.CostoDeLimpieza,
                                                    CostoDeReserva = laHabitacion.CostoDeReserva,
                                                    TipoDeHabitacion = laHabitacion.TipoDeHabitacion,
                                                    Estado = laHabitacion.Estado
                                                }).FirstOrDefault();
            return laHabitacionEnBD;
        }
    }
}
