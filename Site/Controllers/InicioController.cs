using Interface;
using Microsoft.AspNetCore.Mvc;
using Model;
using Site.Models;
using Site.ModelView;

namespace Site.Controllers
{
    public class InicioController : Controller
    {
        private readonly IntranetModelView _intranet;
        public InicioController
            (IRepo<Alerta> alertaRepo,
            IRepo<Andar> andarRepo,
            IRepo<Colaborador> colaboradorRepo,
            IRepo<Secao> secaoRepo,
            IRepo<Sistema> sistemaRepo)
        {
            _intranet = new IntranetModelView(alertaRepo, andarRepo, colaboradorRepo, secaoRepo, sistemaRepo);
        }

        public IActionResult Index()
        {
            return View(_intranet);
        }
    }
}
