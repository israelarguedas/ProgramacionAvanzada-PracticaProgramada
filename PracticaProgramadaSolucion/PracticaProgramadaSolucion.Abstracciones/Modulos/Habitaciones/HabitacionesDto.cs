using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaProgramadaSolucion.Abstracciones.Modulos.Habitaciones
{
    public class HabitacionesDto
    {
        public int Id { get; set; }
        [Display(Name = "Código de Habitación")]
        [MinLength(4)]
        [Required]
        public string CodigoDeHabitacion { get; set; }
        [Display(Name = "Nombre de Habitación")]
        [MinLength(4)]
        [Required]
        public string NombreDeHabitacion { get; set; }
        [Display(Name = "Cantidad de Huespuedes Permitidos")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1.")]
        [Required]
        public int CantidadDeHuespedesPermitidos { get; set; }
        [Display(Name = "Cantidad de Camas")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1.")]
        [Required]
        public int CantidadDeCamas { get; set; }
        [Display(Name = "Cantidad de Baños")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser al menos 1.")]
        [Required]
        public int CantidadDeBanos { get; set; }
        [Display(Name = "Ubicación")]
        [MinLength(5)]
        [Required]
        public string Ubicacion { get; set; }
        [Display(Name = "Encargado/a de la Limpieza")]
        [MinLength(5)]
        [Required]
        public string EncargadoDeLimpieza { get; set; }
        [Display(Name = "Tipo de Habitación")]
        [Required]
        public int TipoDeHabitacion { get; set; }
        [Display(Name = "Costo De Limpieza")]
        [Required]
        public decimal CostoDeLimpieza { get; set; }
        [Display(Name = "Costo De Reserva")]
        [Required]
        public decimal CostoDeReserva { get; set; }
        [Display(Name = "Fecha de Registro")]
        public DateTime FechaDeRegistro { get; set; }
        [Display(Name = "Fecha de Modificación")]
        public DateTime? FechaDeModificacion { get; set; }
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

    }
}

/*
    Id int identity (1,1) not null,
    CodigoDeHabitacion varchar(7) not null,
    NombreDeHabitacion varchar(30) not null,
	CantidadDeHuespedesPermitidos int not null,
	CantidadDeCamas int not null,
	CantidadDeBanos int not null,
	Ubicacion varchar(10) not null,
	EncargadoDeLimpieza varchar(100) not null,
	TipoDeHabitacion int not null,
	CostoDeLimpieza decimal(18,2) not null,
	CostoDeReserva decimal(18,2) not null,
	FechaDeRegistro datetime not null,
	FechaDeModificacion datetime,
	Estado bit,
*/
