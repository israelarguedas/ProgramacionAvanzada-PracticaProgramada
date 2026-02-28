using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Reservaciones
{
    public interface IBuscarReservaAD
    {
        ReservacionesDto BuscarReserva(int Id);
    }
}
