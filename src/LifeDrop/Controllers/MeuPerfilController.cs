using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class MeuPerfilController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
