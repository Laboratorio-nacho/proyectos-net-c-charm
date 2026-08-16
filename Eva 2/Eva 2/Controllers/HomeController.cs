using Eva_2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Eva_2.Controllers
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

        public IActionResult FormCirculo()
        {
            return View();
        }
        public IActionResult FormRombo()
        {
            return View();
        }
        public IActionResult ResPerimetroR()
        {
            int lados = Convert.ToInt32(HttpContext.Request.Form["lados"]);
            int perimetro = lados * 4;

            ViewBag.PerimetroR = perimetro;

            return View();
        }
        public IActionResult ResAreaR()
        {
            int diagonal1 = Convert.ToInt32(HttpContext.Request.Form["Dmayor"]);
            int diagonal2 = Convert.ToInt32(HttpContext.Request.Form["Dmenor"]);

            int area = diagonal1 * diagonal2;

            ViewBag.AreaR = area;

            return View();
        }
        public IActionResult ResPerimetroC()
        {
            int lado1 = Convert.ToInt32(HttpContext.Request.Form["lado1"]);
            int lado2 = Convert.ToInt32(HttpContext.Request.Form["lado2"]);
            int lado3 = Convert.ToInt32(HttpContext.Request.Form["lado3"]);

            int perimetro = (lado1 + lado2 + lado3);
            ViewBag.PerimetroT = perimetro;
            return View();
        }
        public IActionResult ResAreaC()
        {
            int radio = Convert.ToInt32(HttpContext.Request.Form["radio"]);

            double area = Math.PI * Math.Pow(radio, 2);
            ViewBag.AreaT = area;

            return View();
        }

        public IActionResult ResCircunferenciaC()
        {
            int radio = Convert.ToInt32(HttpContext.Request.Form["radio"]);
            double circunferencia = Math.PI * 2 * radio;

            ViewBag.CircunferenciaC = circunferencia;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}