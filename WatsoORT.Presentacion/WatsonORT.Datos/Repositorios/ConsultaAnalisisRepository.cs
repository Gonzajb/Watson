using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatsonORT.Dominio.Clases;

namespace WatsonORT.Datos.Repositorios
{
    public class ConsultaAnalisisRepository : BaseRepository<ConsultaAnalisis>
    {
        public ConsultaAnalisisRepository(WatsonORTDbContext db) :base(db) {
        }

        public ConsultaAnalisisRepository() : base()
        {
        }
        
        /// <summary>  
        ///  Esta función retorna la ConsultaAnalisis obtenida de la base de datos relacionada al código de consulta que recibe por parámetro.
        /// </summary>  
        public ConsultaAnalisis GetConsultaByCodigo(string codigo) {
            return this.GetAll().FirstOrDefault(x => x.CodigoConsulta == codigo);
        }

        /// <summary>  
        ///  Esta función retorna la ConsultaAnalisis obtenida de la base de datos relacionada al email y al código de consulta que recibe por parámetro.
        /// </summary>  
        public ConsultaAnalisis GetConsultaByCodigo(string email, string codigo)
        {
            email = email.Trim().ToLower();
            codigo = codigo.Trim();

            return this.GetAll().FirstOrDefault(x => x.Email == email && x.CodigoConsulta == codigo);
        }
    }
}
