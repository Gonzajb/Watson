using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatsonORT.Presentacion.Servicios;
using System.Collections.Generic;

namespace WatsonORT.Test
{
    [TestClass]
    public class EmailTest
    {
        [TestMethod]
        public void EnviarEmail()
        {
            EmailService emailService = new EmailService("nicolasasabaj@gmail.com", "GGc9opv7", "Nicolas");
            List<string> emailList = new List<string>();
            emailList.Add("nicolasasabaj@gmail.com");
            emailService.SendEmail("Envío de código de consulta",
                @"<h4>Envío de código de consulta:</h4> COD00001",
                emailList);
        }
    }
}
