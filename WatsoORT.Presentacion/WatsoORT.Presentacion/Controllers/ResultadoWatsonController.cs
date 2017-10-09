using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WatsonORT.Presentacion.Models;
using WatsonORT.Datos.Repositorios;
using WatsonORT.Dominio.Clases;

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
            if (ModelState.IsValid)
            {
                var consulta = new ConsultaAnalisis();
                consulta = consultaAnalisis.GetConsultaByCodigo(model.CodigoConsulta);
                if (consulta == null)
                {
                    ModelState.AddModelError("Codigo de consulta incorrecto", "Codigo de consulta incorrecto");
                    return View(model);
                }               
;                
                return RedirectToAction("Resultado", "ResultadoWatson");

            }
            return View(model);
        }
        public ActionResult Resultado()
        {
            return View();
        }
    }
}