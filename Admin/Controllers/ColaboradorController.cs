using Microsoft.AspNetCore.Mvc;
using Model;
using Microsoft.EntityFrameworkCore;

namespace Admin.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly Context _contexto = new Context();
        public ColaboradorController()
        {
        }
        public IActionResult Index()
        {
            var colaboradores = _contexto.Colaboradores.Include(x => x.Cargo).Include(x => x.Secao).Include(x => x.Posto).ToList();
            return View(colaboradores);
        }

        [HttpGet]
        public IActionResult Detalhes(int? id)
        {
            ViewBag.Cargos = _contexto.Cargos.ToList();
            ViewBag.Secoes = _contexto.Secoes.ToList();
            ViewBag.Postos = _contexto.Postos.ToList();
            var colaborador = _contexto.Colaboradores.Where(x => x.Id == id).Include(x => x.Cargo).Include(x => x.Secao).Include(x => x.Posto).FirstOrDefault();
            return View(colaborador);
        }

        [HttpPost]
        public IActionResult Detalhes(Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _contexto.Colaboradores.Update(colaborador);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(colaborador);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            ViewBag.Cargos = _contexto.Cargos.ToList();
            ViewBag.Secoes = _contexto.Secoes.ToList();
            ViewBag.Postos = _contexto.Postos.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Novo([FromForm] Colaborador colaborador)
        {
            if (ModelState.IsValid)
            {
                _contexto.Colaboradores.Add(colaborador);
                _contexto.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(colaborador);
        }

        public IActionResult Excluir(int id)
        {
            var colaborador = _contexto.Colaboradores.Where(x => x.Id == id).FirstOrDefault();
            _contexto.Colaboradores.Remove(colaborador);
            _contexto.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
