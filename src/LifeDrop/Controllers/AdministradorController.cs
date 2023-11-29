using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifeDrop.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly AppDbContext _context;
        public AdministradorController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult PainelAdministrador()
        {
            return View("~/Views/PainelAdministrador/Index.cshtml");
        }

        public async Task<IActionResult> Agendamentos()
        {

            var dadosAg = await _context.Agendamentos.Include(x => x.Doador).ToListAsync();

            return View(dadosAg);
        }
    }
}
