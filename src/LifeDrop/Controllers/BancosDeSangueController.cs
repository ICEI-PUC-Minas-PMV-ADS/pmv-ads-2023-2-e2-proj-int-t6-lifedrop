using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifeDrop.Controllers
{
    public class BancosDeSangueController : Controller
    {
        private readonly AppDbContext _context;
        public BancosDeSangueController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var dados = await _context.BancosDeSangue.ToListAsync();

            return View(dados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(BancoDeSangue bancoDeSangue)
        {
            if (ModelState.IsValid)
            {
                _context.BancosDeSangue.Add(bancoDeSangue);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(bancoDeSangue);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.BancosDeSangue.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, BancoDeSangue bancoDeSangue)
        {
            if (id != bancoDeSangue.IdBancoDeSangue)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.BancosDeSangue.Update(bancoDeSangue);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.BancosDeSangue.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.BancosDeSangue.FindAsync(id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null)
                return NotFound();
            var dados = await _context.BancosDeSangue.FindAsync(id);

            if (dados == null)
                return NotFound();

            _context.BancosDeSangue.Remove(dados);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

    }

}
