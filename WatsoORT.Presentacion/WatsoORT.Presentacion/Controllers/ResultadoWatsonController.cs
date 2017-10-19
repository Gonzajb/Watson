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
            ResultadoWatson resultado = new ResultadoWatson();
            if (ModelState.IsValid)
            {
                var consulta = new ConsultaAnalisis();
                consulta = consultaAnalisis.GetConsultaByCodigo(model.CodigoConsulta);
                if (consulta == null)
                {
                    ModelState.AddModelError("Codigo de consulta incorrecto", "Codigo de consulta incorrecto");
                    return View(model);
                }
                try
                {
                    resultado = api.SendRequest(consulta.Texto);
                    return View("Resultado", resultado);
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("",e.Message);
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