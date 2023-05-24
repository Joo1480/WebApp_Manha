using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_Manha.Entidades;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class ProdutosController : Controller
    {
        private Contexto db;

        public ProdutosController(Contexto db)
        {
            this.db = db;
        }
        
        public IActionResult Lista()
        {
            List<Produtos> model = new List<Produtos>();
            model = db.PRODUTOS.Include(x => x.CATEGORIA).ToList();

            return View(model);
        }
        public IActionResult Cadastro()
        {
            NovoProdutoModel model = new NovoProdutoModel();
            model.ListaCategorias = db.CATEGORIAS.Where(x=>x.Ativo == true).ToList();

            return View(model);
        }

        [HttpPost]
        public IActionResult SalvarDados(Produtos model)
        {
            db.PRODUTOS.Add(model);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
    }
}
