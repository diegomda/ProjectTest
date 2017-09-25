using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Negocio
    {
        [Key]

        public int idNegocio { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Negocio")]

        public string nombreNegocio { get; set; }

        [Display(Name = "Horario de Apertura")]
        [DataType(DataType.Time)]
        public TimeSpan horaApertura { get; set; }

        [Display(Name = "Horario de Cierre")]
        [DataType(DataType.Time)]
        public TimeSpan horaCierre { get; set; }

        [Display(Name = "Abierto?")]
        public string Online { get; set; }


        public List<DateTime> Dias { get; set; }


    }
}
