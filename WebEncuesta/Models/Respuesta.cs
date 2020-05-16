using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEncuesta.Models
{
    public class Respuesta
    {
        public int iIdRespuesta { get; set; }

        public string cRespuesta { get; set; }

        public DateTime dFecha { get; set; }

        public string cEmail { get; set; }

        public int fkSubPregunta { get; set; }
    }
}