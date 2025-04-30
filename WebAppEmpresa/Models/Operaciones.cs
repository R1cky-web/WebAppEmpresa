using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppEmpresa.Models
{
    public class Operaciones
    {

        [Key]
        [Required]
        [Display(Name = "id")]// siempre cuando utilizo en la vista
        public int IdOperaciones { get; set; }

        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "Debe de ingresar la descripcion de la opercaion")]
        [MaxLength(100, ErrorMessage = "el campo no debe tener mas de 100 caracteres")]
        public string Descripcion { get; set; }

        [Display(Name = "Cantidad")]
        [Required(ErrorMessage = "debe ingresar la cantidad de la operacion")]
        public int Cantidad { get; set; }

        [Display(Name = "importe")]
        [Required(ErrorMessage = "debe ingresar el importe de la operacion")]
        public float Importe { get; set; }

        [Display(Name = "Igv")]
        public float Igv { get; set; }

        [Display(Name = "total")]
        public float total { get; set; }


        [Display(Name = "registro")]
        public DateTime registro { get; set; }

        public int IdResponsable {  get; set; }
        
        [ForeignKey("IdResponsable")]
        public virtual Responsable Responsable{get; set; }

        public int IdEstado { get; set; }
        
        [ForeignKey("IdEstado")]
        public virtual Estado Estado { get; set; }

        [Display(Name ="Modificacion")]
        public DateTime? Modificacion { get; set; }

        [Display(Name ="Codigo")]
        [Required]
        [MaxLength(15)]
        public String? codigo { get; set; }
    }
}
