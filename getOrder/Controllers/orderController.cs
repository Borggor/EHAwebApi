using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using getOrder;
using Azure.Core.Serialization;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using getProduct.Data;

namespace getOrder.Controllers;

[ApiController]
[Route("[Controller]")]
public class myProductController : ControllerBase
{
    private readonly mydbContext _context;

    public myProductController(mydbContext context1)
    {
        _context = context1;
    }

    [HttpGet(Name = "getOrder")]
    public ActionResult<IEnumerable<orderReq>> Get()
    {
        try{
            var products = _context.orderInfo.ToList();
            return Ok(products);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}