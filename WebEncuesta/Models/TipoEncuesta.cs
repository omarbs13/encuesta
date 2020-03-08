using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebEncuesta.Models
{
    public class TipoEncuesta
    {


        public string cTipEncuesta { get; set; }
        public int iNumPregunta { get; set; }
        public string cPregunta { get; set; }
        public int iIdSubPregunta { get; set; }
        public string cSubPregunta { get; set; }
        public string cDesc { get; set; }

    }

    
    //public class Encuesta
    //{
    //    public string cTipEncuesta { get; set; }
    //    List<Pregunta> Preguntas { get; set; }
    //}

    public class Pregunta
    {
        public string cTipEncuesta { get; set; }
        public int iNumPregunta { get; set; }
        public string cPregunta { get; set; }
        public string cDesc { get; set; }
       public List<SubPregunta> SubPreguntas { get; set; }
    }
    
    public class SubPregunta
    {
        public int iIdSubPregunta { get; set; }
        public string cSubPregunta { get; set; }
        
    }
}