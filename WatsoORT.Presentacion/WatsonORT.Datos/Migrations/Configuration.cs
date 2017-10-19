namespace WatsonORT.Datos.Migrations
{
    using Dominio.Clases;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WatsonORT.Datos.WatsonORTDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WatsonORT.Datos.WatsonORTDbContext context)
        {
            context.ConsultasAnalisis.Add(new ConsultaAnalisis
            {
                AceptoTerminosYCondiciones = true,
                CodigoConsulta = "123456789",
                Email = "nsabaj@hotmail.com",
                Nombre = "Nicolas",
                Texto = @"En las vacaciones de este año primero fui diez días a un hotel con mi familia, en el hotel de al lado estaba un amigo y todos los días salíamos juntos a la piscina, a la playa, etc.
                    En el hotel había un bufete donde íbamos a desayunar,
                    almorzar y cenar,
                    por la noche paseábamos por el paseo marítimo mientras nos tomábamos un helado,
                    algunos días íbamos a otras playas que estaban más lejos del hotel,
                    algunas eran salvajes,
                    tenían el agua cristalina y había muchos peces y plantas,
                    otros días los pasábamos en la piscina que era muy grande."
            });
            context.SaveChanges();
        }
    }
}
