using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using getProduct;
using Azure.Core.Serialization;
using getProduct.Data;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace getProduct.Controllers;

[ApiController]
[Route("[Controller]")]
public class myProductController : ControllerBase
{
    private readonly mydbContext _context;

    public myProductController(mydbContext context1)
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
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}