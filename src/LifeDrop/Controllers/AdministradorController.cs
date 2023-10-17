using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult PainelAdministrador()
        {
            return View("~/Views/PainelAdministrador/Index.cshtml");
        }

        public IActionResult Agendamentos()
        {
            return View("~/Views/AgendamentosAdministrador/Index.cshtml");
        }

    }
}
