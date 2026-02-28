using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Reservaciones
{
    public interface ICrearReservaLN
    {
        bool CrearReserva(int ID, ReservacionesDto reserva);
    }
}
