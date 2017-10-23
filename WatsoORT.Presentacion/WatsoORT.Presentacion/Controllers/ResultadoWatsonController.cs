using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatsonORT.Presentacion.Models;
using WatsonORT.Datos.Repositorios;
using WatsonORT.Dominio.Clases;
using WatsonORT.Presentacion.Servicios;

namespace WatsonORT.Presentacion.Controllers
{
    public class ResultadoWatsonController : Controller
    {
        private ConsultaAnalisisRepository consultaAnalisis = new ConsultaAnalisisRepository();

        // GET: ResultadoWatson
        public ActionResult IngresoCodigo()
        {
            return View();
        }
        // POST: ResultadoWatson
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IngresoCodigo(IngresoCodigoViewModel model)
        {
            ApiRequestService api = new ApiRequestService();

            if (ModelState.IsValid)
            {
                var consulta = new ConsultaAnalisis();
                consulta = consultaAnalisis.GetConsultaByCodigo(model.Email, model.CodigoConsulta);

                if (consulta == null)
                {
                    ModelState.AddModelError("Email y/o Código de consulta incorrecto", "Email y/o Código de consulta incorrecto");
                    return View(model);
                }
                try
                {
                    Watson.PersonalityInsights.Models.IProfile profile = api.SendRequest(consulta.Texto);

                    return View("Resultado", profile);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }
            }

            return View(model);
        }
        public ActionResult Resultado()
        {
            return View();
        }
    }
}