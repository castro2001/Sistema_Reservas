using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class AccesoController : Controller
    {


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string clave)
        {
            return View();
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email)
        {
            return View();
        }

    }
}
