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
        [Range(1, (double)decimal.MaxValue, ErrorMessage = "Debe ser mayor a 0")]
        [Required]
        public decimal CostoDeLimpieza { get; set; }
        [Display(Name = "Costo De Reserva")]
        [Range(1, (double)decimal.MaxValue, ErrorMessage = "Debe ser mayor a 0")]
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

