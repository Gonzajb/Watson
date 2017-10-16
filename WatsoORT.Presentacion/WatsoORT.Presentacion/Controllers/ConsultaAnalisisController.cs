using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WatsonORT.Datos;
using WatsonORT.Datos.Repositorios;
using WatsonORT.Dominio.Clases;
using WatsonORT.Presentacion.Servicios;

namespace WatsonORT.Presentacion.Controllers
{
    public class ConsultaAnalisisController : Controller
    {
        private ConsultaAnalisisRepository consultaRepository = new ConsultaAnalisisRepository();

        // GET: ConsultaAnalisis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConsultaAnalisis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Nombre,Texto,CodigoConsulta,AceptoTerminosYCondiciones")] ConsultaAnalisis consultaAnalisis)
        {
            if (!consultaAnalisis.AceptoTerminosYCondiciones)
            {
                ModelState.AddModelError("", "Debe aceptar los términos y condiciones para poder seguir adelante.");
            }
            ValidarTexto(consultaAnalisis);
            if (ModelState.IsValid)
            {
                consultaRepository.AddEntity(consultaAnalisis);
                consultaAnalisis.CodigoConsulta = consultaAnalisis.Id.ToString("000000");
                consultaRepository.UpdateEntity(consultaAnalisis);

                EnviarEmailCodigo(consultaAnalisis);
                return RedirectToAction("Index", "Home");
            }

            return View(consultaAnalisis);
        }

        private void ValidarTexto(ConsultaAnalisis consultaAnalisis)
        {
            string texto = consultaAnalisis.Texto.Trim();
            consultaAnalisis.Texto = texto;
            string[] words = texto.Split(new Char[] { ' ' });
            if (words.Length < 100)
            {
                ModelState.AddModelError("", "El texto debe contener al menos 100 palabras.");
            }
        }

        private static void EnviarEmailCodigo(ConsultaAnalisis consultaAnalisis)
        {
            try
            {
                EmailService emailService = new EmailService("nicolasasabaj@gmail.com", "GGc9opv7", "Nicolas");
                List<string> emailList = new List<string>();
                emailList.Add(consultaAnalisis.Email);
                emailService.SendEmail("Envío de código de consulta",
                    @"<h4>Envío de código de consulta:</h4> " + consultaAnalisis.CodigoConsulta,
                    emailList);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("","<script>window.alert('No se pudo enviar mail, vuelva a intentarlo mas tarde.');</script>");
            }
        }
    }

    internal class BaseRepository
    {
    }
}
