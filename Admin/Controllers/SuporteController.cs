using Microsoft.AspNetCore.Mvc;
using Model;

namespace Admin.Controllers
{
    public class SuporteController : Controller
    {
        private readonly Suporte _suporte = new Suporte();
        public IActionResult Index()
        {
            var suportes = _suporte.Arquivos;
            return View(suportes);
        }

        [HttpPost]
        public IActionResult Novo()
        {

            return View();
        }

    }
}
