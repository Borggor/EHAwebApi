using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using getShipment;
using Azure.Core.Serialization;
using getShipment.Data;
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

    [HttpGet(Name = "getShipment")]
    public ActionResult<IEnumerable<shipmentReq>> Get()
    {
        try{
            var products = _context.shipmentInfo.ToList();
            return Ok(products);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}