using Microsoft.AspNetCore.Mvc;
using Model;

namespace Admin.Controllers
{
    public class SistemaController : Controller
    {
        private readonly Context _contexto = new Context();
        public IActionResult Index()
        {
            var sistemas = _contexto.Sistemas.ToList();
            return View(sistemas);
        }
        public IActionResult Detalhes(int id)
        {
            var sistema = _contexto.Sistemas.Where(x => x.Id == id).FirstOrDefault();
            return View(sistema);
        }
        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Novo(Sistema sistema)
        {
            return View();
        }

    }
}
