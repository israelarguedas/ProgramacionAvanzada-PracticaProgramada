using PracticaProgramadaSolucion.Abstracciones.AccesoADatos.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.LogicaDeNegocio.Habitaciones;
using PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones;
using PracticaProgramadaSolucion.AccesoADatos.Habitaciones.ObtenerHistorialDeReservas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.LogicaDeNegocio.Habitaciones.ObtenerHistorialDeReservas
{
    public class ObtenerHistorialDeReservasLN : IObtenerHistorialDeReservasLN
    {
        IObtenerHistorialDeReservasAD _obtenerHistorialDeReservas;

        public ObtenerHistorialDeReservasLN() {
            _obtenerHistorialDeReservas = new ObtenerHistorialDeReservasAD();
        }
        public List<ReservacionesDto> Obtener(int idHabitacion)
        {
            List<ReservacionesDto> listaHistorialDeReservas = _obtenerHistorialDeReservas.Obtener(idHabitacion);
            
            return listaHistorialDeReservas;
        }
    }
}
