using Historical.Business;
using Historical.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Controllers
{
    public class Login_AdminController : Controller
    {
        UserBusiness UserBusiness = new UserBusiness(); 
        public PartialViewResult Index()
        {
            return PartialView("_Login");
        }
        public User Login(string User_Name, string Pasword)
        {
            try
            {
                if (User_Name != null && Pasword != null)
                {
                    var data = UserBusiness.Login(User_Name, Pasword);
                    return data;
                }                
                return new User();
            }
            catch
            {
                return new User();
            }
        }
    }
}
