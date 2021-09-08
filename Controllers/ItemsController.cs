using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ngSupplyLogic.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ngSupplyLogic.Controllers
{
  [ApiController]
  [Route("items")]
  public class ItemsController : ControllerBase
  {
    private readonly ShakespeareContext _context;

    public ItemsController(ShakespeareContext context)
    {
      _context = context;
    }

    [HttpGet]
    public string Get()
    {
      return "Hello, pricecheck endpoint";
    }

    // GET api/<controller>/5
    [HttpGet("{barCode}")]
    public decimal Get(int barCode)
    {
      return 22.2M;
    }
  }
}
