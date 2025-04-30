using System.ComponentModel.DataAnnotations;

namespace WebAppEmpresa.Models
{
    public class Empresa
    {
        [Key]
        [Display(Name ="id")]
        [Required]
        public int IdEmpresa { get; set; }

        [Display(Name ="Empresa")]
        [Required(ErrorMessage ="debe ingresa la razon social de la empresa")]
        [MaxLength(70,ErrorMessage ="el campo debe tener 70 caracteres")]
        public string RazonSocial { get; set; }= "";

        [Display(Name = "Ruc")]
        [Required(ErrorMessage = "debe ingresa el ruc de la empresa")]
        public long Ruc { get; set; }

        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "debe ingresa la razon social de la empresa")]
        [MaxLength(100, ErrorMessage = "el campo debe tener 100 caracteres")]
        public string Direccion { get; set; } = "";
    }
}
