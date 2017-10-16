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
        string errorMessage = "Error en la conexion con el servicio";
        public ApiRequestService()
        {  
        }

        //public T Execute<T>(RestRequest request) where T : new()
        //{
        //    var client = new RestClient(baseUrl);
        //    var response = client.Execute<T>(request);

        //    if (response.ErrorException != null)
        //    {
        //        throw new HttpException(errorMessage);
        //    }
        //    return response.Data;
        //}


        //public Object SendRequest(string consulta)
        //{
        //    var request = new RestRequest(Method.POST);
        //    request.AddParameter("text", consulta);
        //    return Execute<Object>(request);
        //}
        public Object SendRequest(string consulta)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(Method.POST);
            request.AddParameter("text", consulta);
            var response = client.Execute<Object>(request);

            if (response.ErrorException != null)
            {
                throw new HttpException(errorMessage);
            }
            return response.Data;
        }
    }
}