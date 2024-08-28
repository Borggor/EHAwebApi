using Microsoft.AspNetCore.Mvc;

namespace SA_OnlineMarket.Controllers
{
    public class addproductsController : Controller
    {
        [Route("addproductView")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
