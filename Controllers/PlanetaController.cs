using Fiap.Web.Revisao.Aula02.Exemplo01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.Revisao.Aula02.Exemplo01.Controllers
{
    public class PlanetaController : Controller
    {
        private static List<Planeta> _banco = new List<Planeta>(); //Simular um banco de dados
        private static int _index = 0; //Controlar o id do Planeta

        public IActionResult Index()
        {
            //Envia a lista de planetas para a view
            return View(_banco);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            CarregarDados();
            return View();
        }

        //Carrega os dados do radio e do select
        private void CarregarDados()
        {
            //Envia as opções do select das galáxias
            var lista = new List<string>() { "Andrômeda", "Olho Negro", "Via Láctea", "Charuto" };
            //Radio
            ViewBag.atmosferas = new List<string>() { "Co2, N2", "N2 O2", "H2 He Ch4" };
            //Select
            ViewBag.galaxias = new SelectList(lista);
        }

        [HttpPost]
        public IActionResult Cadastrar(Planeta planeta)
        {
            //Adicionar o planeta na lista de planetas
            planeta.Id = ++_index;
            _banco.Add(planeta);
            //Enviar uma mensagem de sucesso para view
            TempData["msg"] = "Planeta cadastrado!";
            return RedirectToAction("Cadastrar");
        }

        [HttpGet] //Receber o Id do planeta para abrir o formulário com os dados preenchidos
        public IActionResult Editar(int id)
        {
            CarregarDados();
            //Pesquisar o planeta pelo Id
            var planeta = _banco.Find(p => p.Id == id);
            //Enviar o planeta para a view
            return View(planeta);
        }
        
        [HttpPost]
        public IActionResult Editar(Planeta planeta)
        {
            //Atualizar o planeta na lista, pesquisa a posição de um elemento da lista 
            _banco[_banco.FindIndex(item => item.Id == planeta.Id)] = planeta;
            //Mensagem de sucesso
            TempData["msg"] = "Planeta atualizado!";
            //Redirecionar para página de listagem
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Excluir(int id)
        {
            //Remove todos os planetas da lista pela condição
            _banco.RemoveAll(p => p.Id == id);
            TempData["msg"] = "Planeta removido!";
            return RedirectToAction("Index");
        }
    }
}
