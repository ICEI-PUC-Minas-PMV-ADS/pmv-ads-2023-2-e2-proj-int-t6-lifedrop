using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifeDrop.Controllers
{
    public class MeuPerfilController : Controller        
    {
        private readonly AppDbContext _context;
        private int idUsuario = 2;

        public  MeuPerfilController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            
            var doador = _context.Doadores.FirstOrDefault(x => x.IdUsuario == idUsuario);

            return View(doador);
        }
    }
}
