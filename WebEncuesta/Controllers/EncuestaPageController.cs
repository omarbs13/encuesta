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
        private readonly SqlConnection _con = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString);
        public ActionResult Index()
        {

            return View(ObtenerEncuesta(1));
        }

        // GET: EncuestaPage
        public ActionResult EnPage(int iIdEncuesta)
        {

            return View(ObtenerEncuesta(iIdEncuesta));
        }

        // METODO: Obtener Encuesta
        [HttpPost]
        public List<Pregunta> ObtenerEncuesta(int iIdEncuesta)
        {
            // Cadena de conexion


            List<TipoEncuesta> TipEncuesta = new List<TipoEncuesta>();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Encuesta.ObtEncuesta";
            cmd.Parameters.Add(new SqlParameter("@iIdEncuesta", SqlDbType.Int));
            cmd.Parameters["@iIdEncuesta"].Value = iIdEncuesta;
            cmd.Connection = _con;
            _con.Open();
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
            List<Respuesta> respuesta = new List<Respuesta>();
            bool success = false;
            foreach (var item in subPreguntas)
            {
                string idSubPregunta = item.Split('_').Last();

                respuesta.Add(new Respuesta
                {
                    fkSubPregunta = int.Parse(idSubPregunta),
                    cRespuesta = idSubPregunta.Equals("1") ? sugerencia : "True",
                    dFecha = DateTime.Now,
                    cEmail = "email.com"
                });
            }
            if (!string.IsNullOrEmpty(sugerencia))
            {
                respuesta.Add(new Respuesta
                {
                    fkSubPregunta = 1,
                    cRespuesta = sugerencia,
                    dFecha = DateTime.Now,
                    cEmail = "email.com"
                });
            }

            try
            {
                var dt = respuesta.ToDataTable();

                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString))
                {
                    connection.Open();
                    using (SqlCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "usp_InsertResp";
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter;

                        parameter = command.Parameters.AddWithValue("@TVP", dt);

                        parameter.SqlDbType = SqlDbType.Structured;
                        parameter.TypeName = "dbo.TRepuesta";

                        command.ExecuteNonQuery();
                    }
                }
                success = true;
            }
            catch (Exception ex)
            {
                success = false;
            }

            return Json(success, JsonRequestBehavior.AllowGet);

        }


    }
}