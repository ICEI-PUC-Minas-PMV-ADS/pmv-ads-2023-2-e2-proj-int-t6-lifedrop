using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class AgendeDoacaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Agendamento agendamento)
        {
            if ModelState.IsValid)
            {
                _context.Agendamento.Add(agendamento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(agendamento);
        }
    }
}
