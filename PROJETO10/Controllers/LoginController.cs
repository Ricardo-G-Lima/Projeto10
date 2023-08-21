using MySql.Data.MySqlClient;
using PROJETO10.Ações;
using PROJETO10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PROJETO10.Controllers
{
    public class LoginController : Controller
    {
        AcLogin ac = new AcLogin();
        modelLogin modelLogin = new modelLogin();

        public ActionResult Login() 
        {
            ac.usuarios();
            return View();
        }
    }
}