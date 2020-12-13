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
        UserBusiness UserBusiness = new UserBusiness();
        RelicsBusiness RelicsBusiness = new RelicsBusiness();
        FeedBackBusiness FeedBackBusiness = new FeedBackBusiness();
        public IActionResult Index()
        {
            ViewBag.CountCategory = c.cnn.Categories.Where(ca => ca.IsActive.Equals(1)).Count();
            ViewBag.CountFeedback = c.cnn.Feedbacks.Where(fe => fe.IsActive.Equals(1)).Count();
            ViewBag.CountRelics = c.cnn.Relics.Where(re => re.IsActive.Equals(1)).Count();
            ViewBag.CountUser = c.cnn.Users.Where(u => u.IsActive.Equals(1)).Count();
            ViewBag.CountContact = c.cnn.Contacts.Where(co => co.IsActive.Equals(1)).Count();
            return View();
        }
        public PartialViewResult ListUser()
        {
            try
            {
                var data = UserBusiness.ListUser();
                return PartialView("ListUser", data);
            }
            catch
            {
                return PartialView("ListUser", null);
            }
        }
        public PartialViewResult ListRelic()
        {
            try
            {
                var data = RelicsBusiness.ListRelic();
                return PartialView("ListPagoda", data);
            }
            catch
            {
                return PartialView("ListPagoda", null);
            }
        }
        public PartialViewResult ListFeedBack()
        {
            try
            {
                var data = FeedBackBusiness.ListFeedBack();
                return PartialView("ListFeedBack", data);
            }
            catch
            {
                return PartialView("ListFeedBack", null);
            }
        }
        public PartialViewResult DeleteUser(int Id)
        {
            try
            {
                var data = UserBusiness.DeleteUser(Id);
                return PartialView("ListUser", data);
            }
            catch
            {
                return PartialView("ListUser", null);
            }
        }
        public PartialViewResult CreateUser(string UserName, string Password)
        {
            try
            {
                var data = UserBusiness.CreateUser(UserName, Password);
                return PartialView("ListUser", data);
            }
            catch
            {
                return PartialView("ListUser", null);
            }
        }
    }
}
