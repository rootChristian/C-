using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DB_CSV.Models
{
    public class ModelIcp
    {
        public int ID { get; set; }
        public string IndirizzoRes { get; set; }
        public string Tipologia { get; set; }
        public string Ubicazione { get; set; }
        public string Descrizione { get; set; }
        public string DataInizioValidita { get; set; }
        public string DataFineValidita { get; set; }
        public string Esposizione { get; set; }
        public string OrdLum { get; set; }
        public string Categoria { get; set; }
        public string Suolo { get; set; }
        public string UnitaDiMisura { get; set; }
        public string Lunghezza { get; set; }
        public string Larghezza { get; set; }
        public string Qta { get; set; }
        public string Elementi { get; set; }
        public string Facce { get; set; }
        public string QtaTass { get; set; }
        public string DataVariazione { get; set; }
        public string OraVariazione { get; set; }
        public string Utente { get; set; }
        public string Tributo { get; set; }
    }
}