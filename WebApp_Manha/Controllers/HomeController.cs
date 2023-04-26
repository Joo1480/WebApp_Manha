using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp_Manha.Models;

namespace WebApp_Manha.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Contexto db; 

        //Construtor da Classe
        public HomeController(Contexto db, ILogger<HomeController> logger)
        {
            _logger = logger;
            this.db = db;
        }

        //Devolve uma tela HTML
        public IActionResult Index()
        {
            var model = db.PRODUTOS.ToList();
            return View(model);
        }
        //mais uma tela do sistema
        public IActionResult BemVindo()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}