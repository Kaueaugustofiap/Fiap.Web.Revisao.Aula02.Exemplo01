using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.Revisao.Aula02.Exemplo01.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Criar uma Action Cadastrar que retorna uma página
        //A página terá um formulário HTML comm os campos nome, cpf e botão
        public IActionResult Cadastrar()
        {
            return View();
        }

    }
}
