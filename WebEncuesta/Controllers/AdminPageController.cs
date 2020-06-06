using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Mvc;
using WebEncuesta.Models;
using System.Data;

namespace WebEncuesta.Controllers
{
   [Authorize]
    public class AdminPageController : Controller
    {

        // GET: AdminPage
        public ActionResult Page()
        {
            var s =Helper.GetUser();
            return View(ListarEncuesta());
        }

        // METODO: Listar Encuesta
        [HttpPost]
        public List<Encuesta> ListarEncuesta()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["connDB"].ConnectionString); // Cadena de conexion

     
            List<Encuesta> ListadeEncuesta = new List<Encuesta>();//Creamos lista
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Encuesta.SelEncuesta"; // Sentencia
            cmd.Connection = conn; // Pasamos la conexion
            conn.Open(); // Abrimos conexion
            SqlDataReader obtener = cmd.ExecuteReader();  // Leeemos
            
            while (obtener.Read()) // Mientras, lee mas de uno
            {
                Encuesta lista = new Encuesta();
                lista.iIdEncuesta = obtener.GetInt32(0);
                lista.cTipEncuesta = obtener.GetString(1);
                lista.iCantPregunta = obtener.GetInt32(2);
                lista.cDescripcion = obtener.GetString(3);
                lista.bStatus = obtener.GetBoolean(4);
                lista.Contestada = obtener.GetInt32(5);
                ListadeEncuesta.Add(lista);//Agregamos y Guardamos, retornando a la lista

            }
            obtener.Close();  // Cerramos
            return ListadeEncuesta;  // Retornamos lista

        }


        public ActionResult Usuario()
        {
            return View();
        }

    }
}