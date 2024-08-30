using System.Data;
using getProductReq;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SA_OnlineMarket.Data;
using SA_OnlineMarket.Models;

namespace SA_OnlineMarket.Controllers
{
    public class addDataController : Controller
    {
        private readonly mydbContext _context;

        public addDataController(mydbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Admin/addProduct")]
        public IActionResult addProduct(addProdData product)
        {
            using (var con=_context.Database.GetDbConnection())
            {
                con.Open();
                using (var aer = con.CreateCommand())
                {
                    aer.CommandType = CommandType.Text;
                    aer.CommandText = "";
                    aer.ExecuteNonQuery();
                    //aer.ExecuteScalar();
                }
            }           
            Console.WriteLine("vbyuisdfvgyuifuvgbygyuSDFgbyuioarugbyizdfh");
            return Redirect("/product");
        }
    }
}
