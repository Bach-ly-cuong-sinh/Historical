using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
