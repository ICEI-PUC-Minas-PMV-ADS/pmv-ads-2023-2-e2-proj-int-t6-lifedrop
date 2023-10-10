using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/PainelAdministrador/Index.cshtml");
        }

        public IActionResult Agendamentos()
        {
            return View("~/Views/AgendamentosAdministrador/Index.cshtml");
        }

    }
}
