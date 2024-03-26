using Intranet.Get;
using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
    public class SistemaController : Controller
    {
        private readonly SistemaView _sistema = new SistemaView();

        public IActionResult Index()
        {
            return View(_sistema);
        }
    }
}
