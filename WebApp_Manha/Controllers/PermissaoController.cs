using Microsoft.AspNetCore.Mvc;
using WebApp_Manha.Entidades;

namespace WebApp_Manha.Controllers
{
    public class PermissaoController : Controller
    {
        private Contexto db;

        public PermissaoController(Contexto db)
        {
            this.db = db;
        }
        public IActionResult Lista()
        {
            return View(db.PERMISSAO.ToList());
        }
        public IActionResult Cadastro()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SalvarDados(Permissao model)
        {
            
            db.PERMISSAO.Add(model);
            db.SaveChanges();
            
            return RedirectToAction("Lista");
        }
    }
}
