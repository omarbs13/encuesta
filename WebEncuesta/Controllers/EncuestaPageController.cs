using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using WebEncuesta.Models;

namespace WebEncuesta.Controllers
{
    public class EncuestaPageController : Controller
    {
        // GET: EncuestaPage
        public ActionResult EnPage(int iIdEncuesta)
        {

            return View(ObtenerEncuesta(iIdEncuesta));
        }

        // METODO: Obtener Encuesta
        [HttpPost]
        public List<Pregunta> ObtenerEncuesta(int iIdEncuesta)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString); // Cadena de conexion


            List<TipoEncuesta> TipEncuesta = new List<TipoEncuesta>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Encuesta.ObtEncuesta";
            cmd.Parameters.Add(new SqlParameter("@iIdEncuesta", SqlDbType.Int));
            cmd.Parameters["@iIdEncuesta"].Value = iIdEncuesta;
            cmd.Connection = conn;
            conn.Open();
            SqlDataReader obtener = cmd.ExecuteReader();  // Leeemos

            while (obtener.Read()) // Mientras, lee mas de uno
            {
                TipoEncuesta lista = new TipoEncuesta();
                lista.iIdPregunta = obtener.GetInt32(0);
                lista.cTipEncuesta = obtener.GetString(1);
                lista.iNumPregunta = obtener.GetInt32(2);
                lista.cPregunta = obtener.GetString(3);
                lista.iIdSubPregunta = obtener.GetInt32(4);
                lista.cSubPregunta = obtener.GetString(5);
                lista.cDesc = obtener.GetString(6);
                TipEncuesta.Add(lista); //Agregamos y Guardamos, retornando a la lista

            }
            obtener.Close();  // Cerramos

            var preguntasList = new List<Pregunta>();

            foreach (var item in TipEncuesta)
            {
                var existePregunta = preguntasList.Exists(x => x.iNumPregunta == item.iNumPregunta);

                if (!existePregunta)
                {
                    var pregunta = new Pregunta
                    {
                        iIdPregunta = item.iIdPregunta,
                        cTipEncuesta = item.cTipEncuesta,
                        iNumPregunta = item.iNumPregunta,
                        cPregunta = item.cPregunta,
                        SubPreguntas = new List<SubPregunta>(),
                        cDesc = item.cDesc
                    };
                    foreach (var sub in TipEncuesta.Where(x => x.iNumPregunta == item.iNumPregunta))
                    {
                        pregunta.SubPreguntas.Add(new SubPregunta
                        {
                            iIdSubPregunta = sub.iIdSubPregunta,
                            cSubPregunta = sub.cSubPregunta
                        });
                    }
                    preguntasList.Add(pregunta);

                }


            }




            return preguntasList;// TipEncuesta.FirstOrDefault().Preguntas.AddRange(preguntasList);  // Retornamos lista
        }


        public JsonResult SaveSurvey(string sugerencia, string[] subPreguntas)
        {
            bool success = false;
            //var respuestas = new List<Respuesta>();
            foreach (var item in subPreguntas)
            {

                string idSubPregunta = item.Split('_').Last();

                //respuestas.Add(new
                //{ fkSubpregunta = int.Parse(idSubPregunta);
                //cRespuesta = true;
                //dFecha = DateTime.today();
                //numerodeEMpleado = 2333; });



            /*Crear modelo de respuesta
             modificar ó crear un nuevo SP para insertar en respuesta con parametro tipo tabla
             analizar si es factible un SP o Entity Framework
             si se puede evitar el cambio de los circulos de las preguntas*/

            }
            try
            {
                success = true;
            }
            catch (Exception ex)
            {

                throw;
            }



            return Json(success, JsonRequestBehavior.AllowGet);

        }
    }
}