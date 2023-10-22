using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class PainelAdministrador : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
