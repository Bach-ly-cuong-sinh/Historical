using Historical.Business;
using Historical.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Test(string Content)
        {
            try
            {
                ContactInputModel ContactInput = new ContactInputModel();
                ContactInput.Content = Content;
                //ContactInput.CreatedDate = DateTime.Now;
                //DateTime myDateTime = (DateTime) System.;
                //string sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                //ContactInput.CreatedDate = DateTime.Parse("04/01/2020 07:07:07 PM");
                //DateTime da = new DateTime();
                DateTime da = DateTime.Now;

                ContactInput.IsActive = 1;
                ContactInput.RelicId = 1;
                GenericBusiness c = new GenericBusiness();
                c.cnn.Feedbacks.Add(ContactInput);
                c.cnn.SaveChanges();
                return Content;
            }
            catch(Exception ex)
            {
                ex.ToString();
                return null;
            }
        }
    }
}
