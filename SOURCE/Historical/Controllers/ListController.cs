using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Historical.Models;
using Historical.Business;

namespace Historical.Controllers
{
    public class ListController : Controller
    {
        ListBusiness listBusiness = new ListBusiness();
        private IStoreRepository repository;
        public int Pagesize = 12;
        public ListController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index(int RelicPage = 1) => View(
            new RelicListViewModel {
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
    
       public PartialViewResult Detail(int ID)
        {
            try
            {
                var data = listBusiness.Detail(ID);
                return PartialView("Detail",data);
            }
            catch(Exception e)
            {
                return null;
            }
        } 
    }
    
}
