using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.AccesoADatos.Entidades
{
    [Table("RESERVACIONES")]
    public class ReservacionesEntidad
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("NombreDeLaPersona")]
        public string NombreDeLaPersona { get; set; }
        [Column("Identificacion")]
        public string Identificacion { get; set; }
        [Column("Telefono")]
        public string Telefono { get; set; }
        [Column("Correo")]
        public string Correo { get; set; }
        [Column("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }
        [Column("Direccion")]
        public string Direccion { get; set; }
        [Column("MontoTotal")]
        public decimal MontoTotal { get; set; }
        [Column("FechaInicioReserva")]
        public DateTime FechaInicioReserva { get; set; }
        [Column("FechaFinReserva")]
        public DateTime FechaFinReserva { get; set; }
        [Column("FechaDeRegistro")]
        public DateTime FechaDeRegistro { get; set; }
        [Column("IdHabitacion")]
        public int IdHabitacion { get; set; }
    }
}

/*
 CREATE TABLE RESERVACIONES (
    Id int identity (1,1) not null,
    NombreDeLaPersona varchar(150) not null,
    Identificacion varchar(30) not null,
	Telefono varchar(10) not null,
	Correo varchar(50) not null,
	FechaNacimiento datetime not null,
	Direccion varchar(200) not null,
	MontoTotal decimal(18,2) not null,
	FechaInicioReserva datetime not null,
	FechaFinReserva datetime not null,
	FechaDeRegistro datetime not null,
	IdHabitacion int not null,
);
*/