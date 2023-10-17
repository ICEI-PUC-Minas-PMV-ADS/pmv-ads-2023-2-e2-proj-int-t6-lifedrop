using Microsoft.AspNetCore.Mvc;

namespace LifeDrop.Controllers
{
    public class UsuarioController : Controller
    {
       
        public IActionResult Login()
        {
            return View("~/Views/Login/Index.cshtml");
        }

        public IActionResult RecuperarSenha()
        {
            return View("~/Views/RecuperarSenha/Index.cshtml");
        }

        public IActionResult Cadastrar()
        {
            return View("~/Views/CadastrarConta/Index.cshtml");
        }
    }
}
