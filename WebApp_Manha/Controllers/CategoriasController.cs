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
        public IActionResult SalvarDados(CategoriasModel model)
        {
            Categorias categorias = new Categorias();
            categorias.Nome = model.Nome;
            categorias.Ativo = model.Ativo; /*== "true" ? true : false;*/
            if (model.Id > 0)
            {   
                db.CATEGORIAS.Update(categorias);
                db.SaveChanges();
            }
            else
            {
                db.CATEGORIAS.Add(categorias);
                db.SaveChanges();
            }
            
            return RedirectToAction("Lista");

        }
        public IActionResult Editar(int id)
        {
            Categorias item = db.CATEGORIAS.Find(id);
            if (item != null)
            {
                return View(item);
            }
            else
            {
                return RedirectToAction("Lista");
            }
        }
        public IActionResult Excluir(int id)
        {
            Categorias item = db.CATEGORIAS.Find(id);
            if (item != null)
            {
                db.CATEGORIAS.Remove(item);
                db.SaveChanges();
            }
            return RedirectToAction("Lista");
        }
    }
}
