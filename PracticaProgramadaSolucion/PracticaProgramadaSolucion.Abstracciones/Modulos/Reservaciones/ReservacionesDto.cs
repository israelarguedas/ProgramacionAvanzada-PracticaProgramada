using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.Modulos.Reservaciones
{
	public class ReservacionesDto 
	{
		public int Id { get; set; }
        [Display(Name = "Nombre de la Persona")]
        [MinLength(4)]
        [Required]
        public string NombreDeLaPersona { get; set; }
        [Display(Name = "Identificación")]
        [MinLength(4)]
        [Required]
        public string Identificacion { get; set; }
        [Display(Name = "Telefóno")]
        [MinLength(4)]
        [Required]
        public string Telefono { get; set; }
        [Display(Name = "Correo Electrónico")]
        [MinLength(4)]
        [Required]
        public string Correo { get; set; }
        [Display(Name = "Fecha de Nacimiento")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Display(Name = "Dirección")]
        [MinLength(4)]
        [Required]
        public string Direccion { get; set; }
        [Display(Name = "Monto Total")]
        [Required]
        public decimal MontoTotal { get; set; }
        [Display(Name = "Fecha de Inicio de la Reserva")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaInicioReserva { get; set; }
        [Display(Name = "Fecha de Finalización de la Reserva")]
        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaFinReserva { get; set; }
        [Display(Name = "Fecha de Registro")]
        [Required]
        public DateTime FechaDeRegistro { get; set; }
        [Display(Name = "ID de la Habitación")]
        [Required]
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