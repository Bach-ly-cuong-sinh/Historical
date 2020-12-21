using Historical.Business;
using Historical.Model;
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
        
        public PartialViewResult ListRelic()
        {
            try
            {
                ViewBag.ListTopic = c.cnn.Categories.ToList();
                var data = RelicsBusiness.ListRelic();
                return PartialView("ListPagoda", data);
            }
            catch
            {
                return PartialView("ListPagoda", null);
            }
        }
        // sử lý phần feedback
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
        public PartialViewResult DeleteFeedBack(int Id)
        {
            try
            {
                var f = c.cnn.Feedbacks.Find(Id);
                f.IsActive = 0;
                c.cnn.SaveChanges();
                var data = FeedBackBusiness.ListFeedBack();
                return PartialView("ListFeedBack", data);
            }
            catch
            {
                return PartialView("ListFeedBack", null);
            }
        }
        // sử lý user
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
                var check = c.cnn.Users.Where(u => u.Name.Equals(UserName)).FirstOrDefault();
                if(check == null)
                {
                    var data = UserBusiness.CreateUser(UserName, Password);
                    return PartialView("ListUser", data);
                }
                return PartialView("ListUser", this.ListUser());
            }
            catch
            {
                return PartialView("ListUser", null);
            }
        }
        public PartialViewResult SuccessUser(int Id)
        {
            try
            {
                var data = UserBusiness.SuccessUser(Id);
                return PartialView("ListUser", data);
            }
            catch
            {
                return PartialView("ListUser", null);
            }
        }
        public PartialViewResult DeletePagoda(int Id)
        {
            try
            {
                ViewBag.ListTopic = c.cnn.Categories.ToList();
                var f = c.cnn.Relics.Find(Id);
                f.IsActive = 0;
                c.cnn.SaveChanges();
                var data = RelicsBusiness.ListRelic();
                return PartialView("ListPagoda", data);
            }
            catch
            {
                ViewBag.ListTopic = c.cnn.Categories.ToList();
                return PartialView("ListPagoda", null);
            }
        }
        public PartialViewResult CreatePagoda(int CateID ,string Name ,string Address , string MapUrl ,string ImageUrl,string Content,string Title)
        {
            try
            {
                ViewBag.ListTopic = c.cnn.Categories.ToList();
                Relic r = new Relic();
                r.Name = Name;
                r.Address = Address;
                r.MapLinks = MapUrl;
                r.ImageUrl = ImageUrl;
                r.CateId = CateID;
                r.CraetedDate = DateTime.Now;
                r.IsActive = 1;
                r.Content = Content;
                r.Title = Title;
                c.cnn.Add(r);
                c.cnn.SaveChanges();
                return PartialView("ListPagoda", this.ListRelic());
            }
            catch
            {
                ViewBag.ListTopic = c.cnn.Categories.ToList();
                return PartialView("ListPagoda", null);
            }
        }
    }
}
