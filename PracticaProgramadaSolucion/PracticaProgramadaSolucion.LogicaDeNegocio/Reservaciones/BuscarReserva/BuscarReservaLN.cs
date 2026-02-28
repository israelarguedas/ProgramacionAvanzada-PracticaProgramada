using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Reservaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using PracticaProgramadaSolucion.AccesoADatos.Reservaciones.BuscarReserva;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Reservaciones.BuscarReserva
{
    public class BuscarReservaLN : IBuscarReservaLN
    {
        IBuscarReservaAD _buscarReserva;

        public BuscarReservaLN()
        {
            _buscarReserva = new BuscarReservaAD();
        }
        public ReservacionesDto BuscarReserva(int Id) {
            ReservacionesDto ReservaExistente = _buscarReserva.BuscarReserva(Id);

            return ReservaExistente;
        }
    }
}
