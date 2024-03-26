using Intranet.Get;
using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
    public class InicioController : Controller
    {
        private readonly InicioView _inicio = new InicioView();

        public IActionResult Index()
        {
            return View(_inicio);
        }
    }
}
