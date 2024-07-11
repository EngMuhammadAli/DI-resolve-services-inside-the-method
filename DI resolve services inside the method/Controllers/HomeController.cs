using DI_resolve_services_inside_the_method.Models;
using DI_resolve_services_inside_the_method.Service;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DI_resolve_services_inside_the_method.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IServiceProvider _services;

        public HomeController(ILogger<HomeController> logger, IServiceProvider services)
        {
            _logger = logger;
            _services = services;
        }

        public IActionResult Index()
        {
            var myService = _services.GetRequiredService<IMyService>();
            var scopedService = _services.GetRequiredService<IScopedService>();

            var message = myService.GetMessage();
            var scopedMessage = scopedService.GetScopedMessage();

            ViewBag.Message = message;
            ViewBag.ScopedMessage = scopedMessage;

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
