using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_DB_CSV.Models
{
    public class ModelAnagrafica
    {
        public int ID { get; set; }
        public string IDCLIENTE { get; set; }
        public string CF { get; set; }
        public string PIVA { get; set; }
        public string DENOMINAZIONE { get; set; }
        public string MAIL { get; set; }
    }
}