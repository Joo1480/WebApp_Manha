using Microsoft.AspNetCore.Mvc;

namespace WebApp_Manha.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Lista()
        {
            return View();
        }
    }
}
