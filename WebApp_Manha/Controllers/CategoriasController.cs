using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Entidades;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class CategoriasController : Controller
    {
        
        private readonly Contexto db;

    
        public CategoriasController(Contexto db)
        {
            this.db = db;
        }

        public IActionResult Lista()
        {
            return View(db.CATEGORIAS.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(Categorias model)
        {
            db.CATEGORIAS.Add(model);
            db.SaveChanges();
            return RedirectToAction("Lista");
        }
        public IActionResult Editar()
        {
            return View();
        }
        public IActionResult Excluir(int id)
        {
            return RedirectToAction("Lista");
        }
    }
}
