using Microsoft.AspNetCore.Mvc;

namespace SA_OnlineMarket.Controllers
{
    public class order_shipementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Shipment()
        {
            return View();
        }
    }
}
