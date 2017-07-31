using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore.Controllers
{
    [Route("api/products")]
    public class ProductController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "Product 1", "Product 2" };
        }
    }
}
