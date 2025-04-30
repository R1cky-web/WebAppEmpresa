using System.ComponentModel.DataAnnotations;

namespace WebAppEmpresa.Models
{
    public class Responsable
    {
        [Key]
        [Required]
        public int IdResponsable { get; set; }

        [Display(Name ="Nombres")]
        [Required]
        [MaxLength(100)]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos")]
        [Required]
        [MaxLength(100)]
        public string Apellidos { get; set; }

        [Display(Name = "DNI")]
        [Required]
        public long DNI { get; set; }

        [Display(Name ="Edad")]
        public int Edad {  get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(100)]
        public String Direccion { get; set; }

        public virtual ICollection<Operaciones>Operaciones { get; set; }
    }
}
