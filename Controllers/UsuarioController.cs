using Fiap.Web.Revisao.Aula02.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Revisao.Aula02.Exemplo01.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario usuario)
        {
            TempData["msg"] = "Usuário cadastrado!";
            return View(usuario);
        }

    }
}
