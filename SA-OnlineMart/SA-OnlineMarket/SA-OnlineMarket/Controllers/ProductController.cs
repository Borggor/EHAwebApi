using Microsoft.AspNetCore.Mvc;

namespace SA_OnlineMarket.Controllers
{
     [Route("productView")]
    public class ProductController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult addProducts()
        {
            return View();
        }
        public IActionResult cart()
        { 
            return View(); 
        }

    }
}
