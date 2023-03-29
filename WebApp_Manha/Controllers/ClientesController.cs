using Microsoft.AspNetCore.Mvc;

namespace WebApp_Manha.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastro(string Nome, string Telefone)
        {
            if (string.IsNullOrEmpty(Nome))
            {
                TempData["Erro"] = "O campo Nome está vazio";
            }
            if (string.IsNullOrEmpty(Telefone))
            {
                TempData["Erro"] = "O campo Telefone está vazio";
            }
            return View();
        }
        public IActionResult Editar(int id)
        {
            return View();
        }
        public IActionResult Excluir(int id)
        {
            return View();
        }
        public IActionResult Compras(int id)
        {
            return View();
        }
    }
}
