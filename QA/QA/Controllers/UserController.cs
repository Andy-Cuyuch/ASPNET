using Microsoft.AspNetCore.Mvc;

namespace QA.Controllers
{
    public class UserController : Controller
    {
        public IActionResult InicioSesion()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
