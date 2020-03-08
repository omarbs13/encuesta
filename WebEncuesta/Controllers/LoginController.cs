using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebEncuesta.Controllers
{
    public class LoginController : Controller
        // GET: Loginer
    {
        public ActionResult Index()
        {
            
            return View();
        }

        // : Consumimos el web services
        [HttpPost,Route("Login/PostLogin")]
        public string PostLogin(string usuario, string password)
        {
            LoginWS.Service1 ser = new LoginWS.Service1();
            string s = ser.login(usuario, password);
            return s;
        }
        
        
    }
}