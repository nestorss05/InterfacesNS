using ExamenNS.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamenNS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ClsListadosVM vm = new ClsListadosVM();
            return View(vm);
        }

        [HttpPost]
        public IActionResult Index(int id)
        {
            ClsListadosVM vm = new ClsListadosVM(id);
            return View(vm);
        }

        [HttpGet]
        public IActionResult Detalles(int id) 
        { 
            ClsCandidatosVM vm = new ClsCandidatosVM(id);
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
