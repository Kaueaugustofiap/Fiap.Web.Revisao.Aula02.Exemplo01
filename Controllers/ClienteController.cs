using Fiap.Web.Revisao.Aula02.Exemplo01.Models;
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
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        //A action que "cadastra no banco de dados"
        [HttpPost]
        public IActionResult Cadastrar(Cliente cliente)
        {
            TempData["nome"] = $"Cliente cadastrao: {cliente.Nome}"; //Mantém as informações mesmo após um redirect
            
            //As informações são perdidas após um redirect:
            ViewData["msg"] = "Cliente cadastrado!";
            ViewData["nome"] = cliente.Nome;
            ViewBag.cpf = cliente.Cpf;
            ViewBag.cliente = cliente;

            //Envia o objeto cliente para a view
            return View(cliente); //Forward
            //return RedirectToAction("Cadastrar"); //Redirect (Nome do método (Action))
            //return Content($"Nome: {cliente.Nome}, Cpf: {cliente.Cpf}"); //retorna um texto no browser
        }

    }
}
