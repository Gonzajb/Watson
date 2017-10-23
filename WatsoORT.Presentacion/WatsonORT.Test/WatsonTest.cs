using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WatsonORT.Presentacion.Servicios;
using WatsonORT.Dominio;

namespace WatsonORT.Test
{
    [TestClass]
    public class WatsonTest
    {
        [TestMethod]
        public void EnviarTestWatson()
        {
            string mensaje = "En las vacaciones de este año primero fui diez días a un hotel con mi familia, en el hotel de al lado estaba un amigo y todos los días salíamos juntos a la piscina, a la playa, etc.En el hotel había un bufete donde íbamos a desayunar, almorzar y cenar, por la noche paseábamos por el paseo marítimo mientras nos tomábamos un helado, algunos días íbamos a otras playas que estaban más lejos del hotel, algunas eran salvajes, tenían el agua cristalina y había muchos peces y plantas, otros días los pasábamos en la piscina que era muy grande.";
            ApiRequestService ser = new ApiRequestService();
            //ser.SendRequest(mensaje);
        }
    }
}
