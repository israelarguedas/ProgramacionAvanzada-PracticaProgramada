using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerTodasLasHabitaciones
{
    public class ObtenerTodasLasHabitacionesLN : IObtenerTodasLasHabitacionesLN
    {
        public List<HabitacionesDto> Obtener() {

            List<HabitacionesDto> listaHabitaciones = new List<HabitacionesDto>();

            listaHabitaciones.Add(new HabitacionesDto
            {
                Id = 1,
                CodigoDeHabitacion = "HAB001",
                NombreDeHabitacion = "Habitación Deluxe",
                CantidadDeHuespedesPermitidos = 2,
                CantidadDeCamas = 1,
                CantidadDeBanos = 1,
                Ubicacion = "Piso 3",
                EncargadoDeLimpieza = "Juan Pérez",
                TipoDeHabitacion = 1,
                CostoDeLimpieza = 50.00m,
                CostoDeReserva = 200.00m,
                FechaDeRegistro = DateTime.Now,
                Estado = true
            });

            return listaHabitaciones;
        }
    }
}
