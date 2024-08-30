using Microsoft.AspNetCore.Mvc;
using SA_OnlineMarket.Models;
using System.Diagnostics;


namespace SA_OnlineMarket.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        

        public AdminController(ILogger<AdminController> logger)
        {
            logger = _logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}