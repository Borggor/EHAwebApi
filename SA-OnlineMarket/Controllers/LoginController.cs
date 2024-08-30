using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SA_OnlineMarket.Data;

namespace SA_OnlineMarket.Controllers
{
    public class LoginController : Controller
    {
        private readonly mydbContext _context;

        public LoginController(mydbContext context2)
        {
            context2 = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult checkLogin(string userName, string userPass)
        {   
            return View();
        }
    }
}
