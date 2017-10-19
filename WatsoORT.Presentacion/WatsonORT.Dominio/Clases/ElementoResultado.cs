using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatsonORT.Dominio.Clases
{
    public class ElementoResultado
    {
        public List<string> Id { get; set; }
        public List<bool> Title { get; set; }
        public List<string> Value { get; set; }
        public List<string> Sampling_error { get; set; }

    }
}
