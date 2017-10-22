using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using WatsonORT.Dominio.Clases;


namespace WatsonORT.Presentacion.Servicios
{
    public class ApiRequestService
    {
        string baseUrl = "http://jony-personality.mybluemix.net/api/personality";
        string errorMessage = "Error en la conexión con el servicio.";

        public ApiRequestService()
        {  
        }

        public ResultadoWatson SendRequest(string consulta)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.POST);
            request.AddParameter("text", consulta);
            var response = client.Execute<List<ElementoResultado>>(request);
            ResultadoWatson resultado = new ResultadoWatson();
            resultado.Elementos = response.Data;

            if (response.ErrorException != null)
            {
                throw new Exception(errorMessage);
            }
            return resultado;
        }
    }
}