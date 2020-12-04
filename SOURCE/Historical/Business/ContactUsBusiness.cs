using Historical.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Historical.Business
{
    public class ContactUsBusiness:GenericBusiness
    {
        public int Create(string Mes, string Name, string Email)
        {
            try
            {
                Contact c = new Contact();
                c.Content = Mes;
                c.Email = Email;
                c.Name = Name;
                c.IsActive = 1;
                c.CreatedDate = DateTime.Now;
                cnn.Contacts.Add(c);
                cnn.SaveChanges();
                return c.Id;
            }catch(Exception e)
            {
                e.ToString();
                return 0;
            }
        }
    }
}
