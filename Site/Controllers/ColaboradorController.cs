using Interface;
using Intranet.Get;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace Site.Controllers
{
    public class ColaboradorController : Controller
    {
        private readonly ColaboradorView _colaborador = new ColaboradorView();
        public IActionResult Index()
        {
            return View(_colaborador);
        }


    }
}
