using Historical.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Controllers
{
    public class ContactUsController : Controller
    {
        ContactUsBusiness contactUsBusiness = new ContactUsBusiness();
        public IActionResult Index()
        {
            return View();
        }
        public int Create( string Mes, string Name,string Email)
        {
            try
            {
                var data = contactUsBusiness.Create(Mes,Name,Email);
                if(data > 0)
                {
                    return data;
                }
                return 0;
            }catch(Exception e)
            {
                e.ToString();
                return 0;
            }
        }
    }
}
