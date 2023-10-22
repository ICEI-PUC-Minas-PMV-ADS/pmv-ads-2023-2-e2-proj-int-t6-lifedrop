using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LifeDrop.Controllers
{
    public class MeuPerfilController : Controller
    {
        private readonly AppDbContext _context;
        private readonly int _idUsuarioLogado = 3;
        private readonly Usuario _usuarioLogado;

        public MeuPerfilController(AppDbContext context)
        {
            _context = context;
            _usuarioLogado = _context.Usuarios.FirstOrDefault(x => x.IdUsuario == _idUsuarioLogado);
        }

        public IActionResult Index()
        {
            var doador = _context.Doadores.FirstOrDefault(x => x.IdUsuario == _idUsuarioLogado);

            if (doador == null)
            {
                doador = new Doador
                {
                    IdUsuario = _usuarioLogado.IdUsuario,
                    Nome = _usuarioLogado.Nome,
                    Email = _usuarioLogado.Email
                };
            }

            return View(doador);
        }

        public async Task<IActionResult> Salvar(int idDoador, Doador doador)
        {
            if (ModelState.IsValid)
            {
                if (doador.IdDoador > 0 && doador.IdDoador == idDoador)
                {
                    Doador doadorExistente = _context.Doadores.Find(idDoador);
                    doadorExistente.Nome = doador.Nome;
                    doadorExistente.Email = doador.Email;
                    doadorExistente.Telefone = doador.Telefone;
                    doadorExistente.CPF = doador.CPF;
                    doadorExistente.DataNasc = doador.DataNasc;
                    doadorExistente.Endereco = doador.Endereco;
                    doadorExistente.Genero = doador.Genero;
                    doadorExistente.TipoSanguineo = doador.TipoSanguineo;

                    _context.Doadores.Update(doadorExistente);

                    _usuarioLogado.Nome = doador.Nome;
                    _context.Usuarios.Update(_usuarioLogado);

                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
                else
                {
                    _context.Doadores.Add(doador);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }

            return View();
        }
    }
}
