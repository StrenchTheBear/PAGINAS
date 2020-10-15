using System;
using System.ComponentModel.DataAnnotations;

namespace PAGINAS.Models
{
    public class Estudiante
    {
        [Required(ErrorMessage = "Por favor, ingrese el Nombre")]
        [Display(Name="Nombre")]
        public String Name { get; set; }

        [Required(ErrorMessage = "Por favor, ingrese el Apellido")]
        [Display(Name="Apellido")]
        public String LastName { get; set; }
        
        public String Acccion { get; set; }

        public String Response { get; set; }

    }
}