using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFramework.Data.Entidades
{
    public partial class Docente
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Debe ingresar un Nombre")]
        [StringLength(maximumLength:100, ErrorMessage ="Maximo de 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar una edad")]
        [Range(18,100,ErrorMessage ="La edad debe ser entre 18 y 100 años")]
        public int? Edad { get; set; }
        
        [Required(ErrorMessage = "Debe ingresar un Nombre de materia")]
        [StringLength(maximumLength: 100, ErrorMessage = "Maximo de 100 caracteres")]
        public string? Materia { get; set; }

        [Required(ErrorMessage = "Debe ingresar un Nombre de ciudad")]
        [StringLength(maximumLength: 100, ErrorMessage = "Maximo de 100 caracteres")]
        public string? Ciudad { get; set; }
    }
}
