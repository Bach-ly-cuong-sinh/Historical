using Historical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int Pagesize = 5;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index(int RelicPage = 1) => View(
           new RelicListViewModel
           {
               Relics = repository.relics

               .OrderBy(p => p.Id).Skip((RelicPage - 1) * Pagesize)
               .Take(Pagesize),
               Pageinfo = new PageInfo
               {
                   CurrentPage = RelicPage,
                   ItemsPage = Pagesize,
                   TotalItems = repository.relics.Count()
               },

           });

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
