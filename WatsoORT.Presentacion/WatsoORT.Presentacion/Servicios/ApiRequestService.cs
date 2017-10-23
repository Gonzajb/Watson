using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestSharp;
using WatsonORT.Dominio.Clases;
using Watson.PersonalityInsights;
using Watson.Core;
using System.Diagnostics;
using System.Threading.Tasks;
using Watson.PersonalityInsights.Models;
using Watson.PersonalityInsights.Enums;

namespace WatsonORT.Presentacion.Servicios
{
    public class ApiRequestService
    {
        public ApiRequestService()
        {  
        }

        public IProfile GetProfileWithOptionsSync(string texto)
        {
            var options = new ProfileOptions(texto)
            {
                IncludeRaw = true,
                AcceptLanguage = AcceptLanguage.Es,
                ContentLanguage = ContentLanguage.Es
            };
            var service = new PersonalityInsightsService("363fdb26-d90c-4305-9203-45941b7a481b", "BKcFLfhY4dAV");
            var profile = service.GetProfileAsync(options);

            return profile.Result;
        }

        public IProfile SendRequest(string consulta)
        {
            return GetProfileWithOptionsSync(consulta);
        }
    }
}