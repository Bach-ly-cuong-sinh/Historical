using Historical.Business;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Controllers
{
    public class BackEndHomeController : Controller
    {
        GenericBusiness c = new GenericBusiness();
        public IActionResult Index()
        {
            ViewBag.CountCategory = c.cnn.Categories.Where(ca => ca.IsActive.Equals(1)).Count();
            ViewBag.CountFeedback = c.cnn.Feedbacks.Where(fe => fe.IsActive.Equals(1)).Count();
            ViewBag.CountRelics = c.cnn.Relics.Where(re => re.IsActive.Equals(1)).Count();
            ViewBag.CountUser = c.cnn.Users.Where(u => u.IsActive.Equals(1)).Count();
            ViewBag.CountContact = c.cnn.Contacts.Where(co => co.IsActive.Equals(1)).Count();
            return View();
        }
    }
}
