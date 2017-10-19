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
                Texto = @"En las vacaciones de este a�o primero fui diez d�as a un hotel con mi familia, en el hotel de al lado estaba un amigo y todos los d�as sal�amos juntos a la piscina, a la playa, etc.
                    En el hotel hab�a un bufete donde �bamos a desayunar,
                    almorzar y cenar,
                    por la noche pase�bamos por el paseo mar�timo mientras nos tom�bamos un helado,
                    algunos d�as �bamos a otras playas que estaban m�s lejos del hotel,
                    algunas eran salvajes,
                    ten�an el agua cristalina y hab�a muchos peces y plantas,
                    otros d�as los pas�bamos en la piscina que era muy grande."
            });
            context.SaveChanges();
        }
    }
}
