using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class ClientesController : Controller
    {
        public static List<ClienteModel> lista = new List<ClienteModel>();
        public IActionResult Lista()
        {
            //for (int i = 0; i < 16; i++)
            //{
            //    ClienteModel novo = new ClienteModel();
            //    novo.Id = 1;
            //    novo.Nome = "Teste" + i;
            //    novo.Telefone = "9 " + i;
               
            //    lista.Add(novo);
            //}
            return View(lista);
        }
        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SalvarDados(ClienteModel model) 
        {
            if (model.Id > 0)
            {
                int indice = lista.FindIndex(x => x.Id == model.Id);
                lista[indice] = model;
            }
            else
            {
                Random rand = new Random();
                model.Id = rand.Next(1,9999);
                lista.Add(model);
            }
            
            return RedirectToAction("Lista");
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
            ClienteModel cliente = lista.Find(x => x.Id == id);
            if (cliente != null) 
            {
                return View(cliente);
            }
            else
            {
                return RedirectToAction("Lista");
            }
            
        }
        public IActionResult Excluir(int id)
        {
            ClienteModel cliente = lista.Find(x => x.Id == id);
            if (cliente != null)
            {
                lista.Remove(cliente);
            }
            return RedirectToAction("Lista");
        }
        public IActionResult Compras(int id)
        {
            return View();
        }
    }
}
