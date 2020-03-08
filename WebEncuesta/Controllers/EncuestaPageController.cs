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

                lista.cTipEncuesta = obtener.GetString(0);
                lista.iNumPregunta = obtener.GetInt32(1);
                lista.cPregunta = obtener.GetString(2);
                lista.iIdSubPregunta = obtener.GetInt32(3);
                lista.cSubPregunta = obtener.GetString(4);
                lista.cDesc = obtener.GetString(5);
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
                        cTipEncuesta=item.cTipEncuesta,
                        iNumPregunta=item.iNumPregunta,
                        cPregunta = item.cPregunta,
                        SubPreguntas=new List<SubPregunta>(),
                        cDesc = item.cDesc
                    };
                    foreach (var sub in TipEncuesta.Where(x => x.iNumPregunta == item.iNumPregunta))
                    {
                        pregunta.SubPreguntas.Add(new SubPregunta
                        {
                            iIdSubPregunta=sub.iIdSubPregunta,
                            cSubPregunta = sub.cSubPregunta
                        });
                    }
                    preguntasList.Add(pregunta);

                }


            }




            return preguntasList;// TipEncuesta.FirstOrDefault().Preguntas.AddRange(preguntasList);  // Retornamos lista
        }
    }
}