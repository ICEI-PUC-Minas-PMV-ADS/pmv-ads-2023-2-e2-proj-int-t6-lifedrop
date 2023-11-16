using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class AgendeDoacaoController : Controller
    {
        private readonly AppDbContext _context;

        public AgendeDoacaoController(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public List<BancoDeSangue> GetUnidades(string municipio)
        {
            var unidades = _context.BancosDeSangue.Where(x => x.Municipio.Contains(municipio)).OrderBy(y=> y.NomeUnidade).ToList();

            return unidades;
        }
    }
}
