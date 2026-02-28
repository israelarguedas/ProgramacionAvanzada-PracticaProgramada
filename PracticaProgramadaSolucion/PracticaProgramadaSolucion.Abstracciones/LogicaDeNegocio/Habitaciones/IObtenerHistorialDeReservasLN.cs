using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones
{
    public interface IObtenerHistorialDeReservasLN
    {
        List<ReservacionesDto> Obtener(int idHabitacion);
    }
}
