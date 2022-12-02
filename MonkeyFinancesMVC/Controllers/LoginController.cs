using Microsoft.AspNetCore.Mvc;
using MonkeyFinancesMVC.Models;

namespace MonkeyFinancesMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index", "Home");
                }
                return View("Index");
            }
            catch(Exception erro)
            {

                return RedirectToAction("Index");
            }
        }
    }
}
