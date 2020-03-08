using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEncuesta.Models
{
    public class Encuesta
    {
        public int iIdEncuesta { get; set; }
        public string cTipEncuesta { get; set; }
        public int iCantPregunta { get; set; }
        public string cDescripcion { get; set; }
        public bool bStatus { get; set; }
    } 

}