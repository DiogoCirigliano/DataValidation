using DataValidation.Models;
using DataValidation.Utilis;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DataValidation.Controllers
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
            ViewBag.Cpf = new CpfUtilis().CPF_validation("11598923269");//Teste do cpf
            ViewBag.CreateCpf = new CpfUtilis().CPF_Create();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
