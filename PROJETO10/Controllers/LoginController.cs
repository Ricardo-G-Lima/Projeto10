using PROJETO10.Ações;
using PROJETO10.Models;
using System.Web.Mvc;

namespace PROJETO10.Controllers
{
    public class LoginController : Controller
    {
        AcLogin ac = new AcLogin();
        modelLogin modelLogin = new modelLogin();

        public ActionResult Login() 
        {
            return View();
        }
        public ActionResult TestarUsuario(modelLogin user)
        {
            ac.TestarUsuario(user);

            if(user.USUARIO != null && user.SENHA != null)
            {
                Session["USUARIO"] = user.USUARIO.ToString();
                Session["SENHA"] = user.SENHA.ToString();
                return RedirectToAction("Index","Home");

            }
            else
            {
                return RedirectToAction("Login","Login");
            }
            
        }
    }
}