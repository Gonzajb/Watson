using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatsonORT.Dominio.Clases;

namespace WatsonORT.Datos
{
    public class WatsonORTDbContext : DbContext
    {

        public WatsonORTDbContext() : base("WatsonORTDbContext")
        {
        }

        public DbSet<ConsultaAnalisis> ConsultasAnalisis { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Entity<ConsultaAnalisis>().HasKey(a => a.Id).ToTable("ConsultasAnalisis");
        }

        public static WatsonORTDbContext Create()
        {
            return new WatsonORTDbContext();
        }
    }
}
