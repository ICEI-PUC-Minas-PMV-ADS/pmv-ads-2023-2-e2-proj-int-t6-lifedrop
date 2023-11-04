using LifeDrop.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace LifeDrop.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDbContext _context;
        public UsuarioController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Usuarios.ToListAsync());
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email, Senha, Origem")] Usuario usuario)
        {
            var dados = await _context.Usuarios.FindAsync(usuario.Email); // Confirmar se estÃ¡ puxando corretamente

            if (dados == null)
            {
                ViewBag.Message = "E-mail e/ou senha invalidos!";
                return View();
            }
            bool senhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaOk)
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.IdUsuario.ToString()),
                    new Claim(ClaimTypes.Name, dados.Origem),
                };
                var usurioIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(usurioIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };
                await HttpContext.SignInAsync(principal, props);

                Redirect("\\Views\\HomePageDoador\\");//Confirmar como passar para a HomePageDoador
            }
            else
            {
                ViewBag.Message = "E-mail e/ou senha invalidos!";
            }

            return View();
        }

        public IActionResult CadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastrarUsuario([Bind("IdUsuario, Nome, Email, Senha, Origem")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login");
            }

            return View();
        }


        /*
        public IActionResult RecuperarSenha()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RecuperarSenha(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }*/
    }
}
