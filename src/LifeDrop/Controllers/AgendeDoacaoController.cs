using LifeDrop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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
            var identity = (ClaimsIdentity)User.Identity;

            var usuarioLogado = _context.Usuarios.FirstOrDefault(x => x.Nome == identity.Name);

            var doador = _context.Doadores.FirstOrDefault(x => x.IdUsuario == usuarioLogado.IdUsuario);

            if (doador == null)
            {
                return View();
            }

            var agendamento = new Agendamento()
            {
                IdDoador = doador.IdDoador,
                Data = DateTime.Now
            };

            return View(agendamento);
        }

        public List<BancoDeSangue> GetUnidades(string municipio)
        {
            var unidades = _context.BancosDeSangue.Where(x => x.Municipio.Contains(municipio)).OrderBy(y => y.NomeUnidade).ToList();

            return unidades;
        }

        public BancoDeSangue GetUnidade(int id)
        {
            var unidade = _context.BancosDeSangue.Find(id);

            return unidade;
        }

        public async Task<IActionResult> Salvar(Agendamento agendamento)
        {
            if (ModelState.IsValid)
            {
                _context.Agendamentos.Add(agendamento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "MeuPerfil", new { area = "" });
            }

            return View();
        }

        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Agendamentos.Include(u => u.Unidade).FirstOrDefaultAsync(x => x.IdAgendamento == id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(int idAgendamento, Agendamento agendamento)
        {
            if (idAgendamento != agendamento.IdAgendamento)
                return NotFound();

            Agendamento agendamentoExistente = _context.Agendamentos.Find(idAgendamento);
            agendamentoExistente.IdBancoDeSangue = agendamento.IdBancoDeSangue;
            agendamentoExistente.Data = agendamento.Data;
            agendamentoExistente.Hora = agendamento.Hora;

            _context.Agendamentos.Update(agendamentoExistente);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "MeuPerfil", new { area = "" });
        }

        public async Task<IActionResult> Cancelar(int? id)
        {
            if (id == null)
                return NotFound();

            var dados = await _context.Agendamentos.Include(u => u.Unidade).FirstOrDefaultAsync(x => x.IdAgendamento == id);

            if (dados == null)
                return NotFound();

            return View(dados);
        }

        [HttpPost]
        public async Task<IActionResult> Cancelar(int? idAgendamento, Agendamento agendamento)
        {
            if (idAgendamento == null)
                return NotFound();

            Agendamento agendamentoExistente = _context.Agendamentos.Find(idAgendamento);
            agendamentoExistente.StatusDaDoacao = Status.Cancelado;

            _context.Agendamentos.Update(agendamentoExistente);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "MeuPerfil", new { area = "" });
        }
    }
}
