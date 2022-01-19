using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using WebMvcTest.Models;

namespace WebMvcTest.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registros()
        {
            List<Registro> registros = new();

            for (int item = 1; item < 11; item++)
            {
                registros.Add(new Registro { Id = item, Descricao = $"Item {item}" });
            }

            return Json(new
            {
                data = new { sucesso = true, registros }
            });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return Json(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

    public class Registro
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
