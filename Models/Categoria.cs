using System.ComponentModel.DataAnnotations;

namespace ControlIngresoGastos.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(120)]
        [Display(Name = "Nombre Categoria")]
        public string NombreCategoria { get; set; }
        [Required]
        [MaxLength(2)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; }
        [Required]
        public bool Estado { get; set; }
    }
}
