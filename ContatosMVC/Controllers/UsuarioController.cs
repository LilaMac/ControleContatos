using Microsoft.AspNetCore.Mvc;

namespace ContatosMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
