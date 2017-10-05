using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatsonORT.Dominio.Clases
{
    public class ConsultaAnalisis
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo Email no tiene un formato correcto.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El campo Texto es obligatorio.")]
        public string Texto { get; set; }
        public string CodigoConsulta { get; set; }
    }
}
