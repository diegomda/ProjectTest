using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public class Categorias
    {
        [Key]

        public int idCategoria { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [MaxLength(50,ErrorMessage = "El maximo de caracteres para el campo {0} es {1}")]
        [Index("Categorias_nombreCategoria_Index",IsUnique=true)]
        [Display(Name ="Categoria")]
        public string nombreCategoria { get; set; }


        public virtual ICollection<Negocios> negocios { get; set; }
    }
}
