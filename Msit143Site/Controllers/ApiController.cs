using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Msit143Site.Controllers
{
    public class ApiController : Controller
    {
        //http://localhost.../api/index
        public IActionResult Index()
        {
            //回應單純字串"Hello Ajax!!"
            return Content("<h2>こんにちは,您好!!</h2>", "text/html",System.Text.Encoding.UTF8);
        }
    }
}
