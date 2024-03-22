using Interface;
using Microsoft.AspNetCore.Mvc;
using Model;
using Site.ModelView;

namespace Site.Controllers
{
    public class SuporteController : Controller
    {
        private readonly IntranetModelView _intranet;
        public SuporteController(
            IRepo<Alerta> alertaRepo,
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
