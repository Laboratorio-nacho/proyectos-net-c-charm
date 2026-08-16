using EVA2_Ignacio_Perez.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EVA2_Ignacio_Perez.Controllers
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

        public IActionResult FormHeron()
        {
            return View();
        }

        public IActionResult ResHeron()
        {
            int lado1 = Convert.ToInt32(HttpContext.Request.Form["lado1"]);
            int lado2 = Convert.ToInt32(HttpContext.Request.Form["lado2"]);
            int lado3 = Convert.ToInt32(HttpContext.Request.Form["lado3"]);

            double s = (lado1 + lado2 + lado3) / 2; 
            double area = (float)Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));



            ViewBag.AreaH = area;

            return View();
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