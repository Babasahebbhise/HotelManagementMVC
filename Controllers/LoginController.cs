using Microsoft.AspNetCore.Mvc;

namespace HOTELBHISEFAMILY.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
