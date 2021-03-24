using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CurrencyApp.Models;
using Microsoft.Extensions.Caching.Memory;
using System.Linq;
using System.Xml.Linq;

namespace CurrencyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache memoryCache;
        private readonly ILogger<HomeController> _logger;
        private readonly CurrencyDBContext _context;

        public HomeController(ILogger<HomeController> logger, CurrencyDBContext context, IMemoryCache memoryCache)
        {
            _logger = logger;
            _context = context;
            this.memoryCache = memoryCache;
        }

        public IActionResult Index()
        {

            if (!memoryCache.TryGetValue("key_currency", out Dynamic model))
            {
                throw new Exception("Ошибка получения данных");
            }
            return View(model);
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
