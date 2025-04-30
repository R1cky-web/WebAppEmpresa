using System.ComponentModel.DataAnnotations;

namespace WebAppEmpresa.Models
{
    public class Estado
    {
        [Key]
        [Required]
        public int IdEstado { get; set; }

        [Display(Name ="Descripcion")]
        [Required(ErrorMessage ="debe ingresar la desc. del estado")]
        [MaxLength(100,ErrorMessage ="el campo no debe tener mas de 100 caracteres ")]
        public string Descripcion { get; set; }

        public virtual ICollection<Operaciones>Operaciones { get; set; }
    }
}
