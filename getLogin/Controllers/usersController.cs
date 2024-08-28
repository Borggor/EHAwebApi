using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using getLogin;
using Azure.Core.Serialization;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using getProduct.Data;

namespace getLogin.Controllers;

[ApiController]
[Route("[Controller]")]
public class myProductController : ControllerBase
{
    private readonly mydbContext _context;

    public myProductController(mydbContext context1)
    {
        _context = context1;
    }

    [HttpGet(Name = "getLogin")]
    public ActionResult<IEnumerable<cusReq>> Get()
    {
        try{
            var User = _context.cusReq.ToList();
            return Ok(User);
        }
        catch (Exception ex)
        {
            return StatusCode(500, "An error occurred while processing your request.");
        }
    }
}