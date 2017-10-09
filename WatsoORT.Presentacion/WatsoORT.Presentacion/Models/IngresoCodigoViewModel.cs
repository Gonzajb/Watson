using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WatsonORT.Presentacion.Models
{
    public class IngresoCodigoViewModel
    {
        [Required]
        [Display(Name = "Codigo")]
        public string CodigoConsulta { get; set; }
    }
}