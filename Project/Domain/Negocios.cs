using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Negocios
    {
        [Key]

        public int idNegocio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [MaxLength(50, ErrorMessage = "El maximo de caracteres para el campo {0} es {1}")]
        //[Index("Negocios_nombreNegocio_Index", IsUnique = true)]
        [Display(Name = "Negocio")]

        public string nombreNegocio { get; set; }


        [Display(Name = "Dirección")]

        public string Direccion { get; set; }

        [Display(Name = "País")]
        public string Pais { get; set; }

        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; }


        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Teléfono Alternativo")]
        public string Telefono2 { get; set; }

        [Display(Name = "Imagen")]
        public string Logo { get; set; }


        [Display(Name = "Horario de Atención")]
        public DateTime horarioAtencion { get; set; }


        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Display(Name = "Abierto?")]
        public string Online { get; set; }

        [Display(Name = "Categoría")]
        //[Index("Negocios_nombreCategoria_idCategoria_Index", IsUnique = true, Order = 2)]
        public int idCategoria { get; set; }

        public virtual Categorias Categoria { get; set; }

    }
}
