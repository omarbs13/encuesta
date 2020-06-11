using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEncuesta.Models;

namespace WebEncuesta.Controllers
{
    public class LoginController : Controller
    // GET: Loginer
    {
        public ActionResult Login()
        {

            return View();
        }

        // : Consumimos el web services
        [HttpPost, Route("Login/PostLogin")]
        public string PostLogin(string usuario, string password)
        {
            LoginWS.Service1 ser = new LoginWS.Service1();
            string s = "Bienvenido";// ser.login(usuario, password);
            if (s.Equals("Bienvenido"))
            {
                User user = new User
                {
                    Email = usuario,
                    Name = usuario,
                    Username = usuario
                };

                Helper.AddUserToSession(user);
            }

            return s;
        }

        [HttpPost, Route("/Login/LogOut")]
        public string LogOut()
        {
            string s = "logout";
            Helper.DestroyUserSession();
            return s;
        }

    }
}