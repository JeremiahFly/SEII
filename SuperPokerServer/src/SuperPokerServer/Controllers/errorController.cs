using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Ringmaster.Controllers
{
    [Route("api/[controller]")]
    public class errorController : Controller
    {
        public static Exception e;

        // GET: api/values
        [HttpGet]
        public string Get()
        {
            if (e != null) return e.Message;
            return "No error yet";
        }
    }
}
