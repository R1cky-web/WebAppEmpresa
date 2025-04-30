using System.ComponentModel.DataAnnotations;

namespace WebAppEmpresa.Models
{
    public class Operacion
    {
        [Key]     
        [Display(Name ="id")]// siempre cuando utilizo en la vista
        public int idOperacion { get; set; }
        
        [Display(Name ="Descripcion")]
        [Required(ErrorMessage ="Debe de ingresar la descripcion de la opercaion")]
        [MaxLength(100,ErrorMessage ="el campo no debe tener mas de 100 caracteres")]
        public string Descripcion { get; set; }
        
        [Display(Name ="Cantidad")]
        [Required(ErrorMessage ="debe ingresar la cantidad de la operacion")]
        public int Cantidad { get; set; }
        
        [Display(Name ="importe")]
        [Required(ErrorMessage ="debe ingresar el importe de la operacion")]
        public float Importe { get; set; }
        
        [Display(Name ="Igv")]
        public float Igv { get; set; }
       
        [Display(Name ="total")]
        public float total { get; set; }
        
        [Display(Name ="responsable")]
        [Required]
        [MaxLength(45)]
        public string Responsable { get; set; }
        
        [Display(Name ="registro")]
        public DateTime registro { get; set; }

        [Display(Name ="Estado")]
        [Required(ErrorMessage ="se debe asignar un estado a la operacion")]
        [MaxLength(25,ErrorMessage ="el campo no debe tener mas de 25 caracteres")]
        public string Estado { get; set; }
    }
}
