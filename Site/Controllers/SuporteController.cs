using Microsoft.AspNetCore.Mvc;
using Model;

namespace Site.Controllers
{
    public class SuporteController : Controller
    {
        private readonly Suporte _suporte = new Suporte();

        public IActionResult Index()
        {
            return View(_suporte);
        }
    }
}
