using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatsonORT.Presentacion.Models
{
    public class IngresoCodigoViewModel
    {
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El Email no tiene un formato correcto.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio.")]
        [Display(Name = "Código")]
        public string CodigoConsulta { get; set; }
    }
}