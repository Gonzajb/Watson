using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatsonORT.Dominio.Clases
{
    public class ElementoResultado
    {
        public List<string> id { get; set; }
        public List<bool> title { get; set; }
        public List<string> value { get; set; }
        public List<string> sampling_error { get; set; }

    }
}
