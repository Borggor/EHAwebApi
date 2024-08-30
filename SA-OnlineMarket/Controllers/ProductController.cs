using getProductReq;
using Microsoft.AspNetCore.Mvc;
using SA_OnlineMarket.Data;

namespace SA_OnlineMarket.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ProductController : Controller
    {
        private readonly mydbContext _context;

        public ProductController(mydbContext context1)
        {
            _context = context1;
        }
        [HttpGet(Name = "getProduct")]
        public ActionResult<IEnumerable<productReq>> Get()
        {
        try{
            var products = _context.prodInfo.ToList();
            return Ok(products);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
        public IActionResult Index()
        {
            return View();
        }
    }
}
