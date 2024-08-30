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

        [HttpPost("Login/Login")]
        public IActionResult userLogin(addProdData product)
        {
            using (var con=_context.Database.GetDbConnection())
            {
                con.Open();
                using (var aer = con.CreateCommand())
                {
                    aer.CommandType = CommandType.Text;
                    aer.CommandText = "SELECT isAdmin FROM Users WHERE customer_ID = '"Name"' && customer_pass = '"password"';";
                    aer.ExecuteScalar();
                    if (aer == 0)
                    {

                    }
                    else
                    {
                         
                    }
                }
            }           
            Console.WriteLine("vbyuisdfvgyuifuvgbygyuSDFgbyuioarugbyizdfh");
            return Redirect("/product");
        }
    }
}
