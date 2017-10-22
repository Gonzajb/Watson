using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatsonORT.Dominio.Clases
{
    public class ConsultaAnalisis
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        [EmailAddress(ErrorMessage = "El Email no tiene un formato correcto.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio.")]
        [Display(Name = "Tu carta de presentación o un texto de tu autoría")]
        public string Texto { get; set; }
        public string CodigoConsulta { get; set; }
        [NotMapped]
        public bool AceptoTerminosYCondiciones { get; set; }
    }
}
