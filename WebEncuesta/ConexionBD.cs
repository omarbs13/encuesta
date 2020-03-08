using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebEncuesta

   
{
    public class ConexionBD
    {
        public SqlConnection con;
        public void conectar()
        {
            con = new SqlConnection("Data Source=CENCS-163; Initial Catalog=SumEncuesta; Integrated Security=True");
            con.Open();
           
        }
        //metodo para cerrar
        public void cerrar()
        {
            con.Close();
        }
    }
}