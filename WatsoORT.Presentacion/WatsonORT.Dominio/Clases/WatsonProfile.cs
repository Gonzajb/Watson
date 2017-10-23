using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Watson.PersonalityInsights.Enums;
using Watson.PersonalityInsights.Models;

namespace WatsonORT.Dominio.Clases
{
    public class WatsonProfile
    {
        public WatsonProfile() : base()
        {

        }

        public string Id { get; set; }
        public ContentLanguage ProcessedLang { get; set; }
        public string Source { get; set; }
        public ITrait Tree { get; set; }
        public int WordCount { get; set; }
        public string WordCountMessage { get; set; }
    }
}
