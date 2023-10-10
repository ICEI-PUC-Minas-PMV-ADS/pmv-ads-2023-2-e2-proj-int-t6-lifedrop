using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class HomePageDoadorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
