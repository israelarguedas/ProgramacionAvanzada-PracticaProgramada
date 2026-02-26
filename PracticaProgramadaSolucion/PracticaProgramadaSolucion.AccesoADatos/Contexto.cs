using PracticaProgramadaSolucion.AccesoADatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos
{
    public class Contexto : DbContext
    {
        public Contexto()
        {
        }

        public DbSet<HabitacionesEntidad> Habitaciones { get; set; }
        public DbSet<ReservacionesEntidad> Reservaciones { get; set; }
    }
}
