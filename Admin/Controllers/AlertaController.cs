using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Admin.Controllers
{
    public class AlertaController : Controller
    {
        private readonly Context _contexto = new Context();
        public AlertaController()
        {
        }
        public IActionResult Index()
        {
            var alertas = _contexto.Alertas.ToList();
            return View(alertas);
        }

        [HttpGet]
        public IActionResult Detalhes(int? id)
        {
            var alerta = _contexto.Alertas.Where(x => x.Id == id).FirstOrDefault();
            return View(alerta);
        }

        [HttpPost]
        public IActionResult Detalhes(Alerta alerta)
        {
            if (ModelState.IsValid)
            {
                _contexto.Alertas.Update(alerta);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(alerta);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo([FromForm] Alerta alerta)
        {
            if (ModelState.IsValid)
            {
                _contexto.Alertas.Add(alerta);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(alerta);
        }

        public IActionResult Excluir(int id)
        {
            var alerta = _contexto.Alertas.Where(x => x.Id == id).FirstOrDefault();
            _contexto.Alertas.Remove(alerta);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
